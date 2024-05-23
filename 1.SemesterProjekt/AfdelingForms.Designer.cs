namespace _1.SemesterProjekt
{
    partial class AfdelingForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfdelingForms));
            panel2 = new Panel();
            btnExit = new Button();
            panel1 = new Panel();
            btnLogo = new Button();
            btnSøg = new Button();
            comboBoxAfdelingsNavn = new ComboBox();
            comboBoxAfdelingsNr = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dgvBolig = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBolig).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 36);
            panel2.TabIndex = 13;
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
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 900);
            panel1.TabIndex = 12;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Silver;
            btnLogo.BackgroundImage = Properties.Resources.edcLogo3;
            btnLogo.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogo.FlatAppearance.BorderColor = Color.Silver;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Location = new Point(29, 34);
            btnLogo.Margin = new Padding(2);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(96, 96);
            btnLogo.TabIndex = 14;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(268, 859);
            btnSøg.Margin = new Padding(2);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(102, 30);
            btnSøg.TabIndex = 27;
            btnSøg.Text = "Vis alle afdelinger";
            btnSøg.UseVisualStyleBackColor = true;
            btnSøg.Click += btnSøg_Click;
            // 
            // comboBoxAfdelingsNavn
            // 
            comboBoxAfdelingsNavn.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAfdelingsNavn.FormattingEnabled = true;
            comboBoxAfdelingsNavn.Items.AddRange(new object[] { "Nordjylland", "Midtjylland", "Syddanmark", "Sjælland", "Hovedstaden" });
            comboBoxAfdelingsNavn.Location = new Point(268, 262);
            comboBoxAfdelingsNavn.Margin = new Padding(2);
            comboBoxAfdelingsNavn.Name = "comboBoxAfdelingsNavn";
            comboBoxAfdelingsNavn.Size = new Size(211, 28);
            comboBoxAfdelingsNavn.TabIndex = 56;
            comboBoxAfdelingsNavn.DropDownClosed += comboBoxAfdelingsNavn_DropDownClosed;
            // 
            // comboBoxAfdelingsNr
            // 
            comboBoxAfdelingsNr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAfdelingsNr.FormattingEnabled = true;
            comboBoxAfdelingsNr.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxAfdelingsNr.Location = new Point(268, 164);
            comboBoxAfdelingsNr.Margin = new Padding(2);
            comboBoxAfdelingsNr.Name = "comboBoxAfdelingsNr";
            comboBoxAfdelingsNr.Size = new Size(211, 28);
            comboBoxAfdelingsNr.TabIndex = 56;
            comboBoxAfdelingsNr.DropDownClosed += comboBoxAfdelingsNr_DropDownClosed;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 240);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 55;
            label3.Text = "Afdelings navn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 142);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 52;
            label1.Text = "Afdelings nummer";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.Bolig;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(29, 164);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(194, 73);
            button1.TabIndex = 62;
            button1.Text = "Bolig      ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Ejendomsmægler;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(29, 358);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(194, 73);
            button2.TabIndex = 60;
            button2.Text = "               Ejendomsmægler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(29, 457);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(194, 73);
            button3.TabIndex = 59;
            button3.Text = "Afdeling";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(29, 262);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(194, 73);
            button4.TabIndex = 61;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dgvBolig
            // 
            dgvBolig.AllowUserToAddRows = false;
            dgvBolig.AllowUserToDeleteRows = false;
            dgvBolig.AllowUserToOrderColumns = true;
            dgvBolig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolig.Location = new Point(483, 79);
            dgvBolig.Margin = new Padding(2);
            dgvBolig.Name = "dgvBolig";
            dgvBolig.RowHeadersWidth = 62;
            dgvBolig.Size = new Size(902, 810);
            dgvBolig.TabIndex = 63;
            dgvBolig.CellDoubleClick += dgvBolig_CellDoubleClick;
            dgvBolig.ColumnHeaderMouseClick += dgvBolig_ColumnHeaderMouseClick;
            // 
            // AfdelingForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dgvBolig);
            Controls.Add(btnSøg);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBoxAfdelingsNavn);
            Controls.Add(label1);
            Controls.Add(comboBoxAfdelingsNr);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AfdelingForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Afdeling";
            Load += AfdelingForms_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBolig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Panel panel1;
        private Button btnLogo;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxAfdelingsNavn;
        private ComboBox comboBoxAfdelingsNr;
        private Button btnSøg;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvBolig;
    }
}