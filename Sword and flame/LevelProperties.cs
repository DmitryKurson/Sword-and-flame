using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Castle_Crushers
{
    class LevelProperties
    {
        public string level_index { get; set; }
        public int level_rank { get; set; } // needed for loot setting
        public string level_name { get; set; }
        public string level_story_preview { get; } 
        public string level_basic_monster_name { get; set; }
        public int level_basic_monster_count { get; set; }
        public string level_secondary_monster_name { get; set; }
        public bool is_passed { get; set; }        
        public Image background_image { get; set; }

        public static LevelProperties journey_map_go_TO { get; set; }
        public static LevelProperties journey_map_go_FROM { get; set; }
        public static LevelProperties journey_map_current_level_position { get; set; }
       

        public static List<LevelProperties> level_list = new List<LevelProperties>() { };
        public LevelProperties (string level_index_, int level_rank, string level_name_, string level_story_preview_, bool is_passed_, string level_basic_monster_name_, int level_basic_monster_count_, string level_secondary_monster_name_, Image background_image_)
        {
            level_index = level_index_;
            this.level_rank = level_rank;
            level_name = level_name_;
            level_story_preview = level_story_preview_;
            is_passed = is_passed_;
            level_basic_monster_name = level_basic_monster_name_;
            level_basic_monster_count = level_basic_monster_count_;
            level_secondary_monster_name = level_secondary_monster_name_;
            background_image = background_image_;
        }              
    }    
}
