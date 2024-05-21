using _1.SemesterProjekt.DataAccess;
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
            bool bolig_Kunde_Id = int.TryParse(txtSælgerId.Text, out int bolig_Kunde_IdInt);
            bool bolig_Ejendomsmægler_Id = int.TryParse(txtBoligEjendomsmæglerId.Text, out int bolig_Ejendomsmægler_IdInt);
            bool bolig_Kunde_Id_Køber = int.TryParse(txtKøberId.Text, out int bolig_Kunde_Id_KøberInt);
            boligsælger = kdb.Get(bolig_Kunde_IdInt);
            ejendomsmægler = edb.Get(bolig_Ejendomsmægler_IdInt);
            if (txtAdresse.Text.Length > 50)
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
            else if (!bolig_Kunde_Id)
            {
                MessageBox.Show("Du må kun indtaste tal!");
                txtSælgerId.Text = bolig.Bolig_Kunde_Id.ToString();
            }
            else if (boligsælger.Kunde_Id == null)
            {
                MessageBox.Show("Sælgeren skal være oprettet som kunde før du kan tilføje personens id her!");
                txtSælgerId.Text = bolig.Bolig_Kunde_Id.ToString();
            }
            else if (!bolig_Ejendomsmægler_Id)
            {
                MessageBox.Show("Du må kun indtaste tal!");
                txtSælgerId.Text = bolig.Bolig_Ejendomsmægler_Id.ToString();
            }
            else if (ejendomsmægler.Id == null)
            {
                MessageBox.Show("Ejendomsmægleren skal være oprettet som ejendomsmægler før du kan tilføjet personens id her!");
                txtSælgerId.Text = bolig.Bolig_Ejendomsmægler_Id.ToString();
            }

            else if (MessageBox.Show($"Er du sikker på at du vil gemme ændringerne?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Bolig opdateretBolig = new Bolig
                {
                    //Bolig_Id = txtBoligId.Text,
                    //Adresse = ,
                    //Postnummer = ,
                    //Type = comboboxType.Text,
                    //Udbudspris = ,
                    //Størrelse = ,
                    //Bolig_Kunde_Id = ,
                    //Bolig_Ejendomsmægler_Id = ,
                    //Bolig_Afdelings_Navn = ,
                    //Salgsstatus = comboboxSalgsstatus.Text,
                    //Bolig_Kunde_Id_Køber = ,
                    //Handels_Dato = ,
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
            }
            }
            }
            }
            }
            }
            }
            }
        }

    }
}
