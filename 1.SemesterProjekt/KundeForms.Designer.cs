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
            dgvKunde = new DataGridView();
            btnLogo = new Button();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            btnSøg = new Button();
            btnOpret = new Button();
            label3 = new Label();
            panel1 = new Panel();
            btnKunde = new Button();
            btnEjendomsmægler = new Button();
            btnAfdeling = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            btnBolig = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKunde).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKunde
            // 
            dgvKunde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKunde.Location = new Point(423, 205);
            dgvKunde.Name = "dgvKunde";
            dgvKunde.RowHeadersWidth = 62;
            dgvKunde.Size = new Size(876, 662);
            dgvKunde.TabIndex = 21;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Silver;
            btnLogo.BackgroundImage = Properties.Resources.edcLogo3;
            btnLogo.FlatAppearance.BorderColor = Color.Silver;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Location = new Point(103, 54);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(120, 120);
            btnLogo.TabIndex = 20;
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 429);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 29;
            label4.Text = "Kunde type";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(60, 457);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(85, 29);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Køber";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(146, 457);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 29);
            checkBox2.TabIndex = 33;
            checkBox2.Text = "Sælger";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 305);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 26;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 177);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 25;
            label1.Text = "Kunde id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 333);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 31);
            textBox1.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 367);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 25;
            label5.Text = "Telefonnummer";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(56, 269);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 31);
            textBox5.TabIndex = 37;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 31);
            textBox4.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 395);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 31);
            textBox2.TabIndex = 37;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(56, 829);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(101, 38);
            btnSøg.TabIndex = 24;
            btnSøg.Text = "Søg";
            btnSøg.UseVisualStyleBackColor = true;
            // 
            // btnOpret
            // 
            btnOpret.Location = new Point(174, 829);
            btnOpret.Name = "btnOpret";
            btnOpret.Size = new Size(103, 38);
            btnOpret.TabIndex = 22;
            btnOpret.Text = "Opret bolig";
            btnOpret.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 241);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 40;
            label3.Text = "Navn";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnOpret);
            panel1.Controls.Add(btnSøg);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 900);
            panel1.TabIndex = 18;
            // 
            // btnKunde
            // 
            btnKunde.BackColor = Color.FromArgb(224, 224, 224);
            btnKunde.Location = new Point(660, 83);
            btnKunde.Name = "btnKunde";
            btnKunde.Size = new Size(160, 80);
            btnKunde.TabIndex = 16;
            btnKunde.Text = "Kunde";
            btnKunde.UseVisualStyleBackColor = false;
            // 
            // btnEjendomsmægler
            // 
            btnEjendomsmægler.Location = new Point(899, 83);
            btnEjendomsmægler.Name = "btnEjendomsmægler";
            btnEjendomsmægler.Size = new Size(160, 80);
            btnEjendomsmægler.TabIndex = 15;
            btnEjendomsmægler.Text = "Ejendomsmægler";
            btnEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // btnAfdeling
            // 
            btnAfdeling.BackColor = Color.White;
            btnAfdeling.Location = new Point(1139, 83);
            btnAfdeling.Name = "btnAfdeling";
            btnAfdeling.Size = new Size(160, 80);
            btnAfdeling.TabIndex = 14;
            btnAfdeling.Text = "Afdeling";
            btnAfdeling.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gray;
            btnExit.FlatAppearance.BorderColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1344, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 45);
            panel2.TabIndex = 19;
            // 
            // btnBolig
            // 
            btnBolig.BackColor = Color.White;
            btnBolig.Location = new Point(423, 83);
            btnBolig.Name = "btnBolig";
            btnBolig.Size = new Size(160, 80);
            btnBolig.TabIndex = 17;
            btnBolig.Text = "Bolig";
            btnBolig.UseVisualStyleBackColor = false;
            // 
            // KundeForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(dgvKunde);
            Controls.Add(btnLogo);
            Controls.Add(panel2);
            Controls.Add(btnAfdeling);
            Controls.Add(btnEjendomsmægler);
            Controls.Add(btnKunde);
            Controls.Add(btnBolig);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KundeForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kunde";
            ((System.ComponentModel.ISupportInitialize)dgvKunde).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKunde;
        private Button btnLogo;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private Button btnSøg;
        private Button btnOpret;
        private Label label3;
        private Panel panel1;
        private Button btnKunde;
        private Button btnEjendomsmægler;
        private Button btnAfdeling;
        private Button btnExit;
        private Panel panel2;
        private Button btnBolig;
    }
}