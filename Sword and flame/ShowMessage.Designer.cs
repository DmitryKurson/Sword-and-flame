
namespace Sword_and_flame
{
    partial class ShowMessage
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
            this.ShowMessage_OK_btn = new System.Windows.Forms.Button();
            this.ShowMessage_Main_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowMessage_OK_btn
            // 
            this.ShowMessage_OK_btn.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowMessage_OK_btn.Location = new System.Drawing.Point(162, 211);
            this.ShowMessage_OK_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowMessage_OK_btn.Name = "ShowMessage_OK_btn";
            this.ShowMessage_OK_btn.Size = new System.Drawing.Size(75, 29);
            this.ShowMessage_OK_btn.TabIndex = 0;
            this.ShowMessage_OK_btn.Text = "OK";
            this.ShowMessage_OK_btn.UseVisualStyleBackColor = true;
            this.ShowMessage_OK_btn.Click += new System.EventHandler(this.ShowMessage_OK_btn_Click);
            // 
            // ShowMessage_Main_lbl
            // 
            this.ShowMessage_Main_lbl.AutoSize = true;
            this.ShowMessage_Main_lbl.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowMessage_Main_lbl.Location = new System.Drawing.Point(50, 100);
            this.ShowMessage_Main_lbl.Name = "ShowMessage_Main_lbl";
            this.ShowMessage_Main_lbl.Size = new System.Drawing.Size(52, 16);
            this.ShowMessage_Main_lbl.TabIndex = 1;
            this.ShowMessage_Main_lbl.Text = "label1";
            // 
            // ShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.ShowMessage_Main_lbl);
            this.Controls.Add(this.ShowMessage_OK_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowMessage";
            this.Text = "ShowMessage";
            this.Load += new System.EventHandler(this.ShowMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowMessage_OK_btn;
        private System.Windows.Forms.Label ShowMessage_Main_lbl;
    }
}