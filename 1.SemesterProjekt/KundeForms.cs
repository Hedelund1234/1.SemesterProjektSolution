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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _1.SemesterProjekt
{
    public partial class KundeForms : Form
    {
        KundeDbHandler db = new KundeDbHandler();
        List<Kunde> kl = new List<Kunde>();
        bool sort = false;
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

        private void dgvBolig_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Kunde> kundeListe = dgvBolig.DataSource as List<Kunde>;

            if (e.ColumnIndex == 0)
            {
                if (sort == false)
                {
                    dgvBolig.DataSource = kundeListe.OrderByDescending(b => b.Kunde_Id).ToList();
                    sort = true;
                }
                else
                {
                    dgvBolig.DataSource = kundeListe.OrderBy(b => b.Kunde_Id).ToList();
                    sort = false;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (sort == false)
                {
                    dgvBolig.DataSource = kundeListe.OrderByDescending(b => b.Navn).ToList();
                    sort = true;
                }
                else
                {
                    dgvBolig.DataSource = kundeListe.OrderBy(b => b.Navn).ToList();
                    sort = false;
                }
            }
            else if (e.ColumnIndex == 2)
            {
                if (sort == false)
                {
                    dgvBolig.DataSource = kundeListe.OrderByDescending(b => b.Email).ToList();
                    sort = true;
                }
                else
                {
                    dgvBolig.DataSource = kundeListe.OrderBy(b => b.Email).ToList();
                    sort = false;
                }
            }
            else if (e.ColumnIndex == 3)
            {
                if (sort == false)
                {
                    dgvBolig.DataSource = kundeListe.OrderByDescending(b => b.Telefon_Nr).ToList();
                    sort = true;
                }
                else
                {
                    dgvBolig.DataSource = kundeListe.OrderBy(b => b.Telefon_Nr).ToList();
                    sort = false;
                }
            }
            else if (e.ColumnIndex == 4)
            {
                if (sort == false)
                {
                    dgvBolig.DataSource = kundeListe.OrderByDescending(b => b.Kunde_Type).ToList();
                    sort = true;
                }
                else
                {
                    dgvBolig.DataSource = kundeListe.OrderBy(b => b.Kunde_Type).ToList();
                    sort = false;
                }
            }
        }
    }
}
