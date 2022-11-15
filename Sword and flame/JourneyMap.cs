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
    public partial class JourneyMap : Form
    {
        public JourneyMap()
        {
            InitializeComponent();
            
        }

        private void JourneyMap_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;

            city_wistred.Visible = false;
            city_kverat.Visible = false;
            city_dankirm.Visible = false;
            city_tiren.Visible = false;
            city_equinset.Visible = false;
            city_asemel.Visible = false;
            city_rosennest.Visible = false;
            city_aurefort.Visible = false;
            city_arbinat.Visible = false;
            city_aureastrum.Visible = false;
            city_keverwood.Visible = false;
            city_akarayn.Visible = false;
            city_talobane.Visible = false;
            city_mnghagat.Visible = false;
            city_draglock.Visible = false;
            city_rivenport.Visible = false;
            city_talde.Visible = false;

            level_1.Visible = false;
            level_2.Visible = false;
            level_3.Visible = false;
            level_4.Visible = false;
            level_5.Visible = false;
            level_6.Visible = false;
            level_7.Visible = false;
            level_8.Visible = false;
            level_9.Visible = false;
            level_10.Visible = false;
            level_11.Visible = false;
            level_12.Visible = false;
            level_13.Visible = false;
            level_14.Visible = false;
            level_15.Visible = false;
            level_16.Visible = false;
            level_17.Visible = false;
            level_18.Visible = false;
            level_19.Visible = false;
            level_25.Visible = false;
            level_21.Visible = false;
            level_23.Visible = false;
            level_22.Visible = false;
            level_20.Visible = false;
            level_24.Visible = false;
            level_26.Visible = false;
            level_27.Visible = false;
            level_28.Visible = false;
            level_29.Visible = false;
            level_30.Visible = false;
            level_31.Visible = false;
            level_32.Visible = false;
            level_33.Visible = false;
            level_34.Visible = false;
            level_35.Visible = false;
            level_36.Visible = false;
            level_37.Visible = false;
            level_38.Visible = false;
            level_39.Visible = false;
            level_40.Visible = false;
            level_41.Visible = false;
            level_42.Visible = false;
            level_43.Visible = false;
            level_44.Visible = false;
    
            object_rilotruins.Visible = false;
            object_lonelymountain.Visible = false;
            object_flowertree.Visible = false;
            object_rivenpeak.Visible = false;
            object_capeofmisery.Visible = false;

            if (GameGlobalData.count_of_journeymoves == 0)
            {
                LevelProperties.journey_map_current_level_position = LevelProperties.level_list[44];
            }
            if (GameGlobalData.count_of_moves == 0 && GameGlobalData.tutorial_skipped == false)
            {
                TutorialForm tutorialForm_obj = new TutorialForm("Подорожі", "В цьому вікні ви можете...");
                tutorialForm_obj.ShowDialog();
            }

            switch (LevelProperties.journey_map_current_level_position.level_index)
            {
                case "1":
                    level_1.Checked = true;
                    level_1.BackColor = Color.Blue;
                    level_1.Visible = true;                    
                    city_wistred.Visible = true;
                    city_kverat.Visible = true;
                    break;
                case "2":
                    level_2.Checked = true;
                    level_2.BackColor = Color.Blue;
                    level_2.Visible = true;
                    city_wistred.Visible = true;
                    city_dankirm.Visible = true;
                    break;
                case "3":
                    level_3.Checked = true;
                    level_3.BackColor = Color.Blue;
                    level_3.Visible = true;                   
                    city_dankirm.Visible = true;
                    city_kverat.Visible = true;
                    break;
                case "4":
                    level_4.Checked = true;
                    level_4.BackColor = Color.Blue;
                    level_4.Visible = true;                  
                    city_kverat.Visible = true;
                    level_5.Visible = true;
                    break;
                case "5":
                    level_5.Checked = true;
                    level_5.BackColor = Color.Blue;
                    city_equinset.Visible = true;
                    level_5.Visible = true;                
                    level_4.Visible = true;
                    level_6.Visible = true;
                    break;
                case "6":
                    level_6.Checked = true;
                    level_6.BackColor = Color.Blue;
                    level_6.Visible = true;
                    city_tiren.Visible = true;
                    city_equinset.Visible = true;
                    level_5.Visible = true;
                    break;
                case "7":
                    level_7.Checked = true;
                    level_7.BackColor = Color.Blue;
                    level_7.Visible = true;                 
                    city_kverat.Visible = true;
                    level_8.Visible = true;
                    level_16.Visible = true;
                    break;
                case "8":
                    level_8.Checked = true;
                    level_8.BackColor = Color.Blue;
                    level_16.Visible = true;
                    level_8.Visible = true;                  
                    level_7.Visible = true;
                    level_9.Visible = true;
                    level_10.Visible = true;
                    break;
                case "9":
                    level_9.Checked = true;
                    level_9.BackColor = Color.Blue;
                    level_9.Visible = true;                   
                    city_rosennest.Visible = true;
                    level_8.Visible = true;
                    level_10.Visible = true;
                    break;
                case "10":
                    level_10.Checked = true;
                    level_10.BackColor = Color.Blue;
                    level_10.Visible = true;                   
                    object_rilotruins.Visible = true;
                    level_8.Visible = true;
                    level_9.Visible = true;
                    level_13.Visible = true;
                    break;
                case "11":
                    level_11.Checked = true;
                    level_11.BackColor = Color.Blue;
                    level_11.Visible = true;
                    city_equinset.Visible = true;
                    level_12.Visible = true;
                    level_13.Visible = true;
                    break;
                case "12":
                    level_12.Checked = true;
                    level_12.BackColor = Color.Blue;
                    level_12.Visible = true;                 
                    city_aurefort.Visible = true;
                    level_11.Visible = true;
                    level_13.Visible = true;
                    break;
                case "13":                    
                    level_13.Checked = true;
                    level_13.BackColor = Color.Blue;
                    level_13.Visible = true;                   
                    level_10.Visible = true;
                    level_11.Visible = true;
                    level_12.Visible = true;
                    object_rilotruins.Visible = true;
                    break;
                case "14":
                    level_14.Checked = true;
                    level_14.BackColor = Color.Blue;
                    level_14.Visible = true;                
                    city_aurefort.Visible = true;
                    city_rosennest.Visible = true;
                    break;
                case "15":
                    level_15.Checked = true;
                    level_15.BackColor = Color.Blue;
                    level_15.Visible = true;
                    city_rosennest.Visible = true;
                    level_23.Visible = true;
                    level_24.Visible = true;
                    break;
                case "16":
                    level_16.Checked = true;
                    level_16.BackColor = Color.Blue;
                    level_16.Visible = true;
                    city_asemel.Visible = true;
                    level_7.Visible = true;
                    level_8.Visible = true;
                    break;
                case "17":
                    level_17.Checked = true;
                    level_17.BackColor = Color.Blue;
                    level_17.Visible = true;
                    city_aurefort.Visible = true;
                    city_aureastrum.Visible = true;
                    break;
                case "18":
                    level_18.Checked = true;
                    level_18.BackColor = Color.Blue;
                    level_18.Visible = true;
                    city_aureastrum.Visible = true;
                    level_19.Visible = true;
                    break;
                case "19":
                    level_19.Checked = true;
                    level_19.BackColor = Color.Blue;
                    level_19.Visible = true;
                    city_akarayn.Visible = true;
                    level_18.Visible = true;
                    break;
                case "20":
                    level_20.Checked = true;
                    level_20.BackColor = Color.Blue;
                    level_20.Visible = true;
                    city_keverwood.Visible = true;
                    city_arbinat.Visible = true;
                    city_akarayn.Visible = true;
                    break;
                case "21":
                    level_21.Checked = true;
                    level_21.BackColor = Color.Blue;
                    level_21.Visible = true;
                    city_arbinat.Visible = true;
                    level_18.Visible = true;
                    level_19.Visible = true;
                    break;
                case "22":
                    level_22.Checked = true;
                    level_22.BackColor = Color.Blue;
                    level_22.Visible = true;
                    city_rosennest.Visible = true;
                    city_arbinat.Visible = true;
                    break;
                case "23":
                    level_23.Checked = true;
                    level_23.BackColor = Color.Blue;
                    level_23.Visible = true;
                    city_asemel.Visible = true;
                    level_15.Visible = true;
                    level_24.Visible = true;
                    break;
                case "24":
                    level_24.Checked = true;
                    level_24.BackColor = Color.Blue;
                    level_24.Visible = true;
                    city_keverwood.Visible = true;
                    level_15.Visible = true;
                    level_23.Visible = true;
                    level_28.Visible = true;
                    break;
                case "25":
                    level_25.Checked = true;
                    level_25.BackColor = Color.Blue;
                    level_25.Visible = true;
                    city_akarayn.Visible = true;
                    city_talobane.Visible = true;
                    level_33.Visible = true;
                    break;
                case "26":
                    level_26.Checked = true;
                    level_26.BackColor = Color.Blue;
                    level_26.Visible = true;
                    city_draglock.Visible = true;
                    city_wistred.Visible = true;
                    level_36.Visible = true;
                    break;
                case "27":
                    level_27.Checked = true;
                    level_27.BackColor = Color.Blue;
                    level_27.Visible = true;
                    city_draglock.Visible = true;
                    city_wistred.Visible = true;
                    city_asemel.Visible = true;
                    level_35.Visible = true;
                    break;
                case "28":
                    level_28.Checked = true;
                    level_28.BackColor = Color.Blue;
                    level_28.Visible = true;
                    city_keverwood.Visible = true;
                    level_24.Visible = true;
                    level_29.Visible = true;
                    level_30.Visible = true;
                    break;
                case "29":
                    level_29.Checked = true;
                    level_29.BackColor = Color.Blue;
                    level_29.Visible = true;
                    object_flowertree.Visible = true;
                    level_28.Visible = true;
                    level_30.Visible = true;
                    break;
                case "30":
                    level_30.Checked = true;
                    level_39.BackColor = Color.Blue;
                    level_30.Visible = true;
                    city_mnghagat.Visible = true;
                    level_28.Visible = true;
                    level_29.Visible = true;
                    break;
                case "31":
                    level_31.Checked = true;
                    level_31.BackColor = Color.Blue;
                    level_31.Visible = true;
                    city_mnghagat.Visible = true;
                    level_32.Visible = true;
                    break;
                case "32":
                    level_32.Checked = true;
                    level_32.BackColor = Color.Blue;
                    level_32.Visible = true;
                    level_31.Visible = true;
                    level_39.Visible = true;
                    break;
                case "33":
                    level_33.Checked = true;
                    level_33.BackColor = Color.Blue;
                    level_33.Visible = true;
                    city_talobane.Visible = true;
                    level_25.Visible = true;
                    break;
                case "34":
                    level_34.Checked = true;
                    level_34.BackColor = Color.Blue;
                    level_34.Visible = true;
                    city_talde.Visible = true;
                    city_mnghagat.Visible = true;
                    level_35.Visible = true;
                    break;
                case "35":
                    level_35.Checked = true;
                    level_35.BackColor = Color.Blue;
                    level_35.Visible = true;
                    city_talde.Visible = true;
                    level_27.Visible = true;
                    level_34.Visible = true;
                    break;
                case "36":
                    level_36.Checked = true;
                    level_36.BackColor = Color.Blue;
                    level_36.Visible = true;
                    city_rivenport.Visible = true;
                    level_37.Visible = true;
                    level_26.Visible = true;
                    break;
                case "37":
                    level_37.Checked = true;
                    level_37.BackColor = Color.Blue;
                    level_37.Visible = true;
                    city_rivenport.Visible = true;
                    level_38.Visible = true;
                    break;
                case "38":
                    level_38.Checked = true;
                    level_38.BackColor = Color.Blue;
                    level_38.Visible = true;
                    level_37.Visible = true;
                    city_talde.Visible = true;
                    break;
                case "39":
                    level_39.Checked = true;
                    level_39.BackColor = Color.Blue;
                    level_39.Visible = true;
                    level_32.Visible = true;
                    level_40.Visible = true;
                    level_41.Visible = true;
                    break;
                case "40":
                    level_40.Checked = true;
                    level_40.BackColor = Color.Blue;
                    level_40.Visible = true;
                    level_39.Visible = true;
                    level_42.Visible = true;
                    break;
                case "41":
                    level_41.Checked = true;
                    level_41.BackColor = Color.Blue;
                    level_41.Visible = true;
                    level_39.Visible = true;
                    level_42.Visible = true;
                    break;
                case "42":
                    level_42.Checked = true;
                    level_42.BackColor = Color.Blue;
                    level_42.Visible = true;
                    level_40.Visible = true;
                    level_41.Visible = true;
                    level_43.Visible = true;
                    break;
                case "43":
                    level_43.Checked = true;
                    level_43.BackColor = Color.Blue;
                    level_43.Visible = true;
                    level_42.Visible = true;
                    level_44.Visible = true;
                    break;
                case "44":
                    level_44.Checked = true;
                    level_44.BackColor = Color.Blue;
                    level_44.Visible = true;
                    level_13.Visible = true;
                    level_42.Visible = true;
                    object_capeofmisery.Visible = true;
                    break;
                case "45":
                    city_wistred.Checked = true;
                    city_wistred.BackColor = Color.Blue;                
                    city_wistred.Visible = true;
                    level_1.Visible = true;
                    level_2.Visible = true;
                    //if () Розблокування морських шляхів після певного рівн я
                    //{
                    //    level_26.Visible = true;
                    //    level_27.Visible = true;
                    //}
                    break;
                case "46":
                    city_kverat.Checked = true;
                    city_kverat.BackColor = Color.Blue;
                    city_kverat.Visible = true;
                    level_1.Visible = true;
                    level_3.Visible = true;
                    level_4.Visible = true;
                    level_7.Visible = true;
                    break;
                case "47":
                    city_dankirm.Checked = true;
                    city_dankirm.BackColor = Color.Blue;
                    city_dankirm.Visible = true;
                    level_2.Visible = true;
                    level_3.Visible = true;
                    break;
                case "48": // Тайрен
                    city_tiren.Checked = true;
                    city_tiren.BackColor = Color.Blue;
                    city_tiren.Visible = true;
                    city_tiren.Visible = true;
                    level_6.Visible = true;
                    break;
                case "49": //Еквінсет
                    city_equinset.Checked = true;
                    city_equinset.BackColor = Color.Blue;
                    city_equinset.Visible = true;
                    level_5.Visible = true;
                    level_6.Visible = true;
                    level_11.Visible = true;
                    break;
                case "50": // Asemel
                    city_asemel.Checked = true;
                    city_asemel.BackColor = Color.Blue;
                    city_asemel.Visible = true;
                    level_16.Visible = true;
                    level_23.Visible = true;
                    level_27.Visible = true;
                    level_34.Visible = true;
                    break;
                case "51":
                    city_rosennest.Checked = true;
                    city_rosennest.BackColor = Color.Blue;
                    city_rosennest.Visible = true;
                    level_9.Visible = true;
                    level_14.Visible = true;
                    level_15.Visible = true;
                    level_22.Visible = true;
                    break;           
                case "52":
                    city_aurefort.Checked = true;
                    city_aurefort.BackColor = Color.Blue;
                    city_aurefort.Visible = true;
                    level_12.Visible = true;
                    level_14.Visible = true;
                    level_25.Visible = true;
                    break;
                case "53":
                    city_aureastrum.Checked = true;
                    city_aureastrum.BackColor = Color.Blue;
                    city_aureastrum.Visible = true;
                    level_17.Visible = true;
                    level_18.Visible = true;
                    break;
                case "54":
                    city_arbinat.Checked = true;
                    city_arbinat.BackColor = Color.Blue;
                    city_arbinat.Visible = true;
                    level_20.Visible = true;
                    level_21.Visible = true;
                    level_22.Visible = true;
                    break;
                case "55":
                    city_keverwood.Checked = true;
                    city_keverwood.BackColor = Color.Blue;
                    city_keverwood.Visible = true;
                    level_20.Visible = true;
                    level_24.Visible = true;
                    level_28.Visible = true;
                    city_akarayn.Visible = true;
                    break;
                case "56":
                    city_akarayn.Checked = true;
                    city_akarayn.BackColor = Color.Blue;
                    city_akarayn.Visible = true;
                    level_19.Visible = true;
                    level_20.Visible = true;
                    level_25.Visible = true;
                    city_keverwood.Visible = true;
                    object_lonelymountain.Visible = true;
                    break;
                case "57":
                    city_talobane.Checked = true;
                    city_talobane.BackColor = Color.Blue;
                    city_talobane.Visible = true;
                    level_25.Visible = true;
                    level_33.Visible = true;
                    break;             
                case "58":
                    city_mnghagat.Checked = true;
                    city_mnghagat.BackColor = Color.Blue;
                    city_mnghagat.Visible = true;
                    level_30.Visible = true;
                    level_31.Visible = true;
                    level_34.Visible = true;
                    break;
                case "59":
                    city_draglock.Checked = true;
                    city_draglock.BackColor = Color.Blue;
                    city_draglock.Visible = true;
                    level_26.Visible = true;
                    level_27.Visible = true;
                    break;
                case "60":                   
                    city_rivenport.Checked = true;
                    city_rivenport.BackColor = Color.Blue;
                    city_rivenport.Visible = true;
                    object_rivenpeak.Visible = true;                                    
                    level_36.Visible = true;
                    level_37.Visible = true;
                    break;
                case "61":
                    city_talde.Checked = true;
                    city_talde.BackColor = Color.Blue;
                    city_talde.Visible = true;
                    level_34.Visible = true;
                    level_35.Visible = true;
                    level_38.Visible = true;
                    break;
                case "62":
                    object_rilotruins.Checked = true;
                    object_rilotruins.BackColor = Color.Blue;
                    city_wistred.Visible = true;
                    level_10.Visible = true;
                    break;
                case "63":
                    object_lonelymountain.Checked = true;
                    object_lonelymountain.BackColor = Color.Blue;
                    object_lonelymountain.Visible = true;
                    city_akarayn.Visible = true;
                    break;
                case "64":
                    object_flowertree.Checked = true;
                    object_flowertree.BackColor = Color.Blue;
                    object_flowertree.Visible = true;
                    level_29.Visible = true;
                    break;
                case "65":
                    object_rivenpeak.Checked = true;
                    object_rivenpeak.BackColor = Color.Blue;
                    object_rivenpeak.Visible = true;
                    city_rivenport.Visible = true;
                    break;
                case "66":
                    object_capeofmisery.Checked = true;
                    object_capeofmisery.BackColor = Color.Blue;
                    object_capeofmisery.Visible = true;
                    level_44.Visible = true;
                    break;
            }
        }

        private void JM_beginjourney_btn_Click(object sender, EventArgs e)
        {
            if (level_1.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[0];
            }
            if (level_2.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[1];
            }
            if (level_3.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[2];
            }
            if (level_4.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[3];
            }
            if (level_5.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[4];
            }
            if (level_6.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[5];
            }
            if (level_7.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[6];
            }
            if (level_8.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[7];
            }
            if (level_9.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[8];
            }
            if (level_10.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[9];
            }
            if (level_11.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[10];
            }
            if (level_12.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[11];
            }
            if (level_13.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[12];
            }
            if (level_14.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[13];
            }
            if (level_15.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[14];
            }
            if (level_16.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[15];
            }
            if (level_17.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[16];
            }
            if (level_18.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[17];
            }
            if (level_19.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[18];
            }
            if (level_20.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[19];
            }
            if (level_21.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[20];
            }
            if (level_22.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[21];
            }
            if (level_23.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[22];
            }
            if (level_24.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[23];
            }
            if (level_25.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[24];
            }
            if (level_26.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[25];
            }
            if (level_27.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[26];
            }
            if (level_28.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[27];
            }
            if (level_29.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[28];
            }
            if (level_30.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[29];
            }
            if (level_31.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[30];
            }
            if (level_32.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[31];
            }
            if (level_33.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[32];
            }
            if (level_34.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[33];
            }
            if (level_35.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[34];
            }
            if (level_36.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[35];
            }
            if (level_37.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[36];
            }
            if (level_38.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[37];
            }
            if (level_39.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[38];
            }
            if (level_40.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[39];
            }
            if (level_41.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[40];
            }
            if (level_42.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[41];
            }
            if (level_43.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[42];
            }
            if (level_44.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[43];
            }
            if (city_wistred.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[44];
            }
            if (city_kverat.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[45];
            }
            if (city_dankirm.Checked) 
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[46];
            }
            if (city_tiren.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[47];
            }
            if (city_equinset.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[48];
            }
            if (city_asemel.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[49];
            }
            if (city_rosennest.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[50];
            }            
            if (city_aurefort.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[51];
            }
            if (city_aureastrum.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[52];
            }
            if (city_arbinat.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[53];
            }
            if (city_keverwood.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[54];
            }
            if (city_akarayn.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[55];
            }           
            if (city_talobane.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[56];
            }
            if (city_mnghagat.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[57];
            }
            if (city_draglock.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[58];
            }
            if (city_rivenport.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[59];
            }
            if (city_talde.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[60];
            }
            //
            
            //if (level_45.Checked)
            //{
            //    LevelProperties.journey_map_go_TO = "level_45";
            //}
            if (object_rilotruins.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[61];
            }
            if (object_lonelymountain.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[62];
            }
            if (object_flowertree.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[63];
            }
            if (object_rivenpeak.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[64];
            }
            if (object_capeofmisery.Checked)
            {
                LevelProperties.journey_map_go_TO = LevelProperties.level_list[65];
            }
            GameGlobalData.count_of_journeymoves++;

            
            if (int.Parse(LevelProperties.journey_map_go_TO.level_index) < 45) // ЯКЩО ЦЕ РІВЕНЬ
            {
                Hide();
                //JourneyMap j = new JourneyMap();
                //j.ShowDialog();
                LevelPreviewNew level_preview_obj = new LevelPreviewNew();
                level_preview_obj.ShowDialog();
            }
            else if (int.Parse(LevelProperties.journey_map_go_TO.level_index) > 61) // ЯКЩО ЦЕ ЦІКАВА ЗНАХІДКА
            {

            }
            else // ЯКЩО ЦЕ МІСТО
            {
                Hide();
                JourneyMap j = new JourneyMap();
                j.ShowDialog();
                //City city_obj = new City();
                //city_obj.ShowDialog();
            }
        }    
    }
}
