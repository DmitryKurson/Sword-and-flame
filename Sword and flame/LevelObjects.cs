using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle_Crushers
{
    public class LevelObjects
    {
        public string name { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public LevelObjects(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public static int generate_random_X()
        {
            Random ran = new Random();
            int random_x = ran.Next(2, GameGlobalData.level_size_x);
            return random_x;
        }

        public static int generate_random_Y()
        {
            Random ran = new Random();
            int random_y = ran.Next(0, GameGlobalData.level_size_y);
            return random_y;
        }

    }
}
