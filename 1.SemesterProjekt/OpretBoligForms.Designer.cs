namespace _1.SemesterProjekt
{
    partial class OpretBoligForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpretBoligForms));
            btnExit = new Button();
            panel2 = new Panel();
            comboBoxType = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            btnBolig = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnLogo = new Button();
            txtPris = new TextBox();
            txtM2 = new TextBox();
            txtPostnummer = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBoxAfdeling = new ComboBox();
            label1 = new Label();
            btnOpret = new Button();
            btnTilbage = new Button();
            dgvKunde = new DataGridView();
            txtSælgerId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtEjendomsmæglerId = new TextBox();
            txtAdresse = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKunde).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.FlatAppearance.BorderColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1360, 4);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 27);
            btnExit.TabIndex = 16;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 36);
            panel2.TabIndex = 14;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "", "Hus", "Rækkehus", "Lejlighed", "Andelsbolig" });
            comboBoxType.Location = new Point(268, 187);
            comboBoxType.Margin = new Padding(2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(214, 28);
            comboBoxType.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 165);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 11;
            label3.Text = "Type";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnBolig);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 900);
            panel1.TabIndex = 13;
            // 
            // btnBolig
            // 
            btnBolig.BackColor = Color.FromArgb(224, 224, 224);
            btnBolig.BackgroundImage = Properties.Resources.Bolig;
            btnBolig.BackgroundImageLayout = ImageLayout.None;
            btnBolig.Location = new Point(29, 164);
            btnBolig.Margin = new Padding(2);
            btnBolig.Name = "btnBolig";
            btnBolig.Size = new Size(194, 73);
            btnBolig.TabIndex = 12;
            btnBolig.Text = "Bolig      ";
            btnBolig.UseVisualStyleBackColor = false;
            btnBolig.Click += btnBolig_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.Ejendomsmægler;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(29, 358);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(194, 73);
            button2.TabIndex = 14;
            button2.Text = "               Ejendomsmægler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(29, 457);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(194, 73);
            button3.TabIndex = 15;
            button3.Text = "Afdeling";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(29, 262);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(194, 73);
            button4.TabIndex = 13;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Silver;
            btnLogo.BackgroundImage = Properties.Resources.edcLogo3;
            btnLogo.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogo.FlatAppearance.BorderColor = Color.Silver;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Location = new Point(29, 34);
            btnLogo.Margin = new Padding(2);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(96, 96);
            btnLogo.TabIndex = 11;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // txtPris
            // 
            txtPris.Location = new Point(268, 532);
            txtPris.Margin = new Padding(2);
            txtPris.Name = "txtPris";
            txtPris.Size = new Size(214, 27);
            txtPris.TabIndex = 6;
            // 
            // txtM2
            // 
            txtM2.Location = new Point(268, 442);
            txtM2.Margin = new Padding(2);
            txtM2.Name = "txtM2";
            txtM2.Size = new Size(214, 27);
            txtM2.TabIndex = 5;
            // 
            // txtPostnummer
            // 
            txtPostnummer.Location = new Point(268, 349);
            txtPostnummer.Margin = new Padding(2);
            txtPostnummer.Name = "txtPostnummer";
            txtPostnummer.Size = new Size(214, 27);
            txtPostnummer.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 510);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Salgs pris";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 420);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 6;
            label6.Text = "Kvadratmeter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 326);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 6;
            label5.Text = "Postnummer";
            // 
            // comboBoxAfdeling
            // 
            comboBoxAfdeling.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAfdeling.FormattingEnabled = true;
            comboBoxAfdeling.Items.AddRange(new object[] { "", "Nordjylland", "Midtjylland", "Syddanmark", "Sjælland", "Hovedstaden" });
            comboBoxAfdeling.Location = new Point(268, 112);
            comboBoxAfdeling.Margin = new Padding(2);
            comboBoxAfdeling.Name = "comboBoxAfdeling";
            comboBoxAfdeling.Size = new Size(214, 28);
            comboBoxAfdeling.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 89);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 6;
            label1.Text = "Afdeling";
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(271, 816);
            btnOpret.Margin = new Padding(2);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(214, 30);
            btnOpret.TabIndex = 9;
            btnOpret.Text = "Opret bolig";
            btnOpret.UseVisualStyleBackColor = true;
            btnOpret.Click += btnOpret_Click;
            // 
            // btnTilbage
            // 
            btnTilbage.Location = new Point(271, 862);
            btnTilbage.Margin = new Padding(2);
            btnTilbage.Name = "btnTilbage";
            btnTilbage.Size = new Size(102, 30);
            btnTilbage.TabIndex = 10;
            btnTilbage.Text = "Tilbage";
            btnTilbage.UseVisualStyleBackColor = true;
            btnTilbage.Click += btnTilbage_Click;
            // 
            // dgvKunde
            // 
            dgvKunde.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKunde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKunde.Location = new Point(487, 112);
            dgvKunde.Margin = new Padding(2);
            dgvKunde.Name = "dgvKunde";
            dgvKunde.ReadOnly = true;
            dgvKunde.RowHeadersWidth = 62;
            dgvKunde.Size = new Size(902, 777);
            dgvKunde.TabIndex = 59;
            dgvKunde.TabStop = false;
            dgvKunde.ColumnHeaderMouseClick += dgvKunde_ColumnHeaderMouseClick;
            // 
            // txtSælgerId
            // 
            txtSælgerId.Location = new Point(268, 621);
            txtSælgerId.Margin = new Padding(2);
            txtSælgerId.Name = "txtSælgerId";
            txtSælgerId.Size = new Size(214, 27);
            txtSælgerId.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 598);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 60;
            label7.Text = "Kunde id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(268, 687);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 60;
            label8.Text = "Ejendomsmægler id";
            // 
            // txtEjendomsmæglerId
            // 
            txtEjendomsmæglerId.Location = new Point(268, 710);
            txtEjendomsmæglerId.Margin = new Padding(2);
            txtEjendomsmæglerId.Name = "txtEjendomsmæglerId";
            txtEjendomsmæglerId.Size = new Size(214, 27);
            txtEjendomsmæglerId.TabIndex = 8;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(268, 266);
            txtAdresse.Margin = new Padding(2);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(214, 27);
            txtAdresse.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 244);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "Adresse";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(599, 38);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(265, 41);
            label9.TabIndex = 62;
            label9.Text = "Oprettelse af bolig";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(487, 84);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(144, 28);
            label10.TabIndex = 62;
            label10.Text = "Kunde oversigt";
            // 
            // OpretBoligForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtEjendomsmæglerId);
            Controls.Add(txtSælgerId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvKunde);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(txtPris);
            Controls.Add(txtM2);
            Controls.Add(txtPostnummer);
            Controls.Add(panel1);
            Controls.Add(txtAdresse);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnTilbage);
            Controls.Add(label2);
            Controls.Add(btnOpret);
            Controls.Add(comboBoxAfdeling);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "OpretBoligForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpretBoligForm";
            Load += OpretBoligForms_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKunde).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Panel panel2;
        private ComboBox comboBoxType;
        private Label label3;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxAfdeling;
        private Label label1;
        private Button btnTilbage;
        private Button btnLogo;
        private TextBox txtM2;
        private TextBox txtPostnummer;
        private Button btnOpret;
        private TextBox txtPris;
        private Label label4;
        private Button btnBolig;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvKunde;
        private TextBox txtSælgerId;
        private Label label7;
        private Label label8;
        private TextBox txtEjendomsmæglerId;
        private TextBox txtAdresse;
        private Label label2;
        private Label label9;
        private Label label10;
    }
}