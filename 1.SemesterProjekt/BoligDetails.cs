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
        BoligDbHandler db = new BoligDbHandler();
        KundeDbHandler kdb = new KundeDbHandler();
        EjendomsmæglerDbHandler edb = new EjendomsmæglerDbHandler();
        Ejendomsmægler ejendomsmægler = new Ejendomsmægler();
        Bolig bolig = new Bolig();
        Kunde boligsælger = new Kunde();
        Kunde boligkøber = new Kunde();
        Kunde kunde = new Kunde();
        List<Kunde> kl = new List<Kunde>();
        public BoligDetails(int id)
        {
            InitializeComponent();

            this.id = id;

            SeedData();
        }
        void SeedData()
        {
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
            comboBoxAfdelingBoligDetails.Text = bolig.Bolig_Afdelings_Navn;
            txtKøberId.Text = bolig.Bolig_Kunde_Id_Køber.ToString();
        }

        private void btnTilbage_Click(object sender, EventArgs e)
        {
            BoligForms boligforms = new BoligForms();
            boligforms.Show();
            this.Hide();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KundeForms kunde = new KundeForms();
            kunde.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EjendomsmæglerForms ejendomsmægler = new EjendomsmæglerForms();
            ejendomsmægler.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AfdelingForms afdeling = new AfdelingForms();
            afdeling.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoligDetails_Load(object sender, EventArgs e)
        {
            kl = kdb.Get();
            dgvKunder.DataSource = kl;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool bolig_IdBool = int.TryParse(txtBoligId.Text, out int bolig_IdInt);
            bool postnummerBool = int.TryParse(txtPostnummer.Text, out int postnummerInt);
            bool udbudsprisBool = int.TryParse(txtPris.Text, out int prisInt);
            bool størrelseBool = int.TryParse(txtStørrelse.Text, out int størrelseInt);
            bool bolig_Kunde_IdBool = int.TryParse(txtSælgerId.Text, out int bolig_Kunde_IdInt);
            bool bolig_Ejendomsmægler_IdBool = int.TryParse(txtBoligEjendomsmæglerId.Text, out int bolig_Ejendomsmægler_IdInt);
            bool bolig_Kunde_Id_KøberBool = int.TryParse(txtKøberId.Text, out int bolig_Kunde_Id_KøberInt);
            boligsælger = kdb.Get(bolig_Kunde_IdInt);
            ejendomsmægler = edb.Get(bolig_Ejendomsmægler_IdInt);
            boligkøber = kdb.Get(bolig_Kunde_Id_KøberInt);

            if (txtAdresse.Text.Length > 50) //Mangler fuldendt validering. Se -> OpretBoligForms.cs
            {
                MessageBox.Show("Adressen kan maksimalt være 50 karaktere lang!");
                txtAdresse.Text = bolig.Adresse;
            }
            else if (!postnummerBool || postnummerInt < 999 || postnummerInt > 10000)
            {
                MessageBox.Show("Postnummer skal være 4 cifret tal");
                txtPostnummer.Text = bolig.Postnummer.ToString();
            }
            else if (!udbudsprisBool || prisInt > 5000001)
            {
                MessageBox.Show("Prisen kan maksimalt være 5000000kr.");
                txtPris.Text = bolig.Udbudspris.ToString();
            }
            else if (!størrelseBool || størrelseInt > 301)
            {
                MessageBox.Show("Størrelsen kan maksimalt være 300 kvadratmeter!");
                txtStørrelse.Text = bolig.Størrelse.ToString();
            }
            else if (!bolig_Kunde_IdBool)
            {
                MessageBox.Show("Du må kun indtaste tal!");
                txtSælgerId.Text = bolig.Bolig_Kunde_Id.ToString();
            }
            else if (boligsælger.Kunde_Id == 0)
            {
                MessageBox.Show("Sælgeren skal være oprettet som kunde før du kan tilføje personens id her!");
                txtSælgerId.Text = bolig.Bolig_Kunde_Id.ToString();
            }
            else if (!bolig_Ejendomsmægler_IdBool)
            {
                MessageBox.Show("Du må kun indtaste tal!");
                txtSælgerId.Text = bolig.Bolig_Ejendomsmægler_Id.ToString();
            }
            else if (ejendomsmægler.Id == 0)
            {
                MessageBox.Show("Ejendomsmægleren skal være oprettet som ejendomsmægler før du kan tilføjet personens id her!");
                txtBoligEjendomsmæglerId.Text = bolig.Bolig_Ejendomsmægler_Id.ToString();
            }
            else if (!bolig_Kunde_Id_KøberBool)
            {
                MessageBox.Show("Du må kun indtaste tal!");
                txtBoligEjendomsmæglerId.Text = bolig.Bolig_Kunde_Id_Køber.ToString();
            }
            else if (boligkøber.Kunde_Id > 0 && boligkøber.Kunde_Id < 1)/*lambda max value) *///Mangler korrekt validering ??!?!?!?!?!!!?!?!?!?
            {
                    MessageBox.Show("Køberen skal være oprettet som kunde før du kan tilføje personens id her!");
                    txtKøberId.Text = bolig.Bolig_Kunde_Id_Køber.ToString();
            }
            else if (comboBoxAfdelingBoligDetails.Text.Length == 0)
            {
                MessageBox.Show("Boligen skal være tilsluttet en afdeling!");
                comboBoxAfdelingBoligDetails.Text = bolig.Bolig_Afdelings_Navn;
            }
            else if (comboboxType.Text.Length == 0)
            {
                MessageBox.Show("Boligen skal gives en type!");
                comboboxType.Text = bolig.Type;
            }
            else if (comboboxSalgsstatus.Text.Length == 0)
            {
                MessageBox.Show("Boligen skal have en salgsstatus!");
                comboboxSalgsstatus.Text = bolig.Salgsstatus;
            }
            else if (MessageBox.Show($"Er du sikker på at du vil gemme ændringerne?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int boligid = bolig.Bolig_Id;
                string adresse = txtAdresse.Text;
                int postnummer = postnummerInt;
                string type = comboboxType.Text;
                int udbudspris = prisInt;
                int størrelse = størrelseInt;
                int bolig_Kunde_Id = bolig_Kunde_IdInt;
                int bolig_Ejendomsmægler_Id = bolig_Ejendomsmægler_IdInt;
                string bolig_Afdelings_Navn = comboBoxAfdelingBoligDetails.Text;
                string salgsstatus = comboboxSalgsstatus.Text;
                int bolig_Kunde_Id_Køber = bolig_Kunde_Id_KøberInt;
                DateTime dato;
                if (cbHandelsdato.Checked)
                {
                    dato = dtpBoligDetails.Value;
                }
                else
                {
                    dato = DateTime.MinValue;
                }





                Bolig opdateretBolig = new Bolig
                {
                    Bolig_Id = boligid,
                    Adresse = adresse,
                    Postnummer = postnummer,
                    Type = type,
                    Udbudspris = udbudspris,
                    Størrelse = størrelse,
                    Bolig_Kunde_Id = bolig_Kunde_Id,
                    Bolig_Ejendomsmægler_Id = bolig_Ejendomsmægler_Id,
                    Bolig_Afdelings_Navn = bolig_Afdelings_Navn,
                    Salgsstatus = salgsstatus,
                    Bolig_Kunde_Id_Køber = bolig_Kunde_Id_Køber,
                    Handels_Dato = dato,
                };

                bool opdateret = db.Update(opdateretBolig);
                if (opdateret)
                {
                    MessageBox.Show("Opdateringerne blev gemt");
                }
                else
                {
                    MessageBox.Show("Opdateringerne blev ikke gemt");
                }
                BoligForms boligforms = new BoligForms();
                boligforms.Show();
                this.Hide();
            }
        }

        private void cbHandelsdato_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHandelsdato.Checked)
            {
                dtpBoligDetails.Show();
            }
            else
            {
                dtpBoligDetails.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Er du sikker på at du vil slette Bolig ID: {bolig.Bolig_Id} Adresse: {bolig.Adresse}?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool slettet = db.Delete(bolig.Bolig_Id);
                if (slettet)
                {
                    MessageBox.Show("Boligen blev slettet");
                }
                else
                {
                    MessageBox.Show("Boligen blev ikke slettet");
                }
            }
            else
            {
                MessageBox.Show("Noget gik galt. Boligen blev ikke slettet");
            }

            BoligForms boligforms = new BoligForms();
            boligforms.Show();
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBolig_Click(object sender, EventArgs e)
        {
            BoligForms boligforms = new BoligForms();
            boligforms.Show();
            this.Hide();
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            KundeForms kundeforms = new KundeForms();
            kundeforms.Show();
            this.Hide();
        }

        private void btnEjendomsmægler_Click(object sender, EventArgs e)
        {
            EjendomsmæglerForms ejendomsmæglerForms = new EjendomsmæglerForms();
            ejendomsmæglerForms.Show();
            this.Hide();
        }

        private void btnAfdeling_Click(object sender, EventArgs e)
        {
            AfdelingForms afdelingForms = new AfdelingForms();
            afdelingForms.Show();
            this.Hide();
        }

        private void btnLogo_Click_1(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
            this.Hide();
        }
    }
}
