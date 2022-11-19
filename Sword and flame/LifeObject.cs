using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sword_and_flame
{
    public abstract class LifeObject : LevelObject
    {
        public LifeObject(string name, int x, int y) : base(name, x, y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }


        

        public static bool Attack(Hero hero, Monster monster, LevelObject[,] level_map)
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
                int random = ran.Next(1);
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
                int random = ran.Next(1);
                if (random == 1)
                {
                    count += random;
                }
            }
            return count;
        }
    }
}
