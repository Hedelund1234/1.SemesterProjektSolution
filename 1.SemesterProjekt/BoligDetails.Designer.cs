﻿namespace _1.SemesterProjekt
{
    partial class BoligDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoligDetails));
            panel2 = new Panel();
            btnExit = new Button();
            panel1 = new Panel();
            btnBolig = new Button();
            btnEjendomsmægler = new Button();
            btnAfdeling = new Button();
            btnKunde = new Button();
            btnLogo = new Button();
            txtBoligId = new TextBox();
            label1 = new Label();
            txtAdresse = new TextBox();
            label2 = new Label();
            txtPostnummer = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboboxType = new ComboBox();
            txtPris = new TextBox();
            label5 = new Label();
            txtStørrelse = new TextBox();
            label6 = new Label();
            txtSælgerId = new TextBox();
            label7 = new Label();
            txtBoligEjendomsmæglerId = new TextBox();
            label8 = new Label();
            txtKøberId = new TextBox();
            label11 = new Label();
            label12 = new Label();
            dgvKunder = new DataGridView();
            comboboxSalgsstatus = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            btnTilbage = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label14 = new Label();
            comboBoxAfdelingBoligDetails = new ComboBox();
            dtpBoligDetails = new DateTimePicker();
            cbHandelsdato = new CheckBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKunder).BeginInit();
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
            btnExit.Click += btnExit_Click_1;
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
            panel1.TabIndex = 20;
            // 
            // btnBolig
            // 
            btnBolig.BackColor = Color.FromArgb(224, 224, 224);
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
            btnLogo.Click += btnLogo_Click_1;
            // 
            // txtBoligId
            // 
            txtBoligId.Enabled = false;
            txtBoligId.Location = new Point(269, 164);
            txtBoligId.Margin = new Padding(2);
            txtBoligId.Name = "txtBoligId";
            txtBoligId.Size = new Size(183, 27);
            txtBoligId.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 142);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 23;
            label1.Text = "Bolig id";
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(269, 214);
            txtAdresse.Margin = new Padding(2);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(183, 27);
            txtAdresse.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 191);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 23;
            label2.Text = "Adresse";
            // 
            // txtPostnummer
            // 
            txtPostnummer.Location = new Point(269, 267);
            txtPostnummer.Margin = new Padding(2);
            txtPostnummer.Name = "txtPostnummer";
            txtPostnummer.Size = new Size(183, 27);
            txtPostnummer.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 242);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 23;
            label3.Text = "Postnummer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 294);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 23;
            label4.Text = "Type";
            // 
            // comboboxType
            // 
            comboboxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxType.FormattingEnabled = true;
            comboboxType.Items.AddRange(new object[] { "", "Hus", "Rækkehus", "Lejlighed", "Andelsbolig" });
            comboboxType.Location = new Point(269, 317);
            comboboxType.Margin = new Padding(2);
            comboboxType.Name = "comboboxType";
            comboboxType.Size = new Size(183, 28);
            comboboxType.TabIndex = 24;
            // 
            // txtPris
            // 
            txtPris.Location = new Point(269, 368);
            txtPris.Margin = new Padding(2);
            txtPris.Name = "txtPris";
            txtPris.Size = new Size(183, 27);
            txtPris.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 346);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 23;
            label5.Text = "Pris";
            // 
            // txtStørrelse
            // 
            txtStørrelse.Location = new Point(269, 418);
            txtStørrelse.Margin = new Padding(2);
            txtStørrelse.Name = "txtStørrelse";
            txtStørrelse.Size = new Size(183, 27);
            txtStørrelse.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 395);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 23;
            label6.Text = "Størrelse";
            // 
            // txtSælgerId
            // 
            txtSælgerId.Location = new Point(269, 467);
            txtSælgerId.Margin = new Padding(2);
            txtSælgerId.Name = "txtSælgerId";
            txtSælgerId.Size = new Size(183, 27);
            txtSælgerId.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 445);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 23;
            label7.Text = "Sælger id";
            // 
            // txtBoligEjendomsmæglerId
            // 
            txtBoligEjendomsmæglerId.Location = new Point(269, 517);
            txtBoligEjendomsmæglerId.Margin = new Padding(2);
            txtBoligEjendomsmæglerId.Name = "txtBoligEjendomsmæglerId";
            txtBoligEjendomsmæglerId.Size = new Size(183, 27);
            txtBoligEjendomsmæglerId.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(269, 494);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(181, 20);
            label8.TabIndex = 23;
            label8.Text = "Bolig ejendomsmægler id";
            // 
            // txtKøberId
            // 
            txtKøberId.Location = new Point(474, 267);
            txtKøberId.Margin = new Padding(2);
            txtKøberId.Name = "txtKøberId";
            txtKøberId.Size = new Size(199, 27);
            txtKøberId.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(474, 244);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 23;
            label11.Text = "Køber id";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(474, 345);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 23;
            label12.Text = "Handels dato";
            // 
            // dgvKunder
            // 
            dgvKunder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKunder.Location = new Point(682, 164);
            dgvKunder.Margin = new Padding(2);
            dgvKunder.Name = "dgvKunder";
            dgvKunder.RowHeadersWidth = 62;
            dgvKunder.Size = new Size(707, 725);
            dgvKunder.TabIndex = 26;
            // 
            // comboboxSalgsstatus
            // 
            comboboxSalgsstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxSalgsstatus.FormattingEnabled = true;
            comboboxSalgsstatus.Items.AddRange(new object[] { "", "Solgt", "Til salg" });
            comboboxSalgsstatus.Location = new Point(474, 214);
            comboboxSalgsstatus.Margin = new Padding(2);
            comboboxSalgsstatus.Name = "comboboxSalgsstatus";
            comboboxSalgsstatus.Size = new Size(199, 28);
            comboboxSalgsstatus.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(474, 192);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 23;
            label9.Text = "Salgsstatus";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(775, 38);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(192, 41);
            label10.TabIndex = 23;
            label10.Text = "Bolig detaljer";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(682, 135);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(144, 28);
            label13.TabIndex = 23;
            label13.Text = "Kunde oversigt";
            // 
            // btnTilbage
            // 
            btnTilbage.Location = new Point(270, 862);
            btnTilbage.Margin = new Padding(2);
            btnTilbage.Name = "btnTilbage";
            btnTilbage.Size = new Size(90, 27);
            btnTilbage.TabIndex = 28;
            btnTilbage.Text = "Tilbage";
            btnTilbage.UseVisualStyleBackColor = true;
            btnTilbage.Click += btnTilbage_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(364, 862);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Opdater";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(458, 862);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Slet";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(474, 142);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 23;
            label14.Text = "Afdeling";
            // 
            // comboBoxAfdelingBoligDetails
            // 
            comboBoxAfdelingBoligDetails.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAfdelingBoligDetails.FormattingEnabled = true;
            comboBoxAfdelingBoligDetails.Items.AddRange(new object[] { "", "Nordjylland", "Midtjylland", "Syddanmark", "Sjælland", "Hovedstaden" });
            comboBoxAfdelingBoligDetails.Location = new Point(474, 164);
            comboBoxAfdelingBoligDetails.Margin = new Padding(2);
            comboBoxAfdelingBoligDetails.Name = "comboBoxAfdelingBoligDetails";
            comboBoxAfdelingBoligDetails.Size = new Size(199, 28);
            comboBoxAfdelingBoligDetails.TabIndex = 27;
            // 
            // dtpBoligDetails
            // 
            dtpBoligDetails.Location = new Point(474, 368);
            dtpBoligDetails.MaxDate = new DateTime(2100, 1, 31, 0, 0, 0, 0);
            dtpBoligDetails.MinDate = new DateTime(1899, 1, 1, 0, 0, 0, 0);
            dtpBoligDetails.Name = "dtpBoligDetails";
            dtpBoligDetails.Size = new Size(199, 27);
            dtpBoligDetails.TabIndex = 29;
            dtpBoligDetails.Visible = false;
            // 
            // cbHandelsdato
            // 
            cbHandelsdato.AutoSize = true;
            cbHandelsdato.Location = new Point(474, 311);
            cbHandelsdato.Name = "cbHandelsdato";
            cbHandelsdato.Size = new Size(151, 24);
            cbHandelsdato.TabIndex = 30;
            cbHandelsdato.Text = "Tilføj handelsdato";
            cbHandelsdato.UseVisualStyleBackColor = true;
            cbHandelsdato.CheckedChanged += cbHandelsdato_CheckedChanged;
            // 
            // BoligDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(cbHandelsdato);
            Controls.Add(dtpBoligDetails);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnTilbage);
            Controls.Add(comboBoxAfdelingBoligDetails);
            Controls.Add(comboboxSalgsstatus);
            Controls.Add(dgvKunder);
            Controls.Add(comboboxType);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtBoligEjendomsmæglerId);
            Controls.Add(label3);
            Controls.Add(txtSælgerId);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(txtStørrelse);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(txtPris);
            Controls.Add(txtPostnummer);
            Controls.Add(txtKøberId);
            Controls.Add(txtAdresse);
            Controls.Add(txtBoligId);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "BoligDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BoligDetails";
            Load += BoligDetails_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKunder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Panel panel1;
        private Button btnBolig;
        private Button btnEjendomsmægler;
        private Button btnAfdeling;
        private Button btnKunde;
        private Button btnLogo;
        private TextBox txtBoligId;
        private Label label1;
        private TextBox txtAdresse;
        private Label label2;
        private TextBox txtPostnummer;
        private Label label3;
        private Label label4;
        private ComboBox comboboxType;
        private TextBox txtPris;
        private Label label5;
        private TextBox txtStørrelse;
        private Label label6;
        private TextBox txtSælgerId;
        private Label label7;
        private TextBox txtBoligEjendomsmæglerId;
        private Label label8;
        private TextBox txtKøberId;
        private Label label11;
        private Label label12;
        private DataGridView dgvKunder;
        private ComboBox comboboxSalgsstatus;
        private Label label9;
        private Label label10;
        private Label label13;
        private Button btnTilbage;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label14;
        private ComboBox comboBoxAfdelingBoligDetails;
        private DateTimePicker dtpBoligDetails;
        private CheckBox cbHandelsdato;
    }
}