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
    public partial class OpretBoligForms : Form
    {
        KundeDbHandler kdb = new KundeDbHandler();
        List<Kunde> kundelist = new List<Kunde>();
        BoligDbHandler db = new BoligDbHandler();
        List<Bolig> bl = new List<Bolig>();
        Bolig bolig = new Bolig();
        Kunde boligsælger = new Kunde();
        EjendomsmæglerDbHandler edb = new EjendomsmæglerDbHandler();
        Ejendomsmægler ejendomsmægler = new Ejendomsmægler();
        public OpretBoligForms()
        {
            InitializeComponent();
        }

        private void btnTilbage_Click(object sender, EventArgs e)
        {
            BoligForms boligForms = new BoligForms();
            boligForms.Show();
            this.Hide();
        }

        private void OpretBoligForms_Load(object sender, EventArgs e)
        {
            kundelist = kdb.Get();
            dgvKunde.DataSource = kundelist;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnOpret_Click(object sender, EventArgs e)
        {
            bool postnummerBool = int.TryParse(txtPostnummer.Text, out int postnummerInt);
            bool størrelseBool = int.TryParse(txtM2.Text, out int størrelseInt);
            bool udbudsprisBool = int.TryParse(txtPris.Text, out int prisInt);
            bool bolig_Kunde_IdBool = int.TryParse(txtSælgerId.Text, out int bolig_Kunde_IdInt);
            boligsælger = kdb.Get(bolig_Kunde_IdInt);
            bool bolig_Ejendomsmægler_IdBool = int.TryParse(txtEjendomsmæglerId.Text, out int bolig_Ejendomsmægler_IdInt);
            ejendomsmægler = edb.Get(bolig_Ejendomsmægler_IdInt);

            if (txtAdresse.Text.Length == 0)
            {
                MessageBox.Show("Adressen skal udfyldes!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdresse.Text = "";
            }
            else if (txtAdresse.Text.Length > 50)
            {
                MessageBox.Show("Adressen må maksimalt være 50 karaktere lang!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdresse.Text = "";
            }
            else if (txtPostnummer.Text.Length == 0)
            {
                MessageBox.Show("Postnummer skal udfyldes!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostnummer.Text = "";
            }
            else if (!postnummerBool)
            {
                MessageBox.Show("Postnummer må kun indeholde tal!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostnummer.Text = "";
            }
            else if (postnummerInt < 999 || postnummerInt > 10000)
            {
                MessageBox.Show("Postnummer skal være 4 cifret tal", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostnummer.Text = "";
            }
            else if (txtM2.Text.Length == 0)
            {
                MessageBox.Show("Størrelse på boligen skal udfyldes!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtM2.Text = "";
            }
            else if (!størrelseBool)
            {
                MessageBox.Show("Størrelse må kun være tal!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtM2.Text = "";
            }
            else if (størrelseInt > 301 || størrelseInt < 0)
            {
                MessageBox.Show("Størrelsen kan maksimalt være 300 kvadratmeter!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtM2.Text = "";
            }
            else if (txtPris.Text.Length == 0)
            {
                MessageBox.Show("Prisen på huset skal udfyldes!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPris.Text = "";
            }
            else if (!udbudsprisBool)
            {
                MessageBox.Show("Pris skal være tal!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPris.Text = "";
            }
            else if (!udbudsprisBool || prisInt > 5000001 || prisInt <= 0)
            {
                MessageBox.Show("Prisen skal være imellem 0-5000000", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPris.Text = "";
            }
            else if (txtSælgerId.Text.Length == 0)
            {
                MessageBox.Show("Sælgers Id skal udfyldes!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSælgerId.Text = "";
            }
            else if (!bolig_Kunde_IdBool)
            {
                MessageBox.Show("Du må kun indtaste tal!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSælgerId.Text = "";
            }
            else if (boligsælger.Kunde_Id == 0)
            {
                MessageBox.Show("Sælgeren skal være oprettet som kunde før du kan tilføje personens id her!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSælgerId.Text = "";
            }
            else if (txtEjendomsmæglerId.Text.Length == 0)
            {
                MessageBox.Show("Ejendomsmælger Id skal udfyldes!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEjendomsmæglerId.Text = "";
            }
            else if (!bolig_Ejendomsmægler_IdBool)
            {
                MessageBox.Show("Du må kun indtaste tal!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEjendomsmæglerId.Text = "";
            }
            else if (ejendomsmægler.Id == 0)
            {
                MessageBox.Show("Ejendomsmægleren skal være oprettet som ejendomsmægler før du kan tilføjet personens id her!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEjendomsmæglerId.Text = "";
            }
            else if (comboBoxAfdeling.Text.Length == 0)
            {
                MessageBox.Show("Boligen skal være tilsluttet en afdeling!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxAfdeling.Text = "";
            }
            else if (comboBoxType.Text.Length == 0)
            {
                MessageBox.Show("Boligen skal gives en type!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxType.Text = "";
            }

            else if (MessageBox.Show($"Er du sikker på at du vil oprette bolig?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string adresse = txtAdresse.Text;
                int postnummer = postnummerInt;
                string type = comboBoxType.Text;
                int udbudspris = prisInt;
                int størrelse = størrelseInt;
                int bolig_Kunde_Id = bolig_Kunde_IdInt;
                int bolig_Ejendomsmægler_Id = bolig_Ejendomsmægler_IdInt;
                string bolig_Afdelings_Navn = comboBoxAfdeling.Text;
                string salgsstatus = "Til salg";

                Bolig opdateretBolig = new Bolig
                {
                    Adresse = adresse,
                    Postnummer = postnummer,
                    Type = type,
                    Udbudspris = udbudspris,
                    Størrelse = størrelse,
                    Bolig_Kunde_Id = bolig_Kunde_Id,
                    Bolig_Ejendomsmægler_Id = bolig_Ejendomsmægler_Id,
                    Bolig_Afdelings_Navn = bolig_Afdelings_Navn,
                    Salgsstatus = salgsstatus
                };

                bool opdateret = db.Create(opdateretBolig);
                if (opdateret)
                {
                    MessageBox.Show("Boligen blev oprettet", "Bolig oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Boligen blev ikke oprettet!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BoligForms boligforms = new BoligForms();
                boligforms.Show();
                this.Hide();
            }
        }

        private void btnBolig_Click(object sender, EventArgs e)
        {
            BoligForms boligforms = new BoligForms();
            boligforms.Show();
            this.Hide();
        }
    }
}
