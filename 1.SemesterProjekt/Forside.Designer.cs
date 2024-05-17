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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forside));
            panel2 = new Panel();
            btnExit = new Button();
            panel1 = new Panel();
            btnBolig = new Button();
            btnEjendomsmægler = new Button();
            btnAfdeling = new Button();
            btnKunde = new Button();
            btnLogo = new Button();
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
            panel2.TabIndex = 19;
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
            panel1.Controls.Add(btnBolig);
            panel1.Controls.Add(btnEjendomsmægler);
            panel1.Controls.Add(btnAfdeling);
            panel1.Controls.Add(btnKunde);
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 900);
            panel1.TabIndex = 18;
            // 
            // btnBolig
            // 
            btnBolig.BackColor = Color.White;
            btnBolig.BackgroundImage = Properties.Resources.Bolig;
            btnBolig.BackgroundImageLayout = ImageLayout.None;
            btnBolig.Location = new Point(29, 164);
            btnBolig.Margin = new Padding(2);
            btnBolig.Name = "btnBolig";
            btnBolig.Size = new Size(194, 73);
            btnBolig.TabIndex = 18;
            btnBolig.Text = "Bolig      ";
            btnBolig.UseVisualStyleBackColor = false;
            btnBolig.Click += btnBolig_Click;
            // 
            // btnEjendomsmægler
            // 
            btnEjendomsmægler.BackColor = Color.White;
            btnEjendomsmægler.BackgroundImage = Properties.Resources.Ejendomsmægler;
            btnEjendomsmægler.BackgroundImageLayout = ImageLayout.None;
            btnEjendomsmægler.Location = new Point(29, 358);
            btnEjendomsmægler.Margin = new Padding(2);
            btnEjendomsmægler.Name = "btnEjendomsmægler";
            btnEjendomsmægler.Size = new Size(194, 73);
            btnEjendomsmægler.TabIndex = 16;
            btnEjendomsmægler.Text = "               Ejendomsmægler";
            btnEjendomsmægler.UseVisualStyleBackColor = false;
            btnEjendomsmægler.Click += btnEjendomsmægler_Click;
            // 
            // btnAfdeling
            // 
            btnAfdeling.BackgroundImage = (Image)resources.GetObject("btnAfdeling.BackgroundImage");
            btnAfdeling.BackgroundImageLayout = ImageLayout.None;
            btnAfdeling.Location = new Point(29, 457);
            btnAfdeling.Margin = new Padding(2);
            btnAfdeling.Name = "btnAfdeling";
            btnAfdeling.Size = new Size(194, 73);
            btnAfdeling.TabIndex = 15;
            btnAfdeling.Text = "Afdeling";
            btnAfdeling.UseVisualStyleBackColor = true;
            btnAfdeling.Click += btnAfdeling_Click;
            // 
            // btnKunde
            // 
            btnKunde.BackgroundImage = Properties.Resources.Kunde;
            btnKunde.BackgroundImageLayout = ImageLayout.None;
            btnKunde.Location = new Point(29, 262);
            btnKunde.Margin = new Padding(2);
            btnKunde.Name = "btnKunde";
            btnKunde.Size = new Size(194, 73);
            btnKunde.TabIndex = 17;
            btnKunde.Text = "Kunde   ";
            btnKunde.UseVisualStyleBackColor = true;
            btnKunde.Click += btnKunde_Click;
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
            btnLogo.Location = new Point(29, 34);
            btnLogo.Margin = new Padding(2);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(96, 96);
            btnLogo.TabIndex = 14;
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // Forside
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private Panel panel1;
        private Button btnLogo;
        private Button btnBolig;
        private Button btnEjendomsmægler;
        private Button btnAfdeling;
        private Button btnKunde;
    }
}
