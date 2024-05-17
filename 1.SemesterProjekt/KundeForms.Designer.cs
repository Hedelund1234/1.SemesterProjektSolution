namespace _1.SemesterProjekt
{
    partial class KundeForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundeForms));
            btnLogo = new Button();
            btnSøg = new Button();
            btnOpret = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            label4 = new Label();
            cBoxKundeKøber = new CheckBox();
            cBoxKundeSælger = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtBoxKundeEmail = new TextBox();
            label5 = new Label();
            txtBoxKundeNavn = new TextBox();
            txtBoxKundeId = new TextBox();
            txtBoxKundeTelefonnummer = new TextBox();
            label3 = new Label();
            dgvBolig = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBolig).BeginInit();
            SuspendLayout();
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Silver;
            btnLogo.BackgroundImage = Properties.Resources.edcLogo3;
            btnLogo.FlatAppearance.BorderColor = Color.Silver;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Location = new Point(36, 43);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(120, 120);
            btnLogo.TabIndex = 20;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(336, 850);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(128, 38);
            btnSøg.TabIndex = 24;
            btnSøg.Text = "Søg";
            btnSøg.UseVisualStyleBackColor = true;
            btnSøg.Click += btnSøg_Click;
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(475, 850);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(128, 38);
            btnOpret.TabIndex = 22;
            btnOpret.Text = "Gå til opret";
            btnOpret.UseVisualStyleBackColor = true;
            btnOpret.Click += btnOpret_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 900);
            panel1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.Bolig;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(36, 205);
            button1.Name = "button1";
            button1.Size = new Size(242, 71);
            button1.TabIndex = 29;
            button1.Text = "Bolig      ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Ejendomsmægler;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(36, 447);
            button2.Name = "button2";
            button2.Size = new Size(242, 71);
            button2.TabIndex = 27;
            button2.Text = "               Ejendomsmægler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(36, 571);
            button3.Name = "button3";
            button3.Size = new Size(242, 71);
            button3.TabIndex = 26;
            button3.Text = "Afdeling";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(36, 327);
            button4.Name = "button4";
            button4.Size = new Size(242, 71);
            button4.TabIndex = 28;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.FlatAppearance.BorderColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1344, 4);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 45);
            panel2.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 301);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 29;
            label4.Text = "Kunde type";
            // 
            // cBoxKundeKøber
            // 
            cBoxKundeKøber.AutoSize = true;
            cBoxKundeKøber.Location = new Point(340, 329);
            cBoxKundeKøber.Name = "cBoxKundeKøber";
            cBoxKundeKøber.Size = new Size(85, 29);
            cBoxKundeKøber.TabIndex = 34;
            cBoxKundeKøber.Text = "Køber";
            cBoxKundeKøber.UseVisualStyleBackColor = true;
            cBoxKundeKøber.CheckedChanged += cBoxKundeKøber_CheckedChanged;
            // 
            // cBoxKundeSælger
            // 
            cBoxKundeSælger.AutoSize = true;
            cBoxKundeSælger.Location = new Point(426, 329);
            cBoxKundeSælger.Name = "cBoxKundeSælger";
            cBoxKundeSælger.Size = new Size(93, 29);
            cBoxKundeSælger.TabIndex = 33;
            cBoxKundeSælger.Text = "Sælger";
            cBoxKundeSælger.UseVisualStyleBackColor = true;
            cBoxKundeSælger.CheckedChanged += cBoxKundeSælger_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 177);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 26;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 49);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 25;
            label1.Text = "Kunde id";
            // 
            // txtBoxKundeEmail
            // 
            txtBoxKundeEmail.Location = new Point(336, 205);
            txtBoxKundeEmail.Name = "txtBoxKundeEmail";
            txtBoxKundeEmail.Size = new Size(267, 31);
            txtBoxKundeEmail.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 239);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 25;
            label5.Text = "Telefonnummer";
            // 
            // txtBoxKundeNavn
            // 
            txtBoxKundeNavn.Location = new Point(336, 141);
            txtBoxKundeNavn.Name = "txtBoxKundeNavn";
            txtBoxKundeNavn.Size = new Size(267, 31);
            txtBoxKundeNavn.TabIndex = 37;
            // 
            // txtBoxKundeId
            // 
            txtBoxKundeId.Location = new Point(336, 77);
            txtBoxKundeId.Name = "txtBoxKundeId";
            txtBoxKundeId.Size = new Size(267, 31);
            txtBoxKundeId.TabIndex = 37;
            // 
            // txtBoxKundeTelefonnummer
            // 
            txtBoxKundeTelefonnummer.Location = new Point(336, 267);
            txtBoxKundeTelefonnummer.Name = "txtBoxKundeTelefonnummer";
            txtBoxKundeTelefonnummer.Size = new Size(267, 31);
            txtBoxKundeTelefonnummer.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 40;
            label3.Text = "Navn";
            // 
            // dgvBolig
            // 
            dgvBolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolig.Location = new Point(609, 79);
            dgvBolig.Name = "dgvBolig";
            dgvBolig.RowHeadersWidth = 62;
            dgvBolig.Size = new Size(779, 809);
            dgvBolig.TabIndex = 58;
            dgvBolig.CellDoubleClick += dgvBolig_CellDoubleClick;
            // 
            // KundeForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(dgvBolig);
            Controls.Add(label3);
            Controls.Add(btnLogo);
            Controls.Add(panel2);
            Controls.Add(btnOpret);
            Controls.Add(btnSøg);
            Controls.Add(panel1);
            Controls.Add(txtBoxKundeTelefonnummer);
            Controls.Add(label1);
            Controls.Add(txtBoxKundeId);
            Controls.Add(label4);
            Controls.Add(txtBoxKundeNavn);
            Controls.Add(cBoxKundeKøber);
            Controls.Add(label5);
            Controls.Add(cBoxKundeSælger);
            Controls.Add(txtBoxKundeEmail);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KundeForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kunde";
            Load += KundeForms_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBolig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogo;
        private Button btnSøg;
        private Button btnOpret;
        private Panel panel1;
        private Button btnExit;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private CheckBox cBoxKundeKøber;
        private CheckBox cBoxKundeSælger;
        private Label label2;
        private Label label1;
        private TextBox txtBoxKundeEmail;
        private Label label5;
        private TextBox txtBoxKundeNavn;
        private TextBox txtBoxKundeId;
        private TextBox txtBoxKundeTelefonnummer;
        private Label label3;
        private DataGridView dgvBolig;
    }
}