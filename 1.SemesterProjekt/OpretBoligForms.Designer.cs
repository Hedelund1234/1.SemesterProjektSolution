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
            comboBox2 = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnLogo = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnOpret = new Button();
            btnTilbage = new Button();
            dgvKunde = new DataGridView();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
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
            panel2.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(336, 140);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(266, 33);
            comboBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 11;
            label3.Text = "Type";
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
            panel1.Size = new Size(330, 900);
            panel1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.BackgroundImage = Properties.Resources.Bolig;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(36, 205);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(242, 71);
            button1.TabIndex = 34;
            button1.Text = "Bolig      ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.Ejendomsmægler;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(36, 448);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(242, 71);
            button2.TabIndex = 32;
            button2.Text = "               Ejendomsmægler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(36, 571);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(242, 71);
            button3.TabIndex = 31;
            button3.Text = "Afdeling";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(36, 328);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(242, 71);
            button4.TabIndex = 33;
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
            btnLogo.Location = new Point(36, 42);
            btnLogo.Margin = new Padding(2);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(120, 120);
            btnLogo.TabIndex = 5;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 390);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(266, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 328);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(336, 266);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 31);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 362);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 6;
            label4.Text = "Pris";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 300);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 6;
            label6.Text = "Kvadratmeter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 238);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 6;
            label5.Text = "Postnummer";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(336, 76);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 33);
            comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 6;
            label1.Text = "Afdeling";
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(336, 782);
            btnOpret.Margin = new Padding(2);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(268, 38);
            btnOpret.TabIndex = 0;
            btnOpret.Text = "Opret bolig";
            btnOpret.UseVisualStyleBackColor = true;
            // 
            // btnTilbage
            // 
            btnTilbage.Location = new Point(336, 850);
            btnTilbage.Margin = new Padding(2);
            btnTilbage.Name = "btnTilbage";
            btnTilbage.Size = new Size(101, 38);
            btnTilbage.TabIndex = 0;
            btnTilbage.Text = "Tilbage";
            btnTilbage.UseVisualStyleBackColor = true;
            btnTilbage.Click += btnTilbage_Click;
            // 
            // dgvKunde
            // 
            dgvKunde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKunde.Location = new Point(609, 140);
            dgvKunde.Margin = new Padding(2);
            dgvKunde.Name = "dgvKunde";
            dgvKunde.RowHeadersWidth = 62;
            dgvKunde.Size = new Size(779, 748);
            dgvKunde.TabIndex = 59;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(336, 458);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(266, 31);
            textBox5.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 429);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 60;
            label7.Text = "Sælger id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 492);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(171, 25);
            label8.TabIndex = 60;
            label8.Text = "Ejendomsmægler id";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(336, 521);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(266, 31);
            textBox6.TabIndex = 61;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 204);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 31);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 176);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 6;
            label2.Text = "Adresse";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(749, 48);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(316, 48);
            label9.TabIndex = 62;
            label9.Text = "Oprettelse af bolig";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(609, 105);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(175, 32);
            label10.TabIndex = 62;
            label10.Text = "Kunde oversigt";
            // 
            // OpretBoligForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvKunde);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnTilbage);
            Controls.Add(label2);
            Controls.Add(btnOpret);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox2;
        private Label label3;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnTilbage;
        private Button btnLogo;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnOpret;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvKunde;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label label2;
        private Label label9;
        private Label label10;
    }
}