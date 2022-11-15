using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle_Crushers
{
    public class Monster : LevelObjects
    {
        public int monster_strength { get; set; }
        public int monster_random_strength { get; set; }
        public int monster_defense { get; set; }
        public int monster_random_defense { get; set; }
        public int monster_health { get; set; }
        public int monster_speed { get; set; }
        public int monster_gold_reward { get; set; }
        public int monster_loot_chance { get; set; }
        public int monster_exp_reward { get; set; }
        public string monster_attack_type { get; set; } 

        // BASIC MONSTER CHARACTERISTICS
        // 1
        // Грабіжник
        public static int default_robber_strength { get; } = 2;
        public static int default_robber_random_strength { get; } = 0;
        public static int default_robber_defense { get; } = 3;
        public static int default_robber_random_defense { get; } = 0;
        public static int default_robber_health { get; } = 3;
        public static int default_robber_speed { get; } = 2;
        public static int default_robber_gold_reward { get; } = 5;
        public static int default_robber_loot_chance { get; } = 6;
        public static int default_robber_exp_reward { get; } = 1;
        public static string default_robber_attack_type { get; } = "melee";

        // Вбивця
        public static int default_rogue_strength { get; } = 3;
        public static int default_rogue_random_strength { get; } = 0;
        public static int default_rogue_defense { get; } = 2;
        public static int default_rogue_random_defense { get; } = 0;
        public static int default_rogue_health { get; } = 2;
        public static int default_rogue_speed { get; } = 3;
        public static int default_rogue_gold_reward { get; }
        public static int default_rogue_loot_chance { get; }
        public static int default_rogue_exp_reward { get; }
        public static string default_rogue_attack_type { get; } = "archer";

        // Головоріз
        public static int default_reaper_strength { get; } = 50;
        public static int default_reaper_random_strength { get; } = 0;
        public static int default_reaper_defense { get; } = 3;
        public static int default_reaper_random_defense { get; } = 2;
        public static int default_reaper_health { get; } = 3;
        public static int default_reaper_speed { get; } = 2;
        public static int default_reaper_gold_reward { get; } = 5;
        public static int default_reaper_loot_chance { get; } = 6;
        public static int default_reaper_exp_reward { get; } = 1;
        public static string default_reaper_attack_type { get; } = "melee";

        // 2
        // Варвар
        public static int default_barbarian_strength { get; } = 50;
        public static int default_barbarian_random_strength { get; } = 0;
        public static int default_barbarian_defense { get; } = 3;
        public static int default_barbarian_random_defense { get; } = 2;
        public static int default_barbarian_health { get; } = 3;
        public static int default_barbarian_speed { get; } = 2;
        public static int default_barbarian_gold_reward { get; } = 5;
        public static int default_barbarian_loot_chance { get; } = 6;
        public static int default_barbarian_exp_reward { get; } = 1;
        public static string default_barbarian_attack_type { get; } = "melee";

        // Вовк
        public static int default_wolf_strength { get; } = 50;
        public static int default_wolf_random_strength { get; } = 0;
        public static int default_wolf_defense { get; } = 3;
        public static int default_wolf_random_defense { get; } = 2;
        public static int default_wolf_health { get; } = 3;
        public static int default_wolf_speed { get; } = 2;
        public static int default_wolf_gold_reward { get; } = 5;
        public static int default_wolf_loot_chance { get; } = 6;
        public static int default_wolf_exp_reward { get; } = 1;
        public static string default_wolf_attack_type { get; } = "melee";

        // Павук-монстроїд
        public static int default_spider_strength { get; } = 50;
        public static int default_spider_random_strength { get; } = 0;
        public static int default_spider_defense { get; } = 3;
        public static int default_spider_random_defense { get; } = 2;
        public static int default_spider_health { get; } = 3;
        public static int default_spider_speed { get; } = 2;
        public static int default_spider_gold_reward { get; } = 5;
        public static int default_spider_loot_chance { get; } = 6;
        public static int default_spider_exp_reward { get; } = 1;
        public static string default_spider_attack_type { get; } = "melee";

        // Друїд
        public static int default_druid_strength { get; } = 5;
        public static int default_druid_random_strength { get; } = 0;
        public static int default_druid_defense { get; } = 4;
        public static int default_druid_random_defense { get; } = 0;
        public static int default_druid_health { get; } = 3;
        public static int default_druid_speed { get; } = 2;
        public static int default_druid_gold_reward { get; }
        public static int default_druid_loot_chance { get; }
        public static int default_druid_exp_reward { get; }
        public static string default_druid_attack_type { get; } = "???";

        // Сніжний барс      
        public static int default_snowLeopard_strength { get; } = 50;
        public static int default_snowLeopard_random_strength { get; } = 0;
        public static int default_snowLeopard_defense { get; } = 3;
        public static int default_snowLeopard_random_defense { get; } = 2;
        public static int default_snowLeopard_health { get; } = 3;
        public static int default_snowLeopard_speed { get; } = 2;
        public static int default_snowLeopard_gold_reward { get; } = 5;
        public static int default_snowLeopard_loot_chance { get; } = 6;
        public static int default_snowLeopard_exp_reward { get; } =  1;
        public static string default_snowLeopard_attack_type { get; } = "melee";

        // Берсеркер
        public static int default_berserker_strength { get; } = 2;
        public static int default_berserker_random_strength { get; } = 2;
        public static int default_berserker_defense { get; } = 1;
        public static int default_berserker_random_defense { get; } = 2;
        public static int default_berserker_health { get; } = 1;
        public static int default_berserker_speed { get; } = 3;
        public static int default_berserker_gold_reward { get; }
        public static int default_berserker_loot_chance { get; }
        public static int default_berserker_exp_reward { get; } = 2;
        public static string default_berserker_attack_type { get; } = "melee";



        //                  ==================================
        // 3
        public static int default_skeleton_strength { get; } = 4;
        public static int default_skeleton_random_strength { get; } = 2;
        public static int default_skeleton_defense { get; } = 0;
        public static int default_skeleton_random_defense { get; } = 4;
        public static int default_skeleton_health { get; } = 4;
        public static int default_skeleton_speed { get; } = 2;
        public static int default_skeleton_gold_reward { get; }
        public static int default_skeleton_loot_chance { get; }
        public static int default_skeleton_exp_reward { get; }

        //public static int default_druid_strength { get; } = 5;
        //public static int default_druid_random_strength { get; } = 0;
        //public static int default_druid_defense { get; } = 4;
        //public static int default_druid_random_defense { get; } = 0;
        //public static int default_druid_health { get; } = 3;
        //public static int default_druid_speed { get; } = 2;
        //public static int default_druid_gold_reward { get; }
        //public static int default_druid_loot_chance { get; }
        //public static int default_druid_exp_reward { get; }

        public static int default_darkKnight_strength { get; } = 4;
        public static int default_darkKnight_random_strength { get; } = 3;
        public static int default_darkKnight_defense { get; } = 5;
        public static int default_darkKnight_random_defense { get; } = 1;
        public static int default_darkKnight_health { get; } = 4;
        public static int default_darkKnight_speed { get; } = 1;
        public static int default_darkKnight_gold_reward { get; }
        public static int default_darkKnight_loot_chance { get; }
        public static int default_darkKnight_exp_reward { get; }

        public static int default_elemental_strength { get; } = 5;
        public static int default_elemental_random_strength { get; } = 4;
        public static int default_elemental_defense { get; } = 6;
        public static int default_elemental_random_defense { get; } = 3;
        public static int default_elemental_health { get; } = 5;
        public static int default_elemental_speed { get; } = 2;
        public static int default_elemental_gold_reward { get; }
        public static int default_elemental_loot_chance { get; }
        public static int default_elemental_exp_reward { get; }

        //  BONUSES
        public static int easy_difficulty_MB_strength { get; } = 0;
        public static int easy_difficulty_MB_random_strength { get; } = 0;
        public static int easy_difficulty_MB_defense { get; } = 0;
        public static int easy_difficulty_MB_random_defense { get; } = 0;
        public static int easy_difficulty_MB_health { get; } = 0;
        public static int easy_difficulty_MB_speed { get; } = 0;
        public static int easy_difficulty_gold_reward { get; }
        public static int easy_difficulty_loot_chance { get; } 
        public static int easy_difficulty_exp_reward { get; }
        public static int normal_difficulty_MB_strength { get; } = 1;
        public static int normal_difficulty_MB_random_strength { get; } = 1;
        public static int normal_difficulty_MB_defense { get; } = 1;
        public static int normal_difficulty_MB_random_defense { get; } = 1;
        public static int normal_difficulty_MB_health { get; } = 1;
        public static int normal_difficulty_MB_speed { get; } = 0;
        public static int normal_difficulty_gold_reward { get; }
        public static int normal_difficulty_loot_chance { get; }
        public static int normal_difficulty_exp_reward { get; }
        public static int hard_difficulty_MB_strength { get; } = 2;
        public static int hard_difficulty_MB_random_strength { get; } = 2;
        public static int hard_difficulty_MB_defense { get; } = 2;
        public static int hard_difficulty_MB_random_defense { get; } = 2;
        public static int hard_difficulty_MB_health { get; } = 2;
        public static int hard_difficulty_MB_speed { get; } = 1;
        public static int hard_difficulty_gold_reward { get; }
        public static int hard_difficulty_loot_chance { get; }
        public static int hard_difficulty_exp_reward { get; }
        //public static int count_players4_MB { get; }
        public static int count_players2_MB { get; }
        public static int count_players3_MB { get; }
        public static int count_players4_MB { get; }



        public Monster(string name, int x, int y) : base(name, x, y)
        {
            this.name = name;
            this.x = x;
            this.y = y;

            switch (GameGlobalData.difficulty)
            {
                case "Легко":
                    generate_monster(easy_difficulty_MB_strength,  easy_difficulty_MB_random_strength, easy_difficulty_MB_defense, easy_difficulty_MB_random_defense, easy_difficulty_MB_health, easy_difficulty_MB_speed, easy_difficulty_gold_reward, easy_difficulty_exp_reward, easy_difficulty_loot_chance);
                    break;
                case "Нормально":
                    generate_monster(normal_difficulty_MB_strength, normal_difficulty_MB_random_strength, normal_difficulty_MB_defense, normal_difficulty_MB_random_defense, normal_difficulty_MB_health, normal_difficulty_MB_speed, normal_difficulty_gold_reward, normal_difficulty_exp_reward, normal_difficulty_loot_chance);
                    break;
                case "Важко":
                    generate_monster(hard_difficulty_MB_strength, hard_difficulty_MB_random_strength, hard_difficulty_MB_defense, hard_difficulty_MB_random_defense, hard_difficulty_MB_health, hard_difficulty_MB_speed, hard_difficulty_gold_reward, hard_difficulty_exp_reward, hard_difficulty_loot_chance);
                    break;
            }
        }

        private void generate_monster (int variable_difficulty_bonus_strength, int variable_difficulty_bonus_random_strength, int variable_difficulty_bonus_defense, int variable_difficulty_bonus_random_defense, int variable_difficulty_bonus_health, int variable_difficulty_bonus_speed, int variable_difficulty_gold_reward, int variable_difficulty_exp_reward, int variable_difficulty_loot_chance)
        {
            switch (name)
            {
                case "Грабіжник":
                    monster_strength = default_robber_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_robber_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_robber_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_robber_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_robber_health + variable_difficulty_bonus_health;
                    monster_speed = default_robber_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_robber_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_robber_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_robber_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_robber_attack_type;
                    break;
                case "Вбивця":
                    monster_strength = default_rogue_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_rogue_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_rogue_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_rogue_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_rogue_health + variable_difficulty_bonus_health;
                    monster_speed = default_rogue_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_rogue_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_rogue_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_rogue_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_rogue_attack_type;
                    break;
                case "Головоріз":
                    monster_strength = default_rogue_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_rogue_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_rogue_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_rogue_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_rogue_health + variable_difficulty_bonus_health;
                    monster_speed = default_rogue_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_rogue_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_rogue_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_rogue_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_reaper_attack_type;
                    break;
                case "Варвар":
                    monster_strength = default_barbarian_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_barbarian_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_barbarian_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_barbarian_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_barbarian_health + variable_difficulty_bonus_health;
                    monster_speed = default_barbarian_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_barbarian_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_barbarian_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_barbarian_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_barbarian_attack_type;
                    break;
                case "Вовк":
                    monster_strength = default_wolf_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_wolf_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_wolf_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_wolf_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_wolf_health + variable_difficulty_bonus_health;
                    monster_speed = default_wolf_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_wolf_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_wolf_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_wolf_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_wolf_attack_type;
                    break;
                case "Павук-монстроїд":
                    monster_strength = default_spider_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_spider_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_spider_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_spider_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_spider_health + variable_difficulty_bonus_health;
                    monster_speed = default_spider_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_spider_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_spider_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_spider_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_spider_attack_type;
                    break;
                case "Друїд":
                    monster_strength = default_druid_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_druid_random_strength + variable_difficulty_bonus_strength;
                    monster_defense = default_druid_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_druid_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_druid_health + variable_difficulty_bonus_health;
                    monster_speed = default_druid_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_druid_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_druid_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_druid_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_druid_attack_type;
                    break;
                case "Сніжний барс":
                    monster_strength = default_snowLeopard_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_snowLeopard_random_strength + variable_difficulty_bonus_strength;
                    monster_defense = default_snowLeopard_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_snowLeopard_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_snowLeopard_health + variable_difficulty_bonus_health;
                    monster_speed = default_snowLeopard_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_snowLeopard_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_snowLeopard_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_snowLeopard_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_snowLeopard_attack_type;
                    break;
                case "Берсеркер":
                    monster_strength = default_berserker_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_berserker_random_strength + variable_difficulty_bonus_strength;
                    monster_defense = default_berserker_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_berserker_random_defense + variable_difficulty_bonus_defense;
                    monster_health = default_berserker_health + variable_difficulty_bonus_health;
                    monster_speed = default_berserker_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_berserker_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_berserker_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_berserker_loot_chance + variable_difficulty_loot_chance;
                    monster_attack_type = default_berserker_attack_type;
                    break;
                



                case "Скелет":
                    monster_strength = default_skeleton_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_skeleton_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_skeleton_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_skeleton_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_skeleton_health + variable_difficulty_bonus_health;
                    monster_speed = default_skeleton_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_skeleton_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_skeleton_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_skeleton_loot_chance + variable_difficulty_loot_chance;
                    break;               
                case "Темний лицар":
                    monster_strength = default_darkKnight_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_darkKnight_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_darkKnight_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_darkKnight_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_darkKnight_health + variable_difficulty_bonus_health;
                    monster_speed = default_darkKnight_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_darkKnight_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_darkKnight_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_darkKnight_loot_chance + variable_difficulty_loot_chance;
                    break;
                case "Елементаль":
                    monster_strength = default_elemental_strength + variable_difficulty_bonus_strength;
                    monster_random_strength = default_elemental_random_strength + variable_difficulty_bonus_random_strength;
                    monster_defense = default_elemental_defense + variable_difficulty_bonus_defense;
                    monster_random_defense = default_elemental_random_defense + variable_difficulty_bonus_random_defense;
                    monster_health = default_elemental_health + variable_difficulty_bonus_health;
                    monster_speed = default_elemental_speed + variable_difficulty_bonus_speed;
                    monster_gold_reward = default_elemental_gold_reward + variable_difficulty_gold_reward;
                    monster_exp_reward = default_elemental_exp_reward + variable_difficulty_exp_reward;
                    monster_loot_chance = default_elemental_loot_chance + variable_difficulty_loot_chance;
                    break;
            }
        }

        public static Monster spawn_monster_by_name (string name)
        {
            switch (name)
            {
                // 1
                case "Грабіжник":
                    Monster robber = new Monster("Грабіжник", generate_random_X(), generate_random_Y());
                    return robber;
                case "Вбивця":
                    Monster rogue = new Monster("Вбивця", generate_random_X(), generate_random_Y());
                    return rogue;
                case "Головоріз":
                    Monster reaper = new Monster("Головоріз", generate_random_X(), generate_random_Y());
                    return reaper;
                // 2
                case "Варвар":
                    Monster barbarian = new Monster("Варвар", generate_random_X(), generate_random_Y());
                    return barbarian;
                case "Вовк":
                    Monster wolf = new Monster("Вовк", generate_random_X(), generate_random_Y());
                    return wolf;
                case "Павук-монстроїд":
                    Monster spider = new Monster("Павук-монстроїд", generate_random_X(), generate_random_Y());
                    return spider;
                case "Друїд":
                    Monster druid = new Monster("Друїд", generate_random_X(), generate_random_Y());
                    return druid;
                case "Сніжний барс":
                    Monster snowLeopard = new Monster("Сніжний барс", generate_random_X(), generate_random_Y());
                    return snowLeopard;
                case "Берсеркер":
                    Monster berserker = new Monster("Берсеркер", generate_random_X(), generate_random_Y());
                    return berserker;
                // 3




                //case "Абориген":
                //    Monster spider = new Monster("Павук-монстроїд", generate_random_X(), generate_random_Y());
                //    return spider;
                //case "Абориген":
                //    Monster spider = new Monster("", generate_random_X(), generate_random_Y());
                //    return spider;
                //case "Абориген":
                //    Monster spider = new Monster("", generate_random_X(), generate_random_Y());
                //    return spider;
                //case "Абориген":
                //    Monster spider = new Monster("", generate_random_X(), generate_random_Y());
                //    return spider;
                //case "Абориген":
                //    Monster spider = new Monster("", generate_random_X(), generate_random_Y());
                //    return spider;

                //case "Скелет":
                //    return spawn_skeleton();

                //case "Темний лицар":
                //    return spawn_darkKnight();
                //case "Елементаль":
                //    return spawn_elemental();
                default:
                    return null;
            }
        }

        public static Monster spawn_skeleton()
        {
            Monster skeleton = new Monster("Скелет", generate_random_X(), generate_random_Y());
            return skeleton;
        }

        public static Monster spawn_darkKnight()
        {
            Monster darkKnight = new Monster("Темний лицар", generate_random_X(), generate_random_Y());
            return darkKnight;
        }
        public static Monster spawn_elemental()
        {
            Monster elemental = new Monster("Елементаль", generate_random_X(), generate_random_Y());
            return elemental;
        }


        public static int monster_random_count(int monster_random_basic)
        {
            int count = 0;
            for (int i = 0; i < monster_random_basic; i++)
            {
                Random ran = new Random();
                int random = ran.Next(0, 1);
                if (random == 1)
                {
                    count += random;
                }
            }
            return count;
        }

    }
}

    

