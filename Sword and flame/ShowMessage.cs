namespace Sword_and_flame
{
    public partial class ShowMessage : Form
    {
        string Message = "";
        public ShowMessage(string Message)
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.Message = Message;
            InitializeComponent();
        }

        private void ShowMessage_Load(object sender, EventArgs e)
        {            
            ShowMessage_Main_lbl.Text = Message + ", Ваш хід.";
        }

        private void ShowMessage_OK_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
