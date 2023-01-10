using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sword_and_flame.Forms
{
    public partial class JourneyMapMenu : Form
    {
        public JourneyMapMenu()
        {
            InitializeComponent();
        }

        private void jmm_gotomainmenu_btn_Click(object sender, EventArgs e)
        {
            ShowMessage_ChooseFrom2 show_msg = new ShowMessage_ChooseFrom2 (this, "Всі незбережені зміни буде втрачено, ви впевнені, що хочете вийти?");
            show_msg.ShowDialog();
        }
    }
}
