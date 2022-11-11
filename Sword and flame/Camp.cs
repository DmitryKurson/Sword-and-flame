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
    public partial class Camp : Form
    {
        Loot loot_buffer;
        Button some_painted_button;
        public Camp()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Camp_Load(object sender, EventArgs e)
        {
            Color color_container = Color.Green;
            switch (GameGlobalData.count_of_players)
            {
                case 1:
                    player2_overal_panel.Visible = false;
                    player3_overal_panel.Visible = false;
                    player4_overal_panel.Visible = false;
                    break;
                case 2:
                    player3_overal_panel.Visible = false;
                    player4_overal_panel.Visible = false;
                    break;
                case 3:
                    player4_overal_panel.Visible = false;
                    break;
                case 4:
                    break;
            }
        }      
        private void show_heroinfo(int i)
        {
            camp_heroinfo_panel.Visible = true;
            camp_heroinfo_name_lbl.Text = GameGlobalData.HeroList[i].name;
            camp_heroinfo_levelValue_lbl.Text = GameGlobalData.HeroList[i].level.ToString();
            camp_heroinfo_strengthValue_lbl.Text = GameGlobalData.HeroList[i].current_strength + " (" + GameGlobalData.HeroList[i].current_random_strength + ")";
            camp_heroinfo_defenseValue_lbl.Text = GameGlobalData.HeroList[i].current_defense + " (" + GameGlobalData.HeroList[i].current_random_defense + ")" ;
            camp_heroinfo_healthValue_lbl.Text = GameGlobalData.HeroList[i].current_health.ToString();
            camp_heroinfo_speedValue_lbl.Text = GameGlobalData.HeroList[i].current_speed.ToString();
        }
        private void show_equippedloot_info(int player_index, int loot_index)
        {
            if (GameGlobalData.HeroList[player_index].equiped_loot[loot_index] != null)
            {
                camp_lootinfo_panel.Visible = true;
                camp_lootinfo_typeValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].type_of_bodypart;
                camp_lootinfo_playerclassValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].equipment_class;
                camp_lootinfo_minlevelValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].min_level.ToString();
                camp_lootinfo_strengthBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].strength_bonus + " (" + GameGlobalData.HeroList[player_index].equiped_loot[loot_index].random_strength_bonus + ")";
                camp_lootinfo_defenseBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].defense_bonus + " (" + GameGlobalData.HeroList[player_index].equiped_loot[loot_index].random_defense_bonus + ")";
                camp_lootinfo_healthBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].health_bonus.ToString();
                camp_lootinfo_speedBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].speed_bonus.ToString();
                camp_lootinfo_PriceValue_lbl.Text = GameGlobalData.HeroList[player_index].equiped_loot[loot_index].price.ToString();
            }           
        }
        private void show_inventoryloot_info(int player_index, int loot_index)
        {
            if (GameGlobalData.HeroList[player_index].inventory[loot_index] != null)
            {
                camp_lootinfo_panel.Visible = true;
                camp_lootinfo_typeValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].type_of_bodypart;
                camp_lootinfo_playerclassValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].equipment_class;
                camp_lootinfo_minlevelValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].min_level.ToString();
                camp_lootinfo_strengthBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].strength_bonus + " (" + GameGlobalData.HeroList[player_index].inventory[loot_index].random_strength_bonus + ")";
                camp_lootinfo_defenseBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].defense_bonus + " (" + GameGlobalData.HeroList[player_index].inventory[loot_index].random_defense_bonus + ")";
                camp_lootinfo_healthBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].health_bonus.ToString();
                camp_lootinfo_speedBonusValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].speed_bonus.ToString();
                camp_lootinfo_PriceValue_lbl.Text = GameGlobalData.HeroList[player_index].inventory[loot_index].price.ToString();
            }
        }

        private void set_looticon()
        {
            player1_head_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[0].loot_image;
            player1_torso_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[1].loot_image;
            player1_righthand_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[2].loot_image;
            player1_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[3].loot_image;
            player1_legs_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[4].loot_image;
            player1_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[0].inventory[0].loot_image;
            player1_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[0].inventory[1].loot_image;
            player2_head_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[0].loot_image;
            player2_torso_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[1].loot_image;
            player2_righthand_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[2].loot_image;
            player2_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[3].loot_image;
            player2_legs_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[4].loot_image;
            player2_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[1].inventory[0].loot_image;
            player2_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[1].inventory[1].loot_image;
            player3_head_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[0].loot_image;
            player3_torso_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[1].loot_image;
            player3_righthand_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[2].loot_image;
            player3_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[3].loot_image;
            player3_legs_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[4].loot_image;
            player3_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[2].inventory[0].loot_image;
            player3_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[2].inventory[1].loot_image;
            player4_head_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[0].loot_image;
            player4_torso_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[1].loot_image;
            player4_righthand_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[2].loot_image;
            player4_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[3].loot_image;
            player4_legs_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[4].loot_image;
            player4_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[3].inventory[0].loot_image;
            player4_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[3].inventory[1].loot_image;
        }

        private void some_button_click(Button pressed_button, Loot variable_loot, Button some_painted_button)
        {          
            if (variable_loot == null)
            {
                pressed_button.BackColor = Color.Green;
                some_painted_button = pressed_button;                
                switch (pressed_button.Name)
                {
                    case "player1_head_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[0] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[0].equiped_loot[0];
                        }
                        break;
                    case "player1_torso_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[0].equiped_loot[1];
                        }
                        break;
                    case "player1_righthand_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[2] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[0].equiped_loot[2];
                        }
                        break;
                    case "player1_lefthand_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[3] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[0].equiped_loot[3];
                        }
                        break;
                    case "player1_legs_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[4] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[0].equiped_loot[4];
                        }
                        break;
                    case "player1_inventory1_btn":
                        if (GameGlobalData.HeroList[0].inventory[0] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[0].inventory[0];
                        }
                        break;
                    case "player1_inventory2_btn":
                        if (GameGlobalData.HeroList[0].inventory[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[0].inventory[1];
                        }
                        break;
                    case "player2_head_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[0] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[1].equiped_loot[0];
                        }
                        break;
                    case "player2_torso_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[1].equiped_loot[1];
                        }
                        break;
                    case "player2_righthand_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[2] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[1].equiped_loot[2];
                        }
                        break;
                    case "player2_lefthand_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[3] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[1].equiped_loot[3];
                        }
                        break;
                    case "player2_legs_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[4] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[1].equiped_loot[4];
                        }
                        break;
                    case "player2_inventory1_btn":
                        if (GameGlobalData.HeroList[1].inventory[0] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[1].inventory[0];
                        }
                        break;
                    case "player2_inventory2_btn":
                        if (GameGlobalData.HeroList[1].inventory[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[1].inventory[1];
                        }
                        break;
                    case "player3_head_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[0] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[2].equiped_loot[0];
                        }
                        break;
                    case "player3_torso_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[2].equiped_loot[1];
                        }
                        break;
                    case "player3_righthand_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[2] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[2].equiped_loot[2];
                        }
                        break;
                    case "player3_lefthand_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[3] != null)
                        {
                             variable_loot = GameGlobalData.HeroList[2].equiped_loot[3];
                        }
                        break;
                    case "player3_legs_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[4] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[2].equiped_loot[4];
                        }
                        break;
                    case "player3_inventory1_btn":
                        if (GameGlobalData.HeroList[2].inventory[0] != null)
                        {
                           variable_loot = GameGlobalData.HeroList[2].inventory[0];
                        }
                        break;
                    case "player3_inventory2_btn":
                        if (GameGlobalData.HeroList[2].inventory[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[2].inventory[1];
                        }
                        break;
                    case "player4_head_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[0] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[3].equiped_loot[0];
                        }
                        break;
                    case "player4_torso_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[3].equiped_loot[1];
                        }
                        break;
                    case "player4_righthand_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[2] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[3].equiped_loot[2];
                        }
                        break;
                    case "player4_lefthand_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[3] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[3].equiped_loot[3];
                        }
                        break;
                    case "player4_legs_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[4] != null)
                        {
                           variable_loot = GameGlobalData.HeroList[3].equiped_loot[4];
                        }
                        break;
                    case "player4_inventory1_btn":
                        if (GameGlobalData.HeroList[3].inventory[0] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[3].inventory[0];
                        }
                        break;
                    case "player4_inventory2_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[1] != null)
                        {
                            variable_loot = GameGlobalData.HeroList[3].equiped_loot[1];
                        }
                        break;
                }
            }
            else
            {
                some_painted_button.BackColor = Color.Transparent;
                switch (pressed_button.Name)
                {
                    case "player1_head_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[0] == null)
                        {
                            GameGlobalData.HeroList[0].equiped_loot[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player1_torso_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[1] == null)
                        {
                            GameGlobalData.HeroList[0].equiped_loot[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player1_righthand_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[2] == null)
                        {
                            GameGlobalData.HeroList[0].equiped_loot[2] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player1_lefthand_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[3] == null)
                        {
                            GameGlobalData.HeroList[0].equiped_loot[3] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player1_legs_btn":
                        if (GameGlobalData.HeroList[0].equiped_loot[4] == null)
                        {
                            GameGlobalData.HeroList[0].equiped_loot[4] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player1_inventory1_btn":
                        if (GameGlobalData.HeroList[0].inventory[0] == null)
                        {
                            GameGlobalData.HeroList[0].inventory[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player1_inventory2_btn":
                        if (GameGlobalData.HeroList[0].inventory[1] == null)
                        {
                            GameGlobalData.HeroList[0].inventory[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player2_head_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[0] == null)
                        {
                            GameGlobalData.HeroList[1].equiped_loot[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player2_torso_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[1] == null)
                        {
                            GameGlobalData.HeroList[1].equiped_loot[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player2_righthand_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[2] == null)
                        {
                            GameGlobalData.HeroList[1].equiped_loot[2] = variable_loot;
                            set_looticon();
                            variable_loot = null;

                        }
                        break;
                    case "player2_lefthand_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[3] == null)
                        {
                            GameGlobalData.HeroList[1].equiped_loot[3] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player2_legs_btn":
                        if (GameGlobalData.HeroList[1].equiped_loot[4] == null)
                        {
                            GameGlobalData.HeroList[1].equiped_loot[4] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player2_inventory1_btn":
                        if (GameGlobalData.HeroList[1].inventory[0] == null)
                        {
                            GameGlobalData.HeroList[1].inventory[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player2_inventory2_btn":
                        if (GameGlobalData.HeroList[1].inventory[1] == null)
                        {
                            GameGlobalData.HeroList[1].inventory[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player3_head_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[0] == null)
                        {
                            GameGlobalData.HeroList[2].equiped_loot[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player3_torso_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[1] == null)
                        {
                            GameGlobalData.HeroList[2].equiped_loot[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player3_righthand_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[2] == null)
                        {
                            GameGlobalData.HeroList[2].equiped_loot[2] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player3_lefthand_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[3] == null)
                        {
                            GameGlobalData.HeroList[2].equiped_loot[3] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player3_legs_btn":
                        if (GameGlobalData.HeroList[2].equiped_loot[4] == null)
                        {
                            GameGlobalData.HeroList[2].equiped_loot[4] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player3_inventory1_btn":
                        if (GameGlobalData.HeroList[2].inventory[0] == null)
                        {
                            GameGlobalData.HeroList[2].inventory[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player3_inventory2_btn":
                        if (GameGlobalData.HeroList[2].inventory[1] == null)
                        {
                            GameGlobalData.HeroList[2].inventory[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player4_head_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[0] == null)
                        {
                            GameGlobalData.HeroList[3].equiped_loot[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player4_torso_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[1] == null)
                        {
                            GameGlobalData.HeroList[3].equiped_loot[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player4_righthand_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[2] == null)
                        {
                            GameGlobalData.HeroList[3].equiped_loot[2] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player4_lefthand_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[3] == null)
                        {
                            GameGlobalData.HeroList[3].equiped_loot[3] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player4_legs_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[4] == null)
                        {
                            GameGlobalData.HeroList[3].equiped_loot[4] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player4_inventory1_btn":
                        if (GameGlobalData.HeroList[3].inventory[0] == null)
                        {
                            GameGlobalData.HeroList[3].inventory[0] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;
                    case "player4_inventory2_btn":
                        if (GameGlobalData.HeroList[3].equiped_loot[1] == null)
                        {
                            GameGlobalData.HeroList[3].equiped_loot[1] = variable_loot;
                            set_looticon();
                            variable_loot = null;
                        }
                        break;                   
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // PLAYER 1
        private void player1_overal_panel_MouseHover(object sender, EventArgs e)
        {
            show_heroinfo(0);
        }
        private void player1_overal_panel_MouseLeave(object sender, EventArgs e)
        {
            camp_heroinfo_panel.Visible = false;
        }        
        private void player1_head_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player1_head_btn, loot_buffer, some_painted_button);
        }
        private void player1_head_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(0, 0);
        }
        private void player1_head_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player1_torso_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player1_torso_btn, loot_buffer, some_painted_button);
        }
        private void player1_torso_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(0, 1);
        } 
        private void player1_torso_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player1_righthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player1_righthand_btn, loot_buffer, some_painted_button);
        }
        private void player1_righthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(0, 2);
        }
        private void player1_righthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player1_lefthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player1_lefthand_btn, loot_buffer, some_painted_button);
        }
        private void player1_lefthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(0, 3);
        }
        private void player1_lefthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player1_legs_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player1_legs_btn, loot_buffer, some_painted_button);
        }
        private void player1_legs_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(0, 4);
        }
        private void player1_legs_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player1_inventory1_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player1_inventory1_btn, loot_buffer, some_painted_button);
        }
        private void player1_inventory1_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(0, 0);
        }
        private void player1_inventory1_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player1_inventory2_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player1_inventory2_btn, loot_buffer, some_painted_button);
        }
        private void player1_inventory2_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(0, 1);
        }
        private void player1_inventory2_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player1_gold_btn_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void player1_gold_btn_MouseHover(object sender, EventArgs e)
        {

        }
        private void player1_gold_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        // PLAYER 2
        private void player2_overal_panel_MouseHover(object sender, EventArgs e)
        {
            show_heroinfo(1);
        }
        private void player2_overal_panel_MouseLeave(object sender, EventArgs e)
        {
            camp_heroinfo_panel.Visible = false;
        }
        private void player2_head_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player2_head_btn, loot_buffer, some_painted_button);
        }
        private void player2_head_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(1, 0);
        }
        private void player2_head_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player2_torso_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player2_torso_btn, loot_buffer, some_painted_button);
        }       
        private void player2_torso_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(1, 1);
        }
        private void player2_torso_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player2_righthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player2_righthand_btn, loot_buffer, some_painted_button);
        }
        private void player2_righthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(1, 2);
        }
        private void player2_righthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player2_lefthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player2_lefthand_btn, loot_buffer, some_painted_button);
        }
        private void player2_lefthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(1, 3);
        }
        private void player2_lefthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player2_legs_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player2_legs_btn, loot_buffer, some_painted_button);
        }
        private void player2_legs_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(1, 4);
        }
        private void player2_legs_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player2_inventory1_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player2_inventory1_btn, loot_buffer, some_painted_button);
        }
        private void player2_inventory1_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(1, 0);
        }
        private void player2_inventory1_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player2_inventory2_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player2_inventory2_btn, loot_buffer, some_painted_button);
        }
        private void player2_inventory2_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(1, 1);
        }
        private void player2_inventory2_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player2_gold_btn_Click(object sender, EventArgs e)
        {

        }

        // PLAYER 3
        private void player3_overal_panel_MouseHover(object sender, EventArgs e)
        {
            show_heroinfo(2);
        }
        private void player3_overal_panel_MouseLeave(object sender, EventArgs e)
        {
            camp_heroinfo_panel.Visible = false;
        }
        private void player3_head_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player3_head_btn, loot_buffer, some_painted_button);
        }
        private void player3_head_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(2, 0);
        }
        private void player3_head_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player3_torso_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player3_torso_btn, loot_buffer, some_painted_button);
        }
        private void player3_torso_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(2, 1);
        }
        private void player3_torso_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player3_righthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player3_righthand_btn, loot_buffer, some_painted_button);
        }
        private void player3_righthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(2, 2);
        }
        private void player3_righthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player3_lefthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player3_lefthand_btn, loot_buffer, some_painted_button);
        }
        private void player3_lefthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(2, 3);
        }
        private void player3_lefthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player3_legs_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player3_legs_btn, loot_buffer, some_painted_button);
        }
        private void player3_legs_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(2, 4);
        }
        private void player3_legs_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player3_inventory1_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player3_inventory1_btn, loot_buffer, some_painted_button);
        }
        private void player3_inventory1_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(2, 0);
        }
        private void player3_inventory1_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player3_inventory2_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player3_inventory2_btn, loot_buffer, some_painted_button);
        }
        private void player3_inventory2_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(2, 1);
        }
        private void player3_inventory2_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player3_gold_btn_Click(object sender, EventArgs e)
        {

        }

        // PLAYER 4
        private void player4_overal_panel_MouseHover(object sender, EventArgs e)
        {
            show_heroinfo(3);
        }

        private void player4_overal_panel_MouseLeave(object sender, EventArgs e)
        {
            camp_heroinfo_panel.Visible = false;
        }
        private void player4_head_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player4_head_btn, loot_buffer, some_painted_button);
        }
        private void player4_head_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(3, 0);
        }

        private void player4_head_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }

        private void player4_torso_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player4_torso_btn, loot_buffer, some_painted_button);
        }
        private void player4_torso_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(3, 1);
        }
        private void player4_torso_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player4_righthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player4_righthand_btn, loot_buffer, some_painted_button);
        }
        private void player4_righthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(3, 2);
        }
        private void player4_righthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player4_lefthand_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player4_lefthand_btn, loot_buffer, some_painted_button);
        }
        private void player4_lefthand_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(3, 3);
        }
        private void player4_lefthand_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player4_legs_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player4_legs_btn, loot_buffer, some_painted_button);
        }
        private void player4_legs_btn_MouseHover(object sender, EventArgs e)
        {
            show_equippedloot_info(3, 4);
        }
        private void player4_legs_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player4_inventory1_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player4_inventory1_btn, loot_buffer, some_painted_button);
        }
        private void player4_inventory1_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(3, 0);
        }
        private void player4_inventory1_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player4_inventory2_btn_Click(object sender, EventArgs e)
        {
            some_button_click(player4_inventory2_btn, loot_buffer, some_painted_button);
        }
        private void player4_inventory2_btn_MouseHover(object sender, EventArgs e)
        {
            show_inventoryloot_info(3, 1);
        }
        private void player4_inventory2_btn_MouseLeave(object sender, EventArgs e)
        {
            camp_lootinfo_panel.Visible = false;
        }
        private void player4_gold_btn_Click(object sender, EventArgs e)
        {

        }

        private void table_Click(object sender, EventArgs e)
        {

        }

        private void camp_main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
