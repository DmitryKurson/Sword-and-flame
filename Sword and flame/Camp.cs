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
        static Loot loot_buffer { get; set; }
        static Button some_painted_button_before { get; set; } // needed for button paint buffer

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
            player1_head_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[0].loot_image_right;
            player1_torso_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[1].loot_image_right;
            player1_righthand_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[2].loot_image_right;
            player1_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[3].loot_image_right;
            player1_legs_btn.BackgroundImage = GameGlobalData.HeroList[0].equiped_loot[4].loot_image_right;
            player1_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[0].inventory[0].loot_image_right;
            player1_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[0].inventory[1].loot_image_right;
            player2_head_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[0].loot_image_right;
            player2_torso_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[1].loot_image_right;
            player2_righthand_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[2].loot_image_right;
            player2_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[3].loot_image_right;
            player2_legs_btn.BackgroundImage = GameGlobalData.HeroList[1].equiped_loot[4].loot_image_right;
            player2_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[1].inventory[0].loot_image_right;
            player2_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[1].inventory[1].loot_image_right;
            player3_head_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[0].loot_image_right;
            player3_torso_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[1].loot_image_right;
            player3_righthand_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[2].loot_image_right;
            player3_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[3].loot_image_right;
            player3_legs_btn.BackgroundImage = GameGlobalData.HeroList[2].equiped_loot[4].loot_image_right;
            player3_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[2].inventory[0].loot_image_right;
            player3_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[2].inventory[1].loot_image_right;
            player4_head_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[0].loot_image_right;
            player4_torso_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[1].loot_image_right;
            player4_righthand_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[2].loot_image_right;
            player4_lefthand_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[3].loot_image_right;
            player4_legs_btn.BackgroundImage = GameGlobalData.HeroList[3].equiped_loot[4].loot_image_right;
            player4_inventory1_btn.BackgroundImage = GameGlobalData.HeroList[3].inventory[0].loot_image_right;
            player4_inventory2_btn.BackgroundImage = GameGlobalData.HeroList[3].inventory[1].loot_image_right;
        }
        private Loot loot_take_off(Hero hero, int equipped_index)
        {
            Loot variable_buffer;
            variable_buffer = hero.equiped_loot[equipped_index];
            hero.equiped_loot[equipped_index] = null;
            return variable_buffer;
        }
        private void put_some_loot_in_buffer(Hero hero, string key, int loot_index, Button pressed_button)
        {
            bool success_putting = false;
            if (key == "eqp")
            {
                if (hero.equiped_loot[loot_index].type_of_bodypart == "Дворучне")
                {
                    loot_buffer = hero.equiped_loot[loot_index];
                    hero.equiped_loot[2] = null;
                    hero.equiped_loot[3] = null;
                    success_putting = true;
                }
                else
                {
                    if (hero.equiped_loot[loot_index] != null)
                    {
                        loot_buffer = hero.equiped_loot[loot_index];
                        hero.equiped_loot[loot_index] = null;
                        success_putting = true;
                    }
                }                               
            }
            else if (key == "inv")
            {
                if (hero.inventory[loot_index].type_of_bodypart == "Дворучне")
                {
                    loot_buffer = hero.inventory[loot_index];
                    hero.inventory[loot_index] = null;
                    success_putting = true;
                }
                else
                {
                    if (hero.inventory[loot_index] != null)
                    {
                        loot_buffer = hero.inventory[loot_index];
                        hero.inventory[loot_index] = null;
                        success_putting = true;
                    }
                }                
            }
            if (success_putting == true)
            {
                pressed_button.BackColor = Color.Green;
                some_painted_button_before = pressed_button;
            }
        }
        private void some_button_click (Button pressed_button)
        {                     
            if (loot_buffer == null)
            {                              
                switch (pressed_button.Name)
                {
                    case "player1_head_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[0], "eqp", 0, pressed_button);
                        break;
                    case "player1_torso_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[0], "eqp", 1, pressed_button);
                        break;
                    case "player1_righthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[0], "eqp", 2, pressed_button);
                        break;
                    case "player1_lefthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[0], "eqp", 3, pressed_button);
                        break;
                    case "player1_legs_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[0], "eqp", 4, pressed_button);
                        break;
                    case "player1_inventory1_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[0], "inv", 0, pressed_button);
                        break;
                    case "player1_inventory2_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[0], "inv", 1, pressed_button);
                        break;
                    case "player2_head_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[1], "eqp", 0, pressed_button);
                        break;
                    case "player2_torso_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[1], "eqp", 1, pressed_button);
                        break;
                    case "player2_righthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[1], "eqp", 2, pressed_button);
                        break;
                    case "player2_lefthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[1], "eqp", 3, pressed_button);
                        break;
                    case "player2_legs_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[1], "eqp", 4, pressed_button);
                        break;
                    case "player2_inventory1_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[1], "inv", 0, pressed_button);
                        break;
                    case "player2_inventory2_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[1], "inv", 1, pressed_button);
                        break;
                    case "player3_head_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[2], "eqp", 0, pressed_button);
                        break;
                    case "player3_torso_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[2], "eqp", 1, pressed_button);
                        break;
                    case "player3_righthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[2], "eqp", 2, pressed_button);
                        break;
                    case "player3_lefthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[2], "eqp", 3, pressed_button);
                        break;
                    case "player3_legs_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[2], "eqp", 4, pressed_button);
                        break;
                    case "player3_inventory1_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[2], "inv", 0, pressed_button);
                        break;
                    case "player3_inventory2_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[2], "inv", 1, pressed_button);
                        break;
                    case "player4_head_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[3], "eqp", 0, pressed_button);
                        break;
                    case "player4_torso_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[3], "eqp", 1, pressed_button);
                        break;
                    case "player4_righthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[3], "eqp", 2, pressed_button);
                        break;
                    case "player4_lefthand_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[3], "eqp", 3, pressed_button);
                        break;
                    case "player4_legs_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[3], "eqp", 4, pressed_button);
                        break;
                    case "player4_inventory1_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[3], "inv", 0, pressed_button);
                        break;
                    case "player4_inventory2_btn":
                        put_some_loot_in_buffer(GameGlobalData.HeroList[3], "inv", 1, pressed_button);
                        break;
                }
            }
            else
            {              
                switch (pressed_button.Name)
                {
                    case "player1_head_btn":
                        loot_equip("Голова", GameGlobalData.HeroList[0], 0);
                        break;
                    case "player1_torso_btn":
                        loot_equip("Торс", GameGlobalData.HeroList[0], 1);                        
                        break;
                    case "player1_righthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[0], 2);
                        break;
                    case "player1_lefthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[0], 3);
                        break;
                    case "player1_legs_btn":
                        loot_equip("Ноги", GameGlobalData.HeroList[0], 4);
                        break;
                    case "player1_inventory1_btn":
                        
                        break;
                    case "player1_inventory2_btn":
                        
                        break;
                    case "player2_head_btn":
                        loot_equip("Голова", GameGlobalData.HeroList[1], 0);
                        break;
                    case "player2_torso_btn":
                        loot_equip("Торс", GameGlobalData.HeroList[1], 1);
                        break;
                    case "player2_righthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[1], 2);
                        break;
                    case "player2_lefthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[1], 3);
                        break;
                    case "player2_legs_btn":
                        loot_equip("Ноги", GameGlobalData.HeroList[1], 4);
                        break;
                    case "player2_inventory1_btn":
                       
                        break;
                    case "player2_inventory2_btn":
                        
                        break;
                    case "player3_head_btn":
                        loot_equip("Голова", GameGlobalData.HeroList[2], 0);
                        break;
                    case "player3_torso_btn":
                        loot_equip("Торс", GameGlobalData.HeroList[2], 1);
                        break;
                    case "player3_righthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[2], 2);
                        break;
                    case "player3_lefthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[2], 3);
                        break;
                    case "player3_legs_btn":
                        loot_equip("Ноги", GameGlobalData.HeroList[2], 4);
                        break;
                    case "player3_inventory1_btn":
                        
                        break;
                    case "player3_inventory2_btn":
                        
                        break;
                    case "player4_head_btn":
                        loot_equip("Голова", GameGlobalData.HeroList[3], 0);
                        break;
                    case "player4_torso_btn":
                        loot_equip("Торс", GameGlobalData.HeroList[3], 1);
                        break;
                    case "player4_righthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[3], 2);
                        break;
                    case "player4_lefthand_btn":
                        loot_equip("Рука", GameGlobalData.HeroList[3], 3);
                        break;
                    case "player4_legs_btn":
                        loot_equip("Ноги", GameGlobalData.HeroList[3], 4);
                        break;
                    case "player4_inventory1_btn":         
                        
                        break;
                    case "player4_inventory2_btn":
                        
                        break;                       
                }               
                set_looticon();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loot_move_to_inventory(Button pressed_button)
        {

        }
        private void loot_equip(string loot_bodytype_in_equipped, Hero hero, int equipped_index)
        {
            if (loot_buffer.type_of_bodypart == "Дворучне")
            {
                if (hero.equiped_loot[2] == null && hero.equiped_loot[2] == null)
                {
                    if (loot_bodytype_in_equipped == "Рука")
                    {
                        if (hero.level >= loot_buffer.min_level)
                        {
                            hero.equiped_loot[2] = loot_buffer;
                            hero.equiped_loot[3] = loot_buffer;
                            some_painted_button_before.BackColor = Color.FromArgb(223, 195, 126);
                            loot_buffer = null;
                        }
                        else
                        {
                            ShowMessage showMessage_obj = new ShowMessage(" Недостатній рівень");
                            showMessage_obj.ShowDialog();
                        }
                    }
                    else
                    {
                        ShowMessage showMessage_obj = new ShowMessage(" Не можливо екіпірувати");
                        showMessage_obj.ShowDialog();
                    }
                }
                else
                {
                    ShowMessage showMessage_obj = new ShowMessage(" Для того, щоб екіпірувати дворучну зброю маю бути вільні обидві руки");
                    showMessage_obj.ShowDialog();
                }
            }
            else
            {
                if (hero.equiped_loot[equipped_index] == null)
                {
                    if (loot_bodytype_in_equipped == loot_buffer.type_of_bodypart)
                    {
                        if (hero.level >= loot_buffer.min_level)
                        {
                            hero.equiped_loot[equipped_index] = loot_buffer;
                            some_painted_button_before.BackColor = Color.FromArgb(223, 195, 126);
                            loot_buffer = null;
                        }
                        else
                        {
                            ShowMessage showMessage_obj = new ShowMessage(" Недостатній рівень");
                            showMessage_obj.ShowDialog();
                        }
                    }
                    else
                    {
                        ShowMessage showMessage_obj = new ShowMessage(" Не можливо екіпірувати");
                        showMessage_obj.ShowDialog();
                    }
                }
                else
                {
                    ShowMessage showMessage_obj = new ShowMessage(" Ця комірка зайнята");
                    showMessage_obj.ShowDialog();
                }
            }           
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
            some_button_click(player1_head_btn);
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
            some_button_click(player1_torso_btn);
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
            some_button_click(player1_righthand_btn);
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
            some_button_click(player1_lefthand_btn);
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
            some_button_click(player1_legs_btn);
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
            some_button_click(player1_inventory1_btn);
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
            some_button_click(player1_inventory2_btn);
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
            some_button_click(player2_head_btn);
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
            some_button_click(player2_torso_btn);
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
            some_button_click(player2_righthand_btn);
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
            some_button_click(player2_lefthand_btn);
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
            some_button_click(player2_legs_btn);
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
            some_button_click(player2_inventory1_btn);
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
            some_button_click(player2_inventory2_btn);
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
            some_button_click(player3_head_btn);
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
            some_button_click(player3_torso_btn);
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
            some_button_click(player3_righthand_btn);
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
            some_button_click(player3_lefthand_btn);
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
            some_button_click(player3_legs_btn);
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
            some_button_click(player3_inventory1_btn);
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
            some_button_click(player3_inventory2_btn);
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
            some_button_click(player4_head_btn);
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
            some_button_click(player4_torso_btn);
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
            some_button_click(player4_righthand_btn);
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
            some_button_click(player4_lefthand_btn);
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
            some_button_click(player4_legs_btn);
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
            some_button_click(player4_inventory1_btn);
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
            some_button_click(player4_inventory2_btn);
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
