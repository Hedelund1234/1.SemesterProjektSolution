namespace _1.SemesterProjekt
{
    partial class AfdelingDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfdelingDetails));
            panel2 = new Panel();
            btnExit = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            AfdelingFormsDetails = new Button();
            button4 = new Button();
            btnLogo = new Button();
            button5 = new Button();
            label1 = new Label();
            comboBoxAfdelingsDetailsSøg = new ComboBox();
            label2 = new Label();
            txtBoxAfdelingNrDetails = new TextBox();
            txtBoxAfdelingsNavnDetails = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dgvAfdelingsDetails = new DataGridView();
            btnCsvUdprint = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAfdelingsDetails).BeginInit();
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
            panel2.TabIndex = 21;
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(AfdelingFormsDetails);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 900);
            panel1.TabIndex = 20;
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
            button1.TabIndex = 18;
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
            button2.TabIndex = 16;
            button2.Text = "               Ejendomsmægler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AfdelingFormsDetails
            // 
            AfdelingFormsDetails.BackColor = Color.FromArgb(224, 224, 224);
            AfdelingFormsDetails.BackgroundImage = (Image)resources.GetObject("AfdelingFormsDetails.BackgroundImage");
            AfdelingFormsDetails.BackgroundImageLayout = ImageLayout.None;
            AfdelingFormsDetails.Location = new Point(29, 457);
            AfdelingFormsDetails.Margin = new Padding(2);
            AfdelingFormsDetails.Name = "AfdelingFormsDetails";
            AfdelingFormsDetails.Size = new Size(194, 73);
            AfdelingFormsDetails.TabIndex = 15;
            AfdelingFormsDetails.Text = "Afdeling";
            AfdelingFormsDetails.UseVisualStyleBackColor = false;
            AfdelingFormsDetails.Click += AfdelingFormsDetails_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Kunde;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(29, 262);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(194, 73);
            button4.TabIndex = 17;
            button4.Text = "Kunde   ";
            button4.UseVisualStyleBackColor = true;
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
            btnLogo.TabIndex = 14;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // button5
            // 
            button5.Location = new Point(268, 862);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(102, 30);
            button5.TabIndex = 32;
            button5.Text = "Tilbage";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(775, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 41);
            label1.TabIndex = 35;
            label1.Text = "Afdelings detaljer";
            // 
            // comboBoxAfdelingsDetailsSøg
            // 
            comboBoxAfdelingsDetailsSøg.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAfdelingsDetailsSøg.FormattingEnabled = true;
            comboBoxAfdelingsDetailsSøg.Items.AddRange(new object[] { "Bolig", "Ejendomsmægler" });
            comboBoxAfdelingsDetailsSøg.Location = new Point(268, 164);
            comboBoxAfdelingsDetailsSøg.Margin = new Padding(2);
            comboBoxAfdelingsDetailsSøg.Name = "comboBoxAfdelingsDetailsSøg";
            comboBoxAfdelingsDetailsSøg.Size = new Size(211, 28);
            comboBoxAfdelingsDetailsSøg.TabIndex = 57;
            comboBoxAfdelingsDetailsSøg.DropDownClosed += comboBoxAfdelingsDetailsSøg_DropDownClosed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 142);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 58;
            label2.Text = "Søg";
            // 
            // txtBoxAfdelingNrDetails
            // 
            txtBoxAfdelingNrDetails.Enabled = false;
            txtBoxAfdelingNrDetails.Location = new Point(268, 262);
            txtBoxAfdelingNrDetails.Margin = new Padding(2);
            txtBoxAfdelingNrDetails.Name = "txtBoxAfdelingNrDetails";
            txtBoxAfdelingNrDetails.Size = new Size(211, 27);
            txtBoxAfdelingNrDetails.TabIndex = 59;
            // 
            // txtBoxAfdelingsNavnDetails
            // 
            txtBoxAfdelingsNavnDetails.Enabled = false;
            txtBoxAfdelingsNavnDetails.Location = new Point(268, 358);
            txtBoxAfdelingsNavnDetails.Margin = new Padding(2);
            txtBoxAfdelingsNavnDetails.Name = "txtBoxAfdelingsNavnDetails";
            txtBoxAfdelingsNavnDetails.Size = new Size(211, 27);
            txtBoxAfdelingsNavnDetails.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 240);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 58;
            label3.Text = "Afdelings nummer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 336);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 58;
            label4.Text = "Afdelings navn";
            // 
            // dgvAfdelingsDetails
            // 
            dgvAfdelingsDetails.AllowUserToAddRows = false;
            dgvAfdelingsDetails.AllowUserToDeleteRows = false;
            dgvAfdelingsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvAfdelingsDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAfdelingsDetails.Location = new Point(483, 79);
            dgvAfdelingsDetails.Margin = new Padding(2);
            dgvAfdelingsDetails.Name = "dgvAfdelingsDetails";
            dgvAfdelingsDetails.ReadOnly = true;
            dgvAfdelingsDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvAfdelingsDetails.Size = new Size(902, 810);
            dgvAfdelingsDetails.TabIndex = 22;
            // 
            // btnCsvUdprint
            // 
            btnCsvUdprint.Location = new Point(268, 828);
            btnCsvUdprint.Margin = new Padding(2);
            btnCsvUdprint.Name = "btnCsvUdprint";
            btnCsvUdprint.Size = new Size(211, 30);
            btnCsvUdprint.TabIndex = 60;
            btnCsvUdprint.Text = "Udprint .csv";
            btnCsvUdprint.UseVisualStyleBackColor = true;
            btnCsvUdprint.Click += btnCsvUdprint_Click;
            // 
            // AfdelingDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(btnCsvUdprint);
            Controls.Add(txtBoxAfdelingsNavnDetails);
            Controls.Add(txtBoxAfdelingNrDetails);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxAfdelingsDetailsSøg);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(dgvAfdelingsDetails);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AfdelingDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AfdelingDetails";
            Load += AfdelingDetails_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAfdelingsDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button AfdelingFormsDetails;
        private Button button4;
        private Button btnLogo;
        private Button button5;
        private Label label1;
        private ComboBox comboBoxAfdelingsDetailsSøg;
        private Label label2;
        private TextBox txtBoxAfdelingNrDetails;
        private TextBox txtBoxAfdelingsNavnDetails;
        private Label label3;
        private Label label4;
        private DataGridView dgvAfdelingsDetails;
        private Button btnCsvUdprint;
    }
}