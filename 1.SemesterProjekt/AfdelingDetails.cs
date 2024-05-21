using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;

namespace _1.SemesterProjekt
{
    public partial class AfdelingDetails : Form
    {
        int nr;
        Afdeling afdeling;
        AfdelingDbHandler db;
        List<Afdeling> al = new List<Afdeling>();
        EjendomsmæglerDbHandler ejendomsmæglerDb;
        public AfdelingDetails(int nr)
        {
            InitializeComponent();
            this.nr = nr;
            SeedData();
            txtBoxAfdelingNrDetails.Text = afdeling.Afdelings_Nr.ToString();
            txtBoxAfdelingsNavnDetails.Text = afdeling.Afdelings_Navn;
        }
        void SeedData()
        {
            db = new AfdelingDbHandler();
            afdeling = db.Get(nr);
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

        private void button5_Click(object sender, EventArgs e)
        {
            AfdelingForms afdelingForms = new AfdelingForms();
            afdelingForms.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AfdelingDetails_Load(object sender, EventArgs e)
        {
            comboBoxAfdelingsDetailsSøg.Text = "Bolig";
            dgvAfdelingsDetails.DataSource = db.GetJoinBolig(comboBoxAfdelingsDetailsSøg.Text, txtBoxAfdelingsNavnDetails.Text);
        }

        private void comboBoxAfdelingsDetailsSøg_DropDownClosed(object sender, EventArgs e)
        {
            string searchChoice = comboBoxAfdelingsDetailsSøg.Text;
            if (searchChoice == "Bolig")
            {
                dgvAfdelingsDetails.DataSource = db.GetJoinBolig(searchChoice, txtBoxAfdelingsNavnDetails.Text);
            }
            else
            {
                dgvAfdelingsDetails.DataSource = db.GetJoinEjendomsmægler(searchChoice, Convert.ToInt32(txtBoxAfdelingNrDetails.Text));
            }
        }

        private void AfdelingFormsDetails_Click(object sender, EventArgs e)
        {
            AfdelingForms afdeling = new AfdelingForms();
            afdeling.Show();
            this.Hide();
        }

        private void btnCsvUdprint_Click(object sender, EventArgs e)
        {
            List<Bolig> boligList = db.GetJoinBolig(comboBoxAfdelingsDetailsSøg.Text, txtBoxAfdelingsNavnDetails.Text);
            List<Ejendomsmægler> ejendomsmæglerList = db.GetJoinEjendomsmægler("Ejendomsmægler", Convert.ToInt32(txtBoxAfdelingNrDetails.Text));
            
            bool success = db.SaveDataToCsv(boligList, ejendomsmæglerList, $"BoligerOmråde{txtBoxAfdelingsNavnDetails.Text}.csv", boligList.Count);
            if (success)
            {
                MessageBox.Show(".csv fil gemt", ".csv gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(".csv fil blev IKKE gemt", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
