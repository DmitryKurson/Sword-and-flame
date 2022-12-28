namespace Sword_and_flame.Entities
{
    public class Loot : LevelObject
    {
        public string loot_index { get; set; }
        public string type_of_bodypart { get; set; }
        public int strength_bonus { get; set; }
        public int random_strength_bonus { get; set; }
        public int defense_bonus { get; set; }
        public int random_defense_bonus { get; set; }
        public int health_bonus { get; set; }
        public int speed_bonus { get; set; }
        public int rank { get; set; }
        public int min_level { get; set; }
        public string equipment_class { get; set; }
        public int price { get; set; }
        public Image loot_image_right { get; set; }
        public Image loot_image_left { get; set; }

        public Loot(string loot_index, string name, string type_of_bodypart, string equipment_class, int min_level, int x, int y, int strength_bonus, int random_strength_bonus, int defense_bonus, int random_defense_bonus, int health_bonus, int speed_bonus, int price, Image loot_image_right, Image loot_image_left) : base(name, x, y)
        {
            this.loot_index = loot_index;
            this.name = name;
            this.type_of_bodypart = type_of_bodypart;
            this.strength_bonus = strength_bonus;
            this.random_strength_bonus = random_strength_bonus;
            this.defense_bonus = defense_bonus;
            this.random_defense_bonus = random_defense_bonus;
            this.health_bonus = health_bonus;
            this.speed_bonus = speed_bonus;
            this.min_level = min_level;
            this.equipment_class = equipment_class;
            this.price = price;
            this.loot_image_right = loot_image_right;
            this.loot_image_left = loot_image_left;
        }
        public static List<Loot> LootList = new List<Loot>() { };
    }

}
