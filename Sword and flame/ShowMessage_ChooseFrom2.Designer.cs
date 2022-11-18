
namespace Sword_and_flame
{
    partial class ShowMessage_ChooseFrom2
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
            this.SM_main_lbl = new System.Windows.Forms.Label();
            this.YES_btn = new System.Windows.Forms.Button();
            this.NO_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SM_main_lbl
            // 
            this.SM_main_lbl.AutoSize = true;
            this.SM_main_lbl.Location = new System.Drawing.Point(85, 79);
            this.SM_main_lbl.Name = "SM_main_lbl";
            this.SM_main_lbl.Size = new System.Drawing.Size(78, 20);
            this.SM_main_lbl.TabIndex = 5;
            this.SM_main_lbl.Text = "Some Text";
            // 
            // YES_btn
            // 
            this.YES_btn.Location = new System.Drawing.Point(95, 135);
            this.YES_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YES_btn.Name = "YES_btn";
            this.YES_btn.Size = new System.Drawing.Size(75, 31);
            this.YES_btn.TabIndex = 4;
            this.YES_btn.Text = "Так";
            this.YES_btn.UseVisualStyleBackColor = true;
            // 
            // NO_btn
            // 
            this.NO_btn.Location = new System.Drawing.Point(220, 135);
            this.NO_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NO_btn.Name = "NO_btn";
            this.NO_btn.Size = new System.Drawing.Size(75, 31);
            this.NO_btn.TabIndex = 3;
            this.NO_btn.Text = "Ні";
            this.NO_btn.UseVisualStyleBackColor = true;
            // 
            // ShowMessage_ChooseFrom2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 245);
            this.Controls.Add(this.SM_main_lbl);
            this.Controls.Add(this.YES_btn);
            this.Controls.Add(this.NO_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowMessage_ChooseFrom2";
            this.Text = "ShowMessage_ChooseFrom2";
            this.Load += new System.EventHandler(this.ShowMessage_ChooseFrom2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SM_main_lbl;
        private Button YES_btn;
        private Button NO_btn;
    }
}