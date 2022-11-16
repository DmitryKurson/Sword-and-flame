using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sword_and_flame
{
    public partial class TutorialForm : Form
    {
        public static string main_text { get; set; }
        public static string tutorial_text { get; set; }
        public TutorialForm(string main_text_, string tutorial_text_)
        {
            InitializeComponent();
            main_text = main_text_;
            tutorial_text = tutorial_text_;
        }

        private void TutorialForm_Load(object sender, EventArgs e)
        {
            TF_main_lbl.Text = main_text;
            TF_tutorialtext_lbl.Text = tutorial_text;
        }

        private void TF_ok_btn_Click(object sender, EventArgs e)
        {
            if (TF_skiptutorial_cb.Checked)
            {
                GameGlobalData.tutorial_skipped = true;
            }
            Hide();
        }

        private void TF_skiptutorial_cb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
