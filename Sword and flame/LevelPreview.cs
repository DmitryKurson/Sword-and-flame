using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sword_and_flame
{
    public partial class LevelPreview : Form
    {
        string basic_monster_name = null;
        int basic_monster_count = 0;
        string secondary_monster_name = null;
        int secondary_monster_count = 0;
        public LevelPreview()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void LevelPreviewNew_Load(object sender, EventArgs e)
        {
            //if (GameGlobalData.count_of_journeymoves == 0)
            //{
            //    LevelProperties.journey_map_go_FROM = "Wistred";
            //}
            int variable_level_index = int.Parse(LevelProperties.journey_map_go_TO.level_index) - 1;
            LevPrev_level_name_lbl.Text = LevelProperties.level_list[variable_level_index].level_name;
            LevPrev_level_story_lbl.Text = LevelProperties.level_list[variable_level_index].level_story_preview;
            basic_monster_count = LevelProperties.level_list[variable_level_index].level_basic_monster_count;
            basic_monster_name = LevelProperties.level_list[variable_level_index].level_basic_monster_name;
            secondary_monster_name = LevelProperties.level_list[variable_level_index].level_secondary_monster_name;
            BackgroundImage = LevelProperties.level_list[variable_level_index].background_image;
            if (LevelProperties.level_list[variable_level_index].is_passed == true)
            {
                LevPrev_level_name_lbl.Text += " (Пройдено)";
                basic_monster_count = LevelProperties.level_list[variable_level_index].level_basic_monster_count / 2;
            }
            for (int i = 1; i < GameGlobalData.count_of_players+1; i++)
            {
                show_player_data(GameGlobalData.HeroList[i-1], i);
                hide_players_data(GameGlobalData.count_of_players);
            }
            //ЗАЛЕЖНІСТЬ КІЛЬКОСТІ ДОДАТКОВИХ МОНСТРІВ ДРУГОГО ТИПУ ВІД КІЛЬКОСТІ ГРАВЦІВ
            switch (GameGlobalData.count_of_players)
            {
                case 1:
                    secondary_monster_count = 0;
                    break;
                case 2:
                    secondary_monster_count = 1;
                    break;
                case 3:
                    secondary_monster_count = 2;
                    break;
                case 4:
                    secondary_monster_count = 3;
                    break;
            }            
        }

        private void LPN_next_btn_Click(object sender, EventArgs e)
        {
            Hide();
            Level Level_obj = new Level(LevelProperties.journey_map_go_TO.level_name, basic_monster_name, basic_monster_count, secondary_monster_name, secondary_monster_count);
            Level_obj.ShowDialog();
        }
        private void show_player_data(Hero hero, int i)
        {
            switch (i)
            {
                case 1:
                    LevPrev_pl1_Main_lbl.Text = LevPrev_pl1_Main_lbl.Text + hero.name;
                    LevPrev_pl1_classValue_lbl.Text = hero.player_class;
                    LevPrev_pl1_StrengthValue_lbl.Text = hero.current_strength.ToString() + " (" + hero.current_random_strength + ")";
                    LevPrev_pl1_DefenseValue_lbl.Text = hero.current_defense.ToString() + " (" + hero.current_random_defense + ")";
                    LevPrev_pl1_HealthValue_lbl.Text = hero.current_health.ToString();
                    LevPrev_pl1_SpeedValue_lbl.Text = hero.current_speed.ToString();
                    LevPrev_pl1_LevelValue_lbl.Text = hero.level.ToString();
                    if (hero.inventory.Count == 0)
                    {
                        LevPrev_pl1_Inventory01Value_lbl.Text = "Пусто";
                        LevPrev_pl1_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 1)
                    {
                        LevPrev_pl1_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl1_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 2)
                    {
                        LevPrev_pl1_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl1_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    else if (hero.inventory.Count == 3)
                    {
                        LevPrev_pl1_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl1_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    break;
                case 2:
                    LevPrev_pl2_Main_lbl.Text = LevPrev_pl2_Main_lbl.Text + hero.name;
                    LevPrev_pl2_classValue_lbl.Text = hero.player_class;
                    LevPrev_pl2_StrengthValue_lbl.Text = hero.current_strength.ToString() + " (" + hero.current_random_strength + ")";
                    LevPrev_pl2_DefenseValue_lbl.Text = hero.current_defense.ToString() + " (" + hero.current_random_defense + ")";
                    LevPrev_pl2_HealthValue_lbl.Text = hero.current_health.ToString();
                    LevPrev_pl2_SpeedValue_lbl.Text = hero.current_speed.ToString();
                    LevPrev_pl2_LevelValue_lbl.Text = hero.level.ToString();
                    if (hero.inventory.Count == 0)
                    {
                        LevPrev_pl2_Inventory01Value_lbl.Text = "Пусто";
                        LevPrev_pl2_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 1)
                    {
                        LevPrev_pl2_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl2_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 2)
                    {
                        LevPrev_pl2_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl2_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    else if (hero.inventory.Count == 3)
                    {
                        LevPrev_pl2_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl2_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    break;
                case 3:
                    LevPrev_pl3_Main_lbl.Text = LevPrev_pl3_Main_lbl.Text + hero.name;
                    LevPrev_pl3_classValue_lbl.Text = hero.player_class;
                    LevPrev_pl3_StrengthValue_lbl.Text = hero.current_strength.ToString() + " (" + hero.current_random_defense + ")";
                    LevPrev_pl3_DefenseValue_lbl.Text = hero.current_defense.ToString() + " (" + hero.current_random_defense + ")";
                    LevPrev_pl3_HealthValue_lbl.Text = hero.current_health.ToString();
                    LevPrev_pl3_SpeedValue_lbl.Text = hero.current_speed.ToString();
                    LevPrev_pl3_LevelValue_lbl.Text = hero.level.ToString();
                    if (hero.inventory.Count == 0)
                    {
                        LevPrev_pl3_Inventory01Value_lbl.Text = "Пусто";
                        LevPrev_pl3_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 1)
                    {
                        LevPrev_pl3_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl3_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 2)
                    {
                        LevPrev_pl3_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl3_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    else if (hero.inventory.Count == 3)
                    {
                        LevPrev_pl3_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl3_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    break;
                case 4:
                    LevPrev_pl4_Main_lbl.Text = LevPrev_pl4_Main_lbl.Text + hero.name;
                    LevPrev_pl4_classValue_lbl.Text = hero.player_class;
                    LevPrev_pl4_StrengthValue_lbl.Text = hero.current_strength.ToString() + " (" + hero.current_random_defense + ")";
                    LevPrev_pl4_DefenseValue_lbl.Text = hero.current_defense.ToString() + " (" + hero.current_random_defense + ")";
                    LevPrev_pl4_HealthValue_lbl.Text = hero.current_health.ToString();
                    LevPrev_pl4_SpeedValue_lbl.Text = hero.current_speed.ToString();
                    LevPrev_pl4_LevelValue_lbl.Text = hero.level.ToString();
                    if (hero.inventory.Count == 0)
                    {
                        LevPrev_pl4_Inventory01Value_lbl.Text = "Пусто";
                        LevPrev_pl4_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 1)
                    {
                        LevPrev_pl4_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl4_Inventory02Value_lbl.Visible = false;
                    }
                    else if (hero.inventory.Count == 2)
                    {
                        LevPrev_pl4_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl4_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    else if (hero.inventory.Count == 3)
                    {
                        LevPrev_pl4_Inventory01Value_lbl.Text = hero.inventory[0].name;
                        LevPrev_pl4_Inventory02Value_lbl.Text = hero.inventory[1].name;
                    }
                    break;
            }
        }

        void hide_players_data(int i)
        {
            switch (i)
            {
                case 1:
                    LevPrev_pl2_panel.Visible = false;
                    LevPrev_pl3_panel.Visible = false;
                    LevPrev_pl4_panel.Visible = false;
                    break;
                case 2:
                    LevPrev_pl3_panel.Visible = false;
                    LevPrev_pl4_panel.Visible = false;
                    break;
                case 3:
                    LevPrev_pl4_panel.Visible = false;
                    break;
                case 4:
                    break;
            }
        }

        private void LevPrev_level_story_lbl_Click(object sender, EventArgs e)
        {

        }

        private void LevPrev_level_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void LevPrev_pl2_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


