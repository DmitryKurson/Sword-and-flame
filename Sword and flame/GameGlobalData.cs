using Sword_and_flame.Entities;

namespace Sword_and_flame
{
    static class GameGlobalData
    {
        public static string final_project_location { get; set; }
        public static int wistred_midocean_minimum_level { get; } = 5;
        public static int game_global_data_creation_count { get; set; } = 0;
        public static int players_turnTime { get; } = 6000000; // 10 min
        public static string current_turn_player_name { get; set; } = "";
        public static int count_of_journeymoves { get; set; }
        public static bool tutorial_skipped { get; set; }
        public static int hide_paper_count_of_click { get; set; }

        public static int count_of_players = 0;
        public static int level_size_x = 10;
        public static int level_size_y = 5;

        public static bool error { get; set; } = false;
        public static int count_of_moves { get; set; }

        public static string difficulty { get; set; }
        public static List<Hero> HeroList = new List<Hero>() { };
        //public static List<Loot> global_player1_inventory = new List<Loot>(3) { };
        //public static List<Loot> global_player2_inventory = new List<Loot>(3) { };
        //public static List<Loot> global_player3_inventory = new List<Loot>(3) { };
        //public static List<Loot> global_player4_inventory = new List<Loot>(3) { };
        //public static int player1_level_strength_bonus = 0;
        //public static int player1_level_random_strength_bonus = 0;
        //public static int player2_level_strength_bonus = 0;
        //public static int player2_level_random_strength_bonus = 0;
        //public static int player3_level_strength_bonus = 0;
        //public static int player3_level_random_strength_bonus = 0;
        //public static int player4_level_strength_bonus = 0;
        //public static int player4_level_random_strength_bonus = 0;
        //public static int player1_level_defense_bonus = 0;
        //public static int player1_level_random_defense_bonus = 0;
        //public static int player2_level_defense_bonus = 0;
        //public static int player2_level_random_defense_bonus = 0;
        //public static int player3_level_defense_bonus = 0;
        //public static int player3_level_random_defense_bonus = 0;
        //public static int player4_level_defense_bonus = 0;
        //public static int player4_level_random_defense_bonus = 0;
        //public static int player1_level_health_bonus = 0;
        //public static int player2_level_health_bonus = 0;
        //public static int player3_level_health_bonus = 0;
        //public static int player4_level_health_bonus = 0;
        //public static int player1_level_speed_bonus = 0;
        //public static int player2_level_speed_bonus = 0;
        //public static int player3_level_speed_bonus = 0;
        //public static int player4_level_speed_bonus = 0;

        //public static int player1_level_strength_bonus = 0;
        //public static int player1_level_random_strength_bonus = 0;
        //public static int player1_level_health_bonus = 0;
        //public static int player1_level_speed_bonus = 0;        
    }
}
