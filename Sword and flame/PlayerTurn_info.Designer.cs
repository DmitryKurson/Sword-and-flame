
namespace Castle_Crushers
{
    partial class PlayerTurn_info
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
            this.PlayerTurn_info_ok_btn = new System.Windows.Forms.Button();
            this.PlayerTurn_info_Main_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerTurn_info_ok_btn
            // 
            this.PlayerTurn_info_ok_btn.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTurn_info_ok_btn.Location = new System.Drawing.Point(104, 85);
            this.PlayerTurn_info_ok_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerTurn_info_ok_btn.Name = "PlayerTurn_info_ok_btn";
            this.PlayerTurn_info_ok_btn.Size = new System.Drawing.Size(153, 130);
            this.PlayerTurn_info_ok_btn.TabIndex = 0;
            this.PlayerTurn_info_ok_btn.Text = "ОК";
            this.PlayerTurn_info_ok_btn.UseVisualStyleBackColor = true;
            this.PlayerTurn_info_ok_btn.Click += new System.EventHandler(this.PlayerTurn_info_ok_btn_Click);
            // 
            // PlayerTurn_info_Main_lbl
            // 
            this.PlayerTurn_info_Main_lbl.AutoSize = true;
            this.PlayerTurn_info_Main_lbl.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTurn_info_Main_lbl.Location = new System.Drawing.Point(145, -1);
            this.PlayerTurn_info_Main_lbl.Name = "PlayerTurn_info_Main_lbl";
            this.PlayerTurn_info_Main_lbl.Size = new System.Drawing.Size(52, 16);
            this.PlayerTurn_info_Main_lbl.TabIndex = 1;
            this.PlayerTurn_info_Main_lbl.Text = "label1";
            // 
            // PlayerTurn_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 269);
            this.Controls.Add(this.PlayerTurn_info_Main_lbl);
            this.Controls.Add(this.PlayerTurn_info_ok_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlayerTurn_info";
            this.Text = "PlayerTurn_info";
            this.Load += new System.EventHandler(this.PlayerTurn_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayerTurn_info_ok_btn;
        private System.Windows.Forms.Label PlayerTurn_info_Main_lbl;
    }
}