﻿namespace _1.SemesterProjekt
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
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            btnLogo = new Button();
            label1 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dgvBolig = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBolig).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 112);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 40;
            label3.Text = "Email";
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(336, 783);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(267, 38);
            btnOpret.TabIndex = 22;
            btnOpret.Text = "Opret bolig";
            btnOpret.UseVisualStyleBackColor = true;
            // 
            // btnTilbage
            // 
            btnTilbage.Location = new Point(336, 850);
            btnTilbage.Name = "btnTilbage";
            btnTilbage.Size = new Size(101, 38);
            btnTilbage.TabIndex = 24;
            btnTilbage.Text = "Tilbage";
            btnTilbage.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 31);
            textBox2.TabIndex = 37;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 76);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 31);
            textBox4.TabIndex = 37;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(336, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(267, 31);
            textBox5.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 174);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 900);
            panel1.TabIndex = 26;
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
            btnLogo.TabIndex = 30;
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 48);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 25;
            label1.Text = "Navn";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(426, 264);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 29);
            checkBox2.TabIndex = 33;
            checkBox2.Text = "Sælger";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(340, 264);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(85, 29);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Køber";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 236);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 29;
            label4.Text = "Kunde type";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 45);
            panel2.TabIndex = 30;
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
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.Bolig;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(36, 205);
            button1.Name = "button1";
            button1.Size = new Size(242, 71);
            button1.TabIndex = 42;
            button1.Text = "Bolig      ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.Ejendomsmægler;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(36, 447);
            button2.Name = "button2";
            button2.Size = new Size(242, 71);
            button2.TabIndex = 40;
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
            button3.TabIndex = 39;
            button3.Text = "Afdeling";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(36, 327);
            button4.Name = "button4";
            button4.Size = new Size(242, 71);
            button4.TabIndex = 41;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = false;
            // 
            // dgvBolig
            // 
            dgvBolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolig.Location = new Point(609, 79);
            dgvBolig.Name = "dgvBolig";
            dgvBolig.RowHeadersWidth = 62;
            dgvBolig.Size = new Size(779, 809);
            dgvBolig.TabIndex = 61;
            // 
            // OpretKundeForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(dgvBolig);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(btnOpret);
            Controls.Add(btnTilbage);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OpretKundeForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpretKundeForms";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBolig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnOpret;
        private Button btnTilbage;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private Panel panel2;
        private Button btnExit;
        private Button btnLogo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvBolig;
    }
}