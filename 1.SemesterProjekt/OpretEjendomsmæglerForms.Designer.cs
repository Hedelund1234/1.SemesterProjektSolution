namespace _1.SemesterProjekt
{
    partial class OpretEjendomsmæglerForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpretEjendomsmæglerForms));
            btnOpret = new Button();
            ComboBox1 = new ComboBox();
            btnTilbage = new Button();
            label3 = new Label();
            btnLogo = new Button();
            txtEmail = new TextBox();
            txtNavn = new TextBox();
            label5 = new Label();
            txtTelefonNr = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label9 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(271, 816);
            btnOpret.Margin = new Padding(2);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(214, 30);
            btnOpret.TabIndex = 25;
            btnOpret.Text = "Opret Ejendomsmægler";
            btnOpret.UseVisualStyleBackColor = true;
            btnOpret.Click += btnOpret_Click;
            // 
            // ComboBox1
            // 
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "", "1", "2", "3", "4", "5" });
            ComboBox1.Location = new Point(269, 457);
            ComboBox1.Margin = new Padding(2);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(214, 28);
            ComboBox1.TabIndex = 52;
            // 
            // btnTilbage
            // 
            btnTilbage.Location = new Point(271, 862);
            btnTilbage.Margin = new Padding(2);
            btnTilbage.Name = "btnTilbage";
            btnTilbage.Size = new Size(102, 30);
            btnTilbage.TabIndex = 26;
            btnTilbage.Text = "Tilbage";
            btnTilbage.UseVisualStyleBackColor = true;
            btnTilbage.Click += btnTilbage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 142);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 51;
            label3.Text = "Navn";
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
            btnLogo.TabIndex = 28;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(271, 358);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 47;
            // 
            // txtNavn
            // 
            txtNavn.Location = new Point(269, 164);
            txtNavn.Margin = new Padding(2);
            txtNavn.Name = "txtNavn";
            txtNavn.Size = new Size(214, 27);
            txtNavn.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 336);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // txtTelefonNr
            // 
            txtTelefonNr.Location = new Point(268, 262);
            txtTelefonNr.Margin = new Padding(2);
            txtTelefonNr.Name = "txtTelefonNr";
            txtTelefonNr.Size = new Size(214, 27);
            txtTelefonNr.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 435);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 44;
            label4.Text = "Afdeling";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 240);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 43;
            label2.Text = "Telefonnummer";
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
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 36);
            panel2.TabIndex = 27;
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
            panel1.TabIndex = 26;
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
            button1.TabIndex = 38;
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
            button2.TabIndex = 36;
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
            button3.TabIndex = 35;
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
            button4.TabIndex = 37;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(599, 38);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(429, 41);
            label9.TabIndex = 63;
            label9.Text = "Oprettelse af Ejendomsmægler";
            // 
            // OpretEjendomsmæglerForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(label9);
            Controls.Add(btnOpret);
            Controls.Add(ComboBox1);
            Controls.Add(btnLogo);
            Controls.Add(btnTilbage);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(txtNavn);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txtTelefonNr);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "OpretEjendomsmæglerForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpretEjendomsmæglerForms";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpret;
        private ComboBox ComboBox1;
        private Button btnTilbage;
        private Label label3;
        private Button btnLogo;
        private TextBox txtEmail;
        private TextBox txtNavn;
        private Label label5;
        private TextBox txtTelefonNr;
        private Label label4;
        private Label label2;
        private Button btnExit;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label9;
    }
}