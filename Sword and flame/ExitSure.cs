namespace Sword_and_flame
{
    public partial class ExitSure : Form
    {
        public ExitSure()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void YES_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NO_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ExitSure_Load(object sender, EventArgs e)
        {

        }

       

        private void ExitSure_Load_1(object sender, EventArgs e)
        {

        }
    }
}
