namespace Sword_and_flame
{
    public partial class NGGlobalDetails : Form
    {
        public NGGlobalDetails()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void NGGlobalDetails_Load(object sender, EventArgs e)
        {

        }

        private void difficultyCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {           
            if (!(NGGD_count_of_players_1pl_rb.Checked || NGGD_count_of_players_2pl_rb.Checked || NGGD_count_of_players_3pl_rb.Checked || NGGD_count_of_players_4pl_rb.Checked))
            {
                NGGD_error_lbl.Text = "Помилка - оберіть кількість гравців";
            }
            else
            {
                if (NGGD_count_of_players_1pl_rb.Checked)
                {
                    GameGlobalData.count_of_players = 1;
                }
                if (NGGD_count_of_players_2pl_rb.Checked)
                {
                    GameGlobalData.count_of_players = 2;
                }
                if (NGGD_count_of_players_3pl_rb.Checked)
                {
                    GameGlobalData.count_of_players = 3;
                }
                if (NGGD_count_of_players_4pl_rb.Checked)
                {
                    GameGlobalData.count_of_players = 4;
                }

                if (!(NGGD_difficulty_easy_rb.Checked || NGGD_difficulty_normal_rb.Checked || NGGD_difficulty_hard_rb.Checked))
                {
                    NGGD_error_lbl.Text = "Помилка - оберіть складність гри";
                }
                else
                {
                    if (NGGD_difficulty_easy_rb.Checked)
                    {
                        GameGlobalData.difficulty = NGGD_difficulty_easy_rb.Text;
                    }
                    if (NGGD_difficulty_normal_rb.Checked)
                    {
                        GameGlobalData.difficulty = NGGD_difficulty_normal_rb.Text;
                    }
                    if (NGGD_difficulty_hard_rb.Checked)
                    {
                        GameGlobalData.difficulty = NGGD_difficulty_hard_rb.Text;
                    }                    
                    Hide();
                    RoleplayDetails NGRoleplayDetails_obj = new RoleplayDetails();
                    NGRoleplayDetails_obj.ShowDialog();
                }
            }


            // TO DO
            //if (!((NGGD_count_of_players_1pl_rb.Checked || NGGD_count_of_players_2pl_rb.Checked || NGGD_count_of_players_3pl_rb.Checked || NGGD_count_of_players_4pl_rb.Checked)
            //&& (NGGD_difficulty_easy_rb.Checked || NGGD_difficulty_normal_rb.Checked || NGGD_difficulty_hard_rb.Checked)))
            //{
            //    NGGD_error_lbl.Text = "Помилка - оберіть кількість гравців та складність гри.";
            //}
            //else
            //{
            //}


        

            //// Чіти
            if (textBox1.Text == "")
            {
                //if (difficultyCB.Text == "" || count_of_playersCB.Text == "")
                //{
                //    NGGD_error_lbl.Text = "Помилка - оберіть клас та введіть кількість гравців";
                //}
                //else
                //{
                //    if ((count_of_playersCB.Text == "1" || count_of_playersCB.Text == "2" || count_of_playersCB.Text == "3" || count_of_playersCB.Text == "4") && (difficultyCB.Text == "Легко" || difficultyCB.Text == "Нормально" || difficultyCB.Text == "Важко"))
                //    {
                //        GameGlobalData.count_of_players = Int32.Parse(count_of_playersCB.Text);
                //        GameGlobalData.difficulty = difficultyCB.Text;
                        
                //    }
                //    else
                //    {
                //        NGGD_error_lbl.Text = "Помилка - ви неправильно ввели дані";
                //    }
                //}
            }
            else //// Чіти
            {


                // Перший символ(0) -кількість гравців(число)
                // Другий символ(1) -складність(e / n)
                // Третій символ(2) -ім'я першого гравця (рядок)
                // Четвертий символ(3) -клас першого гравця(w/ p / a / m)
                // П'ятий символ (4) - ім'я другого гравця(рядок)
                // Щостий символ(5) -клас другого гравця(w/ p / a / m)
                // Сьомий символ(6) -рівень гри(число)

            //    string cheat_str = "";
            //    string empty_v = " ";
            //    cheat_str = textBox1.Text;

            //    // КІЛЬКІСТЬ ГРАВЦІВ
            //    GameGlobalData.count_of_players = cheat_str[0];
            //    Console.WriteLine((int)cheat_str[0]);

            //    // СКЛАДНІСТЬ
            //    if (cheat_str[1].ToString() == "e")
            //    {
            //        GameGlobalData.difficulty = "Легко";
            //    }
            //    if (cheat_str[1].ToString() == "n")
            //    {
            //        GameGlobalData.difficulty = "Нормально";
            //    }
            //    if (cheat_str[1].ToString() == "h")
            //    {
            //        GameGlobalData.difficulty = "Важко";
            //    }

            //    // КЛАСИ ТА ІМЕНА
            //    switch (GameGlobalData.count_of_players)
            //    {
            //        case 1:
            //            GameGlobalData.player1_name = cheat_str[2].ToString();
            //            switch (cheat_str[3].ToString())
            //            {
            //                case "w":
            //                    GameGlobalData.player1_class = "Воїн";
            //                    break;
            //                case "p":
            //                    GameGlobalData.player1_class = "Паладін";
            //                    break;
            //                case "a":
            //                    GameGlobalData.player1_class = "Лучник";
            //                    break;
            //                case "m":
            //                    GameGlobalData.player1_class = "Чарівник";
            //                    break;
            //            }
            //            cheat_str[4] = " ";
            //            cheat_str[5] = " "; 
            //            break;
            //        case 2:
            //            GameGlobalData.player1_name = cheat_str[2].ToString();
            //            switch (cheat_str[3].ToString())
            //            {
            //                case "w":
            //                    GameGlobalData.player1_class = "Воїн";
            //                    break;
            //                case "p":
            //                    GameGlobalData.player1_class = "Паладін";
            //                    break;
            //                case "a":
            //                    GameGlobalData.player1_class = "Лучник";
            //                    break;
            //                case "m":
            //                    GameGlobalData.player1_class = "Чарівник";
            //                    break;
            //            }
            //            GameGlobalData.player2_name = cheat_str[4].ToString();
            //            switch (cheat_str[5].ToString())
            //            {
            //                case "w":
            //                    GameGlobalData.player2_class = "Воїн";
            //                    break;
            //                case "p":
            //                    GameGlobalData.player2_class = "Паладін";
            //                    break;
            //                case "a":
            //                    GameGlobalData.player2_class = "Лучник";
            //                    break;
            //                case "m":
            //                    GameGlobalData.player2_class = "Чарівник";
            //                    break;
            //            }
            //            break;                   
            //    }

            //    // ІНВЕНТАР
            //    switch (GameGlobalData.count_of_players)
            //    {
            //        case 1:
            //            switch (cheat_str[6].ToString()) // Первая ячейка инвентаря игрока №1
            //            {
            //                case "1":
                                
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[7].ToString()) // Вторая ячейка инвентаря игрока №1
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[8].ToString()) // Третья ячейка инвентаря игрока №1
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            cheat_str[9] = "";
            //            cheat_str[10] = "";
            //            cheat_str[11] = "";
            //            break;
            //        case 2:
            //            switch (cheat_str[6].ToString()) // Первая ячейка инвентаря игрока №1
            //            {
            //                case "1":

            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[7].ToString()) // Вторая ячейка инвентаря игрока №1
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[8].ToString()) // Третья ячейка инвентаря игрока №1
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[9].ToString()) // Первая ячейка инвентаря игрока №2
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[10].ToString()) // Вторая ячейка инвентаря игрока №2
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[11].ToString()) // Третья ячейка инвентаря игрока №2
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }                        
            //            break;                        
            //    }

            //    // РІВЕНЬ
            //    switch (GameGlobalData.count_of_players)
            //    {
            //        case 1:
            //            switch (cheat_str[12].ToString()) 
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            cheat_str[13].ToString() = empty_v;
            //            break;
            //        case 2:
            //            switch (cheat_str[12].ToString()) 
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            switch (cheat_str[13].ToString()) 
            //            {
            //                case "1":
            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //            }
            //            break;
            //    }

            //    // ПОТОЧНЕ МІСЦЕЗНАХОДЖЕННЯ
            //    switch (cheat_str[12].ToString())
            //    {
            //        case "1":
            //            LevelProperties.journey_map_current_level_position = "level_1";
            //            break;
            //    }

            //    Hide();
            //    LevelPreviewNew levelPreviewNew_cheatobj = new LevelPreviewNew();
            //    levelPreviewNew_cheatobj.ShowDialog();
            
            }             
        }

        private void count_of_players_lbl_Click(object sender, EventArgs e)
        {

        }

        private void count_of_playersCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NGGD_difficulty_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NGGD_back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainmenu_obj = new MainMenu();
            mainmenu_obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
