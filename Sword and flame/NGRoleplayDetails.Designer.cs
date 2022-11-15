
namespace Castle_Crushers
{
    partial class RoleplayDetails
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
            this.RoleplayDetails_info = new System.Windows.Forms.Button();
            this.pl2_panel_RPD = new System.Windows.Forms.Panel();
            this.NGRD_pl2_error_lbl = new System.Windows.Forms.Label();
            this.pl2_class_CB = new System.Windows.Forms.ComboBox();
            this.pl2_main_RPD_lbl = new System.Windows.Forms.Label();
            this.pl2_name_RPD_lbl = new System.Windows.Forms.Label();
            this.pl2_name_tbx = new System.Windows.Forms.TextBox();
            this.pl2_class_RPD_lbl = new System.Windows.Forms.Label();
            this.pl3_panel_RPD = new System.Windows.Forms.Panel();
            this.NGRD_pl3_error_lbl = new System.Windows.Forms.Label();
            this.pl3_class_CB = new System.Windows.Forms.ComboBox();
            this.pl3_main_RPD_lbl = new System.Windows.Forms.Label();
            this.pl3_name_RPD_lbl = new System.Windows.Forms.Label();
            this.pl3_name_tbx = new System.Windows.Forms.TextBox();
            this.pl3_class_RPD_lbl = new System.Windows.Forms.Label();
            this.pl4_panel_RPD = new System.Windows.Forms.Panel();
            this.NGRD_pl4_error_lbl = new System.Windows.Forms.Label();
            this.pl4_class_CB = new System.Windows.Forms.ComboBox();
            this.pl4_main_RPD_lbl = new System.Windows.Forms.Label();
            this.pl4_name_RPD_lbl = new System.Windows.Forms.Label();
            this.pl4_name_tbx = new System.Windows.Forms.TextBox();
            this.pl4_class_RPD_lbl = new System.Windows.Forms.Label();
            this.NGRD_pl1_error_lbl = new System.Windows.Forms.Label();
            this.pl1_panel_RPD = new System.Windows.Forms.Panel();
            this.pl1_class_CB = new System.Windows.Forms.ComboBox();
            this.pl1_main_RPD_lbl = new System.Windows.Forms.Label();
            this.pl1_name_RPD_lbl = new System.Windows.Forms.Label();
            this.pl1_name_tbx = new System.Windows.Forms.TextBox();
            this.pl1_class_RPD_lbl = new System.Windows.Forms.Label();
            this.NGRD_back_btn = new System.Windows.Forms.Button();
            this.NGRD_next_btn = new System.Windows.Forms.Button();
            this.pl2_panel_RPD.SuspendLayout();
            this.pl3_panel_RPD.SuspendLayout();
            this.pl4_panel_RPD.SuspendLayout();
            this.pl1_panel_RPD.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoleplayDetails_info
            // 
            this.RoleplayDetails_info.Location = new System.Drawing.Point(20, 44);
            this.RoleplayDetails_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoleplayDetails_info.Name = "RoleplayDetails_info";
            this.RoleplayDetails_info.Size = new System.Drawing.Size(75, 29);
            this.RoleplayDetails_info.TabIndex = 21;
            this.RoleplayDetails_info.Text = "Довідка";
            this.RoleplayDetails_info.UseVisualStyleBackColor = true;
            this.RoleplayDetails_info.Click += new System.EventHandler(this.button1_Click);
            // 
            // pl2_panel_RPD
            // 
            this.pl2_panel_RPD.BackColor = System.Drawing.Color.Transparent;
            this.pl2_panel_RPD.BackgroundImage = global::Sword_and_flame.Properties.Resources.yellow_banner;
            this.pl2_panel_RPD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl2_panel_RPD.Controls.Add(this.NGRD_pl2_error_lbl);
            this.pl2_panel_RPD.Controls.Add(this.pl2_class_CB);
            this.pl2_panel_RPD.Controls.Add(this.pl2_main_RPD_lbl);
            this.pl2_panel_RPD.Controls.Add(this.pl2_name_RPD_lbl);
            this.pl2_panel_RPD.Controls.Add(this.pl2_name_tbx);
            this.pl2_panel_RPD.Controls.Add(this.pl2_class_RPD_lbl);
            this.pl2_panel_RPD.Location = new System.Drawing.Point(510, 100);
            this.pl2_panel_RPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl2_panel_RPD.Name = "pl2_panel_RPD";
            this.pl2_panel_RPD.Size = new System.Drawing.Size(400, 675);
            this.pl2_panel_RPD.TabIndex = 24;
            // 
            // NGRD_pl2_error_lbl
            // 
            this.NGRD_pl2_error_lbl.AutoSize = true;
            this.NGRD_pl2_error_lbl.Location = new System.Drawing.Point(47, 495);
            this.NGRD_pl2_error_lbl.Name = "NGRD_pl2_error_lbl";
            this.NGRD_pl2_error_lbl.Size = new System.Drawing.Size(50, 20);
            this.NGRD_pl2_error_lbl.TabIndex = 31;
            this.NGRD_pl2_error_lbl.Text = "label1";
            // 
            // pl2_class_CB
            // 
            this.pl2_class_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(182)))), ((int)(((byte)(5)))));
            this.pl2_class_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl2_class_CB.FormattingEnabled = true;
            this.pl2_class_CB.Items.AddRange(new object[] {
            "Воїн",
            "Паладін",
            "Лучник",
            "Чарівник"});
            this.pl2_class_CB.Location = new System.Drawing.Point(200, 224);
            this.pl2_class_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl2_class_CB.Name = "pl2_class_CB";
            this.pl2_class_CB.Size = new System.Drawing.Size(150, 34);
            this.pl2_class_CB.TabIndex = 18;
            this.pl2_class_CB.SelectedIndexChanged += new System.EventHandler(this.pl2_class_CB_SelectedIndexChanged_1);
            // 
            // pl2_main_RPD_lbl
            // 
            this.pl2_main_RPD_lbl.AutoSize = true;
            this.pl2_main_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl2_main_RPD_lbl.Location = new System.Drawing.Point(122, 94);
            this.pl2_main_RPD_lbl.Name = "pl2_main_RPD_lbl";
            this.pl2_main_RPD_lbl.Size = new System.Drawing.Size(155, 29);
            this.pl2_main_RPD_lbl.TabIndex = 0;
            this.pl2_main_RPD_lbl.Text = "Гравець №2";
            // 
            // pl2_name_RPD_lbl
            // 
            this.pl2_name_RPD_lbl.AutoSize = true;
            this.pl2_name_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl2_name_RPD_lbl.Location = new System.Drawing.Point(45, 165);
            this.pl2_name_RPD_lbl.Name = "pl2_name_RPD_lbl";
            this.pl2_name_RPD_lbl.Size = new System.Drawing.Size(134, 26);
            this.pl2_name_RPD_lbl.TabIndex = 2;
            this.pl2_name_RPD_lbl.Text = "Введіть ім\'я";
            // 
            // pl2_name_tbx
            // 
            this.pl2_name_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(182)))), ((int)(((byte)(5)))));
            this.pl2_name_tbx.CausesValidation = false;
            this.pl2_name_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl2_name_tbx.Location = new System.Drawing.Point(200, 162);
            this.pl2_name_tbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl2_name_tbx.Name = "pl2_name_tbx";
            this.pl2_name_tbx.Size = new System.Drawing.Size(150, 32);
            this.pl2_name_tbx.TabIndex = 16;
            this.pl2_name_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pl2_class_RPD_lbl
            // 
            this.pl2_class_RPD_lbl.AutoSize = true;
            this.pl2_class_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl2_class_RPD_lbl.Location = new System.Drawing.Point(45, 224);
            this.pl2_class_RPD_lbl.Name = "pl2_class_RPD_lbl";
            this.pl2_class_RPD_lbl.Size = new System.Drawing.Size(146, 26);
            this.pl2_class_RPD_lbl.TabIndex = 11;
            this.pl2_class_RPD_lbl.Text = "Оберіть клас";
            // 
            // pl3_panel_RPD
            // 
            this.pl3_panel_RPD.BackColor = System.Drawing.Color.Transparent;
            this.pl3_panel_RPD.BackgroundImage = global::Sword_and_flame.Properties.Resources.green_banner;
            this.pl3_panel_RPD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl3_panel_RPD.Controls.Add(this.NGRD_pl3_error_lbl);
            this.pl3_panel_RPD.Controls.Add(this.pl3_class_CB);
            this.pl3_panel_RPD.Controls.Add(this.pl3_main_RPD_lbl);
            this.pl3_panel_RPD.Controls.Add(this.pl3_name_RPD_lbl);
            this.pl3_panel_RPD.Controls.Add(this.pl3_name_tbx);
            this.pl3_panel_RPD.Controls.Add(this.pl3_class_RPD_lbl);
            this.pl3_panel_RPD.Location = new System.Drawing.Point(1010, 100);
            this.pl3_panel_RPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl3_panel_RPD.Name = "pl3_panel_RPD";
            this.pl3_panel_RPD.Size = new System.Drawing.Size(400, 675);
            this.pl3_panel_RPD.TabIndex = 24;
            this.pl3_panel_RPD.Paint += new System.Windows.Forms.PaintEventHandler(this.pl3_panel_RPD_Paint);
            // 
            // NGRD_pl3_error_lbl
            // 
            this.NGRD_pl3_error_lbl.AutoSize = true;
            this.NGRD_pl3_error_lbl.Location = new System.Drawing.Point(68, 495);
            this.NGRD_pl3_error_lbl.Name = "NGRD_pl3_error_lbl";
            this.NGRD_pl3_error_lbl.Size = new System.Drawing.Size(50, 20);
            this.NGRD_pl3_error_lbl.TabIndex = 30;
            this.NGRD_pl3_error_lbl.Text = "label1";
            // 
            // pl3_class_CB
            // 
            this.pl3_class_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pl3_class_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl3_class_CB.FormattingEnabled = true;
            this.pl3_class_CB.Items.AddRange(new object[] {
            "Воїн",
            "Паладін",
            "Лучник",
            "Чарівник"});
            this.pl3_class_CB.Location = new System.Drawing.Point(200, 224);
            this.pl3_class_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl3_class_CB.Name = "pl3_class_CB";
            this.pl3_class_CB.Size = new System.Drawing.Size(150, 34);
            this.pl3_class_CB.TabIndex = 18;
            // 
            // pl3_main_RPD_lbl
            // 
            this.pl3_main_RPD_lbl.AutoSize = true;
            this.pl3_main_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl3_main_RPD_lbl.Location = new System.Drawing.Point(122, 94);
            this.pl3_main_RPD_lbl.Name = "pl3_main_RPD_lbl";
            this.pl3_main_RPD_lbl.Size = new System.Drawing.Size(155, 29);
            this.pl3_main_RPD_lbl.TabIndex = 0;
            this.pl3_main_RPD_lbl.Text = "Гравець №3";
            // 
            // pl3_name_RPD_lbl
            // 
            this.pl3_name_RPD_lbl.AutoSize = true;
            this.pl3_name_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl3_name_RPD_lbl.Location = new System.Drawing.Point(45, 165);
            this.pl3_name_RPD_lbl.Name = "pl3_name_RPD_lbl";
            this.pl3_name_RPD_lbl.Size = new System.Drawing.Size(134, 26);
            this.pl3_name_RPD_lbl.TabIndex = 2;
            this.pl3_name_RPD_lbl.Text = "Введіть ім\'я";
            // 
            // pl3_name_tbx
            // 
            this.pl3_name_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pl3_name_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl3_name_tbx.Location = new System.Drawing.Point(200, 162);
            this.pl3_name_tbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl3_name_tbx.Name = "pl3_name_tbx";
            this.pl3_name_tbx.Size = new System.Drawing.Size(150, 32);
            this.pl3_name_tbx.TabIndex = 16;
            this.pl3_name_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pl3_class_RPD_lbl
            // 
            this.pl3_class_RPD_lbl.AutoSize = true;
            this.pl3_class_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl3_class_RPD_lbl.Location = new System.Drawing.Point(45, 224);
            this.pl3_class_RPD_lbl.Name = "pl3_class_RPD_lbl";
            this.pl3_class_RPD_lbl.Size = new System.Drawing.Size(146, 26);
            this.pl3_class_RPD_lbl.TabIndex = 11;
            this.pl3_class_RPD_lbl.Text = "Оберіть клас";
            // 
            // pl4_panel_RPD
            // 
            this.pl4_panel_RPD.BackColor = System.Drawing.Color.Transparent;
            this.pl4_panel_RPD.BackgroundImage = global::Sword_and_flame.Properties.Resources.blue_banner;
            this.pl4_panel_RPD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl4_panel_RPD.Controls.Add(this.NGRD_pl4_error_lbl);
            this.pl4_panel_RPD.Controls.Add(this.pl4_class_CB);
            this.pl4_panel_RPD.Controls.Add(this.pl4_main_RPD_lbl);
            this.pl4_panel_RPD.Controls.Add(this.pl4_name_RPD_lbl);
            this.pl4_panel_RPD.Controls.Add(this.pl4_name_tbx);
            this.pl4_panel_RPD.Controls.Add(this.pl4_class_RPD_lbl);
            this.pl4_panel_RPD.Location = new System.Drawing.Point(1510, 100);
            this.pl4_panel_RPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl4_panel_RPD.Name = "pl4_panel_RPD";
            this.pl4_panel_RPD.Size = new System.Drawing.Size(400, 675);
            this.pl4_panel_RPD.TabIndex = 24;
            // 
            // NGRD_pl4_error_lbl
            // 
            this.NGRD_pl4_error_lbl.AutoSize = true;
            this.NGRD_pl4_error_lbl.Location = new System.Drawing.Point(56, 495);
            this.NGRD_pl4_error_lbl.Name = "NGRD_pl4_error_lbl";
            this.NGRD_pl4_error_lbl.Size = new System.Drawing.Size(50, 20);
            this.NGRD_pl4_error_lbl.TabIndex = 29;
            this.NGRD_pl4_error_lbl.Text = "label1";
            // 
            // pl4_class_CB
            // 
            this.pl4_class_CB.BackColor = System.Drawing.Color.DodgerBlue;
            this.pl4_class_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl4_class_CB.FormattingEnabled = true;
            this.pl4_class_CB.Items.AddRange(new object[] {
            "Воїн",
            "Паладін",
            "Лучник",
            "Чарівник"});
            this.pl4_class_CB.Location = new System.Drawing.Point(200, 224);
            this.pl4_class_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl4_class_CB.Name = "pl4_class_CB";
            this.pl4_class_CB.Size = new System.Drawing.Size(150, 34);
            this.pl4_class_CB.TabIndex = 19;
            // 
            // pl4_main_RPD_lbl
            // 
            this.pl4_main_RPD_lbl.AutoSize = true;
            this.pl4_main_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl4_main_RPD_lbl.Location = new System.Drawing.Point(122, 94);
            this.pl4_main_RPD_lbl.Name = "pl4_main_RPD_lbl";
            this.pl4_main_RPD_lbl.Size = new System.Drawing.Size(155, 29);
            this.pl4_main_RPD_lbl.TabIndex = 0;
            this.pl4_main_RPD_lbl.Text = "Гравець №4";
            // 
            // pl4_name_RPD_lbl
            // 
            this.pl4_name_RPD_lbl.AutoSize = true;
            this.pl4_name_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl4_name_RPD_lbl.Location = new System.Drawing.Point(45, 165);
            this.pl4_name_RPD_lbl.Name = "pl4_name_RPD_lbl";
            this.pl4_name_RPD_lbl.Size = new System.Drawing.Size(134, 26);
            this.pl4_name_RPD_lbl.TabIndex = 2;
            this.pl4_name_RPD_lbl.Text = "Введіть ім\'я";
            // 
            // pl4_name_tbx
            // 
            this.pl4_name_tbx.BackColor = System.Drawing.Color.DodgerBlue;
            this.pl4_name_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl4_name_tbx.Location = new System.Drawing.Point(200, 162);
            this.pl4_name_tbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl4_name_tbx.Name = "pl4_name_tbx";
            this.pl4_name_tbx.Size = new System.Drawing.Size(150, 32);
            this.pl4_name_tbx.TabIndex = 16;
            this.pl4_name_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pl4_class_RPD_lbl
            // 
            this.pl4_class_RPD_lbl.AutoSize = true;
            this.pl4_class_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl4_class_RPD_lbl.Location = new System.Drawing.Point(45, 224);
            this.pl4_class_RPD_lbl.Name = "pl4_class_RPD_lbl";
            this.pl4_class_RPD_lbl.Size = new System.Drawing.Size(146, 26);
            this.pl4_class_RPD_lbl.TabIndex = 11;
            this.pl4_class_RPD_lbl.Text = "Оберіть клас";
            // 
            // NGRD_pl1_error_lbl
            // 
            this.NGRD_pl1_error_lbl.AutoSize = true;
            this.NGRD_pl1_error_lbl.Location = new System.Drawing.Point(66, 514);
            this.NGRD_pl1_error_lbl.Name = "NGRD_pl1_error_lbl";
            this.NGRD_pl1_error_lbl.Size = new System.Drawing.Size(50, 20);
            this.NGRD_pl1_error_lbl.TabIndex = 25;
            this.NGRD_pl1_error_lbl.Text = "label1";
            this.NGRD_pl1_error_lbl.Click += new System.EventHandler(this.NGRD_error_lbl_Click);
            // 
            // pl1_panel_RPD
            // 
            this.pl1_panel_RPD.BackColor = System.Drawing.Color.Transparent;
            this.pl1_panel_RPD.BackgroundImage = global::Sword_and_flame.Properties.Resources.red_banner;
            this.pl1_panel_RPD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl1_panel_RPD.Controls.Add(this.pl1_class_CB);
            this.pl1_panel_RPD.Controls.Add(this.pl1_main_RPD_lbl);
            this.pl1_panel_RPD.Controls.Add(this.NGRD_pl1_error_lbl);
            this.pl1_panel_RPD.Controls.Add(this.pl1_name_RPD_lbl);
            this.pl1_panel_RPD.Controls.Add(this.pl1_name_tbx);
            this.pl1_panel_RPD.Controls.Add(this.pl1_class_RPD_lbl);
            this.pl1_panel_RPD.Location = new System.Drawing.Point(10, 100);
            this.pl1_panel_RPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl1_panel_RPD.Name = "pl1_panel_RPD";
            this.pl1_panel_RPD.Size = new System.Drawing.Size(400, 675);
            this.pl1_panel_RPD.TabIndex = 23;
            this.pl1_panel_RPD.Paint += new System.Windows.Forms.PaintEventHandler(this.pl1_panel_RPD_Paint);
            // 
            // pl1_class_CB
            // 
            this.pl1_class_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl1_class_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl1_class_CB.FormattingEnabled = true;
            this.pl1_class_CB.Items.AddRange(new object[] {
            "Воїн",
            "Паладін",
            "Лучник",
            "Чарівник"});
            this.pl1_class_CB.Location = new System.Drawing.Point(200, 224);
            this.pl1_class_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl1_class_CB.Name = "pl1_class_CB";
            this.pl1_class_CB.Size = new System.Drawing.Size(150, 34);
            this.pl1_class_CB.TabIndex = 17;
            this.pl1_class_CB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pl1_main_RPD_lbl
            // 
            this.pl1_main_RPD_lbl.AutoSize = true;
            this.pl1_main_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl1_main_RPD_lbl.Location = new System.Drawing.Point(122, 94);
            this.pl1_main_RPD_lbl.Name = "pl1_main_RPD_lbl";
            this.pl1_main_RPD_lbl.Size = new System.Drawing.Size(155, 29);
            this.pl1_main_RPD_lbl.TabIndex = 0;
            this.pl1_main_RPD_lbl.Text = "Гравець №1";
            this.pl1_main_RPD_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pl1_name_RPD_lbl
            // 
            this.pl1_name_RPD_lbl.AutoSize = true;
            this.pl1_name_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl1_name_RPD_lbl.Location = new System.Drawing.Point(45, 165);
            this.pl1_name_RPD_lbl.Name = "pl1_name_RPD_lbl";
            this.pl1_name_RPD_lbl.Size = new System.Drawing.Size(134, 26);
            this.pl1_name_RPD_lbl.TabIndex = 2;
            this.pl1_name_RPD_lbl.Text = "Введіть ім\'я";
            this.pl1_name_RPD_lbl.Click += new System.EventHandler(this.pl1_name_RPD_lbl_Click);
            // 
            // pl1_name_tbx
            // 
            this.pl1_name_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl1_name_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl1_name_tbx.Location = new System.Drawing.Point(200, 162);
            this.pl1_name_tbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl1_name_tbx.Name = "pl1_name_tbx";
            this.pl1_name_tbx.Size = new System.Drawing.Size(150, 32);
            this.pl1_name_tbx.TabIndex = 16;
            this.pl1_name_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pl1_class_RPD_lbl
            // 
            this.pl1_class_RPD_lbl.AutoSize = true;
            this.pl1_class_RPD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pl1_class_RPD_lbl.Location = new System.Drawing.Point(45, 224);
            this.pl1_class_RPD_lbl.Name = "pl1_class_RPD_lbl";
            this.pl1_class_RPD_lbl.Size = new System.Drawing.Size(146, 26);
            this.pl1_class_RPD_lbl.TabIndex = 11;
            this.pl1_class_RPD_lbl.Text = "Оберіть клас";
            // 
            // NGRD_back_btn
            // 
            this.NGRD_back_btn.BackColor = System.Drawing.SystemColors.Control;
            this.NGRD_back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NGRD_back_btn.Location = new System.Drawing.Point(100, 905);
            this.NGRD_back_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NGRD_back_btn.Name = "NGRD_back_btn";
            this.NGRD_back_btn.Size = new System.Drawing.Size(150, 100);
            this.NGRD_back_btn.TabIndex = 27;
            this.NGRD_back_btn.Text = "Назад";
            this.NGRD_back_btn.UseVisualStyleBackColor = false;
            this.NGRD_back_btn.Click += new System.EventHandler(this.NGGD_back_btn_Click);
            // 
            // NGRD_next_btn
            // 
            this.NGRD_next_btn.BackColor = System.Drawing.Color.White;
            this.NGRD_next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NGRD_next_btn.Location = new System.Drawing.Point(1670, 905);
            this.NGRD_next_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NGRD_next_btn.Name = "NGRD_next_btn";
            this.NGRD_next_btn.Size = new System.Drawing.Size(150, 100);
            this.NGRD_next_btn.TabIndex = 26;
            this.NGRD_next_btn.Text = "Далі";
            this.NGRD_next_btn.UseVisualStyleBackColor = false;
            this.NGRD_next_btn.Click += new System.EventHandler(this.NGRD_next_btn_Click);
            // 
            // RoleplayDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sword_and_flame.Properties.Resources.roleplay_details_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.NGRD_back_btn);
            this.Controls.Add(this.NGRD_next_btn);
            this.Controls.Add(this.pl2_panel_RPD);
            this.Controls.Add(this.pl3_panel_RPD);
            this.Controls.Add(this.pl4_panel_RPD);
            this.Controls.Add(this.pl1_panel_RPD);
            this.Controls.Add(this.RoleplayDetails_info);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoleplayDetails";
            this.Text = "RoleplayDetails";
            this.Load += new System.EventHandler(this.NGRoleplayDetails_Load);
            this.pl2_panel_RPD.ResumeLayout(false);
            this.pl2_panel_RPD.PerformLayout();
            this.pl3_panel_RPD.ResumeLayout(false);
            this.pl3_panel_RPD.PerformLayout();
            this.pl4_panel_RPD.ResumeLayout(false);
            this.pl4_panel_RPD.PerformLayout();
            this.pl1_panel_RPD.ResumeLayout(false);
            this.pl1_panel_RPD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pl1_main_RPD_lbl;
        private System.Windows.Forms.Label pl1_name_RPD_lbl;
        private System.Windows.Forms.Label pl1_class_RPD_lbl;
        private System.Windows.Forms.TextBox pl1_name_tbx;
        private System.Windows.Forms.Button RoleplayDetails_info;
        private System.Windows.Forms.Panel pl1_panel_RPD;
        private System.Windows.Forms.Panel pl2_panel_RPD;
        private System.Windows.Forms.Panel pl3_panel_RPD;
        private System.Windows.Forms.Label pl3_main_RPD_lbl;
        private System.Windows.Forms.Label pl3_name_RPD_lbl;
        private System.Windows.Forms.TextBox pl3_name_tbx;
        private System.Windows.Forms.Label pl3_class_RPD_lbl;
        private System.Windows.Forms.Label pl2_main_RPD_lbl;
        private System.Windows.Forms.Label pl2_name_RPD_lbl;
        private System.Windows.Forms.TextBox pl2_name_tbx;
        private System.Windows.Forms.Label pl2_class_RPD_lbl;
        private System.Windows.Forms.Panel pl4_panel_RPD;
        private System.Windows.Forms.Label pl4_main_RPD_lbl;
        private System.Windows.Forms.Label pl4_name_RPD_lbl;
        private System.Windows.Forms.TextBox pl4_name_tbx;
        private System.Windows.Forms.Label pl4_class_RPD_lbl;
        private System.Windows.Forms.Label NGRD_pl1_error_lbl;
        private System.Windows.Forms.ComboBox pl1_class_CB;
        private System.Windows.Forms.ComboBox pl3_class_CB;
        private System.Windows.Forms.ComboBox pl4_class_CB;
        private System.Windows.Forms.ComboBox pl2_class_CB;
        private System.Windows.Forms.Button NGRD_back_btn;
        private System.Windows.Forms.Button NGRD_next_btn;
        private System.Windows.Forms.Label NGRD_pl2_error_lbl;
        private System.Windows.Forms.Label NGRD_pl3_error_lbl;
        private System.Windows.Forms.Label NGRD_pl4_error_lbl;
    }
}