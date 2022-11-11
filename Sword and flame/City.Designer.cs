
namespace Castle_Crushers
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
            this.SuspendLayout();
            // 
            // City_tavern_btn
            // 
            this.City_tavern_btn.Location = new System.Drawing.Point(80, 175);
            this.City_tavern_btn.Name = "City_tavern_btn";
            this.City_tavern_btn.Size = new System.Drawing.Size(75, 23);
            this.City_tavern_btn.TabIndex = 0;
            this.City_tavern_btn.Text = "Таверна";
            this.City_tavern_btn.UseVisualStyleBackColor = true;
            // 
            // City_market_btn
            // 
            this.City_market_btn.Location = new System.Drawing.Point(363, 214);
            this.City_market_btn.Name = "City_market_btn";
            this.City_market_btn.Size = new System.Drawing.Size(75, 23);
            this.City_market_btn.TabIndex = 1;
            this.City_market_btn.Text = "Ринок";
            this.City_market_btn.UseVisualStyleBackColor = true;
            // 
            // City_next_btn
            // 
            this.City_next_btn.Location = new System.Drawing.Point(519, 214);
            this.City_next_btn.Name = "City_next_btn";
            this.City_next_btn.Size = new System.Drawing.Size(145, 54);
            this.City_next_btn.TabIndex = 2;
            this.City_next_btn.Text = "Відкрити мапу";
            this.City_next_btn.UseVisualStyleBackColor = true;
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.City_next_btn);
            this.Controls.Add(this.City_market_btn);
            this.Controls.Add(this.City_tavern_btn);
            this.Name = "City";
            this.Text = "City";
            this.Load += new System.EventHandler(this.City_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button City_tavern_btn;
        private System.Windows.Forms.Button City_market_btn;
        private System.Windows.Forms.Button City_next_btn;
    }
}