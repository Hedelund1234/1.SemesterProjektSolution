﻿using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;

namespace _1.SemesterProjekt
{
    public partial class BoligForms : Form
    {
        BoligDbHandler db = new BoligDbHandler();
        List<Bolig> bl = new List<Bolig>();
        Bolig bolig = new Bolig();

        public BoligForms()
        {
            InitializeComponent();
            SliderPris();
            SliderM2();
        }

        void SliderPris()
        {
            int minpris = tbMinPris.Value * 250000;
            int maxpris = tbMaxPris.Value * 250000;
            lblMinpris.Text = minpris.ToString();
            lblMaxpris.Text = maxpris.ToString();
            if (tbMaxPris.Value < tbMinPris.Value)
            {
                MessageBox.Show("Fejl (Minimumspris er større end maksimumspris)");
                tbMinPris.Value = 0;
                tbMaxPris.Value = 20;
                minpris = tbMinPris.Value * 250000;
                maxpris = tbMaxPris.Value * 250000;
                lblMinpris.Text = minpris.ToString();
                lblMaxpris.Text = maxpris.ToString();
            }
        }
        void SliderM2()
        {
            int minm2 = tbMinM2.Value * 15;
            int maxm2 = tbMaxM2.Value * 15;
            lblMinM2.Text = minm2.ToString();
            lblMaxM2.Text = maxm2.ToString();
            if (tbMaxM2.Value < tbMinM2.Value)
            {
                MessageBox.Show("Fejl (´Minimus M2 er større end maksimums M2");
                tbMinM2.Value = 0;
                tbMaxM2.Value = 20;
                minm2 = tbMinM2.Value * 15;
                maxm2 = tbMaxM2.Value * 15;
                lblMinM2.Text = minm2.ToString();
                lblMaxM2.Text = maxm2.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoligForms_Load(object sender, EventArgs e)
        {
            bl = db.Get();
            dgvBolig.DataSource = bl;
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            OpretBoligForms opretboligforms = new OpretBoligForms();
            opretboligforms.Show();
            this.Hide();
        }

        private void dgvBolig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            DataGridView dgv = sender as DataGridView;

            DataGridViewRow data = dgv.Rows[row];
            int id = (int)data.Cells["id"].Value;
            NavigateToDetails(id);
        }
        void NavigateToDetails(int id)
        {
            BoligDetails boligdetails = new BoligDetails(id);
            boligdetails.Show();
            this.Hide();
        }

        private void btnSøg_Click(object sender, EventArgs e)
        {
            string afdeling;
            string type;
            int postnummer;
            string salgsstatus;
            int pris;
            int m2;
            string adresse;
            bool postnummerbool = int.TryParse(txtPostnummer.Text, out int postnummerint);
            if (comboBoxAfdeling.Text.Length == 0 && comboBoxType.Text.Length == 0 && txtPostnummer.Text.Length == 0 && cbSolgt.Checked.Equals(false) && cbTilSalg.Checked.Equals(false)
                && tbMinPris.Value.Equals(0) && tbMaxPris.Value.Equals(20) && tbMinM2.Value.Equals(0) && tbMaxM2.Value.Equals(20) && txtAdresse.Text.Length == 0)
            {
                bl = db.Get();
                dgvBolig.DataSource = bl;
                MessageBox.Show("ramt top");
            }
            else if (txtPostnummer.Text.Length > 0)
            {
                if (!postnummerbool || postnummerint < 999 || postnummerint > 10000)
                {
                    MessageBox.Show("Det intastede postnummer er ikke gyldigt!");
                    txtPostnummer.Text = null;
                }
            }
            else if (cbSolgt.Checked.Equals(true) && cbTilSalg.Checked.Equals(true))
            {
                MessageBox.Show("Fejl (Boligen kan ikke både være solgt og til salg)");
            }

            if (comboBoxAfdeling.Text.Length > 0)
            {
                afdeling = comboBoxAfdeling.Text;
            }
            if (comboBoxType.Text.Length > 0)
            {
                type = comboBoxType.Text;
            }
            if (txtPostnummer.Text.Length > 0)
            {
                postnummer = postnummerint;
            }
            if (cbSolgt.Checked.Equals(true))
            {
                salgsstatus = "Solgt";
            }
            if (cbTilSalg.Checked.Equals(true))
            {
                salgsstatus = "Til salg";
            }



        }





        private void tbMinPris_MouseUp(object sender, MouseEventArgs e)
        {
            SliderPris();
        }

        private void tbMaxPris_MouseUp(object sender, MouseEventArgs e)
        {
            SliderPris();
        }

        private void tbMinM2_MouseUp(object sender, MouseEventArgs e)
        {
            SliderM2();
        }

        private void tbMaxM2_MouseUp(object sender, MouseEventArgs e)
        {
            SliderM2();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
            this.Hide();
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            KundeForms kunde = new KundeForms();
            kunde.Show();
            this.Hide();
        }

        private void btnEjendomsmægler_Click(object sender, EventArgs e)
        {
            EjendomsmæglerForms ejendomsmægler = new EjendomsmæglerForms();
            ejendomsmægler.Show();
            this.Hide();
        }

        private void btnAfdeling_Click(object sender, EventArgs e)
        {
            AfdelingForms afdeling = new AfdelingForms();
            afdeling.Show();
            this.Hide();
        }
    }
}
