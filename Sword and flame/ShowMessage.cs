using Sword_and_flame;
using System.Windows.Forms;

namespace Sword_and_flame
{
    public partial class ShowMessage : Form
    {
        string Message = "";
        public ShowMessage(string Message)
        {           
            InitializeComponent();
            this.Message = Message;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ShowMessage_Load(object sender, EventArgs e)
        {            
            ShowMessage_Main_lbl.Text = Message;
        }

        private void ShowMessage_OK_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

//public ShowMessage_ChooseFrom2 (Form key)
//{
//    InitializeComponent();
    
   
//}

//private void ShowMessage_ChooseFrom2_Load(object sender, EventArgs e)
//{
//    switch (key_)
//    {
//        case MainMenu:
//            btn_1.Text = "Так";
//            btn_2.Text = "Ні";
//            SM_main_lbl.Text = "Ви впевнені, що хочете вийти з гри?";
//            break;
//    }