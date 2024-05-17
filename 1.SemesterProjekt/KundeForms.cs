using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;

namespace _1.SemesterProjekt
{
    public partial class KundeForms : Form
    {
        KundeDbHandler db = new KundeDbHandler();
        List<Kunde> kl = new List<Kunde>();
        public KundeForms()
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

        private void btnOpret_Click(object sender, EventArgs e)
        {
            OpretKundeForms opretKunde = new OpretKundeForms();
            opretKunde.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSøg_Click(object sender, EventArgs e)
        {
            try
            {
                bool telefonnummerSuccess = int.TryParse(txtBoxKundeTelefonnummer.Text, out int telefonnummerInt);
                bool idSuccess = int.TryParse(txtBoxKundeId.Text, out int idInt);
                string id = "";
                string navn = "";
                string email = "";
                string telefonnummer = "";
                string checkBox = "";
                if (cBoxKundeKøber.Checked == true)
                {
                    checkBox = "Køber";
                }
                else if (cBoxKundeSælger.Checked == true)
                {
                    checkBox = "Sælger";
                }
                if (txtBoxKundeId.Text.Length != 0)
                {
                    id = txtBoxKundeId.Text;
                }
                if (txtBoxKundeNavn.Text.Length != 0)
                {
                    navn = txtBoxKundeNavn.Text;
                }
                if (txtBoxKundeEmail.Text.Length != 0)
                {
                    email = txtBoxKundeEmail.Text;
                }
                if (txtBoxKundeTelefonnummer.Text.Length != 0)
                {
                    telefonnummer = txtBoxKundeTelefonnummer.Text;
                }
                if (txtBoxKundeId.Text.Length == 0 && txtBoxKundeNavn.Text.Length == 0 && txtBoxKundeEmail.Text.Length == 0 && txtBoxKundeTelefonnummer.Text.Length == 0 && cBoxKundeKøber.Checked == false && cBoxKundeSælger.Checked == false)
                {
                    kl = db.Get();
                    dgvBolig.DataSource = kl;
                }
                else
                {
                    kl = db.Get(id, navn, email, telefonnummer, checkBox);
                }
            }
            catch (Exception)
            {

            }
            if (kl.Count == 0)
            {
                MessageBox.Show("Kunde blev ikke fundet", "Ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kl = db.Get();
                dgvBolig.DataSource = kl;
            }
            else
            {
                dgvBolig.DataSource = kl;
            }
            txtBoxKundeId.Text = null;
            txtBoxKundeNavn.Text = null;
            txtBoxKundeEmail.Text = null;
            txtBoxKundeTelefonnummer.Text = null;
        }

        private void KundeForms_Load(object sender, EventArgs e)
        {
            kl = db.Get();
            dgvBolig.DataSource = kl;
        }

        private void dgvBolig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            DataGridView dgv = sender as DataGridView;

            DataGridViewRow data = dgv.Rows[row];
            int id = (int)data.Cells["Kunde_Id"].Value;
            NavigateToDetails(id);
        }
        void NavigateToDetails(int id)
        {
            KundeDetails kundeDetails = new KundeDetails(id);
            kundeDetails.Show();
            this.Hide();
        }

        private void cBoxKundeSælger_CheckedChanged(object sender, EventArgs e)
        {
            cBoxKundeKøber.CheckState = CheckState.Unchecked;
        }

        private void cBoxKundeKøber_CheckedChanged(object sender, EventArgs e)
        {
            cBoxKundeSælger.CheckState = CheckState.Unchecked;
        }
    }
}
