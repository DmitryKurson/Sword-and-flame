using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sword_and_flame.Entities
{
    public abstract class LifeObject : LevelObject
    {
        public LifeObject(string name, int x, int y) : base(name, x, y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public void Move(LifeObject someone, int final_position_X, int final_position_Y, LevelObject[,] level_map)
        {
            level_map[someone.x, someone.y] = null;
            level_map[final_position_X, final_position_Y] = someone;
            someone.x = final_position_X;
            someone.y = final_position_Y;
        }

        public bool Attack(Hero hero, Monster monster, LevelObject[,] level_map)
        {
            string battle_result_message = "";
            bool monster_kill = false;
            int random_hero_damage = random_count(hero.current_random_strength, hero.equipment_bonus_random_strength);
            int random_hero_defense = random_count(hero.current_random_defense, hero.equipment_bonus_random_defense);

            int random_monster_damage = random_count(monster.monster_random_strength);
            int random_monster_defense = random_count(monster.monster_random_defense);

            int damage_to_monster = hero.current_strength + random_hero_damage - monster.monster_defense - random_monster_defense;
            if (damage_to_monster < 0)
            {
                damage_to_monster = 0;
            }
            int damage_to_hero = monster.monster_strength + random_monster_damage - hero.current_defense - random_hero_defense;
            if (damage_to_hero < 0)
            {
                damage_to_hero = 0;
            }

            monster.monster_health -= damage_to_monster;
            if (monster.monster_health <= 0)
            {
                level_map[monster.x, monster.y] = null;
                double exp = exp_reward_count(hero, monster);
                hero.current_health -= damage_to_hero / 2; // Якщо монстр гине, герой отримує половину від завданої монстром шкоди
                if (hero.current_health <= 0)
                {
                    battle_result_message = "\n\tПОРАЗКА\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero / 2 + " ран.\n " + hero.name + " непритомніє від ран. " + monster.name + " загинув.";
                }
                else
                {
                    battle_result_message = "\n\tПЕРЕМОГА\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero / 2 + " ран.\n " + hero.name + " виживає та отримує " + exp + " досвіду та " + monster.monster_gold_reward + "золота.\n " + monster.name + " загинув.\n";
                }

                Random loot_drop_chance = new Random();
                Random loot = new Random();
                int low = 0, high = 0; // Low and high edge of array of loot that will drop. E.G. for 2ranked level 
                // will drop loot of 1ranked level and 2ranked level
                if (loot_drop_chance.NextDouble() < monster.monster_loot_chance)
                {
                    switch (LevelProperties.journey_map_current_level_position.level_rank)
                    {
                        case 1:
                            low = 1;
                            high = 2;
                            break;
                        case 2:
                            low = 1;
                            high = 2;
                            break;
                        case 3:
                            low = 1;
                            high = 2;
                            break;
                        case 4:
                            low = 1;
                            high = 2;
                            break;
                        case 5:
                            low = 1;
                            high = 2;
                            break;
                    }
                    string loot_pickup_message = " Обшукавши " + monster.name + " ви знайшли " + Loot.LootList[loot.Next(low, high)].name + ". ";
                    if (hero.inventory.Capacity - hero.inventory.Count < 1)
                    {
                        loot_pickup_message += " Інвентар заповнений, доведеться покласти знайдене.";
                        level_map[monster.x, monster.y] = Loot.LootList[loot.Next(low, high)];
                    }
                    ShowMessage_ChooseFrom2 showMessage = new ShowMessage_ChooseFrom2(this, loot_pickup_message);
                    showMessage.ShowDialog();
                }                
                hero.XP += exp;
                hero.count_of_gold += monster.monster_gold_reward;
                monster_kill = true;
            }
            else if (monster.monster_health > 0)
            {
                hero.current_health -= damage_to_hero;
                if (hero.current_health <= 0)
                {
                    battle_result_message = "\n\tПОРАЗКА\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero + " ран.\n " + hero.name + " непритомніє від ран. " + monster.name + " виживає.";
                }
                else
                {
                    battle_result_message = "\n\tНІЧИЯ\n" + monster.name + " отримує " + damage_to_monster + " ран.\n " + hero.name + " отримує " + damage_to_hero + " ран.\n " + hero.name + " виживає. " + monster.name + " виживає.";
                }
                monster_kill = false;
            }
            ShowMessage battle_result = new ShowMessage(battle_result_message);
            battle_result.ShowDialog();
            
            return monster_kill;
        }

        public double exp_reward_count(Hero hero, Monster monster)
        {     
            double exp_reward = monster.monster_strength - hero.current_strength + monster.monster_random_strength / 2 - hero.current_random_strength / 2 +
                   monster.monster_defense - hero.current_defense + monster.monster_random_defense / 2 - hero.current_random_defense / 2 +
                   monster.monster_health - hero.current_health + monster.monster_speed - hero.current_speed;
            if (exp_reward < 0)
            {
                return Math.Abs(exp_reward / 2);  // return exp/2 if summary of of player characteristics will be bigger than monsters
            }
            else
            {
                return exp_reward;
            }                      
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
            return count;
        }
        public static int random_count(int random_basic)
        {
            int count = 0;
            for (int i = 0; i < random_basic; i++)
            {
                Random ran = new Random();
                int random = ran.Next(0, 2);
                if (random == 1)
                {
                    count += random;
                }
            }
            return count;
        }
    }
}
