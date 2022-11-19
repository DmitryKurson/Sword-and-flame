
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SM_main_lbl
            // 
            this.SM_main_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SM_main_lbl.Font = new System.Drawing.Font("Bangkok", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SM_main_lbl.Location = new System.Drawing.Point(0, 40);
            this.SM_main_lbl.Name = "SM_main_lbl";
            this.SM_main_lbl.Size = new System.Drawing.Size(480, 100);
            this.SM_main_lbl.TabIndex = 5;
            this.SM_main_lbl.Text = "Some Text";
            this.SM_main_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SM_main_lbl.Click += new System.EventHandler(this.SM_main_lbl_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Bangkok", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(100, 175);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 50);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Bangkok", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(280, 175);
            this.btn_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 50);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // ShowMessage_ChooseFrom2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.SM_main_lbl);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowMessage_ChooseFrom2";
            this.Load += new System.EventHandler(this.ShowMessage_ChooseFrom2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label SM_main_lbl;
        private Button btn_1;
        private Button btn_2;
    }
}