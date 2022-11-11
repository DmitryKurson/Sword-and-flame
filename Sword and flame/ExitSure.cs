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
    }
}
