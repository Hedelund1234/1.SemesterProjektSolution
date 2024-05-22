namespace _1.SemesterProjekt
{
    partial class OpretKundeForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpretKundeForms));
            label3 = new Label();
            btnOpret = new Button();
            btnTilbage = new Button();
            txtBoxTelefonnummerOpretKunde = new TextBox();
            txtBoxNavnOpretKunde = new TextBox();
            txtBoxEmailOpretKunde = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnLogo = new Button();
            label1 = new Label();
            checkBoxSælgerOpretKunde = new CheckBox();
            checkBoxKøberOpretKunde = new CheckBox();
            label4 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 239);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 40;
            label3.Text = "Email";
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(271, 816);
            btnOpret.Margin = new Padding(2);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(214, 30);
            btnOpret.TabIndex = 22;
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
            btnTilbage.TabIndex = 24;
            btnTilbage.Text = "Tilbage";
            btnTilbage.UseVisualStyleBackColor = true;
            btnTilbage.Click += btnTilbage_Click;
            // 
            // txtBoxTelefonnummerOpretKunde
            // 
            txtBoxTelefonnummerOpretKunde.Location = new Point(269, 358);
            txtBoxTelefonnummerOpretKunde.Name = "txtBoxTelefonnummerOpretKunde";
            txtBoxTelefonnummerOpretKunde.Size = new Size(267, 27);
            txtBoxTelefonnummerOpretKunde.TabIndex = 37;
            // 
            // txtBoxNavnOpretKunde
            // 
            txtBoxNavnOpretKunde.Location = new Point(269, 164);
            txtBoxNavnOpretKunde.Name = "txtBoxNavnOpretKunde";
            txtBoxNavnOpretKunde.Size = new Size(267, 27);
            txtBoxNavnOpretKunde.TabIndex = 37;
            // 
            // txtBoxEmailOpretKunde
            // 
            txtBoxEmailOpretKunde.Location = new Point(269, 262);
            txtBoxEmailOpretKunde.Name = "txtBoxEmailOpretKunde";
            txtBoxEmailOpretKunde.Size = new Size(267, 27);
            txtBoxEmailOpretKunde.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 335);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 25;
            label5.Text = "Telefonnummer";
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
            button1.TabIndex = 42;
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
            button2.TabIndex = 40;
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
            button3.TabIndex = 39;
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
            button4.TabIndex = 41;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            btnLogo.TabIndex = 30;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 141);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 25;
            label1.Text = "Navn";
            // 
            // checkBoxSælgerOpretKunde
            // 
            checkBoxSælgerOpretKunde.AutoSize = true;
            checkBoxSælgerOpretKunde.Location = new Point(359, 457);
            checkBoxSælgerOpretKunde.Name = "checkBoxSælgerOpretKunde";
            checkBoxSælgerOpretKunde.Size = new Size(77, 24);
            checkBoxSælgerOpretKunde.TabIndex = 33;
            checkBoxSælgerOpretKunde.Text = "Sælger";
            checkBoxSælgerOpretKunde.UseVisualStyleBackColor = true;
            checkBoxSælgerOpretKunde.CheckedChanged += checkBoxSælgerOpretKunde_CheckedChanged;
            // 
            // checkBoxKøberOpretKunde
            // 
            checkBoxKøberOpretKunde.AutoSize = true;
            checkBoxKøberOpretKunde.Location = new Point(273, 457);
            checkBoxKøberOpretKunde.Name = "checkBoxKøberOpretKunde";
            checkBoxKøberOpretKunde.Size = new Size(71, 24);
            checkBoxKøberOpretKunde.TabIndex = 34;
            checkBoxKøberOpretKunde.Text = "Køber";
            checkBoxKøberOpretKunde.UseVisualStyleBackColor = true;
            checkBoxKøberOpretKunde.CheckedChanged += checkBoxKøberOpretKunde_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 432);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 29;
            label4.Text = "Kunde type";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 36);
            panel2.TabIndex = 30;
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
            // OpretKundeForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(btnOpret);
            Controls.Add(btnTilbage);
            Controls.Add(panel1);
            Controls.Add(txtBoxTelefonnummerOpretKunde);
            Controls.Add(txtBoxNavnOpretKunde);
            Controls.Add(txtBoxEmailOpretKunde);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(checkBoxSælgerOpretKunde);
            Controls.Add(checkBoxKøberOpretKunde);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "OpretKundeForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpretKundeForms";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnOpret;
        private Button btnTilbage;
        private TextBox txtBoxTelefonnummerOpretKunde;
        private TextBox txtBoxNavnOpretKunde;
        private TextBox txtBoxEmailOpretKunde;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private CheckBox checkBoxSælgerOpretKunde;
        private CheckBox checkBoxKøberOpretKunde;
        private Label label4;
        private Panel panel2;
        private Button btnExit;
        private Button btnLogo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}