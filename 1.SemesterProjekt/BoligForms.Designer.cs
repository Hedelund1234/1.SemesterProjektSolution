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
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button8 = new Button();
            btnSøg = new Button();
            btnOpret = new Button();
            trackBar4 = new TrackBar();
            label9 = new Label();
            label6 = new Label();
            trackBar2 = new TrackBar();
            label10 = new Label();
            trackBar3 = new TrackBar();
            dgvBolig = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolig).BeginInit();
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
            panel1.Size = new Size(264, 720);
            panel1.TabIndex = 6;
            // 
            // btnBolig
            // 
            btnBolig.BackColor = Color.FromArgb(224, 224, 224);
            btnBolig.BackgroundImage = Properties.Resources.Bolig;
            btnBolig.BackgroundImageLayout = ImageLayout.None;
            btnBolig.Location = new Point(29, 164);
            btnBolig.Margin = new Padding(2);
            btnBolig.Name = "btnBolig";
            btnBolig.Size = new Size(194, 57);
            btnBolig.TabIndex = 17;
            btnBolig.Text = "Bolig      ";
            btnBolig.UseVisualStyleBackColor = false;
            // 
            // btnEjendomsmægler
            // 
            btnEjendomsmægler.BackgroundImage = Properties.Resources.Ejendomsmægler;
            btnEjendomsmægler.BackgroundImageLayout = ImageLayout.None;
            btnEjendomsmægler.Location = new Point(29, 358);
            btnEjendomsmægler.Margin = new Padding(2);
            btnEjendomsmægler.Name = "btnEjendomsmægler";
            btnEjendomsmægler.Size = new Size(194, 57);
            btnEjendomsmægler.TabIndex = 15;
            btnEjendomsmægler.Text = "               Ejendomsmægler";
            btnEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // btnAfdeling
            // 
            btnAfdeling.BackgroundImage = (Image)resources.GetObject("btnAfdeling.BackgroundImage");
            btnAfdeling.BackgroundImageLayout = ImageLayout.None;
            btnAfdeling.Location = new Point(29, 457);
            btnAfdeling.Margin = new Padding(2);
            btnAfdeling.Name = "btnAfdeling";
            btnAfdeling.Size = new Size(194, 57);
            btnAfdeling.TabIndex = 14;
            btnAfdeling.Text = "Afdeling";
            btnAfdeling.UseVisualStyleBackColor = true;
            // 
            // btnKunde
            // 
            btnKunde.BackgroundImage = Properties.Resources.Kunde;
            btnKunde.BackgroundImageLayout = ImageLayout.None;
            btnKunde.Location = new Point(29, 262);
            btnKunde.Margin = new Padding(2);
            btnKunde.Name = "btnKunde";
            btnKunde.Size = new Size(194, 57);
            btnKunde.TabIndex = 16;
            btnKunde.Text = "Kunde   ";
            btnKunde.UseVisualStyleBackColor = true;
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
            btnLogo.TabIndex = 13;
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.FlatAppearance.BorderColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1075, 3);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 27);
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
            panel2.Size = new Size(1120, 36);
            panel2.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Hus", "Rækkehus", "Lejlighed", "Andelsbolig" });
            comboBox2.Location = new Point(269, 114);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(209, 28);
            comboBox2.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 55;
            label3.Text = "Type";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(268, 611);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 27);
            textBox3.TabIndex = 54;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(268, 558);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 27);
            textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 166);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 52;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 2;
            trackBar1.Location = new Point(269, 263);
            trackBar1.Margin = new Padding(2);
            trackBar1.Maximum = 20;
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = RightToLeft.No;
            trackBar1.Size = new Size(205, 56);
            trackBar1.TabIndex = 50;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(341, 215);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 24);
            checkBox2.TabIndex = 48;
            checkBox2.Text = "Til salg";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(272, 215);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 24);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "Solgt";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 241);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 45;
            label5.Text = "Min pris";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 193);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 44;
            label4.Text = "Salgsstatus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(268, 589);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 43;
            label8.Text = "Kvadratmeter pris";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 535);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 42;
            label7.Text = "Søg adresse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 41;
            label2.Text = "Postnummer";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(269, 63);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 40;
            label1.Text = "Afdeling";
            // 
            // button8
            // 
            button8.Location = new Point(268, 645);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(209, 30);
            button8.TabIndex = 38;
            button8.Text = "Gem .CSV fil";
            button8.UseVisualStyleBackColor = true;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(268, 680);
            btnSøg.Margin = new Padding(2);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(102, 30);
            btnSøg.TabIndex = 39;
            btnSøg.Text = "Søg";
            btnSøg.UseVisualStyleBackColor = true;
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(374, 680);
            btnOpret.Margin = new Padding(2);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(102, 30);
            btnOpret.TabIndex = 37;
            btnOpret.Text = "Gå til opret";
            btnOpret.UseVisualStyleBackColor = true;
            btnOpret.Click += btnOpret_Click;
            // 
            // trackBar4
            // 
            trackBar4.LargeChange = 2;
            trackBar4.Location = new Point(269, 314);
            trackBar4.Margin = new Padding(2);
            trackBar4.Maximum = 20;
            trackBar4.Name = "trackBar4";
            trackBar4.RightToLeft = RightToLeft.No;
            trackBar4.Size = new Size(205, 56);
            trackBar4.TabIndex = 50;
            trackBar4.Value = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(269, 294);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 45;
            label9.Text = "Max pris";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 450);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 57;
            label6.Text = "Max kvadratmeter";
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 2;
            trackBar2.Location = new Point(268, 468);
            trackBar2.Margin = new Padding(2);
            trackBar2.Maximum = 20;
            trackBar2.Name = "trackBar2";
            trackBar2.RightToLeft = RightToLeft.No;
            trackBar2.Size = new Size(205, 56);
            trackBar2.TabIndex = 59;
            trackBar2.Value = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(268, 395);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 58;
            label10.Text = "Min kvadratmeter";
            // 
            // trackBar3
            // 
            trackBar3.LargeChange = 2;
            trackBar3.Location = new Point(268, 418);
            trackBar3.Margin = new Padding(2);
            trackBar3.Maximum = 20;
            trackBar3.Name = "trackBar3";
            trackBar3.RightToLeft = RightToLeft.No;
            trackBar3.Size = new Size(205, 56);
            trackBar3.TabIndex = 60;
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
            dgvBolig.Location = new Point(487, 63);
            dgvBolig.Margin = new Padding(2);
            dgvBolig.Name = "dgvBolig";
            dgvBolig.RowHeadersWidth = 62;
            dgvBolig.Size = new Size(623, 647);
            dgvBolig.TabIndex = 61;
            dgvBolig.CellDoubleClick += dgvBolig_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(268, 240);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 132);
            panel3.TabIndex = 62;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(267, 394);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 132);
            panel4.TabIndex = 63;
            // 
            // BoligForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 720);
            Controls.Add(dgvBolig);
            Controls.Add(label6);
            Controls.Add(trackBar2);
            Controls.Add(label10);
            Controls.Add(trackBar3);
            Controls.Add(label9);
            Controls.Add(trackBar4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(btnSøg);
            Controls.Add(btnOpret);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(trackBar1);
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
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolig).EndInit();
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
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button8;
        private Button btnSøg;
        private Button btnOpret;
        private TrackBar trackBar4;
        private Label label9;
        private Label label6;
        private TrackBar trackBar2;
        private Label label10;
        private TrackBar trackBar3;
        private DataGridView dgvBolig;
        private Panel panel3;
        private Panel panel4;
    }
}