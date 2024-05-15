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
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(button7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 45);
            panel2.TabIndex = 13;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.FlatAppearance.BorderColor = Color.Gray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1344, 4);
            button7.Name = "button7";
            button7.Size = new Size(48, 34);
            button7.TabIndex = 3;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(224, 224, 224);
            button5.Location = new Point(1139, 83);
            button5.Name = "button5";
            button5.Size = new Size(160, 80);
            button5.TabIndex = 8;
            button5.Text = "Afdeling";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(899, 83);
            button4.Name = "button4";
            button4.Size = new Size(160, 80);
            button4.TabIndex = 9;
            button4.Text = "Ejendomsmægler";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(660, 83);
            button3.Name = "button3";
            button3.Size = new Size(160, 80);
            button3.TabIndex = 10;
            button3.Text = "Kunde";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(423, 83);
            button2.Name = "button2";
            button2.Size = new Size(160, 80);
            button2.TabIndex = 11;
            button2.Text = "Bolig";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 900);
            panel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(60, 72);
            button1.Name = "button1";
            button1.Size = new Size(182, 91);
            button1.TabIndex = 5;
            button1.Text = "LOGO";
            button1.UseVisualStyleBackColor = true;
            // 
            // AfdelingForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(panel2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AfdelingForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Afdeling";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Button button1;
    }
}