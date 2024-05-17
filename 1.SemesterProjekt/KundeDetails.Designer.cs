namespace _1.SemesterProjekt
{
    partial class KundeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundeDetails));
            panel2 = new Panel();
            btnExit = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnLogo = new Button();
            label1 = new Label();
            btnSletKunde = new Button();
            button6 = new Button();
            button5 = new Button();
            label2 = new Label();
            txtBoxKundeId = new TextBox();
            label3 = new Label();
            txtBoxKundeNavn = new TextBox();
            label4 = new Label();
            txtBoxKundeEmail = new TextBox();
            label5 = new Label();
            txtBoxKundeTelefonnummer = new TextBox();
            label6 = new Label();
            comboBoxKundeType = new ComboBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            panel2.TabIndex = 21;
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
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 900);
            panel1.TabIndex = 20;
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
            button1.TabIndex = 18;
            button1.Text = "Bolig      ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button2.TabIndex = 16;
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
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(29, 262);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(194, 73);
            button4.TabIndex = 17;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(599, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 22;
            label1.Text = "Kunde detaljer";
            // 
            // btnSletKunde
            // 
            btnSletKunde.Location = new Point(484, 862);
            btnSletKunde.Name = "btnSletKunde";
            btnSletKunde.Size = new Size(102, 30);
            btnSletKunde.TabIndex = 29;
            btnSletKunde.Text = "Slet";
            btnSletKunde.UseVisualStyleBackColor = true;
            btnSletKunde.Click += btnSletKunde_Click;
            // 
            // button6
            // 
            button6.Location = new Point(377, 862);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(102, 30);
            button6.TabIndex = 30;
            button6.Text = "Opdater";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(271, 862);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(102, 30);
            button5.TabIndex = 31;
            button5.Text = "Tilbage";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 142);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 32;
            label2.Text = "Kunde id";
            // 
            // txtBoxKundeId
            // 
            txtBoxKundeId.Enabled = false;
            txtBoxKundeId.Location = new Point(271, 165);
            txtBoxKundeId.Name = "txtBoxKundeId";
            txtBoxKundeId.Size = new Size(230, 27);
            txtBoxKundeId.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 221);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 32;
            label3.Text = "Navn";
            // 
            // txtBoxKundeNavn
            // 
            txtBoxKundeNavn.Location = new Point(271, 244);
            txtBoxKundeNavn.Name = "txtBoxKundeNavn";
            txtBoxKundeNavn.Size = new Size(230, 27);
            txtBoxKundeNavn.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 307);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 32;
            label4.Text = "Email";
            // 
            // txtBoxKundeEmail
            // 
            txtBoxKundeEmail.Location = new Point(270, 330);
            txtBoxKundeEmail.Name = "txtBoxKundeEmail";
            txtBoxKundeEmail.Size = new Size(230, 27);
            txtBoxKundeEmail.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 384);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 32;
            label5.Text = "Telefonnummer";
            // 
            // txtBoxKundeTelefonnummer
            // 
            txtBoxKundeTelefonnummer.Location = new Point(271, 407);
            txtBoxKundeTelefonnummer.Name = "txtBoxKundeTelefonnummer";
            txtBoxKundeTelefonnummer.Size = new Size(230, 27);
            txtBoxKundeTelefonnummer.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 465);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 34;
            label6.Text = "Kunde type";
            // 
            // comboBoxKundeType
            // 
            comboBoxKundeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKundeType.FormattingEnabled = true;
            comboBoxKundeType.Items.AddRange(new object[] { "", "Køber", "Sælger" });
            comboBoxKundeType.Location = new Point(271, 488);
            comboBoxKundeType.MaxDropDownItems = 3;
            comboBoxKundeType.Name = "comboBoxKundeType";
            comboBoxKundeType.Size = new Size(231, 28);
            comboBoxKundeType.TabIndex = 35;
            // 
            // KundeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(comboBoxKundeType);
            Controls.Add(label6);
            Controls.Add(txtBoxKundeTelefonnummer);
            Controls.Add(txtBoxKundeEmail);
            Controls.Add(txtBoxKundeNavn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBoxKundeId);
            Controls.Add(label2);
            Controls.Add(btnSletKunde);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "KundeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundeDetaljer";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnLogo;
        private Label label1;
        private Button btnSletKunde;
        private Button button6;
        private Button button5;
        private Label label2;
        private TextBox txtBoxKundeId;
        private Label label3;
        private TextBox txtBoxKundeNavn;
        private Label label4;
        private TextBox txtBoxKundeEmail;
        private Label label5;
        private TextBox txtBoxKundeTelefonnummer;
        private Label label6;
        private ComboBox comboBoxKundeType;
    }
}