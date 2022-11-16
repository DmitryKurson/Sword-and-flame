using System;
using System.Collections.Generic;
using System.Linq;

namespace Castle_Crushers
{
    public class Hero : LevelObjects
    {
        public static int default_PL1X_cp1 = 0;
        public static int default_PL1X_cp2 = 0;
        public static int default_PL1X_cp3 = 0;
        public static int default_PL1X_cp4 = 0;
        public static int default_PL2X_cp2 = 0;
        public static int default_PL2X_cp3 = 0;
        public static int default_PL2X_cp4 = 0;
        public static int default_PL3X_cp3 = 0;
        public static int default_PL3X_cp4 = 0;
        public static int default_PL4X_cp4 = 0;

        public static int default_PL1Y_cp1 = 2;
        public static int default_PL1Y_cp2 = 1;
        public static int default_PL1Y_cp3 = 0;
        public static int default_PL1Y_cp4 = 0;
        public static int default_PL2Y_cp2 = 3;
        public static int default_PL2Y_cp3 = 2;
        public static int default_PL2Y_cp4 = 1;
        public static int default_PL3Y_cp3 = 4;
        public static int default_PL3Y_cp4 = 3;
        public static int default_PL4Y_cp4 = 4;
       
        public string player_class { get; set; }
        public int level { get; set; }
        public int XP { get; set; }
        public int current_strength { get; set; }
        public int current_random_strength { get; set; }
        public int current_defense { get; set; }
        public int current_random_defense { get; set; }
        public int current_health { get; set; }
        public int current_speed { get; set; }
        public int count_of_gold { get; set; }
        public int player_level_strength_bonus { get; set; }
        public int player_level_random_strength_bonus { get; set; }
        public int player_level_defense_bonus { get; set; }
        public int player_level_random_defense_bonus { get; set; }
        public int player_level_health_bonus { get; set; }  
        public int player_level_speed_bonus { get; set; }
        public List<Loot> inventory = new List<Loot>(2) { }; 
        public List<Loot> equiped_loot = new List<Loot>(5) { }; // HEAD
                                                                // TORSO
                                                                // RIGHT HAND
                                                                // LEFT HAND                                                               
                                                                // LEGS


        // ДЛЯ ЗАПИСУ КЛАСОВИХ ХАРАКТЕРИСТИК
        public static int variable_class_strength { get; set; }
        public static int variable_class_random_strength { get; set; }
        public static int variable_class_defense { get; set; }
        public static int variable_class_random_defense { get; set; }
        public static int variable_class_health { get; set; }
        public static int variable_class_speed { get; set; }  

        public static int default_Warrior_Strength { get; } = 0;
        public static int default_Warrior_random_Strength { get; } = 5;
        public static int default_Warrior_Defense { get; } = 0;
        public static int default_Warrior_random_Defense { get; } = 0;
        public static int default_Warrior_Health { get; } = 3;
        public static int default_Warrior_Speed { get; } = 3;

        public static int default_Paladin_Strength { get; } = 3;
        public static int default_Paladin_random_Strength { get; } = 2;
        public static int default_Paladin_Defense { get; } = 3;
        public static int default_Paladin_random_Defense { get; } = 2;
        public static int default_Paladin_Health { get; } = 5;
        public static int default_Paladin_Speed { get; } = 3;

        public static int default_Archer_Strength { get; } = 1;         //
        public static int default_Archer_random_Strength { get; } = 1;  //
        public static int default_Archer_Defense { get; } = 2;
        public static int default_Archer_random_Defense { get; } = 3;
        public static int default_Archer_Health { get; } = 2;
        public static int default_Archer_Speed { get; } = 4;

        public static int default_Wizard_Strength { get; } = 1;         //
        public static int default_Wizard_random_Strength { get; } = 1;  //
        public static int default_Wizard_Defense { get; } = 2;
        public static int default_Wizard_random_Defense { get; } = 2;
        public static int default_Wizard_Health { get; } = 2;           //
        public static int default_Wizard_Speed { get; } = 3;            //

        
        

        private int equipment_bonus_strength { get; set; }
        private int equipment_bonus_random_strength { get; set; }
        private int equipment_bonus_defense { get; set; }
        private int equipment_bonus_random_defense { get; set; }
        private int equipment_bonus_health { get; set; }
        private int equipment_bonus_speed { get; set; }


       

