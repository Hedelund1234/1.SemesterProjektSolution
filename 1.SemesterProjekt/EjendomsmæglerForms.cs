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

namespace _1.SemesterProjekt
{
    public partial class EjendomsmæglerForms : Form
    {
        //EjendomsmæglerDbHandler db = new EjendomsmæglerDbHandler();
        List<Ejendomsmægler> el = new List<Ejendomsmægler>();
        EjendomsmæglerDbHandler db;

        public EjendomsmæglerForms()
        {
            InitializeComponent();
            db = new EjendomsmæglerDbHandler();
            dgvEjendomsmægler.DataSource = db.Get();
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

        private void button3_Click(object sender, EventArgs e)
        {
            AfdelingForms afdeling = new AfdelingForms();
            afdeling.Show();
            this.Hide();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            OpretEjendomsmæglerForms opretEjendomsmægler = new OpretEjendomsmæglerForms();
            opretEjendomsmægler.Show();
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
                bool ejendomsmæglerSucces = int.TryParse(txtEjendomsmæglerId.Text, out int ejendomsmæglerInt);
                bool telefonnummerSuccess = int.TryParse(txtTelefonnummer.Text, out int telefonnummerInt);
                string id = "";
                string navn = "";
                string email = "";
                string telefonnummer = "";
                string AfdelingId = "";

                if (txtEjendomsmæglerId.Text.Length != 0)
                {
                    id = txtEjendomsmæglerId.Text;
                }
                if (txtNavn.Text.Length != 0)
                {
                    navn = txtNavn.Text;
                }
                if (txtTelefonnummer.Text.Length != 0)
                {
                    telefonnummer = txtTelefonnummer.Text;
                }
                if (txtEmail.Text.Length != 0)
                {
                    email = txtEmail.Text;
                }
                if (comboBoxAfdeling != null)
                {
                    AfdelingId = comboBoxAfdeling.Text;
                }
                if (txtEjendomsmæglerId.Text.Length == 0 && txtNavn.Text.Length == 0 && txtTelefonnummer.Text.Length == 0 && txtEmail.Text.Length == 0 && comboBoxAfdeling.Text.Length == 0)
                {
                    MessageBox.Show("Ejendomsmægler blev ikke fundet", "Ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    el = db.Get();
                    dgvEjendomsmægler.DataSource = el;
                }
                else
                {
                    el = db.Get(id, navn, telefonnummer, email, AfdelingId);
                }
            }
            catch (Exception)
            {

            }
            if (el.Count == 0)
            {
                MessageBox.Show("Ejendomsmægler blev ikke fundet", "Ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                el = db.Get();
                dgvEjendomsmægler.DataSource = el;
            }
            else
            {

                dgvEjendomsmægler.DataSource = el;
            }
            txtEjendomsmæglerId.Text = null;
            txtNavn.Text = null;
            txtTelefonnummer.Text = null;
            comboBoxAfdeling.Text = null;
        }

        private void dgvEjendomsmægler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            DataGridView dgv = sender as DataGridView;

            DataGridViewRow data = dgv.Rows[row];
            int id = (int)data.Cells["Id"].Value;
            NavigateToDetails(id);
        }
        void NavigateToDetails(int id)
        {
            EjendomsmæglerDetails ejendomsmæglerDetails = new EjendomsmæglerDetails(id);
            ejendomsmæglerDetails.Show();
            this.Hide();
        }
    }
}

