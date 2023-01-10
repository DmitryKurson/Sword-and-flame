using Sword_and_flame.Forms;
using System.Windows.Forms;

namespace Sword_and_flame
{
    public partial class ShowMessage_ChooseFrom2 : Form
    {
        private object key;
        private string message;
        public ShowMessage_ChooseFrom2 (object key, string message)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            this.key = key;
            this.message = message;
        }

        private void ShowMessage_ChooseFrom2_Load(object sender, EventArgs e)
        {
            btn_1.Text = "Так";
            btn_2.Text = "Ні";
            SM_main_lbl.Text = message;

            //break;
            //switch (key)
            //{
            //    case MainMenu:
                    
            //    case JourneyMapMenu:
            //        btn_1.Text = "Так";
            //        btn_2.Text = "Ні";
            //        SM_main_lbl.Text = message;
            //        break;
            //}
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            switch (key)
            {
                case MainMenu:
                    Application.Exit();                 
                    break;
                case JourneyMapMenu:
                    MainMenu main_menu_obj = new MainMenu();
                    main_menu_obj.ShowDialog();
                    break;
            }
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            switch (key)
            {
                case MainMenu:
                    Close();
                    break;
                case JourneyMapMenu:
                    Close();
                    break;
            }
        }

        private void SM_main_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
