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
