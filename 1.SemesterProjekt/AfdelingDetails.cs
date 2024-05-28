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
        Export csv = new Export();
        bool sort = false;
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
            List<BoligJoinKunde> boligJoinKundeList = new List<BoligJoinKunde>();


            boligJoinKundeList = db.GetJoinAfdeling(txtBoxAfdelingsNavnDetails.Text);
            
            bool success = csv.SaveDataToCsv(boligJoinKundeList, $"Boliger {txtBoxAfdelingsNavnDetails.Text}.csv", boligJoinKundeList.Count);
            if (success)
            {
                MessageBox.Show(".csv fil gemt", ".csv gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(".csv fil blev IKKE gemt", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAfdelingsDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBoxAfdelingsDetailsSøg.Text == "Bolig")
            {
                int row = e.RowIndex;

                DataGridView dgv = sender as DataGridView;

                DataGridViewRow data = dgv.Rows[row];
                int id = (int)data.Cells["Bolig_Id"].Value;
                NavigateToDetailsBolig(id);
            }
            else if (comboBoxAfdelingsDetailsSøg.Text == "Ejendomsmægler")
            {
                int row = e.RowIndex;

                DataGridView dgv = sender as DataGridView;

                DataGridViewRow data = dgv.Rows[row];
                int id = (int)data.Cells["Id"].Value;
                NavigateToDetailsEjendomsmægler(id);
            }
        }
        void NavigateToDetailsBolig(int id)
        {
            BoligDetails bolig = new BoligDetails(id);
            bolig.Show();
            this.Hide();
        }
        void NavigateToDetailsEjendomsmægler(int id)
        {
            EjendomsmæglerDetails ejendomsmæglerDetails = new EjendomsmæglerDetails(id);
            ejendomsmæglerDetails.Show();
            this.Hide();
        }

        private void dgvAfdelingsDetails_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Ejendomsmægler> ejendomsmæglerListe = dgvAfdelingsDetails.DataSource as List<Ejendomsmægler>;
            List<Bolig> boligListe = dgvAfdelingsDetails.DataSource as List<Bolig>;
            if (comboBoxAfdelingsDetailsSøg.Text == "Bolig")
            {
                if (e.ColumnIndex == 0)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Bolig_Id).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Bolig_Id).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Adresse).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Adresse).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Postnummer).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Postnummer).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Type).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Type).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Udbudspris).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Udbudspris).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Størrelse).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Størrelse).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Bolig_Kunde_Id).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Bolig_Kunde_Id).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 7)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Bolig_Ejendomsmægler_Id).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Bolig_Ejendomsmægler_Id).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 8)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Bolig_Afdelings_Navn).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Bolig_Afdelings_Navn).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 9)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Salgsstatus).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Salgsstatus).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 10)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Bolig_Kunde_Id_Køber).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Bolig_Kunde_Id_Køber).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 11)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderByDescending(b => b.Handels_Dato).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = boligListe.OrderBy(b => b.Handels_Dato).ToList();
                        sort = false;
                    }
                }
            }
            else if (comboBoxAfdelingsDetailsSøg.Text == "Ejendomsmægler")
            {
                if (e.ColumnIndex == 0)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderByDescending(x => x.Id).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderBy(x => x.Id).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderByDescending(x => x.Navn).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderBy(x => x.Navn).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderByDescending(x => x.Telefon_Nr).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderBy(x => x.Telefon_Nr).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderByDescending(x => x.Email).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderBy(x => x.Email).ToList();
                        sort = false;
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    if (sort == false)
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderByDescending(x => x.Ejendomsmægler_Afdeling_Nr).ToList();
                        sort = true;
                    }
                    else
                    {
                        dgvAfdelingsDetails.DataSource = ejendomsmæglerListe.OrderBy(x => x.Ejendomsmægler_Afdeling_Nr).ToList();
                        sort = false;
                    }
                }
            }
        }
    }
}
