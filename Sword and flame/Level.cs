using Sword_and_flame;
using System.Diagnostics;
using System.Threading;

namespace Sword_and_flame
{
    public partial class Level : Form
    {
        private static LevelObject[,] level_map = new LevelObject[GameGlobalData.level_size_x, GameGlobalData.level_size_y];
        int count_of_monsters { get; set; } = 0;  // Кількість згенерованих монстрів
        string level_name { get; }          // Назва рівня
        string basic_monster_name { get; }
        int basic_monster_count { get; }
        string secondary_monster_name { get; }
        int secondary_monster_count { get; }

        static int level_load_counter = 0;      
        
        public Level (string level_name_, string basic_monster_name_, int basic_monster_count_, string secondary_monster_name_, int secondary_monster_count_)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            level_name = level_name_;
            basic_monster_name = basic_monster_name_;
            basic_monster_count = basic_monster_count_;
            
            secondary_monster_name = secondary_monster_name_;
            secondary_monster_count = secondary_monster_count_;
            
        }

        private void Level_Load(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            level_name_lbl.Text = level_name;

            //ЗАЛЕЖНІСТЬ ФОНОВОГО МАЛЮНКУ РІВНЯ ВІД ІНДЕКСУ РІВНЯ
            switch(level_name)
            {
                case "":
                    ActiveForm.BackgroundImage = Image.FromFile("1");
                    break;
            }
            int variable_count_of_loot = 0;
            
            
            
            
            
            // ЗАЛЕЖНІСТЬ КІЛЬКОСТІ СПОРЯДЖЕННЯ ВІД СКЛАДНОСТІ
            switch (GameGlobalData.difficulty)
            {
                case "Легко":
                    variable_count_of_loot = 2;
                    break;
                case "Нормально":
                    variable_count_of_loot = 1;
                    break;
                case "Важко":
                    variable_count_of_loot = 0;
                    break;
            } 
            
            // ВИСТАВЛЕННЯ ГРАВЦІВ
            for (int i = 0; i < GameGlobalData.count_of_players; i++)
            {
                setHero(GameGlobalData.HeroList[i], level_map);
            }

            // ВИСТАВЛЕННЯ МОНСТРІВ
            count_of_monsters = spawn_monsters(basic_monster_name, basic_monster_count, secondary_monster_name, secondary_monster_count, level_map); 

            // ВИСТАВЛЕННЯ СПОРЯДЖЕННЯ
            for (int i = 0; i < variable_count_of_loot; i++)
            {
                setLoot(Loot.LootList, level_map);
            }

            set_null_obj(level_map);
            button_set_text(level_map);
            show_null_info_set_visible_settings();
            turn(0);
        }

        
        public void turn (int i)
        {
            if (i == GameGlobalData.count_of_players)
            {
                monster_turn_main();
                turn(0);
            }
            else
            {
                if (GameGlobalData.HeroList[i].current_health <= 0)
                {
                    ShowMessage showMessage_obj = new ShowMessage(" Гравець " + GameGlobalData.HeroList[i].name + " непритомний.");
                    showMessage_obj.ShowDialog();
                    turn(i + 1);
                }
                else
                {
                    turn_owner.Text = GameGlobalData.HeroList[i].name;
                    GameGlobalData.current_turn_player_name = GameGlobalData.HeroList[i].name;
                    GameGlobalData.count_of_moves = GameGlobalData.HeroList[i].current_speed;
                    level_count_of_moves.Text = GameGlobalData.count_of_moves.ToString();
                    paint_buttons();
                    ShowMessage player_turn_info = new ShowMessage(GameGlobalData.HeroList[i].name + ", Ваш хід");
                    player_turn_info.ShowDialog();
                    level_load_counter = i;
                }                
            }
        }
        

        private void victory_or_defeat_check()
        {
            int alive_heroes = 0;
            for (int i = 0; i < GameGlobalData.count_of_players; i++)
            {
                if (GameGlobalData.HeroList[i].current_health > 0)
                {
                    alive_heroes++;
                }
            }   
            if (count_of_monsters > 0 && alive_heroes == 0)
            {
                ShowMessage showMessage_obj = new ShowMessage("Всі герої загинули");
                showMessage_obj.ShowDialog();
                MainMenu MainMenu_obj= new MainMenu();
                MainMenu_obj.ShowDialog();
            }
            if (count_of_monsters == 0 && alive_heroes > 0)
            {
                ShowMessage showMessage_obj = new ShowMessage("Рівень пройдено");
                showMessage_obj.ShowDialog();
                EventEnd eventEnd_obj = new EventEnd();
                eventEnd_obj.ShowDialog();
            }
            
            
        }

        private void Action_Check(int x, int y)
        {
            for (int i = 0; i < GameGlobalData.HeroList.Count; i++)
            {
                if (GameGlobalData.HeroList[i].name == GameGlobalData.current_turn_player_name)
                {
                    if (level_map[x, y].name == " ")
                    {
                        MoveCheck(GameGlobalData.HeroList[i], x, y);
                    }
                    if (level_map[x, y] is Monster)
                    {
                        AttackCheck(GameGlobalData.HeroList[i], (Monster)level_map[x, y]);
                    }
                    if (level_map[x, y] is Hero)
                    {
                        //if (level_map[x, y])
                    }
                    if (level_map[x, y] is Loot)
                    {

                    }                   
                    set_null_obj(level_map);
                    button_set_text(level_map);
                    paint_buttons();
                }
            }          
        }
        private bool AttackCheck (Hero hero, Monster monster)
        {
            if (monster.x == hero.x || monster.y == hero.y)
            {
                if (Math.Abs(monster.x - hero.x) == 1 || Math.Abs(monster.y - hero.y) == 1)
                {
                    if (hero.Attack(hero, monster, level_map) == true)
                    {
                        GameGlobalData.count_of_moves--;
                        count_of_monsters--;
                        victory_or_defeat_check();
                    }
                    return true;
                }            
            }
            return false;
        }

