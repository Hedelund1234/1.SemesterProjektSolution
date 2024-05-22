namespace _1.SemesterProjekt
{
    partial class EjendomsmæglerForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjendomsmæglerForms));
            panel2 = new Panel();
            btnExit = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnOpret = new Button();
            comboBoxAfdeling = new ComboBox();
            btnSøg = new Button();
            label3 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtEjendomsmæglerId = new TextBox();
            txtNavn = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtTelefonnummer = new TextBox();
            btnLogo = new Button();
            dgvEjendomsmægler = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjendomsmægler).BeginInit();
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
            panel2.TabIndex = 19;
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 900);
            panel1.TabIndex = 18;
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
            button1.TabIndex = 30;
            button1.Text = "Bolig      ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.BackgroundImage = Properties.Resources.Ejendomsmægler;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(29, 358);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(194, 73);
            button2.TabIndex = 28;
            button2.Text = "               Ejendomsmægler";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(29, 457);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(194, 73);
            button3.TabIndex = 27;
            button3.Text = "Afdeling";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button4.TabIndex = 29;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(381, 862);
            btnOpret.Margin = new Padding(2);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(102, 30);
            btnOpret.TabIndex = 25;
            btnOpret.Text = "Gå til opret";
            btnOpret.UseVisualStyleBackColor = true;
            btnOpret.Click += btnOpret_Click;
            // 
            // comboBoxAfdeling
            // 
            comboBoxAfdeling.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAfdeling.FormattingEnabled = true;
            comboBoxAfdeling.Items.AddRange(new object[] { "", "1", "2", "3", "4", "5" });
            comboBoxAfdeling.Location = new Point(268, 554);
            comboBoxAfdeling.Margin = new Padding(2);
            comboBoxAfdeling.Name = "comboBoxAfdeling";
            comboBoxAfdeling.Size = new Size(214, 28);
            comboBoxAfdeling.TabIndex = 52;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(271, 862);
            btnSøg.Margin = new Padding(2);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(102, 30);
            btnSøg.TabIndex = 26;
            btnSøg.Text = "Søg";
            btnSøg.UseVisualStyleBackColor = true;
            btnSøg.Click += btnSøg_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 240);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 51;
            label3.Text = "Navn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 141);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 42;
            label1.Text = "Ejendomsmægler id";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(269, 457);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 532);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 44;
            label4.Text = "Afdeling";
            // 
            // txtEjendomsmæglerId
            // 
            txtEjendomsmæglerId.Location = new Point(268, 164);
            txtEjendomsmæglerId.Margin = new Padding(2);
            txtEjendomsmæglerId.Name = "txtEjendomsmæglerId";
            txtEjendomsmæglerId.Size = new Size(214, 27);
            txtEjendomsmæglerId.TabIndex = 48;
            // 
            // txtNavn
            // 
            txtNavn.Location = new Point(269, 262);
            txtNavn.Margin = new Padding(2);
            txtNavn.Name = "txtNavn";
            txtNavn.Size = new Size(214, 27);
            txtNavn.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 434);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 336);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 43;
            label2.Text = "Telefonnummer";
            // 
            // txtTelefonnummer
            // 
            txtTelefonnummer.Location = new Point(268, 358);
            txtTelefonnummer.Margin = new Padding(2);
            txtTelefonnummer.Name = "txtTelefonnummer";
            txtTelefonnummer.Size = new Size(214, 27);
            txtTelefonnummer.TabIndex = 50;
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
            btnLogo.TabIndex = 20;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // dgvEjendomsmægler
            // 
            dgvEjendomsmægler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEjendomsmægler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjendomsmægler.Location = new Point(487, 63);
            dgvEjendomsmægler.Margin = new Padding(2);
            dgvEjendomsmægler.Name = "dgvEjendomsmægler";
            dgvEjendomsmægler.RowHeadersWidth = 62;
            dgvEjendomsmægler.Size = new Size(902, 826);
            dgvEjendomsmægler.TabIndex = 58;
            dgvEjendomsmægler.CellDoubleClick += dgvEjendomsmægler_CellDoubleClick;
            dgvEjendomsmægler.ColumnHeaderMouseClick += dgvEjendomsmægler_ColumnHeaderMouseClick;
            // 
            // EjendomsmæglerForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(dgvEjendomsmægler);
            Controls.Add(comboBoxAfdeling);
            Controls.Add(btnLogo);
            Controls.Add(panel2);
            Controls.Add(btnOpret);
            Controls.Add(btnSøg);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtEjendomsmæglerId);
            Controls.Add(txtNavn);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txtTelefonnummer);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "EjendomsmæglerForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejendomsmægler";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEjendomsmægler).EndInit();
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
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtEjendomsmæglerId;
        private TextBox txtNavn;
        private Label label5;
        private Label label2;
        private TextBox txtTelefonnummer;
        private ComboBox comboBoxAfdeling;
        private Button btnOpret;
        private Button btnSøg;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvEjendomsmægler;
    }
}