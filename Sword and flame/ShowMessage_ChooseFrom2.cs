using System.Windows.Forms;

namespace Sword_and_flame
{
    public partial class ShowMessage_ChooseFrom2 : Form
    {
        private Form key_;
        public ShowMessage_ChooseFrom2 (Form key)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            key_ = key;
        }

        private void ShowMessage_ChooseFrom2_Load(object sender, EventArgs e)
        {
            switch (key_)
            {
                case MainMenu:
                    btn_1.Text = "Так";
                    btn_2.Text = "Ні";
                    SM_main_lbl.Text = "Ви впевнені, що хочете вийти з гри?";
                    break;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            switch (key_)
            {
                case MainMenu:
                    Application.Exit();                 
                    break;
            }
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            switch (key_)
            {
                case MainMenu:
                    Hide();
                    break;
            }
        }

        private void SM_main_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
