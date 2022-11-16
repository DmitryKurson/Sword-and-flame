
namespace Castle_Crushers
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MM_main_panel = new System.Windows.Forms.Panel();
            this.MM_main_lbl = new System.Windows.Forms.Label();
            this.MM_EG_btn = new System.Windows.Forms.Button();
            this.MM_NG_btn = new System.Windows.Forms.Button();
            this.MM_LG_btn = new System.Windows.Forms.Button();
            this.MM_main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MM_main_panel
            // 
            this.MM_main_panel.AutoSize = true;
            this.MM_main_panel.BackColor = System.Drawing.Color.Transparent;
            this.MM_main_panel.BackgroundImage = global::Sword_and_flame.Properties.Resources.main_flag;
            this.MM_main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MM_main_panel.Controls.Add(this.MM_main_lbl);
            this.MM_main_panel.Controls.Add(this.MM_EG_btn);
            this.MM_main_panel.Controls.Add(this.MM_NG_btn);
            this.MM_main_panel.Controls.Add(this.MM_LG_btn);
            this.MM_main_panel.Location = new System.Drawing.Point(73, 0);
            this.MM_main_panel.Name = "MM_main_panel";
            this.MM_main_panel.Size = new System.Drawing.Size(500, 700);
            this.MM_main_panel.TabIndex = 1;
            this.MM_main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MM_main_panel_Paint);
            // 
            // MM_main_lbl
            // 
            this.MM_main_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MM_main_lbl.Font = new System.Drawing.Font("Bangkok", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MM_main_lbl.Location = new System.Drawing.Point(83, 120);
            this.MM_main_lbl.Name = "MM_main_lbl";
            this.MM_main_lbl.Size = new System.Drawing.Size(334, 59);
            this.MM_main_lbl.TabIndex = 5;
            this.MM_main_lbl.Text = "Головне меню";
            this.MM_main_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MM_main_lbl.Click += new System.EventHandler(this.MM_main_lbl_Click);
            // 
            // MM_EG_btn
            // 
            this.MM_EG_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MM_EG_btn.Font = new System.Drawing.Font("Bangkok", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MM_EG_btn.Location = new System.Drawing.Point(125, 520);
            this.MM_EG_btn.Name = "MM_EG_btn";
            this.MM_EG_btn.Size = new System.Drawing.Size(250, 100);
            this.MM_EG_btn.TabIndex = 4;
            this.MM_EG_btn.Text = "Вийти з гри";
            this.MM_EG_btn.UseVisualStyleBackColor = false;
            this.MM_EG_btn.Click += new System.EventHandler(this.MM_EG_btn_Click);
            // 
            // MM_NG_btn
            // 
            this.MM_NG_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MM_NG_btn.Font = new System.Drawing.Font("Bangkok", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MM_NG_btn.Location = new System.Drawing.Point(125, 220);
            this.MM_NG_btn.Name = "MM_NG_btn";
            this.MM_NG_btn.Size = new System.Drawing.Size(250, 100);
            this.MM_NG_btn.TabIndex = 2;
            this.MM_NG_btn.Text = "Нова гра";
            this.MM_NG_btn.UseVisualStyleBackColor = false;
            this.MM_NG_btn.Click += new System.EventHandler(this.MM_NG_btn_Click);
            // 
            // MM_LG_btn
            // 
            this.MM_LG_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MM_LG_btn.Font = new System.Drawing.Font("Bangkok", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MM_LG_btn.Location = new System.Drawing.Point(125, 370);
            this.MM_LG_btn.Name = "MM_LG_btn";
            this.MM_LG_btn.Size = new System.Drawing.Size(250, 100);
            this.MM_LG_btn.TabIndex = 3;
            this.MM_LG_btn.Text = "Завантажити гру";
            this.MM_LG_btn.UseVisualStyleBackColor = false;
            this.MM_LG_btn.Click += new System.EventHandler(this.MM_LG_btn_Click);
            // 
            // MainMenu
            // 
            this.BackgroundImage = global::Sword_and_flame.Properties.Resources.main_menu_and_global_details_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.MM_main_panel);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MM_main_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NGbtn;
        private System.Windows.Forms.Button LGbtn;
        private System.Windows.Forms.Button EGbtn;
        private System.Windows.Forms.Panel MainMenu_panel;
        private System.Windows.Forms.Label MainMenu_main_lbl;
        private System.Windows.Forms.Panel MM_main_panel;
        private System.Windows.Forms.Button MM_NG_btn;
        private System.Windows.Forms.Button MM_LG_btn;
        private System.Windows.Forms.Button MM_EG_btn;
        private System.Windows.Forms.Label MM_main_lbl;
    }
}

