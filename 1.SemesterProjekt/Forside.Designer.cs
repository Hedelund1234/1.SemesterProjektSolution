namespace _1.SemesterProjekt
{
    partial class Forside
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            btnLogo = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnAfdeling.BackColor = Color.White;
            btnAfdeling.Location = new Point(1139, 83);
            btnAfdeling.Name = "btnAfdeling";
            btnAfdeling.Size = new Size(160, 80);
            btnAfdeling.TabIndex = 14;
            btnAfdeling.Text = "Afdeling";
            btnAfdeling.UseVisualStyleBackColor = false;
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
            // btnKunde
            // 
            btnKunde.Location = new Point(660, 83);
            btnKunde.Name = "btnKunde";
            btnKunde.Size = new Size(160, 80);
            btnKunde.TabIndex = 16;
            btnKunde.Text = "Kunde";
            btnKunde.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 900);
            panel1.TabIndex = 18;
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
            // Forside
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(panel2);
            Controls.Add(btnAfdeling);
            Controls.Add(btnEjendomsmægler);
            Controls.Add(btnKunde);
            Controls.Add(btnBolig);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forside";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
    }
}
