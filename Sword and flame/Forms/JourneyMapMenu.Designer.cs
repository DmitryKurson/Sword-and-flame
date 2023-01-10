namespace Sword_and_flame.Forms
{
    partial class JourneyMapMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JourneyMapMenu));
            this.jmm_save_btn = new System.Windows.Forms.Button();
            this.jmm_load_btn = new System.Windows.Forms.Button();
            this.jmm_gotomainmenu_btn = new System.Windows.Forms.Button();
            this.jmm_journal_btn = new System.Windows.Forms.Button();
            this.jmm_statistic_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jmm_save_btn
            // 
            this.jmm_save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(210)))), ((int)(((byte)(173)))));
            this.jmm_save_btn.Font = new System.Drawing.Font("Bangkok", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jmm_save_btn.Location = new System.Drawing.Point(75, 265);
            this.jmm_save_btn.Name = "jmm_save_btn";
            this.jmm_save_btn.Size = new System.Drawing.Size(250, 75);
            this.jmm_save_btn.TabIndex = 0;
            this.jmm_save_btn.Text = "Зберегти гру";
            this.jmm_save_btn.UseVisualStyleBackColor = false;
            // 
            // jmm_load_btn
            // 
            this.jmm_load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(210)))), ((int)(((byte)(173)))));
            this.jmm_load_btn.Font = new System.Drawing.Font("Bangkok", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jmm_load_btn.Location = new System.Drawing.Point(75, 365);
            this.jmm_load_btn.Name = "jmm_load_btn";
            this.jmm_load_btn.Size = new System.Drawing.Size(250, 75);
            this.jmm_load_btn.TabIndex = 2;
            this.jmm_load_btn.Text = "Завантажити гру";
            this.jmm_load_btn.UseVisualStyleBackColor = false;
            // 
            // jmm_gotomainmenu_btn
            // 
            this.jmm_gotomainmenu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(210)))), ((int)(((byte)(173)))));
            this.jmm_gotomainmenu_btn.Font = new System.Drawing.Font("Bangkok", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jmm_gotomainmenu_btn.Location = new System.Drawing.Point(75, 465);
            this.jmm_gotomainmenu_btn.Name = "jmm_gotomainmenu_btn";
            this.jmm_gotomainmenu_btn.Size = new System.Drawing.Size(250, 75);
            this.jmm_gotomainmenu_btn.TabIndex = 3;
            this.jmm_gotomainmenu_btn.Text = "Вийти в головне меню";
            this.jmm_gotomainmenu_btn.UseVisualStyleBackColor = false;
            this.jmm_gotomainmenu_btn.Click += new System.EventHandler(this.jmm_gotomainmenu_btn_Click);
            // 
            // jmm_journal_btn
            // 
            this.jmm_journal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(210)))), ((int)(((byte)(173)))));
            this.jmm_journal_btn.Font = new System.Drawing.Font("Bangkok", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jmm_journal_btn.Location = new System.Drawing.Point(75, 65);
            this.jmm_journal_btn.Name = "jmm_journal_btn";
            this.jmm_journal_btn.Size = new System.Drawing.Size(250, 75);
            this.jmm_journal_btn.TabIndex = 4;
            this.jmm_journal_btn.Text = "Журнал";
            this.jmm_journal_btn.UseVisualStyleBackColor = false;
            // 
            // jmm_statistic_btn
            // 
            this.jmm_statistic_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(210)))), ((int)(((byte)(173)))));
            this.jmm_statistic_btn.Font = new System.Drawing.Font("Bangkok", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jmm_statistic_btn.Location = new System.Drawing.Point(75, 165);
            this.jmm_statistic_btn.Name = "jmm_statistic_btn";
            this.jmm_statistic_btn.Size = new System.Drawing.Size(250, 75);
            this.jmm_statistic_btn.TabIndex = 5;
            this.jmm_statistic_btn.Text = "Статистика";
            this.jmm_statistic_btn.UseVisualStyleBackColor = false;
            // 
            // JourneyMapMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 613);
            this.Controls.Add(this.jmm_statistic_btn);
            this.Controls.Add(this.jmm_journal_btn);
            this.Controls.Add(this.jmm_gotomainmenu_btn);
            this.Controls.Add(this.jmm_load_btn);
            this.Controls.Add(this.jmm_save_btn);
            this.DoubleBuffered = true;
            this.Name = "JourneyMapMenu";
            this.Text = "JourneyMapMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button jmm_save_btn;
        private Button jmm_load_btn;
        private Button jmm_gotomainmenu_btn;
        private Button jmm_journal_btn;
        private Button jmm_statistic_btn;
    }
}