        public static int return_final_player_strength(int class_strength_, int equipment_bonus_strength_, int level_bonus_strength_)
        {
            return class_strength_ + equipment_bonus_strength_ + level_bonus_strength_;
        }
        public static int return_final_player_random_strength(int class_random_strength_, int equipment_bonus_random_strength_, int level_bonus_random_strength_)
        {
            return class_random_strength_ + equipment_bonus_random_strength_ + level_bonus_random_strength_;
        }
        public static int return_final_player_defense(int class_defense_, int equipment_bonus_defense_, int level_bonus_defense_)
        {
            return class_defense_ + equipment_bonus_defense_ + level_bonus_defense_;
        }
        public static int return_final_player_random_defense(int class_random_defense_, int equipment_bonus_random_defense_, int level_bonus_random_defense_)
        {
            return class_random_defense_ + equipment_bonus_random_defense_ + level_bonus_random_defense_;
        }
        public static int return_final_player_health(int class_health_, int equipment_bonus_health_, int level_bonus_health_)
        {
            return class_health_ + equipment_bonus_health_ + level_bonus_health_;
        }
        public static int return_final_player_speed(int class_speed_, int equipment_bonus_speed_, int level_bonus_speed_)
        {
            return class_speed_ + equipment_bonus_speed_ + level_bonus_speed_;
        }

        public Hero (int x, int y, string name, string player_class, int level, int XP, int count_of_gold, int final_strength, int random_strength, int final_defense, int random_defense, int final_health, int final_speed, List<Loot> inventory, List<Loot> equiped_loot) : base(name, x, y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.player_class = player_class;
            this.level = level;
            this.XP = XP;
            this.count_of_gold = count_of_gold;
            this.current_strength = final_strength;
            this.current_random_strength = random_strength;
            this.current_defense = final_defense;
            this.current_random_defense = random_defense;
            this.current_health = final_health;
            this.current_speed = final_speed;
            this.inventory = inventory;
            this.equiped_loot = equiped_loot;
        }


        public static void AddToInventory(Hero player, Loot loot)
        {
            player.inventory.Add(loot);
            Console.WriteLine("Ви підібрали - " + loot.name + ".");
        }

        public static void Move(Hero player, int final_player_position_X, int final_player_position_Y, LevelObjects[,] level_map)
        {
            level_map[player.x, player.y] = null;
            level_map[final_player_position_X, final_player_position_Y] = player;
            player.x = final_player_position_X;
            player.y = final_player_position_Y;
        }

        public static bool Attack(Hero hero, Monster monster, LevelObjects[,] level_map)
        {
            string battle_result_message = "";
            bool monster_kill = false;
            int random_hero_damage = random_count(hero.current_random_strength, hero.equipment_bonus_random_strength);
            int random_hero_defense = random_count(hero.current_random_defense, hero.equipment_bonus_random_defense);

            int random_monster_damage = random_count(monster.monster_random_strength);
            int random_monster_defense = random_count(monster.monster_random_defense);

            int damage_to_monster = hero.current_strength + random_hero_damage - monster.monster_defense - random_monster_defense;
            int damage_to_hero = monster.monster_strength + random_monster_damage - hero.current_defense - random_hero_defense;

            monster.monster_health -= Math.Abs(damage_to_monster);
            if (monster.monster_health <= 0)
            {
                level_map[monster.x, monster.y] = null;
                hero.current_health -= Math.Abs(damage_to_hero / 2); // Якщо монстр гине, герой отримує половину від завданої монстром шкоди
                if (hero.current_health < 0)
                {
                    battle_result_message = "\n\tПОРАЗКА\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero / 2 + " ран.\n " + hero.name + " непритомніє від ран. " + monster.name + " загинув.";
                }
                else
                {
                    battle_result_message = "\n\tПЕРЕМОГА\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero / 2 + " ран.\n " + hero.name + " виживає та отримує " + monster.monster_exp_reward + " досвіду.\n " + monster.name + " загинув.";
                }
                monster_kill = true;
            }
            else if (monster.monster_health > 0)
            {
                hero.current_health -= Math.Abs(damage_to_hero);
                if (hero.current_health < 0)
                {
                    battle_result_message = "\n\tПОРАЗКА\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero + " ран.\n " + hero.name + " непритомніє від ран. " + monster.name + " виживає.";
                }
                else
                {
                    battle_result_message = "\n\tНІЧИЯ\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero + " ран.\n " + hero.name + " виживає. " + monster.name + " виживає.";
                }
            }
            ShowMessage battle_result = new ShowMessage(battle_result_message);
            battle_result.ShowDialog();
            return monster_kill;            
        }