        private bool MoveCheck(LifeObject someone, int position_to_move_X, int position_to_move_Y)
        {
            if (position_to_move_X < 0)
            {
                position_to_move_X = 0;               
            }
            if (position_to_move_X > 9)
            {
                position_to_move_X = 9;
            }
            if (position_to_move_Y < 0)
            {
                position_to_move_Y = 0;
            }
            if (position_to_move_Y > 4)
            {
                position_to_move_Y = 4;
            }
            if (position_to_move_X == someone.x || position_to_move_Y == someone.y)
            {
                if (Math.Abs(position_to_move_X - someone.x) == 1 || Math.Abs(position_to_move_Y - someone.y) == 1)
                {
                    if (level_map[position_to_move_X, position_to_move_Y].name == " ")
                    {
                        someone.Move(someone, position_to_move_X, position_to_move_Y, level_map);
                        GameGlobalData.count_of_moves--;
                        level_count_of_moves.Text = GameGlobalData.count_of_moves.ToString();
                        return true;                       
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public void ShowInfo(LevelObject[,] level_map, int x, int y, Hero hero)
        {            
            if (level_map[x, y] is Hero)
            {
                string object_type_str = "";               
                Hero variable_hero = (Hero)level_map[x, y];
                if (variable_hero.name == GameGlobalData.current_turn_player_name)
                {
                    object_type_str = "Ви (Герой - " + variable_hero.player_class + ")";
                }
                else
                {
                    object_type_str = "Союзник (Герой - " + variable_hero.player_class + ")";
                }
                string player_class = variable_hero.player_class;
                int player_max_health = 0;
                switch (player_class)
                {
                    case "Воїн":
                        player_max_health = Hero.default_Warrior_Health;
                        break;
                    case "Паладін":
                        player_max_health = Hero.default_Paladin_Health;
                        break;
                    case "Лучник":
                        player_max_health = Hero.default_Archer_Health;
                        break;
                    case "Чарівник":
                        player_max_health = Hero.default_Wizard_Health;
                        break;
                }
                show_hero_info_set_visible_settings();
                level_heroobjinfo_nameValue_lbl.Text = level_map[x, y].name;
                level_heroobjinfo_typeValue_lbl.Text = object_type_str;
                level_heroobjinfo_strengthValue_lbl.Text = variable_hero.current_strength.ToString() + " ("+variable_hero.current_random_strength + ")";
                level_heroobjinfo_defenseValue_lbl.Text = variable_hero.current_defense.ToString() + " (" + variable_hero.current_random_defense + ")";
                if (variable_hero.current_health<player_max_health)
                {
                    level_heroobjinfo_healthValue_lbl.Text = variable_hero.current_health.ToString() + "/" + player_max_health;
                }
                else
                {
                    level_heroobjinfo_healthValue_lbl.Text = variable_hero.current_health.ToString();
                }
                level_heroobjinfo_speedValue_lbl.Text = variable_hero.current_speed.ToString();
                level_heroobjinfo_levelValue_lbl.Text = variable_hero.level.ToString();
                if (variable_hero.inventory.Count == 0)
                {
                    level_heroobjinfo_inventory01Value_lbl.Text = "Пусто";
                    level_heroobjinfo_inventory02Value_lbl.Visible = false;
                }
                else if (variable_hero.inventory.Count == 1)
                {             
                    level_heroobjinfo_inventory01Value_lbl.Text = variable_hero.inventory[0].name;
                    level_heroobjinfo_inventory02Value_lbl.Visible = false;
                }
                else if (variable_hero.inventory.Count == 2)
                {                   
                    level_heroobjinfo_inventory01Value_lbl.Text = variable_hero.inventory[0].name;
                    level_heroobjinfo_inventory02Value_lbl.Text = variable_hero.inventory[1].name;
                }
                if (variable_hero.current_health <= 0)
                {
                    level_heroobjInfo_able_reanimate_lbl.Visible = true;
                }
                else
                {
                    level_heroobjInfo_able_reanimate_lbl.Visible = false;
                }
            }
            else if (level_map[x, y] is Monster)
            {
                show_monster_info_set_visible_settings();
                level_monsterinfo_battle_panel.Visible = false;
                Monster variable_monster = (Monster)level_map[x, y];
                level_monsterobjinfo_nameValue_lbl.Text = variable_monster.name;
                level_monsterobjinfo_typeValue_lbl.Text = "Ворог";
                level_monsterobjinfo_strengthValue_lbl.Text = variable_monster.monster_strength.ToString() + " ("+ variable_monster.monster_random_strength + ")";
                level_monsterobjinfo_defenseValue_lbl.Text = variable_monster.monster_defense.ToString() + " (" + variable_monster.monster_random_defense + ")"; ;
                level_monsterobjinfo_healthValue_lbl.Text = variable_monster.monster_health.ToString();
                level_monsterobjinfo_speedValue_lbl.Text = variable_monster.monster_speed.ToString();

                if (x == hero.x || y == hero.y)
                {
                    if (Math.Abs(x - hero.x) == 1 || Math.Abs(y - hero.y) == 1)
                    {
                        string battle_result = "";
                        int minimum_damage_to_hero = variable_monster.monster_strength - (hero.current_defense + hero.current_random_defense);
                        int maximum_damage_to_hero = variable_monster.monster_strength + variable_monster.monster_random_strength - hero.current_defense;
                        int minimum_damage_to_monster = hero.current_strength - (variable_monster.monster_defense + variable_monster.monster_random_defense);
                        int maximum_damage_to_monster = hero.current_strength + hero.current_random_strength - variable_monster.monster_defense;
                        if (maximum_damage_to_hero <= 0)
                        {
                            battle_result = "\t"+ hero.name + ":\n не отримає поранень";
                        }
                        else
                        {
                            if (hero.current_health - minimum_damage_to_hero <= 0)
                            {
                                battle_result = "\t" + hero.name + ":\n точно загине";
                            }
                            else
                            {
                                if (minimum_damage_to_hero < 0)
                                {
                                    minimum_damage_to_hero = 0;
                                }
                                if (hero.current_health - maximum_damage_to_hero > 0)
                                {
                                    if (maximum_damage_to_monster == minimum_damage_to_monster)
                                    {
                                        battle_result = "\t" + hero.name + ":\n зазнає поранень (" + maximum_damage_to_hero + "), проте не загине.";
                                    }
                                    else
                                    {
                                        battle_result = "\t" + hero.name + ":\n зазнає поранень (" + minimum_damage_to_hero + "-" + maximum_damage_to_hero + "), проте не загине.";
                                    }
                                }
                                else
                                {
                                    if (maximum_damage_to_monster == minimum_damage_to_monster)
                                    {
                                        battle_result = "\t" + hero.name + ":\n зазнає поранень (" + maximum_damage_to_hero + "), можливо загине.";
                                    }
                                    else
                                    {
                                        battle_result = "\t" + hero.name + ":\n зазнає поранень (" + minimum_damage_to_hero + "-" + maximum_damage_to_hero + "), можливо загине.";
                                    }
                                }
                            }
                        }
                        if (maximum_damage_to_monster <= 0)
                        {
                            battle_result += "\n\t" + variable_monster.name + ":\n не отримає поранень";
                        }
                        else
                        {
                            if (variable_monster.monster_health - minimum_damage_to_monster <= 0)
                            {
                                
                                battle_result += "\n\t" + variable_monster.name + ":\n точно загине";
                            }
                            else
                            {
                                if (minimum_damage_to_monster < 0)
                                {
                                    minimum_damage_to_monster = 0;
                                }
                                if (variable_monster.monster_health - maximum_damage_to_monster > 0)
                                {
                                    
                                    if (maximum_damage_to_monster == minimum_damage_to_monster)
                                    {
                                        battle_result += "\n\t" + variable_monster.name + ":\n зазнає поранень (" + maximum_damage_to_monster + "), проте не загине.";
                                    }
                                    else
                                    {
                                        battle_result += "\n\t" + variable_monster.name + ":\n зазнає поранень (" + minimum_damage_to_monster + "-" + maximum_damage_to_monster + "), проте не загине.";
                                    }
                                }
                                else
                                {
                                    if (maximum_damage_to_monster == minimum_damage_to_monster)
                                    {
                                        battle_result += "\n\t" + variable_monster.name + ":\n зазнає поранень (" + maximum_damage_to_monster + "), можливо загине.";
                                    }
                                    else
                                    {
                                        battle_result += "\n\t" + variable_monster.name + ":\n зазнає поранень (" + minimum_damage_to_monster + "-" + maximum_damage_to_monster + "), можливо загине.";
                                    }
                                }
                            }
                        }
                        level_monsterobjinfo_posibilities_consequences_lbl.Text = battle_result;

                        level_monsterinfo_battle_panel.Visible = true;
                        level_monsterobjinfo_posibilities_hero_strength_lbl.ForeColor = Color.Green;                  
                        level_monsterobjinfo_posibilities_hero_defense_lbl.ForeColor = Color.Green;
                        level_monsterobjinfo_posibilities_hero_health_lbl.ForeColor = Color.Green;
                        level_monsterobjinfo_posibilities_monster_strength_lbl.ForeColor = Color.Red;
                        level_monsterobjinfo_posibilities_monster_defense_lbl.ForeColor = Color.Red;
                        level_monsterobjinfo_posibilities_monster_health_lbl.ForeColor = Color.Red;
                        
                        level_monsterobjinfo_posibilities_hero_strength_lbl.Text = hero.current_strength.ToString() + " (" + hero.current_random_strength + ")";
                        level_monsterobjinfo_posibilities_hero_defense_lbl.Text = hero.current_defense.ToString() + " (" + hero.current_random_defense + ")";
                        level_monsterobjinfo_posibilities_hero_health_lbl.Text = hero.current_health.ToString();
                        level_monsterobjinfo_posibilities_monster_strength_lbl.Text = variable_monster.monster_strength.ToString() + " (" + variable_monster.monster_random_strength + ")";
                        level_monsterobjinfo_posibilities_monster_defense_lbl.Text = variable_monster.monster_defense.ToString() + " (" + variable_monster.monster_random_defense + ")";
                        level_monsterobjinfo_posibilities_monster_health_lbl.Text = variable_monster.monster_health.ToString();

                        
                        
                        //        = hero.name + " атакує " + variable_monster.name + " з силою - " + hero.current_strength + ", може нанести " + hero.current_random_strength + " додаткових ушкодженнь. \n" +
                        //         variable_monster.name + " обороняється - зможе відбити атаку з силою " + variable_monster.monster_defense + ", може додатково відбити атаку з силою " + variable_monster.monster_random_defense + " і атакує у відповідь з силою " + hero.current_strength + ", і може нанести " + variable_monster.monster_random_strength + " додаткових ушкодженнь. \n"+
                        //         hero.name + " зможе відбити ворожу атаку " + variable_monster.name + " із силою " + hero.current_defense + " зможе додатково заблокувати " + hero.current_random_defense + "ушкоджень.";
                    }
                }
            }
            else if (level_map[x, y] is Loot)
            {
                show_loot_info_set_visible_settings();
                Loot variable_loot = (Loot)level_map[x, y];
                level_lootobjinfo_nameValue_lbl.Text = level_map[x, y].name;
                level_lootobjinfo_typeValue_lbl.Text = "Спорядження " + "(" + variable_loot.type_of_bodypart + ")";
                level_lootobjinfo_playerclassValue_lbl.Text = variable_loot.equipment_class;
                level_lootobjinfo_strengthBonusValue_lbl.Text = variable_loot.strength_bonus.ToString() +" (" + variable_loot.random_strength_bonus.ToString() + ")";
                level_lootobjinfo_defenseBonusValue_lbl.Text = variable_loot.defense_bonus.ToString() + " (" + variable_loot.random_defense_bonus.ToString() + ")";
                level_lootobjinfo_healthBonusValue_lbl.Text = variable_loot.health_bonus.ToString();
                level_lootobjinfo_speedBonusValue_lbl.Text = variable_loot.speed_bonus.ToString();
                level_lootobjinfo_minlevelValue_lbl.Text = variable_loot.min_level.ToString();
                level_lootobjinfo_lootPriceValue_lbl.Text = variable_loot.price.ToString();
                level_lootobjinfo_able_to_pickup_lbl.Visible = false;
                if (level_map[x, y].x == hero.x || level_map[x, y].y == hero.y)
                {
                    if (Math.Abs(level_map[x, y].x - hero.x) == 1 || Math.Abs(level_map[x, y].y - hero.y) == 1)
                    {
                        level_lootobjinfo_able_to_pickup_lbl.Visible = true;
                    }                   
                }
            }
            else
            {
                show_null_info_set_visible_settings();
            }
        }
        private void show_hero_info_set_visible_settings()
        {
            level_monsterinfo_panel.Visible = false;
            level_lootinfo_panel.Visible = false;
            level_heroinfo_panel.Visible = true; 
        }
        private void show_monster_info_set_visible_settings()
        {
            level_heroinfo_panel.Visible = false;  
            level_lootinfo_panel.Visible = false;
            level_monsterinfo_panel.Visible = true;
        }
        private void show_loot_info_set_visible_settings()
        {
            level_heroinfo_panel.Visible = false;
            level_monsterinfo_panel.Visible = false;
            level_lootinfo_panel.Visible = true;
        }
        private void show_null_info_set_visible_settings()
        {
            level_heroinfo_panel.Visible = false;
            level_monsterinfo_panel.Visible = false;
            level_lootinfo_panel.Visible = false;
        }
        private void setHero(Hero hero, LevelObject[,] level_map)
        {
            level_map[hero.x, hero.y] = hero;
        }
        private void setMonster(Monster monster, LevelObject[,] level_map)
        {
            for (int i = 0; ; i++)
            {
                if (level_map[monster.x, monster.y] == null)
                {
                    level_map[monster.x, monster.y] = monster;
                    break;
                }
                else
                {
                    monster.x = LifeObject.generate_random_X();
                    monster.y = LifeObject.generate_random_Y();
                }
            }
        }
        //private void setMonster(Monster monster, LevelObjects[,] level_map, int x, int y)
        //{
        //    monster.x = x;
        //    monster.y = y;
        //    for (int i = 0; ; i++)
        //    {
        //        if (level_map[monster.x, monster.y] == null)
        //        {
        //            level_map[monster.x, monster.y] = monster;
        //            break;
        //        }
        //        else
        //        {
        //            monster.x = LevelObjects.generate_random_X();
        //            monster.y = LevelObjects.generate_random_Y();
        //        }
        //    }
        //}// COORD
        private void setLoot(List<Loot> loot, LevelObject[,] level_map)
        {
            Random ran = new Random();
            int random_loot_index = ran.Next(0, Loot.LootList.Count);
            for (int i = 0; ; i++)
            {
                if (level_map[loot[random_loot_index].x, loot[random_loot_index].y] == null)
                {
                    level_map[loot[random_loot_index].x, loot[random_loot_index].y] = Loot.LootList[random_loot_index];
                    break;
                }
                else
                {
                    loot[random_loot_index].x = LevelObject.generate_random_X();
                    loot[random_loot_index].y = LevelObject.generate_random_Y();
                }
            }
        }
        // 1 lOOT SET 
        private void set_null_obj(LevelObject[,] level_map)
        {
            for (int i = 0; i < level_map.GetLength(0); i++)
            {
                for (int j = 0; j < level_map.GetLength(1); j++)
                {
                    if (level_map[i, j] == null)
                    {
                        LevelObject empty1 = new LevelObject(" ", i, j);
                        level_map[i, j] = empty1;
                    }
                }
            }
        }

        private void button_set_text(LevelObject[,] level_map)
        {
            level_btn00.Text = level_map[0, 0].name;
            level_btn10.Text = level_map[1, 0].name;
            level_btn20.Text = level_map[2, 0].name;
            level_btn30.Text = level_map[3, 0].name;
            level_btn40.Text = level_map[4, 0].name;
            level_btn50.Text = level_map[5, 0].name;
            level_btn60.Text = level_map[6, 0].name;
            level_btn70.Text = level_map[7, 0].name;
            level_btn80.Text = level_map[8, 0].name;
            level_btn90.Text = level_map[9, 0].name;

            level_btn01.Text = level_map[0, 1].name;
            level_btn11.Text = level_map[1, 1].name;
            level_btn21.Text = level_map[2, 1].name;
            level_btn31.Text = level_map[3, 1].name;
            level_btn41.Text = level_map[4, 1].name;
            level_btn51.Text = level_map[5, 1].name;
            level_btn61.Text = level_map[6, 1].name;
            level_btn71.Text = level_map[7, 1].name;
            level_btn81.Text = level_map[8, 1].name;
            level_btn91.Text = level_map[9, 1].name;

            level_btn02.Text = level_map[0, 2].name;
            level_btn12.Text = level_map[1, 2].name;
            level_btn22.Text = level_map[2, 2].name;
            level_btn32.Text = level_map[3, 2].name;
            level_btn42.Text = level_map[4, 2].name;
            level_btn52.Text = level_map[5, 2].name;
            level_btn62.Text = level_map[6, 2].name;
            level_btn72.Text = level_map[7, 2].name;
            level_btn82.Text = level_map[8, 2].name;
            level_btn92.Text = level_map[9, 2].name;

            level_btn03.Text = level_map[0, 3].name;
            level_btn13.Text = level_map[1, 3].name;
            level_btn23.Text = level_map[2, 3].name;
            level_btn33.Text = level_map[3, 3].name;
            level_btn43.Text = level_map[4, 3].name;
            level_btn53.Text = level_map[5, 3].name;
            level_btn63.Text = level_map[6, 3].name;
            level_btn73.Text = level_map[7, 3].name;
            level_btn83.Text = level_map[8, 3].name;
            level_btn93.Text = level_map[9, 3].name;

            level_btn04.Text = level_map[0, 4].name;
            level_btn14.Text = level_map[1, 4].name;
            level_btn24.Text = level_map[2, 4].name;
            level_btn34.Text = level_map[3, 4].name;
            level_btn44.Text = level_map[4, 4].name;
            level_btn54.Text = level_map[5, 4].name;
            level_btn64.Text = level_map[6, 4].name;
            level_btn74.Text = level_map[7, 4].name;
            level_btn84.Text = level_map[8, 4].name;
            level_btn94.Text = level_map[9, 4].name;
        }
        private void set_static_color(int x, int y, string color_description)
        {
            var color_container = Color.White;
            switch (color_description)
            {
                case "current_hero":
                    color_container = Color.DodgerBlue;
                    break;
                case "can_move":
                    color_container = Color.Wheat;
                    break;
                case "enemy":
                    color_container = Color.Red;
                    break;
                case "ally":
                    color_container = Color.LightSkyBlue;
                    break;
                case "can_use":
                    color_container = Color.Yellow;
                    break;
                case "loot":
                    color_container = Color.Orange;
                    break;
                case "dead_hero":
                    color_container = Color.Gray;
                    break;
                case "clear":
                    color_container = Color.White;
                    break;
            }
            if (x == 0 && y == 0)
            {
                level_btn00.BackColor = color_container;
            }
            if (x == 1 && y == 0)
            {
                level_btn10.BackColor = color_container;
            }
            if (x == 2 && y == 0)
            {
                level_btn20.BackColor = color_container;
            }
            if (x == 3 && y == 0)
            {
                level_btn30.BackColor = color_container;
            }
            if (x == 4 && y == 0)
            {
                level_btn40.BackColor = color_container;
            }
            if (x == 5 && y == 0)
            {
                level_btn50.BackColor = color_container;
            }
            if (x == 6 && y == 0)
            {
                level_btn60.BackColor = color_container;
            }
            if (x == 7 && y == 0)
            {
                level_btn70.BackColor = color_container;
            }
            if (x == 8 && y == 0)
            {
                level_btn80.BackColor = color_container;
            }
            if (x == 9 && y == 0)
            {
                level_btn90.BackColor = color_container;
            }
            if (x == 0 && y == 1)
            {
                level_btn01.BackColor = color_container;
            }
            if (x == 1 && y == 1)
            {
                level_btn11.BackColor = color_container;
            }
            if (x == 2 && y == 1)
            {
                level_btn21.BackColor = color_container;
            }
            if (x == 3 && y == 1)
            {
                level_btn31.BackColor = color_container;
            }
            if (x == 4 && y == 1)
            {
                level_btn41.BackColor = color_container;
            }
            if (x == 5 && y == 1)
            {
                level_btn51.BackColor = color_container;
            }
            if (x == 6 && y == 1)
            {
                level_btn61.BackColor = color_container;
            }
            if (x == 7 && y == 1)
            {
                level_btn71.BackColor = color_container;
            }
            if (x == 8 && y == 1)
            {
                level_btn81.BackColor = color_container;
            }
            if (x == 9 && y == 1)
            {
                level_btn91.BackColor = color_container;
            }
            if (x == 0 && y == 2)
            {
                level_btn02.BackColor = color_container;
            }
            if (x == 1 && y == 2)
            {
                level_btn12.BackColor = color_container;
            }
            if (x == 2 && y == 2)
            {
                level_btn22.BackColor = color_container;
            }
            if (x == 3 && y == 2)
            {
                level_btn32.BackColor = color_container;
            }
            if (x == 4 && y == 2)
            {
                level_btn42.BackColor = color_container;
            }
            if (x == 5 && y == 2)
            {
                level_btn52.BackColor = color_container;
            }
            if (x == 6 && y == 2)
            {
                level_btn62.BackColor = color_container;
            }
            if (x == 7 && y == 2)
            {
                level_btn72.BackColor = color_container;
            }
            if (x == 8 && y == 2)
            {
                level_btn82.BackColor = color_container;
            }
            if (x == 9 && y == 2)
            {
                level_btn92.BackColor = color_container;
            }
            if (x == 0 && y == 3)
            {
                level_btn03.BackColor = color_container;
            }
            if (x == 1 && y == 3)
            {
                level_btn13.BackColor = color_container;
            }
            if (x == 2 && y == 3)
            {
                level_btn23.BackColor = color_container;
            }
            if (x == 3 && y == 3)
            {
                level_btn33.BackColor = color_container;
            }
            if (x == 4 && y == 3)
            {
                level_btn43.BackColor = color_container;
            }
            if (x == 5 && y == 3)
            {
                level_btn53.BackColor = color_container;
            }
            if (x == 6 && y == 3)
            {
                level_btn63.BackColor = color_container;
            }
            if (x == 7 && y == 3)
            {
                level_btn73.BackColor = color_container;
            }
            if (x == 8 && y == 3)
            {
                level_btn83.BackColor = color_container;
            }
            if (x == 9 && y == 3)
            {
                level_btn93.BackColor = color_container;
            }
            if (x == 0 && y == 4)
            {
                level_btn04.BackColor = color_container;
            }
            if (x == 1 && y == 4)
            {
                level_btn14.BackColor = color_container;
            }
            if (x == 2 && y == 4)
            {
                level_btn24.BackColor = color_container;
            }
            if (x == 3 && y == 4)
            {
                level_btn34.BackColor = color_container;
            }
            if (x == 4 && y == 4)
            {
                level_btn44.BackColor = color_container;
            }
            if (x == 5 && y == 4)
            {
                level_btn54.BackColor = color_container;
            }
            if (x == 6 && y == 4)
            {
                level_btn64.BackColor = color_container;
            }
            if (x == 7 && y == 4)
            {
                level_btn74.BackColor = color_container;
            }
            if (x == 8 && y == 4)
            {
                level_btn84.BackColor = color_container;
            }
            if (x == 9 && y == 4)
            {
                level_btn94.BackColor = color_container;
            }
        }
        private void set_static_color()
        {
            for (int x = 0; x < level_map.GetLength(0); x++)
            {
                for (int y = 0; y < level_map.GetLength(1); y++)
                {
                    set_static_color(x, y, "clear");
                }
            }
        }
        private void paint_buttons()
        {
            set_static_color();
            for (int x = 0; x < level_map.GetLength(0); x++)
            {
                for (int y = 0; y < level_map.GetLength(1); y++)
                {
                    if (level_map[x, y].name == GameGlobalData.current_turn_player_name && level_map[x, y] is Hero)
                    {
                        set_static_color(x, y, "current_hero");        // PAINT HERO TO COLOR
                        // PAINT EMPTY BUTTONS TO MOVE
                        if (GameGlobalData.count_of_moves > 0)
                        { 
                            if (level_map[x, y].x == 0)
                            {
                                if (level_map[x + 1, y].name == " ")
                                {
                                    set_static_color(x + 1, y, "can_move");
                                }
                            }
                            else if (level_map[x, y].x == 9)
                            {
                                if (level_map[x - 1, y].name == " ")
                                {
                                    set_static_color(x - 1, y, "can_move");
                                }
                            }
                            else if (level_map[x, y].x != 9 && level_map[x, y].x != 0)
                            {
                                if (level_map[x + 1, y].name == " ")
                                {
                                    set_static_color(x + 1, y, "can_move");
                                }
                                if (level_map[x - 1, y].name == " ")
                                {
                                    set_static_color(x - 1, y, "can_move");
                                }
                            }
                            if (level_map[x, y].y == 0)
                            {
                                if (level_map[x, y + 1].name == " ")
                                {
                                    set_static_color(x, y + 1, "can_move");
                                }
                            }
                            else if (level_map[x, y].y == 4)
                            {
                                if (level_map[x, y - 1].name == " ")
                                {
                                    set_static_color(x, y - 1, "can_move");
                                }
                            }
                            else if (level_map[x, y].y != 9 && level_map[x, y].y != 0)
                            {
                                if (level_map[x, y + 1].name == " ")
                                {
                                    set_static_color(x, y + 1, "can_move");
                                }
                                if (level_map[x, y - 1].name == " ")
                                {
                                    set_static_color(x, y - 1, "can_move");
                                }
                            }
                        }                        
                    }

                    
                    if (level_map[x, y] is Monster)             // PAINT ENEMIES
                    {
                        set_static_color(x, y, "enemy");
                        //int name_size = level_map[x, y].name.Length;
                        
                        //else
                        //{
                        //    if (level_map[x, y].name.Contains("Можна атакувати"))
                        //    {
                        //        level_map[x, y].name += level_map[x, y].name.Substring(0, name_size);
                        //        Console.WriteLine(level_map[x, y].name);
                        //    }
                            
                        //}
                    }
                    if (level_map[x, y] is Loot)                // PAINT LOOT
                    {
                        set_static_color(x, y, "loot");                        
                    }
                    if (level_map[x, y] is Hero && level_map[x, y].name != GameGlobalData.current_turn_player_name)                // PAINT ALLYES
                    {
                        Hero dead_hero = (Hero)level_map[x, y];
                        if (dead_hero.current_health <= 0)
                        {
                            set_static_color(x, y, "dead_hero");
                        }
                        else
                        {
                            set_static_color(x, y, "ally");
                        }                     
                    }
                }
            }
        }

        private int spawn_monsters(string variable_monstertype1_name_, int count_of_monstertype1, string variable_monstertype2_name_, int count_of_monstertype2, LevelObject[,] level_map)
        {
            int count_of_monsters = 0;
            for (int i = 0; i < count_of_monstertype1; i++)
            {
                setMonster(Monster.spawn_monster_by_name (variable_monstertype1_name_), level_map);
                count_of_monsters++;
            }
            for (int i = 0; i < count_of_monstertype2; i++)
            {
                setMonster(Monster.spawn_monster_by_name (variable_monstertype2_name_), level_map);
                count_of_monsters++;
            }
            return count_of_monsters;
        }
        private void monster_turn_main()
        {
            for (int i = 0; i < count_of_monsters; i++)
            {
                Monster monster = monster_turn_find_monster(i);
                GameGlobalData.count_of_moves = monster.monster_speed;
                while (GameGlobalData.count_of_moves > 0)
                {
                    int targeted_hero_index = monster_turn_find_closer_hero(monster);
                    monster_turn_move_or_attack(targeted_hero_index, monster);
                    set_null_obj(level_map);
                    button_set_text(level_map);
                    paint_buttons();
                }               
            }
        }
        private int monster_turn_find_closer_hero (Monster monster)
        {
            int distance_to_closer_hero = 99;
            int closer_hero_index = 0;
            for (int i = 0; i < GameGlobalData.count_of_players; i++)
            {
                if (GameGlobalData.HeroList[i].current_health <= 0)
                {
                    continue;
                }
                int temp_distance_to_closer_hero = Math.Abs(monster.x - GameGlobalData.HeroList[i].x) + Math.Abs(monster.y - GameGlobalData.HeroList[i].y);
                if (temp_distance_to_closer_hero < distance_to_closer_hero)
                {
                    distance_to_closer_hero = temp_distance_to_closer_hero;
                    closer_hero_index = i;
                }
            }
            return closer_hero_index;
        }
        private Monster monster_turn_find_monster (int monster_index)
        {
            int finded_monster = 0;
            for (int x = 0; x < GameGlobalData.level_size_x; x++)
            {
                for (int y = 0; y < GameGlobalData.level_size_y; y++)
                {
                    if (level_map[x, y] is Monster)
                    {
                        if (finded_monster == monster_index)
                        {
                            string s = level_map[x, y].name;
                            return (Monster)level_map[x, y];
                        }
                        finded_monster++;
                    }
                }
            }
            return null;
        }
        private void monster_turn_move_or_attack (int the_most_closer_hero, Monster selected_monster)
        {           
            if (AttackCheck(GameGlobalData.HeroList[the_most_closer_hero], selected_monster) == false)
            {
                if (GameGlobalData.HeroList[the_most_closer_hero].x == selected_monster.x)
                {
                    monster_move_logic_enemy_scan_Y(selected_monster, the_most_closer_hero);
                }
                else if (GameGlobalData.HeroList[the_most_closer_hero].y == selected_monster.y)
                {
                    monster_move_logic_enemy_scan_X(selected_monster, the_most_closer_hero);
                }
                else
                {
                    monster_move_logic_enemy_scan_X(selected_monster, the_most_closer_hero);
                }               
            }
        }

        private void monster_move_logic_enemy_scan_X (Monster selected_monster, int the_most_closer_hero)
        {
            if (GameGlobalData.HeroList[the_most_closer_hero].x > selected_monster.x)
            {
                monster_move_logic_X(selected_monster, 1, -1, 1, -1);
            }
            else
            {
                monster_move_logic_X(selected_monster, -1, 1, -1, 1);
            }
        }
        private void monster_move_logic_enemy_scan_Y(Monster selected_monster, int the_most_closer_hero)
        {
            if (GameGlobalData.HeroList[the_most_closer_hero].y > selected_monster.y)
            {
                monster_move_logic_Y(selected_monster, 1, -1, 1, -1);
            }
            else
            {
                monster_move_logic_Y(selected_monster, -1, 1, -1, 1);
            }
        }
        private void monster_move_logic_X (Monster selected_monster, int right, int left, int up, int down)
        {
            if (MoveCheck(selected_monster, selected_monster.x + right, selected_monster.y) == false)
            {
                if (MoveCheck(selected_monster, selected_monster.x, selected_monster.y + up) == false)
                {
                    if (MoveCheck(selected_monster, selected_monster.x + right, selected_monster.y + down) == false)
                    {
                        if (MoveCheck(selected_monster, selected_monster.x + left, selected_monster.y ) == false)
                        {

                        }
                    }
                }
            }           
        }
        private void monster_move_logic_Y (Monster selected_monster, int right, int left, int up, int down)
        {
            if (MoveCheck(selected_monster, selected_monster.x, selected_monster.y + up) == false)
            {
                if (MoveCheck(selected_monster, selected_monster.x + left, selected_monster.y) == false)
                {
                    if (MoveCheck(selected_monster, selected_monster.x + right, selected_monster.y) == false)
                    {
                        if (MoveCheck(selected_monster, selected_monster.x, selected_monster.y + down) == false)
                        {

                        }
                    }
                }
            }
        }


        
        private int get_player_index()
        {
            for (int i = 0; i < GameGlobalData.HeroList.Count; i++)
            {
                if (GameGlobalData.current_turn_player_name == GameGlobalData.HeroList[i].name)
                {
                    //Console.WriteLine(i);
                    return i;
                }
            }
            return -1; // WARNING
        }

        ////////////////////////////////////////////////// HOVER //////////////////////////////////////////////////
        private void level_btn00_MouseHover(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);       
        }
        private void level_btn10_MouseHover(object sender, EventArgs e)
        {
            int x = 1;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn20_MouseHover(object sender, EventArgs e)
        {
            int x = 2;
            int y = 0;
            ShowInfo(level_map, x, y,GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn30_MouseHover(object sender, EventArgs e)
        {
            int x = 3;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn40_MouseHover(object sender, EventArgs e)
        {
            int x = 4;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn50_MouseHover(object sender, EventArgs e)
        {
            int x = 5;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn60_MouseHover(object sender, EventArgs e)
        {
            int x = 6;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn70_MouseHover(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn80_MouseHover(object sender, EventArgs e)
        {
            int x = 8;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn90_MouseHover(object sender, EventArgs e)
        {
            int x = 9;
            int y = 0;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }

        private void level_btn01_MouseHover(object sender, EventArgs e)
        {
            int x = 0;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn11_MouseHover(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn21_MouseHover(object sender, EventArgs e)
        {
            int x = 2;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn31_MouseHover(object sender, EventArgs e)
        {
            int x = 3;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn41_MouseHover(object sender, EventArgs e)
        {
            int x = 4;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn51_MouseHover(object sender, EventArgs e)
        {
            int x = 5;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn61_MouseHover(object sender, EventArgs e)
        {
            int x = 6;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn71_MouseHover(object sender, EventArgs e)
        {
            int x = 7;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn81_MouseHover(object sender, EventArgs e)
        {
            int x = 8;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn91_MouseHover(object sender, EventArgs e)
        {
            int x = 9;
            int y = 1;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }

        private void level_btn02_MouseHover(object sender, EventArgs e)
        {
            int x = 0;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn12_MouseHover(object sender, EventArgs e)
        {
            int x = 1;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn22_MouseHover(object sender, EventArgs e)
        {
            int x = 2;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn32_MouseHover(object sender, EventArgs e)
        {
            int x = 3;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn42_MouseHover(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn52_MouseHover(object sender, EventArgs e)
        {
            int x = 5;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn62_MouseHover(object sender, EventArgs e)
        {
            int x = 6;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn72_MouseHover(object sender, EventArgs e)
        {
            int x = 7;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn82_MouseHover(object sender, EventArgs e)
        {
            int x = 8;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn92_MouseHover(object sender, EventArgs e)
        {
            int x = 9;
            int y = 2;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }

        private void level_btn03_MouseHover(object sender, EventArgs e)
        {
            int x = 0;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn13_MouseHover(object sender, EventArgs e)
        {
            int x = 1;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn23_MouseHover(object sender, EventArgs e)
        {
            int x = 2;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn33_MouseHover(object sender, EventArgs e)
        {
            int x = 3;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn43_MouseHover(object sender, EventArgs e)
        {
            int x = 4;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn53_MouseHover(object sender, EventArgs e)
        {
            int x = 5;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn63_MouseHover(object sender, EventArgs e)
        {
            int x = 6;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn73_MouseHover(object sender, EventArgs e)
        {
            int x = 7;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn83_MouseHover(object sender, EventArgs e)
        {
            int x = 8;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn93_MouseHover(object sender, EventArgs e)
        {
            int x = 9;
            int y = 3;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }

        private void level_btn04_MouseHover(object sender, EventArgs e)
        {
            int x = 0;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn14_MouseHover(object sender, EventArgs e)
        {
            int x = 1;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn24_MouseHover(object sender, EventArgs e)
        {
            int x = 2;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn34_MouseHover(object sender, EventArgs e)
        {
            int x = 3;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn44_MouseHover(object sender, EventArgs e)
        {
            int x = 4;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn54_MouseHover(object sender, EventArgs e)
        {
            int x = 5;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn64_MouseHover(object sender, EventArgs e)
        {
            int x = 6;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn74_MouseHover(object sender, EventArgs e)
        {
            int x = 7;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn84_MouseHover(object sender, EventArgs e)
        {
            int x = 8;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }
        private void level_btn94_MouseHover(object sender, EventArgs e)
        {
            int x = 9;
            int y = 4;
            ShowInfo(level_map, x, y, GameGlobalData.HeroList[get_player_index()]);
        }

        ////////////////////////////////////////////////// CLICK

        private void level_btn00_Click(object sender, EventArgs e)
        {
            Action_Check(0, 0);
        }
        private void level_btn10_Click(object sender, EventArgs e)
        {
            Action_Check(1, 0);
        }
        private void level_btn20_Click(object sender, EventArgs e)
        {
            Action_Check(2, 0);
        }
        private void level_btn30_Click(object sender, EventArgs e)
        {
            Action_Check(3, 0);
        }
        private void level_btn40_Click(object sender, EventArgs e)
        {
            Action_Check(4, 0);
        }
        private void level_btn50_Click(object sender, EventArgs e)
        {
            Action_Check(5, 0);
        }
        private void level_btn60_Click(object sender, EventArgs e)
        {
            Action_Check(6, 0);
        }
        private void level_btn70_Click(object sender, EventArgs e)
        {
            Action_Check(7, 0);
        }
        private void level_btn80_Click(object sender, EventArgs e)
        {
            Action_Check(8, 0);
        }
        private void level_btn90_Click(object sender, EventArgs e)
        {
            Action_Check(9, 0);
        }

        private void level_btn01_Click(object sender, EventArgs e)
        {
            Action_Check(0, 1);
        }
        private void level_btn11_Click(object sender, EventArgs e)
        {
            Action_Check(1, 1);
        }
        private void level_btn21_Click(object sender, EventArgs e)
        {
            Action_Check(2, 1);
        }
        private void level_btn31_Click(object sender, EventArgs e)
        {
            Action_Check(3, 1);
        }
        private void level_btn41_Click(object sender, EventArgs e)
        {
            Action_Check(4, 1);
        }
        private void level_btn51_Click(object sender, EventArgs e)
        {
            Action_Check(5, 1);
        }
        private void level_btn61_Click(object sender, EventArgs e)
        {
            Action_Check(6, 1);
        }
        private void level_btn71_Click(object sender, EventArgs e)
        {
            Action_Check(7, 1);
        }
        private void level_btn81_Click(object sender, EventArgs e)
        {
            Action_Check(8, 1);
        }
        private void level_btn91_Click(object sender, EventArgs e)
        {
            Action_Check(9, 1);
        }


        private void level_btn02_Click(object sender, EventArgs e)
        {
            Action_Check(0, 2);
        }
        private void level_btn12_Click(object sender, EventArgs e)
        {
            Action_Check(1, 2);
        }
        private void level_btn22_Click(object sender, EventArgs e)
        {
            Action_Check(2, 2);
        }
        private void level_btn32_Click(object sender, EventArgs e)
        {
            Action_Check(3, 2);
        }
        private void level_btn42_Click(object sender, EventArgs e)
        {
            Action_Check(4, 2);
        }
        private void level_btn52_Click(object sender, EventArgs e)
        {
            Action_Check(5, 2);
        }
        private void level_btn62_Click(object sender, EventArgs e)
        {
            Action_Check(6, 2);
        }
        private void level_btn72_Click(object sender, EventArgs e)
        {
            Action_Check(7, 2);
        }
        private void level_btn82_Click(object sender, EventArgs e)
        {
            Action_Check(8, 2);
        }
        private void level_btn92_Click(object sender, EventArgs e)
        {
            Action_Check(9, 2);
        }

        private void level_btn03_Click(object sender, EventArgs e)
        {
            Action_Check(0, 3);
        }

        private void level_btn13_Click(object sender, EventArgs e)
        {
            Action_Check(1, 3);
        }

        private void level_btn23_Click(object sender, EventArgs e)
        {
            Action_Check(2, 3);
        }

        private void level_btn33_Click(object sender, EventArgs e)
        {
            Action_Check(3, 3);
        }

        private void level_btn43_Click(object sender, EventArgs e)
        {
            Action_Check(4, 3);
        }

        private void level_btn53_Click(object sender, EventArgs e)
        {
            Action_Check(5, 3);
        }

        private void level_btn63_Click(object sender, EventArgs e)
        {
            Action_Check(6, 3);
        }
        private void level_btn73_Click(object sender, EventArgs e)
        {
            Action_Check(7, 3);
        }
        private void level_btn83_Click(object sender, EventArgs e)
        {
            Action_Check(8, 3);
        }
        private void level_btn93_Click(object sender, EventArgs e)
        {
            Action_Check(9, 3);
        }


        private void level_btn04_Click(object sender, EventArgs e)
        {
            Action_Check(0, 4);
        }
        private void level_btn14_Click(object sender, EventArgs e)
        {
            Action_Check(1, 4);
        }
        private void level_btn24_Click(object sender, EventArgs e)
        {
            Action_Check(2, 4);
        }
        private void level_btn34_Click(object sender, EventArgs e)
        {
            Action_Check(3, 4);
        }
        private void level_btn44_Click(object sender, EventArgs e)
        {
            Action_Check(4, 4);
        }
        private void level_btn54_Click(object sender, EventArgs e)
        {
            Action_Check(5, 4);
        }
        private void level_btn64_Click(object sender, EventArgs e)
        {
            Action_Check(6, 4);
        }
        private void level_btn74_Click(object sender, EventArgs e)
        {
            Action_Check(7, 4);
        }
        private void level_btn84_Click(object sender, EventArgs e)
        {
            Action_Check(8, 4);
        }
        private void level_btn94_Click(object sender, EventArgs e)
        {
            Action_Check(9, 4);
        }

        

        private void next4btn_Click(object sender, EventArgs e)
        {

        }

        private void pl1_show_info_Click(object sender, EventArgs e)
        {

        }




        ////////////////////////////////////////////////////////


        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void level_btn00_MouseLeave(object sender, EventArgs e)
        {

        }

        private void level_objinfo_lootPrice_lbl_Click(object sender, EventArgs e)
        {

        }

        private void next_turn_btn_Click(object sender, EventArgs e)
        {
            turn(level_load_counter+1);
            //if (level_load_counter > GameGlobalData.count_of_players)
            //{
            //    monster_turn_main();
            //    level_load_counter = 0;
            //    next_turn_btn_Click(sender, e);
            //}
            //else
            //{
            //    Turn(Loot.LootList, GameGlobalData.HeroList, level_map);
            //}


            //MainGameplay(Loot.LootList, GameGlobalData.HeroList, level_map, current_level_count_of_monsters); //count_of_all_monsters);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void level_monsterobjinfo_posibilities_monster_health_lbl_Click(object sender, EventArgs e)
        {

        }

        private void level_monsterobjinfo_posibilities_consequences_lbl_Click(object sender, EventArgs e)
        {

        }

        private void level_monsterinfo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void level_lootinfo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pl3_show_info_Click(object sender, EventArgs e)
        {

        }

        private void Level_next_btn_Click(object sender, EventArgs e)
        {

        }

        private void background_parallax_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        ////////////////////////////////////////////////// LEAVE //////////////////////////////////////////////////

        private void level_btn04_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }

        private void level_btn03_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn02_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn01_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn10_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn20_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn30_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn40_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn50_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn60_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn70_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn80_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn90_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn91_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn92_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn93_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn94_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn84_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn74_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn64_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn54_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn44_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn34_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn24_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
        private void level_btn14_MouseLeave(object sender, EventArgs e)
        {
            show_null_info_set_visible_settings();
            level_monsterobjinfo_posibilities_consequences_lbl.Text = "";
        }
    }
}
