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
using _1.SemesterProjekt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt
{
    public partial class EjendomsmæglerDetails : Form
    {
        Ejendomsmægler ejendomsmægler = new Ejendomsmægler();
        EjendomsmæglerDbHandler db;
        int id;
        public EjendomsmæglerDetails(int id)
        {
            InitializeComponent();
            db = new EjendomsmæglerDbHandler();
            this.id = id;
            SeedData();

        }
        void SeedData()
        {
            
            db = new EjendomsmæglerDbHandler();
            ejendomsmægler = db.Get(id);

            txtNavn.Text = ejendomsmægler.Navn;
            txtTelefonNr.Text = ejendomsmægler.Telefon_Nr.ToString();
            txtEmail.Text = ejendomsmægler.Email;
            ComboBoxAfdeling.Text = ejendomsmægler.Ejendomsmægler_Afdeling_Nr.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool navnSuccessBool = false;
            bool telefonnummerSuccessBool = false;
            bool telefonnummerSuccess = int.TryParse(txtTelefonNr.Text, out int telefonnummerInt);
            bool Ejendomsmægler_Afdeling_NrSucces = false;
            bool emailSuccessBool = false;

            if (txtNavn.Text.Length != 0)
            {
                if (txtNavn.Text.Length > 50)
                {
                    MessageBox.Show("Navn skal være i mellem 1 og 50 bogstaver", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNavn.Text = ejendomsmægler.Navn;
                }
                else
                {
                    navnSuccessBool = true;
                }
            }
            if (txtTelefonNr.Text.Length != 0)
            {
                if (!telefonnummerSuccess || txtTelefonNr.Text.Length != 8)
                {
                    if (!telefonnummerSuccess)
                    {
                        MessageBox.Show("Telefonnummer skal være tal", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTelefonNr.Text = ejendomsmægler.Telefon_Nr.ToString();
                    }
                    else if (txtTelefonNr.Text.Length != 8)
                    {
                        MessageBox.Show("Telefonnummer skal indeholde 8 tal", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTelefonNr.Text = ejendomsmægler.Telefon_Nr.ToString();
                    }
                }
                else { telefonnummerSuccessBool = true; }
            }
            if (txtEmail.Text.Length != 0)
            {
                if (txtEmail.Text.Length > 50 || !txtEmail.Text.Contains('@') || txtEmail.Text.Split('@').Length > 2 || txtEmail.Text.Split('@').Length > 2 || txtEmail.Text.Split('@')[1].Length <= 2 || !txtEmail.Text.Split('@')[1].Contains('.') || txtEmail.Text.Split('.')[1].Length < 2 || txtEmail.Text.Split('@', '.').Length != 3 || txtEmail.Text.Split('@', '.')[1].Length < 2)
                {
                    if (!txtEmail.Text.Contains('@'))
                    {
                        MessageBox.Show("Skal indeholde @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                    else if (txtEmail.Text.Split('@').Length > 2)
                    {
                        MessageBox.Show("Kun 1 @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                    else if (txtEmail.Text.Split('@')[0].Length < 2)
                    {
                        MessageBox.Show("2 karakterer FØR @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                    else if (txtEmail.Text.Split('@')[1].Length < 2)
                    {
                        MessageBox.Show("2 karakterer EFTER @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                    else if (!txtEmail.Text.Split('@')[1].Contains('.'))
                    {
                        MessageBox.Show("Skal indeholde .", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                    else if (txtEmail.Text.Split('.')[1].Length < 2)
                    {
                        MessageBox.Show("2 karakterer efter .", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                    else if (txtEmail.Text.Split('@', '.').Length != 3 || txtEmail.Text.Split('@', '.')[1].Length < 2)
                    {
                        MessageBox.Show("2 karakterer efterfulgt af @ efter fulgt af 2 karakterer efterfulgt af . efterfulgt af 2 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                    else if (txtEmail.Text.Length > 50)
                    {
                        MessageBox.Show("Email må max indeholde 50 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = ejendomsmægler.Email;
                    }
                }
                else { emailSuccessBool = true; }
            }
            if (ComboBoxAfdeling.Text.Length == 0)
            {
                MessageBox.Show("Vælg afdeling", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComboBoxAfdeling.Text = "";
            }
            else
            {
                Ejendomsmægler_Afdeling_NrSucces = true;
            }
            if (navnSuccessBool && emailSuccessBool && telefonnummerSuccessBool && Ejendomsmægler_Afdeling_NrSucces)
            {
                bool b = db.Update(new Ejendomsmægler { Id = id, Navn = txtNavn.Text, Telefon_Nr = Convert.ToInt32(txtTelefonNr.Text), Email = txtEmail.Text, Ejendomsmægler_Afdeling_Nr = Convert.ToInt32(ComboBoxAfdeling.Text) });


                if (b)
                {
                    MessageBox.Show("Ejendomsmægler opdateret", "Ejendomsmægler opdateret", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNavn.Text = null;
                    txtTelefonNr.Text = null;
                    txtEmail.Text = null;
                    ComboBoxAfdeling.Text = null;
                }
                else
                {
                    MessageBox.Show("Ejendomsmægler blev IKKE opdateret", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BoligForms boligform = new BoligForms();
            boligform.Show();
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
            EjendomsmæglerForms ejendomsmæglerForms = new EjendomsmæglerForms();
            ejendomsmæglerForms.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSlet_Click(object sender, EventArgs e)
        {
            EjendomsmæglerForms ejendomsmæglerForms = new EjendomsmæglerForms();
            int id = this.id;
            db.Delete(id);
            MessageBox.Show($"Ejendomsmægler med Id: {id} blev slettet", "Slettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ejendomsmæglerForms.Show();
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
    }
}
