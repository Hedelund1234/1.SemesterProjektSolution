namespace _1.SemesterProjekt
{
    public partial class Forside : Form
    {
        public Forside()
        {
            InitializeComponent();
        }

        private void btnBolig_Click(object sender, EventArgs e)
        {
            BoligForms boligForms = new BoligForms();
            boligForms.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            KundeForms kunde = new KundeForms();
            kunde.Show();
            this.Hide();
        }

        private void btnEjendomsm�gler_Click(object sender, EventArgs e)
        {
            Ejendomsm�glerForms ejendomsm�gler = new Ejendomsm�glerForms();
            ejendomsm�gler.Show();
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
