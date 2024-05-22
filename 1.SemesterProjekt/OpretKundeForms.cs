using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;

namespace _1.SemesterProjekt
{
    public partial class OpretKundeForms : Form
    {
        KundeDbHandler db = new KundeDbHandler();
        public OpretKundeForms()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoligForms boligForms = new BoligForms();
            boligForms.Show();
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

        private void btnTilbage_Click(object sender, EventArgs e)
        {
            KundeForms kunde = new KundeForms();
            kunde.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            string kundeType = "";
            bool navnSuccessBool = false;
            bool emailSuccessBool = false;
            bool telefonnummerSuccessBool = false;
            bool telefonnummerSuccess = int.TryParse(txtBoxTelefonnummerOpretKunde.Text, out int telefonnummerInt);

            if (txtBoxNavnOpretKunde.Text.Length != 0)
            {
                if (txtBoxNavnOpretKunde.Text.Length > 50)
                {
                    MessageBox.Show("Navn må ikke indeholde mere end 50 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNavnOpretKunde.Text = null;
                }
                else { navnSuccessBool = true; }
            }
            if (txtBoxEmailOpretKunde.Text.Length != 0)
            {
                if (txtBoxEmailOpretKunde.Text.Length > 50 || !txtBoxEmailOpretKunde.Text.Contains('@') || txtBoxEmailOpretKunde.Text.Split('@').Length > 2 || txtBoxEmailOpretKunde.Text.Split('@').Length > 2 || txtBoxEmailOpretKunde.Text.Split('@')[1].Length <= 2 || !txtBoxEmailOpretKunde.Text.Split('@')[1].Contains('.') || txtBoxEmailOpretKunde.Text.Split('.')[1].Length < 2 || txtBoxEmailOpretKunde.Text.Split('@', '.').Length != 3 || txtBoxEmailOpretKunde.Text.Split('@', '.')[1].Length < 2)
                {
                    if (!txtBoxEmailOpretKunde.Text.Contains('@'))
                    {
                        MessageBox.Show("Skal indeholde @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtBoxEmailOpretKunde.Text.Split('@').Length > 2)
                    {
                        MessageBox.Show("Kun 1 @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtBoxEmailOpretKunde.Text.Split('@')[0].Length < 2)
                    {
                        MessageBox.Show("2 karakterer FØR @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtBoxEmailOpretKunde.Text.Split('@')[1].Length < 2)
                    {
                        MessageBox.Show("2 karakterer EFTER @", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!txtBoxEmailOpretKunde.Text.Split('@')[1].Contains('.'))
                    {
                        MessageBox.Show("Skal indeholde .", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtBoxEmailOpretKunde.Text.Split('.')[1].Length < 2)
                    {
                        MessageBox.Show("2 karakterer efter .", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtBoxEmailOpretKunde.Text.Split('@', '.').Length != 3 || txtBoxEmailOpretKunde.Text.Split('@', '.')[1].Length < 2)
                    {
                        MessageBox.Show("2 karakterer efterfulgt af @ efter fulgt af 2 karakterer efterfulgt af . efterfulgt af 2 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtBoxEmailOpretKunde.Text.Length > 50)
                    {
                        MessageBox.Show("Email må max indeholde 50 karakterer", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { emailSuccessBool = true; }
            }
            if (txtBoxTelefonnummerOpretKunde.Text.Length != 0)
            {
                if (!telefonnummerSuccess || txtBoxTelefonnummerOpretKunde.Text.Length != 8)
                {
                    if (!telefonnummerSuccess)
                    {
                        MessageBox.Show("Telefonnummer skal være tal", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtBoxTelefonnummerOpretKunde.Text.Length != 8)
                    {
                        MessageBox.Show("Telefonnummer skal indeholde 8 tal", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { telefonnummerSuccessBool = true; }
            }
            if (checkBoxKøberOpretKunde.Checked || checkBoxSælgerOpretKunde.Checked)
            {
                if (checkBoxSælgerOpretKunde.Checked)
                {
                    kundeType = "Sælger";
                }
                else
                {
                    kundeType = "Køber";
                }
            }
            if (navnSuccessBool && emailSuccessBool && telefonnummerSuccessBool)
            {
                bool b = db.Create(new Kunde { Navn = txtBoxNavnOpretKunde.Text, Email = txtBoxEmailOpretKunde.Text, Telefon_Nr = Convert.ToInt32(txtBoxTelefonnummerOpretKunde.Text), Kunde_Type = kundeType });
                if (b)
                {
                    MessageBox.Show("Ny Kunde oprettet", "Kunde oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxNavnOpretKunde.Text = null;
                    txtBoxEmailOpretKunde.Text = null;
                    txtBoxTelefonnummerOpretKunde.Text = null;
                    checkBoxKøberOpretKunde.Checked = false;
                    checkBoxSælgerOpretKunde.Checked = false;
                }
                else
                {
                    MessageBox.Show("Kunde blev IKKE oprettet", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNavnOpretKunde.Text = null;
                    txtBoxEmailOpretKunde.Text = null;
                    txtBoxTelefonnummerOpretKunde.Text = null;
                    checkBoxKøberOpretKunde.Checked = false;
                    checkBoxSælgerOpretKunde.Checked = false;
                }
            }
        }

        private void checkBoxKøberOpretKunde_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSælgerOpretKunde.CheckState = CheckState.Unchecked;
        }

        private void checkBoxSælgerOpretKunde_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxKøberOpretKunde.CheckState = CheckState.Unchecked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KundeForms kunde = new KundeForms();
            kunde.Show();
            this.Hide();
        }
    }
}
