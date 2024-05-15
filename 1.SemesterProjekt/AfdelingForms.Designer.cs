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
            panel2 = new Panel();
            btnExit = new Button();
            btnAfdeling = new Button();
            btnEjendomsmægler = new Button();
            btnKunde = new Button();
            btnBolig = new Button();
            panel1 = new Panel();
            btnSøg = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnLogo = new Button();
            dgvAfdeling = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAfdeling).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 45);
            panel2.TabIndex = 13;
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
            // btnAfdeling
            // 
            btnAfdeling.BackColor = Color.FromArgb(224, 224, 224);
            btnAfdeling.Location = new Point(1139, 83);
            btnAfdeling.Name = "btnAfdeling";
            btnAfdeling.Size = new Size(160, 80);
            btnAfdeling.TabIndex = 8;
            btnAfdeling.Text = "Afdeling";
            btnAfdeling.UseVisualStyleBackColor = false;
            // 
            // btnEjendomsmægler
            // 
            btnEjendomsmægler.Location = new Point(899, 83);
            btnEjendomsmægler.Name = "btnEjendomsmægler";
            btnEjendomsmægler.Size = new Size(160, 80);
            btnEjendomsmægler.TabIndex = 9;
            btnEjendomsmægler.Text = "Ejendomsmægler";
            btnEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // btnKunde
            // 
            btnKunde.Location = new Point(660, 83);
            btnKunde.Name = "btnKunde";
            btnKunde.Size = new Size(160, 80);
            btnKunde.TabIndex = 10;
            btnKunde.Text = "Kunde";
            btnKunde.UseVisualStyleBackColor = true;
            // 
            // btnBolig
            // 
            btnBolig.BackColor = Color.White;
            btnBolig.Location = new Point(423, 83);
            btnBolig.Name = "btnBolig";
            btnBolig.Size = new Size(160, 80);
            btnBolig.TabIndex = 11;
            btnBolig.Text = "Bolig";
            btnBolig.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSøg);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 900);
            panel1.TabIndex = 12;
            // 
            // btnSøg
            // 
            btnSøg.Location = new Point(56, 829);
            btnSøg.Name = "btnSøg";
            btnSøg.Size = new Size(101, 38);
            btnSøg.TabIndex = 27;
            btnSøg.Text = "Søg";
            btnSøg.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(56, 269);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 33);
            comboBox2.TabIndex = 56;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 33);
            comboBox1.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 241);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 55;
            label3.Text = "Afdelings navn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 177);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 52;
            label1.Text = "Afdelings nummer";
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
            btnLogo.TabIndex = 14;
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // dgvAfdeling
            // 
            dgvAfdeling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAfdeling.Location = new Point(423, 205);
            dgvAfdeling.Name = "dgvAfdeling";
            dgvAfdeling.RowHeadersWidth = 62;
            dgvAfdeling.Size = new Size(876, 662);
            dgvAfdeling.TabIndex = 15;
            // 
            // AfdelingForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(dgvAfdeling);
            Controls.Add(btnLogo);
            Controls.Add(panel2);
            Controls.Add(btnAfdeling);
            Controls.Add(btnEjendomsmægler);
            Controls.Add(btnKunde);
            Controls.Add(btnBolig);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AfdelingForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Afdeling";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAfdeling).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Button btnAfdeling;
        private Button btnEjendomsmægler;
        private Button btnKunde;
        private Button btnBolig;
        private Panel panel1;
        private Button btnLogo;
        private DataGridView dgvAfdeling;
        private Label label3;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnSøg;
    }
}