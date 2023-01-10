using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castle_Crushers
{
    public partial class PlayerTurn_info : Form
    {
        string player_name;
        public PlayerTurn_info(string player_name_)
        {
            InitializeComponent();
            player_name = player_name_;
        }

        private void PlayerTurn_info_Load(object sender, EventArgs e)
        {
            
            //Level.turn(Loot.LootList, GameGlobalData.HeroList, Level.level_map )
            
        }

        private void PlayerTurn_info_ok_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
