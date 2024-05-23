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
    public partial class KundeDetails : Form
    {
        KundeDbHandler db;
        int id;
        Kunde kunde;
        public KundeDetails(int id)
        {
            InitializeComponent();
            this.id = id;
            SeedData();
            txtBoxKundeId.Text = kunde.Kunde_Id.ToString();
            txtBoxKundeNavn.Text = kunde.Navn;
            txtBoxKundeEmail.Text = kunde.Email;
            txtBoxKundeTelefonnummer.Text = kunde.Telefon_Nr.ToString();
            comboBoxKundeType.Text = kunde.Kunde_Type;
        }
        void SeedData()
        {
            db = new KundeDbHandler();
            kunde = db.Get(id);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoligForms bolig = new BoligForms();
            bolig.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            KundeForms kunde = new KundeForms();
            kunde.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KundeForms KundeForm = new KundeForms();
            db = new KundeDbHandler();
            bool telefonnummerSuccess = int.TryParse(txtBoxKundeTelefonnummer.Text, out int telefonnummerInt);
            bool navnSuccess = false;
            bool emailSuccess = false;
            bool telefonnummerSuccessBool = false;
            try
            {
                if (txtBoxKundeNavn.Text.Length != 0)
                {
                    if (txtBoxKundeNavn.Text.Length > 50)
                    {
                        MessageBox.Show("Navn må ikke indeholde mere end 50 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else { navnSuccess = true; }
                }
                if (txtBoxKundeEmail.Text.Length != 0)
                {
                    if (txtBoxKundeEmail.Text.Length > 50 || !txtBoxKundeEmail.Text.Contains('@') || txtBoxKundeEmail.Text.Split('@').Length > 2 || txtBoxKundeEmail.Text.Split('@').Length > 2 || txtBoxKundeEmail.Text.Split('@')[1].Length <= 2 || !txtBoxKundeEmail.Text.Split('@')[1].Contains('.') || txtBoxKundeEmail.Text.Split('.')[1].Length < 2 || txtBoxKundeEmail.Text.Split('@', '.').Length != 3 || txtBoxKundeEmail.Text.Split('@', '.')[1].Length < 2)
                    {
                        if (!txtBoxKundeEmail.Text.Contains('@'))
                        {
                            MessageBox.Show("Skal indeholde @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtBoxKundeEmail.Text.Split('@').Length > 2)
                        {
                            MessageBox.Show("Kun 1 @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtBoxKundeEmail.Text.Split('@')[0].Length < 2)
                        {
                            MessageBox.Show("2 karakterer FØR @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtBoxKundeEmail.Text.Split('@')[1].Length < 2)
                        {
                            MessageBox.Show("2 karakterer EFTER @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!txtBoxKundeEmail.Text.Split('@')[1].Contains('.'))
                        {
                            MessageBox.Show("Skal indeholde .", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtBoxKundeEmail.Text.Split('.')[1].Length < 2)
                        {
                            MessageBox.Show("2 karakterer efter .", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtBoxKundeEmail.Text.Split('@', '.').Length != 3 || txtBoxKundeEmail.Text.Split('@', '.')[1].Length < 2)
                        {
                            MessageBox.Show("2 karakterer efterfulgt af @ efter fulgt af 2 karakterer efterfulgt af . efterfulgt af 2 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtBoxKundeEmail.Text.Length > 50)
                        {
                            MessageBox.Show("Email må max indeholde 50 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { emailSuccess = true; }
                }
                if (txtBoxKundeTelefonnummer.Text.Length != 0)
                {
                    if (!telefonnummerSuccess || txtBoxKundeTelefonnummer.Text.Length != 8)
                    {
                        if (!telefonnummerSuccess)
                        {
                            MessageBox.Show("Telefonnummer skal være tal", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtBoxKundeTelefonnummer.Text.Length != 8)
                        {
                            MessageBox.Show("Telefonnummer skal indeholde 8 tal", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { telefonnummerSuccessBool = true; }
                }

                if (navnSuccess && emailSuccess && telefonnummerSuccessBool)
                {
                    bool success = db.Update(new Kunde { Kunde_Id = Convert.ToInt32(txtBoxKundeId.Text), Navn = txtBoxKundeNavn.Text, Email = txtBoxKundeEmail.Text, Telefon_Nr = Convert.ToInt32(txtBoxKundeTelefonnummer.Text), Kunde_Type = comboBoxKundeType.Text });
                    if (success)
                    {
                        MessageBox.Show("Kunden blev opdateret");
                        KundeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kunde blev IKKE opdateret", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxKundeNavn.Text = null;
                        txtBoxKundeEmail.Text = null;
                        txtBoxKundeTelefonnummer.Text = null;
                        comboBoxKundeType.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kunde blev IKKE opdateret", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxKundeNavn.Text = null;
                txtBoxKundeEmail.Text = null;
                txtBoxKundeTelefonnummer.Text = null;
                comboBoxKundeType.SelectedIndex = 0;
            }
        }

        private void btnSletKunde_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Er du sikker på at du vil slette denne kunde:\n\nId: {kunde.Kunde_Id}\nNavn: {kunde.Navn}\nEmail: {kunde.Email}\nTelefonnummer: {kunde.Telefon_Nr}", "Slet kunde", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool kundeId = db.Delete(Convert.ToInt32(txtBoxKundeId.Text));
                if (kundeId)
                {
                    MessageBox.Show("Kunde slettet", "Slettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KundeForms kunde = new KundeForms();
                    kunde.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kunde blev ikke slettet", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kunde blev ikke slettet", "Annullerede", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKundeDetails_Click(object sender, EventArgs e)
        {
            KundeForms kunde = new KundeForms();
            kunde.Show();
            this.Hide();
        }
    }
}
