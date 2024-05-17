using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;

namespace _1.SemesterProjekt
{
    public partial class BoligForms : Form
    {
        BoligDbHandler db = new BoligDbHandler();
        List<Bolig> bl = new List<Bolig>();

        public BoligForms()
        {
            InitializeComponent();
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
            this.Close();
            OpretBoligForms opretboligforms = new OpretBoligForms();
            opretboligforms.Show();
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
            this.Hide();
            BoligDetails boligdetails = new BoligDetails(id);
            boligdetails.Hide();
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
