using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1.SemesterProjekt
{
    public partial class BoligForms : Form
    {
        BoligDbHandler db = new BoligDbHandler();
        List<Bolig> bl = new List<Bolig>();
        Bolig bolig = new Bolig();
        Export export = new Export();
        KundeDbHandler kdb = new KundeDbHandler();
        Kunde kunde = new Kunde();
        int minpris;
        int maxpris;
        int minm2;
        int maxm2;
        bool sort = false;

        public BoligForms()
        {
            InitializeComponent();
            SliderPris();
            SliderM2();
        }

        void kvmPris(List<Bolig> bl)
        {
            int udbud;
            int stør;
            int _sum = 0;
            int sum = 0;
            int sumUd = 0;
            if (bl != null)
            {
                for (int i = 0; i < bl.Count; i++)
                {
                    udbud = bl[i].Udbudspris;
                    stør = bl[i].Størrelse;
                    _sum = udbud / stør;
                    sum += _sum;
                }
            }
            sumUd = sum / bl.Count;
            txtKvmPris.Text = sumUd.ToString();
        }

        void SliderPris()
        {
            minpris = tbMinPris.Value * 250000;
            maxpris = tbMaxPris.Value * 250000;
            lblMinpris.Text = minpris.ToString();
            lblMaxpris.Text = maxpris.ToString();
            if (tbMaxPris.Value < tbMinPris.Value)
            {
                MessageBox.Show("Minimumspris er større end maksimumspris", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            minm2 = tbMinM2.Value * 15;
            maxm2 = tbMaxM2.Value * 15;
            lblMinM2.Text = minm2.ToString();
            lblMaxM2.Text = maxm2.ToString();
            if (tbMaxM2.Value < tbMinM2.Value)
            {
                MessageBox.Show("Minimus M2 er større end maksimums M2", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int id = (int)data.Cells["Bolig_Id"].Value;
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
            try
            {
                string afdeling = "";
                string type = "";
                int postnummer;
                string postnummerstring = "";
                string salgsstatus = "";
                string prismin = "";
                string prismax = "";
                string m2min = "";
                string m2max = "";
                string adresse = "";
                bool postnummerbool = int.TryParse(txtPostnummer.Text, out int postnummerint);
                if (txtPostnummer.Text.Length > 0)
                {
                    if (!postnummerbool || postnummerint < 999 || postnummerint > 10000)
                    {
                        MessageBox.Show("Det intastede postnummer er ikke gyldigt!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPostnummer.Text = null;
                    }

                }
                else if (cbSolgt.Checked.Equals(true) && cbTilSalg.Checked.Equals(true))
                {
                    MessageBox.Show("Boligen kan ikke både være solgt og til salg", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (comboBoxAfdeling.Text.Length == 0 && comboBoxType.Text.Length == 0 && txtPostnummer.Text.Length == 0 && cbSolgt.Checked.Equals(false) && cbTilSalg.Checked.Equals(false)
                    && tbMinPris.Value.Equals(0) && tbMaxPris.Value.Equals(20) && tbMinM2.Value.Equals(0) && tbMaxM2.Value.Equals(20) && txtAdresse.Text.Length == 0)
                {
                    bl = db.Get();
                    dgvBolig.DataSource = bl;
                }
                else
                {
                    adresse = txtAdresse.Text;
                    postnummerstring = postnummerint.ToString();
                    type = comboBoxType.Text;
                    afdeling = comboBoxAfdeling.Text;
                    if (cbSolgt.Checked.Equals(true))
                    {
                        salgsstatus = "Solgt";
                    }
                    if (cbTilSalg.Checked.Equals(true))
                    {
                        salgsstatus = "Til salg";
                    }
                    prismin = minpris.ToString();
                    prismax = maxpris.ToString();
                    m2min = minm2.ToString();
                    m2max = maxm2.ToString();


                    bl = db.Get(adresse, postnummerstring, type, afdeling, salgsstatus, prismin, prismax, m2min, m2max);
                    dgvBolig.DataSource = bl;
                }


                kvmPris(bl);

            }
            catch (Exception)
            {

            }
            if (bl.Count == 0)
            {
                MessageBox.Show("Der er ikke nogen boliger med disse kriterier", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private void dgvBolig_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Bolig> boligliste = dgvBolig.DataSource as List<Bolig>;

            if (e.ColumnIndex == 4)
            {
                if (sort)
                {
                    dgvBolig.DataSource = boligliste.OrderBy(b => b.Udbudspris).ToList();
                    sort = false;
                }
                else
                {
                    dgvBolig.DataSource = boligliste.OrderByDescending(b => b.Udbudspris).ToList();
                    sort = true;
                }
            }
            else if (e.ColumnIndex == 5)
            {
                if (sort)
                {
                    dgvBolig.DataSource = boligliste.OrderBy(b => b.Størrelse).ToList();
                    sort = false;
                }
                else
                {
                    dgvBolig.DataSource = boligliste.OrderByDescending(b => b.Størrelse).ToList();
                    sort = true;
                }
            }


        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            List<Bolig> boligliste = dgvBolig.DataSource as List<Bolig>;
            string navn = $"Hus M2Pris {txtKvmPris.Text.ToString()} udtræk.CSV";

            bool success = export.ExportToCsv(boligliste, path, navn);

            if (success)
            {
                MessageBox.Show(".CSV filen blev gemt på dit skrivebord!", ".csv fil gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(".CSV filen blev ikke gemt!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbMinPris_MouseMove(object sender, MouseEventArgs e)
        {
            SliderPris();
        }

        private void tbMaxPris_MouseMove(object sender, MouseEventArgs e)
        {
            SliderPris();
        }

        private void tbMinM2_MouseMove(object sender, MouseEventArgs e)
        {
            SliderM2();
        }

        private void tbMaxM2_MouseMove(object sender, MouseEventArgs e)
        {
            SliderM2();
        }
    }
}
