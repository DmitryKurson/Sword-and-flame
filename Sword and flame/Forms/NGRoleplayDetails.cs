using Sword_and_flame.Entities;

namespace Sword_and_flame
{
    public partial class RoleplayDetails : Form
    {
        public RoleplayDetails()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;                      
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void NGRoleplayDetails_Load(object sender, EventArgs e)
        { 
            NGRD_pl1_error_lbl.Text = "";
            NGRD_pl2_error_lbl.Text = "";
            NGRD_pl3_error_lbl.Text = "";
            NGRD_pl4_error_lbl.Text = "";
            switch (GameGlobalData.count_of_players)
            {
                case 1:
                    pl2_panel_RPD.Visible = false;
                    pl3_panel_RPD.Visible = false;
                    pl4_panel_RPD.Visible = false;
                    break;
                case 2:                   
                    pl3_panel_RPD.Visible = false;
                    pl4_panel_RPD.Visible = false;         
                    break;
                case 3:
                    pl4_panel_RPD.Visible = false;
                    break;
                case 4:
                    break;
            }
        }

        private void next2btn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pl1_name_RPD_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pl2_class_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   

        private void pl1_class_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void NGRD_error_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pl1_panel_RPD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NGGD_back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            NGGlobalDetails NGGlobalDetails_obj = new NGGlobalDetails();
            NGGlobalDetails_obj.ShowDialog();
        }