        public static int random_count(int random_basic, int random_equipments)
        {
            int count = 0;
            for (int i = 0; i < random_basic + random_equipments; i++)
            {
                Random ran = new Random();
                int random = ran.Next(0, 2);
                if (random == 1)
                {
                    count += random;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        public static int random_count(int random_basic)
        {
            int count = 0;
            for (int i = 0; i < random_basic; i++)
            {
                Random ran = new Random();
                int random = ran.Next(0, 1);
                if (random == 1)
                {
                    count += random;
                }
            }
            Console.WriteLine();
            return count;
        }



        //public static void Equip(Hero player, Loot loot)
        //{
        //    player.inventory.Add(loot);
        //    Console.WriteLine("Ви підібрали - " + loot.name + ".");
        //}

        public static int sum_inventory_strength_bonus(List<Loot> player_inventory)
        {
            int sum_strength = 0;
            for (int i = 0; i < player_inventory.Count(); i++)
            {
                sum_strength += player_inventory[i].strength_bonus;
            }
            return sum_strength;
        }
        public static int sum_inventory_random_strength_bonus(List<Loot> player_inventory)
        {
            int sum_random_strength = 0;
            for (int i = 0; i < player_inventory.Count(); i++)
            {
                sum_random_strength += player_inventory[i].random_strength_bonus;
            }
            return sum_random_strength;
        }
        public static int sum_inventory_defense_bonus(List<Loot> player_inventory)
        {
            int sum_defense = 0;
            for (int i = 0; i < player_inventory.Count(); i++)
            {
                sum_defense += player_inventory[i].defense_bonus;
            }
            return sum_defense;
        }
        public static int sum_inventory_random_defense_bonus(List<Loot> player_inventory)
        {
            int sum_random_defense = 0;
            for (int i = 0; i < player_inventory.Count(); i++)
            {
                sum_random_defense += player_inventory[i].random_defense_bonus;
            }
            return sum_random_defense;
        }
        public static int sum_inventory_health_bonus(List<Loot> player_inventory)
        {
            int sum_health = 0;
            for (int i = 0; i < player_inventory.Count(); i++)
            {
                sum_health += player_inventory[i].health_bonus;
            }
            return sum_health;
        }
        public static int sum_inventory_speed_bonus(List<Loot> player_inventory)
        {
            int sum_speed = 0;
            for (int i = 0; i < player_inventory.Count(); i++)
            {
                sum_speed += player_inventory[i].speed_bonus;
            }
            return sum_speed;
        }

        public static Hero generate_player(int i, string player1_name, string player1_class, string player2_name, string player2_class, string player3_name, string player3_class, string player4_name, string player4_class, int level, int XP, int count_of_gold, int level_strength_bonus, int level_random_strength_bonus, int level_defense_bonus, int level_random_defense_bonus, int level_health_bonus, int level_speed_bonus, List<Loot> variable_inventory, List<Loot> some_equipped)
        {
            int variable_coordinateX = 0;
            int variable_coordinateY = 0;
            switch (i)
            {                
                case 1:
                    switch (player1_class)
                    {
                        case "Воїн":
                            variable_class_strength = default_Warrior_Strength;
                            variable_class_random_strength = default_Warrior_random_Strength;
                            variable_class_defense = default_Warrior_Defense;
                            variable_class_random_defense = default_Warrior_random_Defense;
                            variable_class_health = default_Warrior_Health;
                            variable_class_speed = default_Warrior_Speed;
                            break;
                        case "Паладін":
                            variable_class_strength = default_Paladin_Strength;
                            variable_class_random_strength = default_Paladin_random_Strength;
                            variable_class_defense = default_Paladin_Defense;
                            variable_class_random_defense = default_Paladin_random_Defense;
                            variable_class_health = default_Paladin_Health;
                            variable_class_speed = default_Paladin_Speed;
                            break;
                        case "Лучник":
                            variable_class_strength = default_Archer_Strength;
                            variable_class_random_strength = default_Archer_random_Strength;
                            variable_class_defense = default_Archer_Defense;
                            variable_class_random_defense = default_Archer_random_Defense;
                            variable_class_health = default_Archer_Health;
                            variable_class_speed = default_Archer_Speed;
                            break;
                        case "Чарівник":
                            variable_class_strength = default_Wizard_Strength;
                            variable_class_random_strength = default_Wizard_random_Strength;
                            variable_class_defense = default_Wizard_Defense;
                            variable_class_random_defense = default_Wizard_random_Defense;
                            variable_class_health = default_Wizard_Health;
                            variable_class_speed = default_Wizard_Speed;
                            break;
                    }
                    switch (GameGlobalData.count_of_players)
                    {
                        case 1:
                            variable_coordinateX = default_PL1X_cp1;
                            variable_coordinateY = default_PL1Y_cp1;
                            break;
                        case 2:
                            variable_coordinateX = default_PL1X_cp2;
                            variable_coordinateY = default_PL1Y_cp2;
                            break;
                        case 3:
                            variable_coordinateX = default_PL1X_cp3;
                            variable_coordinateY = default_PL1Y_cp3;
                            break;
                        case 4:
                            variable_coordinateX = default_PL1X_cp4;
                            variable_coordinateY = default_PL1Y_cp4;
                            break;
                    }
                    Hero player_1 = new Hero(variable_coordinateX, variable_coordinateY, player1_name, player1_class, level, XP, count_of_gold,
                       return_final_player_strength(variable_class_strength, sum_inventory_strength_bonus(variable_inventory), level_strength_bonus),
                       return_final_player_random_strength(variable_class_random_strength, sum_inventory_random_strength_bonus(variable_inventory), level_random_strength_bonus),
                       return_final_player_defense(variable_class_defense, sum_inventory_defense_bonus(variable_inventory), level_defense_bonus),
                       return_final_player_random_defense(variable_class_random_defense, sum_inventory_random_defense_bonus(variable_inventory), level_random_defense_bonus),
                       return_final_player_health(variable_class_health, sum_inventory_health_bonus(variable_inventory), level_health_bonus),
                       return_final_player_speed(variable_class_speed, sum_inventory_speed_bonus(variable_inventory), level_speed_bonus),
                       variable_inventory, some_equipped);
                        GameGlobalData.HeroList.Add(player_1);
                    return player_1;
                case 2:
                    switch (player2_class)
                    {
                        case "Воїн":
                            variable_class_strength = default_Warrior_Strength;
                            variable_class_defense = default_Warrior_Defense;
                            variable_class_health = default_Warrior_Health;
                            variable_class_speed = default_Warrior_Speed;
                            break;
                        case "Паладін":
                            variable_class_strength = default_Paladin_Strength;
                            variable_class_defense = default_Paladin_Defense;
                            variable_class_health = default_Paladin_Health;
                            variable_class_speed = default_Paladin_Speed;
                            break;
                        case "Лучник":
                            variable_class_strength = default_Archer_Strength;
                            variable_class_defense = default_Archer_Defense;
                            variable_class_health = default_Archer_Health;
                            variable_class_speed = default_Archer_Speed;
                            break;
                        case "Чарівник":
                            variable_class_strength = default_Wizard_Strength;
                            variable_class_defense = default_Wizard_Defense;
                            variable_class_health = default_Wizard_Health;
                            variable_class_speed = default_Wizard_Speed;
                            break;
                    }
                    switch (GameGlobalData.count_of_players)
                    {
                        case 2:
                            variable_coordinateX = default_PL2X_cp2;
                            variable_coordinateY = default_PL2Y_cp2;
                            break;
                        case 3:
                            variable_coordinateX = default_PL2X_cp3;
                            variable_coordinateY = default_PL2Y_cp3;
                            break;
                        case 4:
                            variable_coordinateX = default_PL2X_cp4;
                            variable_coordinateY = default_PL2Y_cp4;
                            break;
                    }
                    Hero player_2 = new Hero(variable_coordinateX, variable_coordinateY, player2_name, player2_class, level, XP, count_of_gold,
                        return_final_player_strength(variable_class_strength, sum_inventory_strength_bonus(variable_inventory), level_strength_bonus),
                        return_final_player_random_strength(variable_class_random_strength, sum_inventory_random_strength_bonus(variable_inventory), level_random_strength_bonus),
                        return_final_player_defense(variable_class_defense, sum_inventory_defense_bonus(variable_inventory), level_defense_bonus),
                        return_final_player_random_defense(variable_class_random_defense, sum_inventory_random_defense_bonus(variable_inventory), level_random_defense_bonus),
                        return_final_player_health(variable_class_health, sum_inventory_health_bonus(variable_inventory), level_health_bonus),
                        return_final_player_speed(variable_class_speed, sum_inventory_speed_bonus(variable_inventory), level_speed_bonus),
                        variable_inventory, some_equipped);
                    GameGlobalData.HeroList.Add(player_2);
                    return player_2;
                case 3:
                    switch (player3_class)
                    {
                        case "Воїн":
                            variable_class_strength = default_Warrior_Strength;
                            variable_class_defense = default_Warrior_Defense;
                            variable_class_health = default_Warrior_Health;
                            variable_class_speed = default_Warrior_Speed;
                            break;
                        case "Паладін":
                            variable_class_strength = default_Paladin_Strength;
                            variable_class_defense = default_Paladin_Defense;
                            variable_class_health = default_Paladin_Health;
                            variable_class_speed = default_Paladin_Speed;
                            break;
                        case "Лучник":
                            variable_class_strength = default_Archer_Strength;
                            variable_class_defense = default_Archer_Defense;
                            variable_class_health = default_Archer_Health;
                            variable_class_speed = default_Archer_Speed;
                            break;
                        case "Чарівник":
                            variable_class_strength = default_Wizard_Strength;
                            variable_class_defense = default_Wizard_Defense;
                            variable_class_health = default_Wizard_Health;
                            variable_class_speed = default_Wizard_Speed;
                            break;
                    }
                    switch (GameGlobalData.count_of_players)
                    {
                        case 3:
                            variable_coordinateX = default_PL3X_cp3;
                            variable_coordinateY = default_PL3Y_cp3;
                            break;
                        case 4:
                            variable_coordinateX = default_PL3X_cp4;
                            variable_coordinateY = default_PL3Y_cp4;
                            break;
                    }
                    Hero player_3 = new Hero(variable_coordinateX, variable_coordinateY, player3_name, player3_class, level, XP, count_of_gold,
                        return_final_player_strength(variable_class_strength, sum_inventory_strength_bonus(variable_inventory), level_strength_bonus),
                        return_final_player_random_strength(variable_class_random_strength, sum_inventory_random_strength_bonus(variable_inventory), level_random_strength_bonus),
                        return_final_player_defense(variable_class_defense, sum_inventory_defense_bonus(variable_inventory), level_defense_bonus),
                        return_final_player_random_defense(variable_class_random_defense, sum_inventory_random_defense_bonus(variable_inventory), level_random_defense_bonus),
                        return_final_player_health(variable_class_health, sum_inventory_health_bonus(variable_inventory), level_health_bonus),
                        return_final_player_speed(variable_class_speed, sum_inventory_speed_bonus(variable_inventory), level_speed_bonus),
                        variable_inventory, some_equipped);
                    GameGlobalData.HeroList.Add(player_3);
                    return player_3;
                case 4:
                    switch (player4_class)
                    {
                        case "Воїн":
                            variable_class_strength = default_Warrior_Strength;
                            variable_class_defense = default_Warrior_Defense;
                            variable_class_health = default_Warrior_Health;
                            variable_class_speed = default_Warrior_Speed;
                            break;
                        case "Паладін":
                            variable_class_strength = default_Paladin_Strength;
                            variable_class_defense = default_Paladin_Defense;
                            variable_class_health = default_Paladin_Health;
                            variable_class_speed = default_Paladin_Speed;
                            break;
                        case "Лучник":
                            variable_class_strength = default_Archer_Strength;
                            variable_class_defense = default_Archer_Defense;
                            variable_class_health = default_Archer_Health;
                            variable_class_speed = default_Archer_Speed;
                            break;
                        case "Чарівник":
                            variable_class_strength = default_Wizard_Strength;
                            variable_class_defense = default_Wizard_Defense;
                            variable_class_health = default_Wizard_Health;
                            variable_class_speed = default_Wizard_Speed;
                            break;
                    }
                    variable_coordinateX = default_PL4X_cp4;
                    variable_coordinateY = default_PL4Y_cp4;
                    Hero player_4 = new Hero(variable_coordinateX, variable_coordinateY, player4_name, player4_class, level, XP, count_of_gold,
                       return_final_player_strength(variable_class_strength, sum_inventory_strength_bonus(variable_inventory), level_strength_bonus),
                       return_final_player_random_strength(variable_class_random_strength, sum_inventory_random_strength_bonus(variable_inventory), level_random_strength_bonus),
                       return_final_player_defense(variable_class_defense, sum_inventory_defense_bonus(variable_inventory), level_defense_bonus),
                       return_final_player_random_defense(variable_class_random_defense, sum_inventory_random_defense_bonus(variable_inventory), level_random_defense_bonus),
                       return_final_player_health(variable_class_health, sum_inventory_health_bonus(variable_inventory), level_health_bonus),
                       return_final_player_speed(variable_class_speed, sum_inventory_speed_bonus(variable_inventory), level_speed_bonus),
                       variable_inventory, some_equipped);
                    GameGlobalData.HeroList.Add(player_4);
                    return player_4;
                default:
                    return null;
            }

        }
    }
}

