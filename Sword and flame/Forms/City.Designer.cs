
namespace Sword_and_flame
{
    partial class City
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
            this.City_tavern_btn = new System.Windows.Forms.Button();
            this.City_market_btn = new System.Windows.Forms.Button();
            this.City_next_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // City_tavern_btn
            // 
            this.City_tavern_btn.Location = new System.Drawing.Point(178, 806);
            this.City_tavern_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.City_tavern_btn.Name = "City_tavern_btn";
            this.City_tavern_btn.Size = new System.Drawing.Size(250, 100);
            this.City_tavern_btn.TabIndex = 0;
            this.City_tavern_btn.Text = "Таверна";
            this.City_tavern_btn.UseVisualStyleBackColor = true;
            // 
            // City_market_btn
            // 
            this.City_market_btn.Location = new System.Drawing.Point(1108, 676);
            this.City_market_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.City_market_btn.Name = "City_market_btn";
            this.City_market_btn.Size = new System.Drawing.Size(250, 100);
            this.City_market_btn.TabIndex = 1;
            this.City_market_btn.Text = "Ринок";
            this.City_market_btn.UseVisualStyleBackColor = true;
            // 
            // City_next_btn
            // 
            this.City_next_btn.Location = new System.Drawing.Point(906, 806);
            this.City_next_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.City_next_btn.Name = "City_next_btn";
            this.City_next_btn.Size = new System.Drawing.Size(250, 100);
            this.City_next_btn.TabIndex = 2;
            this.City_next_btn.Text = "Відкрити мапу";
            this.City_next_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 806);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Дошка оголошень";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.City_next_btn);
            this.Controls.Add(this.City_market_btn);
            this.Controls.Add(this.City_tavern_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "City";
            this.Text = "City";
            this.Load += new System.EventHandler(this.City_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button City_tavern_btn;
        private System.Windows.Forms.Button City_market_btn;
        private System.Windows.Forms.Button City_next_btn;
        private Button button1;
    }
}