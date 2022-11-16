
namespace Castle_Crushers
{
    partial class TutorialForm
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
            this.TF_ok_btn = new System.Windows.Forms.Button();
            this.TF_skiptutorial_cb = new System.Windows.Forms.CheckBox();
            this.TF_main_lbl = new System.Windows.Forms.Label();
            this.TF_tutorialtext_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TF_ok_btn
            // 
            this.TF_ok_btn.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TF_ok_btn.Location = new System.Drawing.Point(367, 330);
            this.TF_ok_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TF_ok_btn.Name = "TF_ok_btn";
            this.TF_ok_btn.Size = new System.Drawing.Size(75, 29);
            this.TF_ok_btn.TabIndex = 0;
            this.TF_ok_btn.Text = "ОК";
            this.TF_ok_btn.UseVisualStyleBackColor = true;
            this.TF_ok_btn.Click += new System.EventHandler(this.TF_ok_btn_Click);
            // 
            // TF_skiptutorial_cb
            // 
            this.TF_skiptutorial_cb.AutoSize = true;
            this.TF_skiptutorial_cb.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TF_skiptutorial_cb.Location = new System.Drawing.Point(342, 408);
            this.TF_skiptutorial_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TF_skiptutorial_cb.Name = "TF_skiptutorial_cb";
            this.TF_skiptutorial_cb.Size = new System.Drawing.Size(209, 20);
            this.TF_skiptutorial_cb.TabIndex = 1;
            this.TF_skiptutorial_cb.Text = "Не показувати підказки";
            this.TF_skiptutorial_cb.UseVisualStyleBackColor = true;
            this.TF_skiptutorial_cb.CheckedChanged += new System.EventHandler(this.TF_skiptutorial_cb_CheckedChanged);
            // 
            // TF_main_lbl
            // 
            this.TF_main_lbl.AutoSize = true;
            this.TF_main_lbl.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TF_main_lbl.Location = new System.Drawing.Point(364, 31);
            this.TF_main_lbl.Name = "TF_main_lbl";
            this.TF_main_lbl.Size = new System.Drawing.Size(67, 16);
            this.TF_main_lbl.TabIndex = 2;
            this.TF_main_lbl.Text = "Головна";
            // 
            // TF_tutorialtext_lbl
            // 
            this.TF_tutorialtext_lbl.AutoSize = true;
            this.TF_tutorialtext_lbl.Font = new System.Drawing.Font("Bangkok", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TF_tutorialtext_lbl.Location = new System.Drawing.Point(364, 188);
            this.TF_tutorialtext_lbl.Name = "TF_tutorialtext_lbl";
            this.TF_tutorialtext_lbl.Size = new System.Drawing.Size(73, 16);
            this.TF_tutorialtext_lbl.TabIndex = 3;
            this.TF_tutorialtext_lbl.Text = "Підказки";
            // 
            // TutorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.TF_tutorialtext_lbl);
            this.Controls.Add(this.TF_main_lbl);
            this.Controls.Add(this.TF_skiptutorial_cb);
            this.Controls.Add(this.TF_ok_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TutorialForm";
            this.Text = "Підказки";
            this.Load += new System.EventHandler(this.TutorialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TF_ok_btn;
        private System.Windows.Forms.CheckBox TF_skiptutorial_cb;
        private System.Windows.Forms.Label TF_main_lbl;
        private System.Windows.Forms.Label TF_tutorialtext_lbl;
    }
}