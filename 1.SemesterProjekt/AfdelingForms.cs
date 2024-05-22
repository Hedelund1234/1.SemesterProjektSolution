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
    public partial class AfdelingForms : Form
    {
        AfdelingDbHandler db = new AfdelingDbHandler();
        List<Afdeling> al = new List<Afdeling>();
        public AfdelingForms()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSøg_Click(object sender, EventArgs e)
        {
            string afdelingsNr = "";
            string afdelingsNavn = "";
            try
            {
                if (comboBoxAfdelingsNr.Text.Length != 0)
                {
                    afdelingsNr = comboBoxAfdelingsNr.Text;
                }
                if (comboBoxAfdelingsNavn.Text.Length != 0)
                {
                    afdelingsNavn = comboBoxAfdelingsNavn.Text;
                }
                al = db.Get(afdelingsNr, afdelingsNavn);
            }
            catch (Exception)
            {

            }
            if (al.Count == 0)
            {
                MessageBox.Show("Afdeling blev ikke fundet", "Ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                al = db.Get();
                dgvBolig.DataSource = al;
            }
            else
            {
                dgvBolig.DataSource = al;
            }
            comboBoxAfdelingsNr.Text = null;
            comboBoxAfdelingsNavn.Text = null;
        }

        private void dgvBolig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            DataGridView dgv = sender as DataGridView;

            DataGridViewRow data = dgv.Rows[row];
            int nr = (int)data.Cells["Afdelings_Nr"].Value;
            NavigateToDetails(nr);
        }
        void NavigateToDetails(int nr)
        {
            AfdelingDetails afdelingDetails = new AfdelingDetails(nr);
            afdelingDetails.Show();
            this.Hide();
        }

        private void AfdelingForms_Load(object sender, EventArgs e)
        {
            al = db.Get();
            dgvBolig.DataSource = al;
        }

        private void comboBoxAfdelingsNr_DropDownClosed(object sender, EventArgs e)
        {
            string afdelingsNr = "";
            string afdelingsNavn = "";
            try
            {
                if (comboBoxAfdelingsNr.Text.Length != 0)
                {
                    afdelingsNr = comboBoxAfdelingsNr.Text;
                }
                if (comboBoxAfdelingsNavn.Text.Length != 0)
                {
                    afdelingsNavn = comboBoxAfdelingsNavn.Text;
                }
                al = db.Get(afdelingsNr, afdelingsNavn);
            }
            catch (Exception)
            {

            }
            if (al.Count == 0)
            {
                MessageBox.Show("Afdeling blev ikke fundet", "Ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                al = db.Get();
                dgvBolig.DataSource = al;
            }
            else
            {
                dgvBolig.DataSource = al;
            }
            comboBoxAfdelingsNr.Text = null;
            comboBoxAfdelingsNavn.Text = null;
        }

        private void comboBoxAfdelingsNavn_DropDownClosed(object sender, EventArgs e)
        {
            string afdelingsNr = "";
            string afdelingsNavn = "";
            try
            {
                if (comboBoxAfdelingsNr.Text.Length != 0)
                {
                    afdelingsNr = comboBoxAfdelingsNr.Text;
                }
                if (comboBoxAfdelingsNavn.Text.Length != 0)
                {
                    afdelingsNavn = comboBoxAfdelingsNavn.Text;
                }
                al = db.Get(afdelingsNr, afdelingsNavn);
            }
            catch (Exception)
            {

            }
            if (al.Count == 0)
            {
                MessageBox.Show("Afdeling blev ikke fundet", "Ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                al = db.Get();
                dgvBolig.DataSource = al;
            }
            else
            {
                dgvBolig.DataSource = al;
            }
            comboBoxAfdelingsNr.Text = null;
            comboBoxAfdelingsNavn.Text = null;
        }
    }
}
