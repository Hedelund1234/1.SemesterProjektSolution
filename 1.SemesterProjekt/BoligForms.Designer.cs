namespace _1.SemesterProjekt
{
    partial class BoligForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoligForms));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnBolig = new Button();
            btnEjendomsmægler = new Button();
            btnAfdeling = new Button();
            btnKunde = new Button();
            btnLogo = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            comboBoxType = new ComboBox();
            label3 = new Label();
            textBox3 = new TextBox();
            txtAdresse = new TextBox();
            txtPostnummer = new TextBox();
            tbMinPris = new TrackBar();
            cbTilSalg = new CheckBox();
            cbSolgt = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            comboBoxAfdeling = new ComboBox();
            label1 = new Label();
            button8 = new Button();
            btnSøg = new Button();
            btnOpret = new Button();
            tbMaxPris = new TrackBar();
            label9 = new Label();
            label6 = new Label();
            tbMaxM2 = new TrackBar();
            label10 = new Label();
            tbMinM2 = new TrackBar();
            dgvBolig = new DataGridView();
            panel3 = new Panel();
            lblMinpris = new Label();
            panel4 = new Panel();
            lblMinM2 = new Label();
            lblMaxpris = new Label();
            lblMaxM2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbMinPris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbMaxPris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbMaxM2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbMinM2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolig).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnBolig);
            panel1.Controls.Add(btnEjendomsmægler);
            panel1.Controls.Add(btnAfdeling);
            panel1.Controls.Add(btnKunde);
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 900);
            panel1.TabIndex = 6;
            // 
            // btnBolig
            // 
            btnBolig.BackColor = Color.FromArgb(224, 224, 224);
            btnBolig.BackgroundImage = Properties.Resources.Bolig;
            btnBolig.BackgroundImageLayout = ImageLayout.None;
            btnBolig.Location = new Point(36, 205);
            btnBolig.Margin = new Padding(2);
            btnBolig.Name = "btnBolig";
            btnBolig.Size = new Size(242, 71);
            btnBolig.TabIndex = 17;
            btnBolig.Text = "Bolig      ";
            btnBolig.UseVisualStyleBackColor = false;
            // 
            // btnEjendomsmægler
            // 
            btnEjendomsmægler.BackgroundImage = Properties.Resources.Ejendomsmægler;
            btnEjendomsmægler.BackgroundImageLayout = ImageLayout.None;
            btnEjendomsmægler.Location = new Point(36, 448);
            btnEjendomsmægler.Margin = new Padding(2);
            btnEjendomsmægler.Name = "btnEjendomsmægler";
            btnEjendomsmægler.Size = new Size(242, 71);
            btnEjendomsmægler.TabIndex = 15;
            btnEjendomsmægler.Text = "               Ejendomsmægler";
            btnEjendomsmægler.UseVisualStyleBackColor = true;
            btnEjendomsmægler.Click += btnEjendomsmægler_Click;
            // 
            // btnAfdeling
            // 
            btnAfdeling.BackgroundImage = (Image)resources.GetObject("btnAfdeling.BackgroundImage");
            btnAfdeling.BackgroundImageLayout = ImageLayout.None;
            btnAfdeling.Location = new Point(36, 571);
            btnAfdeling.Margin = new Padding(2);
            btnAfdeling.Name = "btnAfdeling";
            btnAfdeling.Size = new Size(242, 71);
            btnAfdeling.TabIndex = 14;
            btnAfdeling.Text = "Afdeling";
            btnAfdeling.UseVisualStyleBackColor = true;
            btnAfdeling.Click += btnAfdeling_Click;
            // 
            // btnKunde
            // 
            btnKunde.BackgroundImage = Properties.Resources.Kunde;
            btnKunde.BackgroundImageLayout = ImageLayout.None;
            btnKunde.Location = new Point(36, 328);
            btnKunde.Margin = new Padding(2);
            btnKunde.Name = "btnKunde";
            btnKunde.Size = new Size(242, 71);
            btnKunde.TabIndex = 16;
            btnKunde.Text = "Kunde   ";
            btnKunde.UseVisualStyleBackColor = true;
            btnKunde.Click += btnKunde_Click;
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
            btnLogo.Location = new Point(36, 42);
            btnLogo.Margin = new Padding(2);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(120, 120);
            btnLogo.TabIndex = 13;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.FlatAppearance.BorderColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1344, 4);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 34);
            btnExit.TabIndex = 3;
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
            panel2.Size = new Size(1400, 45);
            panel2.TabIndex = 7;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "", "Hus", "Rækkehus", "Lejlighed", "Andelsbolig" });
            comboBoxType.Location = new Point(269, 114);
            comboBoxType.Margin = new Padding(2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(209, 28);
            comboBoxType.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 55;
            label3.Text = "Type";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(335, 764);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 31);
            textBox3.TabIndex = 54;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(268, 558);
            txtAdresse.Margin = new Padding(2);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(210, 27);
            txtAdresse.TabIndex = 53;
            // 
            // txtPostnummer
            // 
            txtPostnummer.Location = new Point(269, 166);
            txtPostnummer.Margin = new Padding(2);
            txtPostnummer.Name = "txtPostnummer";
            txtPostnummer.Size = new Size(209, 27);
            txtPostnummer.TabIndex = 52;
            // 
            // tbMinPris
            // 
            tbMinPris.LargeChange = 2;
            tbMinPris.Location = new Point(269, 263);
            tbMinPris.Margin = new Padding(2);
            tbMinPris.Maximum = 20;
            tbMinPris.Name = "tbMinPris";
            tbMinPris.RightToLeft = RightToLeft.No;
            tbMinPris.Size = new Size(205, 56);
            tbMinPris.TabIndex = 50;
            tbMinPris.MouseUp += tbMinPris_MouseUp;
            // 
            // cbTilSalg
            // 
            cbTilSalg.AutoSize = true;
            cbTilSalg.Location = new Point(341, 215);
            cbTilSalg.Margin = new Padding(2);
            cbTilSalg.Name = "cbTilSalg";
            cbTilSalg.Size = new Size(78, 24);
            cbTilSalg.TabIndex = 48;
            cbTilSalg.Text = "Til salg";
            cbTilSalg.UseVisualStyleBackColor = true;
            // 
            // cbSolgt
            // 
            cbSolgt.AutoSize = true;
            cbSolgt.Location = new Point(272, 215);
            cbSolgt.Margin = new Padding(2);
            cbSolgt.Name = "cbSolgt";
            cbSolgt.Size = new Size(66, 24);
            cbSolgt.TabIndex = 49;
            cbSolgt.Text = "Solgt";
            cbSolgt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 301);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 45;
            label5.Text = "Min pris";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 241);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 44;
            label4.Text = "Salgsstatus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(335, 736);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 25);
            label8.TabIndex = 43;
            label8.Text = "Kvadratmeter pris";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 669);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 42;
            label7.Text = "Søg adresse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 179);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 41;
            label2.Text = "Postnummer";
            // 
            // comboBoxAfdeling
            // 
            comboBoxAfdeling.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAfdeling.FormattingEnabled = true;
            comboBoxAfdeling.Items.AddRange(new object[] { "", "Nordjylland", "Midtjylland", "Syddanmark", "Sjælland", "Hovedstaden" });
            comboBoxAfdeling.Location = new Point(269, 63);
            comboBoxAfdeling.Margin = new Padding(2);
            comboBoxAfdeling.Name = "comboBoxAfdeling";
            comboBoxAfdeling.Size = new Size(209, 28);
            comboBoxAfdeling.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 40;
            label1.Text = "Afdeling";
            // 
            // button8
            // 
            button8.Location = new Point(335, 806);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(261, 38);
            button8.TabIndex = 38;
            button8.Text = "Gem .CSV fil";
            button8.UseVisualStyleBackColor = true;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(335, 850);
            btnSøg.Margin = new Padding(2);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(128, 38);
            btnSøg.TabIndex = 39;
            btnSøg.Text = "Søg";
            btnSøg.UseVisualStyleBackColor = true;
            btnSøg.Click += btnSøg_Click;
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(468, 850);
            btnOpret.Margin = new Padding(2);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(128, 38);
            btnOpret.TabIndex = 37;
            btnOpret.Text = "Gå til opret";
            btnOpret.UseVisualStyleBackColor = true;
            btnOpret.Click += btnOpret_Click;
            // 
            // tbMaxPris
            // 
            tbMaxPris.LargeChange = 2;
            tbMaxPris.Location = new Point(269, 314);
            tbMaxPris.Margin = new Padding(2);
            tbMaxPris.Maximum = 20;
            tbMaxPris.Name = "tbMaxPris";
            tbMaxPris.RightToLeft = RightToLeft.No;
            tbMaxPris.Size = new Size(205, 56);
            tbMaxPris.TabIndex = 50;
            tbMaxPris.Value = 20;
            tbMaxPris.MouseUp += tbMaxPris_MouseUp;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(336, 368);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 45;
            label9.Text = "Max pris";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 562);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 57;
            label6.Text = "Max kvadratmeter";
            // 
            // tbMaxM2
            // 
            tbMaxM2.LargeChange = 2;
            tbMaxM2.Location = new Point(268, 468);
            tbMaxM2.Margin = new Padding(2);
            tbMaxM2.Maximum = 20;
            tbMaxM2.Name = "tbMaxM2";
            tbMaxM2.RightToLeft = RightToLeft.No;
            tbMaxM2.Size = new Size(205, 56);
            tbMaxM2.TabIndex = 59;
            tbMaxM2.Value = 20;
            tbMaxM2.MouseUp += tbMaxM2_MouseUp;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(335, 494);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(152, 25);
            label10.TabIndex = 58;
            label10.Text = "Min kvadratmeter";
            // 
            // tbMinM2
            // 
            tbMinM2.LargeChange = 2;
            tbMinM2.Location = new Point(268, 418);
            tbMinM2.Margin = new Padding(2);
            tbMinM2.Maximum = 20;
            tbMinM2.Name = "tbMinM2";
            tbMinM2.RightToLeft = RightToLeft.No;
            tbMinM2.Size = new Size(205, 56);
            tbMinM2.TabIndex = 60;
            tbMinM2.MouseUp += tbMinM2_MouseUp;
            // 
            // dgvBolig
            // 
            dgvBolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBolig.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBolig.Location = new Point(609, 79);
            dgvBolig.Margin = new Padding(2);
            dgvBolig.Name = "dgvBolig";
            dgvBolig.RowHeadersWidth = 62;
            dgvBolig.Size = new Size(779, 809);
            dgvBolig.TabIndex = 61;
            dgvBolig.CellDoubleClick += dgvBolig_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblMinpris);
            panel3.Location = new Point(268, 240);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 164);
            panel3.TabIndex = 62;
            // 
            // lblMinpris
            // 
            lblMinpris.AutoSize = true;
            lblMinpris.Location = new Point(89, 1);
            lblMinpris.Name = "lblMinpris";
            lblMinpris.Size = new Size(58, 20);
            lblMinpris.TabIndex = 65;
            lblMinpris.Text = "label11";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblMinM2);
            panel4.Location = new Point(267, 394);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 164);
            panel4.TabIndex = 63;
            // 
            // lblMinM2
            // 
            lblMinM2.AutoSize = true;
            lblMinM2.Location = new Point(135, 1);
            lblMinM2.Name = "lblMinM2";
            lblMinM2.Size = new Size(58, 20);
            lblMinM2.TabIndex = 0;
            lblMinM2.Text = "label11";
            // 
            // lblMaxpris
            // 
            lblMaxpris.AutoSize = true;
            lblMaxpris.Location = new Point(358, 295);
            lblMaxpris.Name = "lblMaxpris";
            lblMaxpris.Size = new Size(58, 20);
            lblMaxpris.TabIndex = 64;
            lblMaxpris.Text = "label11";
            // 
            // lblMaxM2
            // 
            lblMaxM2.AutoSize = true;
            lblMaxM2.Location = new Point(403, 451);
            lblMaxM2.Name = "lblMaxM2";
            lblMaxM2.Size = new Size(58, 20);
            lblMaxM2.TabIndex = 65;
            lblMaxM2.Text = "label12";
            // 
            // BoligForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 720);
            Controls.Add(lblMaxM2);
            Controls.Add(lblMaxpris);
            Controls.Add(dgvBolig);
            Controls.Add(label6);
            Controls.Add(tbMaxM2);
            Controls.Add(label10);
            Controls.Add(tbMinM2);
            Controls.Add(label9);
            Controls.Add(tbMaxPris);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(txtAdresse);
            Controls.Add(txtPostnummer);
            Controls.Add(cbTilSalg);
            Controls.Add(cbSolgt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(comboBoxAfdeling);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(btnSøg);
            Controls.Add(btnOpret);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(tbMinPris);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "BoligForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bolig";
            Load += BoligForms_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbMinPris).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbMaxPris).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbMaxM2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbMinM2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolig).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnExit;
        private Panel panel2;
        private Button btnLogo;
        private Button button9;
        private Button btnBolig;
        private Button btnEjendomsmægler;
        private Button btnAfdeling;
        private Button btnKunde;
        private ComboBox comboBoxType;
        private Label label3;
        private TextBox textBox3;
        private TextBox txtAdresse;
        private TextBox txtPostnummer;
        private TrackBar tbMinPris;
        private CheckBox cbTilSalg;
        private CheckBox cbSolgt;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label2;
        private ComboBox comboBoxAfdeling;
        private Label label1;
        private Button button8;
        private Button btnSøg;
        private Button btnOpret;
        private TrackBar tbMaxPris;
        private Label label9;
        private Label label6;
        private TrackBar tbMaxM2;
        private Label label10;
        private TrackBar tbMinM2;
        private DataGridView dgvBolig;
        private Panel panel3;
        private Panel panel4;
        private Label lblMinpris;
        private Label lblMaxpris;
        private Label lblMinM2;
        private Label lblMaxM2;
    }
}