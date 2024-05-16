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
            this.Hide();
            BoligForms boligForms = new BoligForms();
            boligForms.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
