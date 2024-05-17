﻿using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.SemesterProjekt
{
    public partial class BoligDetails : Form
    {
        int id;
        BoligDbHandler db;
        Bolig bolig;
        public BoligDetails(int id)
        {
            InitializeComponent();

            this.id = id;

            SeedData();
        }
        void SeedData()
        {
            db = new BoligDbHandler();
            bolig = db.Get(id);
            txtBoligId.Text = bolig.Bolig_Id.ToString();
            txtAdresse.Text = bolig.Adresse;
            txtPostnummer.Text = bolig.Postnummer.ToString();
            comboboxType.Text = bolig.Type;
            txtPris.Text = bolig.Udbudspris.ToString();
            txtStørrelse.Text = bolig.Størrelse.ToString();
            txtSælgerId.Text = bolig.Bolig_Kunde_Id.ToString();
            txtBoligEjendomsmæglerId.Text = bolig.Bolig_Ejendomsmægler_Id.ToString();
            comboboxSalgsstatus.Text = bolig.Salgsstatus;
            txtKøberId.Text = bolig.Bolig_Kunde_Id_Køber.ToString();
        }

        private void btnTilbage_Click(object sender, EventArgs e)
        {
            BoligForms boligforms = new BoligForms();
            boligforms.Show();
            this.Hide();
        }
    }
}
