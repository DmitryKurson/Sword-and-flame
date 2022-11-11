
namespace Castle_Crushers
{
    partial class ExitSure
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
            this.NO_btn = new System.Windows.Forms.Button();
            this.YES_btn = new System.Windows.Forms.Button();
            this.ES_main_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NO_btn
            // 
            this.NO_btn.Location = new System.Drawing.Point(250, 100);
            this.NO_btn.Name = "NO_btn";
            this.NO_btn.Size = new System.Drawing.Size(75, 25);
            this.NO_btn.TabIndex = 0;
            this.NO_btn.Text = "Ні";
            this.NO_btn.UseVisualStyleBackColor = true;
            this.NO_btn.Click += new System.EventHandler(this.NO_btn_Click);
            // 
            // YES_btn
            // 
            this.YES_btn.Location = new System.Drawing.Point(125, 100);
            this.YES_btn.Name = "YES_btn";
            this.YES_btn.Size = new System.Drawing.Size(75, 25);
            this.YES_btn.TabIndex = 1;
            this.YES_btn.Text = "Так";
            this.YES_btn.UseVisualStyleBackColor = true;
            this.YES_btn.Click += new System.EventHandler(this.YES_btn_Click);
            // 
            // ES_main_lbl
            // 
            this.ES_main_lbl.AutoSize = true;
            this.ES_main_lbl.Location = new System.Drawing.Point(115, 55);
            this.ES_main_lbl.Name = "ES_main_lbl";
            this.ES_main_lbl.Size = new System.Drawing.Size(248, 17);
            this.ES_main_lbl.TabIndex = 2;
            this.ES_main_lbl.Text = "Ви впевнені, що хочете вийти з гри?";
            this.ES_main_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 153);
            this.Controls.Add(this.ES_main_lbl);
            this.Controls.Add(this.YES_btn);
            this.Controls.Add(this.NO_btn);
            this.Name = "ExitSure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExitSure";
            this.Load += new System.EventHandler(this.ExitSure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NO_btn;
        private System.Windows.Forms.Button YES_btn;
        private System.Windows.Forms.Label ES_main_lbl;
    }
}