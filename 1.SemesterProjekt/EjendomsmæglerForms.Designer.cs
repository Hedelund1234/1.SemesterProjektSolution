﻿namespace _1.SemesterProjekt
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
            comboBox1 = new ComboBox();
            btnSøg = new Button();
            label3 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnLogo = new Button();
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
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 45);
            panel2.TabIndex = 19;
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
            button2.Location = new Point(36, 447);
            button2.Name = "button2";
            button2.Size = new Size(242, 71);
            button2.TabIndex = 28;
            button2.Text = "               Ejendomsmægler";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(36, 571);
            button3.Name = "button3";
            button3.Size = new Size(242, 71);
            button3.TabIndex = 27;
            button3.Text = "Afdeling";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(36, 327);
            button4.Name = "button4";
            button4.Size = new Size(242, 71);
            button4.TabIndex = 29;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(468, 850);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(128, 38);
            btnOpret.TabIndex = 25;
            btnOpret.Text = "Gå til opret";
            btnOpret.UseVisualStyleBackColor = true;
            btnOpret.Click += btnOpret_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(336, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 33);
            comboBox1.TabIndex = 52;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(336, 850);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(128, 38);
            btnSøg.TabIndex = 26;
            btnSøg.Text = "Søg";
            btnSøg.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 112);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 51;
            label3.Text = "Navn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 48);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 42;
            label1.Text = "Ejendomsmægler id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 31);
            textBox2.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 300);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 44;
            label4.Text = "Afdeling";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 76);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 31);
            textBox4.TabIndex = 48;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(336, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(267, 31);
            textBox5.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 238);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 176);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 43;
            label2.Text = "Telefonnummer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 31);
            textBox1.TabIndex = 50;
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
            // dgvBolig
            // 
            dgvBolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolig.Location = new Point(609, 79);
            dgvBolig.Name = "dgvBolig";
            dgvBolig.RowHeadersWidth = 62;
            dgvBolig.Size = new Size(779, 809);
            dgvBolig.TabIndex = 58;
            // 
            // EjendomsmæglerForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(dgvBolig);
            Controls.Add(comboBox1);
            Controls.Add(btnLogo);
            Controls.Add(panel2);
            Controls.Add(btnOpret);
            Controls.Add(btnSøg);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EjendomsmæglerForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejendomsmægler";
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
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btnOpret;
        private Button btnSøg;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvBolig;
    }
}