        private void NGRD_next_btn_Click(object sender, EventArgs e)
        {
            bool error_pl1 = false;
            bool error_pl2 = false;
            bool error_pl3 = false;
            bool error_pl4 = false;
            switch (GameGlobalData.count_of_players)
            {            
                case 1:
                    if (pl1_name_tbx.Text != "")
                    {
                        if (pl1_name_tbx.Text.Length < 10)
                        {
                            if (pl1_class_CB.Text == "Воїн" || pl1_class_CB.Text == "Паладін" || pl1_class_CB.Text == "Лучник" || pl1_class_CB.Text == "Чарівник")
                            {
                                NGRD_pl1_error_lbl.Text = "";
                                error_pl1 = false;
                            }
                            else
                            {
                                NGRD_pl1_error_lbl.Text = "Помилка - клас гравця №1 обрано невірно.";
                                error_pl1 = true;
                            }
                        }
                        else
                        {
                            NGRD_pl1_error_lbl.Text = "Помилка - ім'я гравця №1 містить більше 10 символів.";
                            error_pl1 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl1_error_lbl.Text = "Помилка - введіть ім'я гравця №1.";
                        error_pl1 = true;

                    }
                    break;
                case 2:
                    if (pl1_name_tbx.Text != "")
                    {
                        if (pl1_name_tbx.Text.Length < 10)
                        {
                            if (pl1_class_CB.Text == "Воїн" || pl1_class_CB.Text == "Паладін" || pl1_class_CB.Text == "Лучник" || pl1_class_CB.Text == "Чарівник")
                            {
                                NGRD_pl1_error_lbl.Text = "";
                                error_pl1 = false;
                            }
                            else
                            {
                                NGRD_pl1_error_lbl.Text = "Помилка - клас гравця №1 обрано невірно.";
                                error_pl1 = true;
                            }
                            
                        }
                        else
                        {
                            NGRD_pl1_error_lbl.Text = "Помилка - ім'я гравця №1 містить більше 10 символів.";
                            error_pl1 = true;                            
                        }                        
                    }
                    else
                    {
                        
                        NGRD_pl1_error_lbl.Text = "Помилка - введіть ім'я гравця №1.";
                        error_pl1 = true;
                        
                    }
                    if (pl2_name_tbx.Text != "")
                    {
                        if (pl2_name_tbx.Text.Length < 10)
                        {
                            if (pl1_name_tbx.Text != pl2_name_tbx.Text)
                            {
                                if (pl2_class_CB.Text == "Воїн" || pl2_class_CB.Text == "Паладін" || pl2_class_CB.Text == "Лучник" || pl2_class_CB.Text == "Чарівник")
                                {
                                    NGRD_pl2_error_lbl.Text = "";
                                    error_pl2 = false;
                                }
                                else
                                {
                                    NGRD_pl2_error_lbl.Text = "Помилка - клас гравця №2 обрано невірно.";
                                    error_pl2 = true;
                                }
                            }
                            else
                            {
                                NGRD_pl1_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                NGRD_pl2_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                error_pl1 = true;
                            }                          
                        }
                        else
                        {
                            NGRD_pl2_error_lbl.Text = "Помилка - ім'я гравця №2 містить більше 10 символів.";
                            error_pl2 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl2_error_lbl.Text = "Помилка - введіть ім'я гравця №2.";
                        error_pl2 = true;
                    }
                    break;
                case 3:
                    if (pl1_name_tbx.Text != "")
                    {
                        if (pl1_name_tbx.Text.Length < 10)
                        {
                            if (pl1_class_CB.Text == "Воїн" || pl1_class_CB.Text == "Паладін" || pl1_class_CB.Text == "Лучник" || pl1_class_CB.Text == "Чарівник")
                            {
                                NGRD_pl1_error_lbl.Text = "";
                                error_pl1 = false;
                            }
                            else
                            {
                                NGRD_pl1_error_lbl.Text = "Помилка - клас гравця №1 обрано невірно.";
                                error_pl1 = true;
                            }                           
                        }
                        else
                        {
                            NGRD_pl1_error_lbl.Text = "Помилка - ім'я гравця №1 містить більше 10 символів.";
                            error_pl1 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl1_error_lbl.Text = "Помилка - введіть ім'я гравця №1.";
                        error_pl1 = true;

                    }
                    if (pl2_name_tbx.Text != "")
                    {
                        if (pl2_name_tbx.Text.Length < 10)
                        {
                            if (pl2_class_CB.Text == "Воїн" || pl2_class_CB.Text == "Паладін" || pl2_class_CB.Text == "Лучник" || pl2_class_CB.Text == "Чарівник")
                            {
                                NGRD_pl2_error_lbl.Text = "";
                                error_pl2 = false;
                            }
                            else
                            {
                                NGRD_pl2_error_lbl.Text = "Помилка - клас гравця №2 обрано невірно.";
                                error_pl2 = true;
                            }                       
                        }
                        else
                        {
                            NGRD_pl2_error_lbl.Text = "Помилка - ім'я гравця №2 містить більше 10 символів.";
                            error_pl2 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl2_error_lbl.Text = "Помилка - введіть ім'я гравця №2.";
                        error_pl2 = true;
                    }
                    if (pl3_name_tbx.Text != "")
                    {
                        if (pl3_name_tbx.Text.Length < 10)
                        {
                            if (pl1_name_tbx.Text != pl2_name_tbx.Text && pl1_name_tbx.Text != pl3_name_tbx.Text && pl2_name_tbx.Text != pl3_name_tbx.Text)
                            {
                                if (pl3_class_CB.Text == "Воїн" || pl3_class_CB.Text == "Паладін" || pl3_class_CB.Text == "Лучник" || pl3_class_CB.Text == "Чарівник")
                                {
                                    NGRD_pl3_error_lbl.Text = "";
                                    error_pl3 = false;
                                }
                                else
                                {
                                    NGRD_pl3_error_lbl.Text = "Помилка - клас гравця №3 обрано невірно.";
                                    error_pl3 = true;
                                }
                            }
                            else
                            {
                                NGRD_pl1_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                NGRD_pl2_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                NGRD_pl3_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                error_pl3 = true;
                            }                            
                        }
                        else
                        {
                            NGRD_pl3_error_lbl.Text = "Помилка - ім'я гравця №3 містить більше 10 символів.";
                            error_pl3 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl3_error_lbl.Text = "Помилка - введіть ім'я гравця №3.";
                        GameGlobalData.error = true;
                    }
                    break;
                case 4:
                    if (pl1_name_tbx.Text != "")
                    {
                        if (pl1_name_tbx.Text.Length < 10)
                        {
                            if (pl1_class_CB.Text == "Воїн" || pl1_class_CB.Text == "Паладін" || pl1_class_CB.Text == "Лучник" || pl1_class_CB.Text == "Чарівник")
                            {
                                NGRD_pl1_error_lbl.Text = "";
                                error_pl1 = false;
                            }
                            else
                            {
                                NGRD_pl1_error_lbl.Text = "Помилка - клас гравця №1 обрано невірно.";
                                error_pl1 = true;
                            }                            
                        }
                        else
                        {
                            NGRD_pl1_error_lbl.Text = "Помилка - ім'я гравця №1 містить більше 10 символів.";
                            error_pl1 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl1_error_lbl.Text = "Помилка - введіть ім'я гравця №1.";
                        error_pl1 = true;
                    }
                    if (pl2_name_tbx.Text != "")
                    {
                        if (pl2_name_tbx.Text.Length < 10)
                        {
                            if (pl2_class_CB.Text == "Воїн" || pl2_class_CB.Text == "Паладін" || pl2_class_CB.Text == "Лучник" || pl2_class_CB.Text == "Чарівник")
                            {
                                NGRD_pl2_error_lbl.Text = "";
                                error_pl2 = false;
                            }
                            else
                            {
                                NGRD_pl2_error_lbl.Text = "Помилка - клас гравця №2 обрано невірно.";
                                error_pl2 = true;
                            }
                        }
                        else
                        {
                            NGRD_pl2_error_lbl.Text = "Помилка - ім'я гравця №2 містить більше 10 символів.";
                            error_pl2 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl2_error_lbl.Text = "Помилка - введіть ім'я гравця №2.";
                        error_pl2 = true;
                    }
                    if (pl3_name_tbx.Text != "")
                    {
                        if (pl3_name_tbx.Text.Length < 10)
                        {
                            if (pl3_class_CB.Text == "Воїн" || pl3_class_CB.Text == "Паладін" || pl3_class_CB.Text == "Лучник" || pl3_class_CB.Text == "Чарівник")
                            {
                                NGRD_pl3_error_lbl.Text = "";
                                error_pl3 = false;
                            }
                            else
                            {
                                NGRD_pl3_error_lbl.Text = "Помилка - клас гравця №3 обрано невірно.";
                                error_pl3 = true;
                            }
                        }
                        else
                        {
                            NGRD_pl3_error_lbl.Text = "Помилка - ім'я гравця №3 містить більше 10 символів.";
                            error_pl3 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl3_error_lbl.Text = "Помилка - введіть ім'я гравця №3.";
                        error_pl3 = true;
                    }
                    if (pl4_name_tbx.Text != "")
                    {
                        if (pl4_name_tbx.Text.Length < 10)
                        {
                            if (pl1_name_tbx.Text != pl2_name_tbx.Text && pl1_name_tbx.Text != pl3_name_tbx.Text && pl1_name_tbx.Text != pl4_name_tbx.Text
                                                                        && pl2_name_tbx.Text != pl3_name_tbx.Text && pl2_name_tbx.Text != pl4_name_tbx.Text
                                                                        && pl3_name_tbx.Text != pl4_name_tbx.Text)
                            {
                                if (pl4_class_CB.Text == "Воїн" || pl4_class_CB.Text == "Паладін" || pl4_class_CB.Text == "Лучник" || pl4_class_CB.Text == "Чарівник")
                                {
                                    NGRD_pl4_error_lbl.Text = "";
                                    error_pl4 = false;
                                }
                                else
                                {
                                    NGRD_pl4_error_lbl.Text = "Помилка - клас гравця №4 обрано невірно.";
                                    error_pl4 = true;
                                }
                            }
                            else
                            {
                                NGRD_pl1_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                NGRD_pl2_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                NGRD_pl3_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                NGRD_pl4_error_lbl.Text = "Помилка - імена гравців не можуть повторюватись.";
                                error_pl4 = true;
                            }                            
                        }
                        else
                        {
                            NGRD_pl4_error_lbl.Text = "Помилка - ім'я гравця №4 містить більше 10 символів.";
                            error_pl4 = true;
                        }
                    }
                    else
                    {
                        NGRD_pl4_error_lbl.Text = "Помилка - введіть ім'я гравця №4.";
                        error_pl4 = true;
                    }
                    break;
                    
            }
            if (error_pl1 == false && error_pl2 == false && error_pl3 == false && error_pl4 == false)
            {
                List<Loot> empty_inventory = new List<Loot>(2) { };
                List<Loot> empty_equipped = new List<Loot>(3) { };
                for (int i = 1; i < GameGlobalData.count_of_players + 1; i++)
                {
                    Hero.generate_players(i, pl1_name_tbx.Text, pl1_class_CB.Text, pl2_name_tbx.Text, pl2_class_CB.Text, pl3_name_tbx.Text, pl3_class_CB.Text, pl4_name_tbx.Text, pl4_class_CB.Text, 1, 0, 0, 0, 0, 0, 0, 0, 0, empty_inventory, empty_equipped);
                }
                Close();
                JourneyMap JourneyMap_obj = new JourneyMap();               
                JourneyMap_obj.ShowDialog();
            }
        }

        private void pl2_class_CB_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pl3_panel_RPD_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
