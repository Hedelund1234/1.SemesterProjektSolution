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
    public partial class OpretBoligForms : Form
    {
        KundeDbHandler kdb = new KundeDbHandler();
        List<Kunde> kundelist = new List<Kunde>();
        public OpretBoligForms()
        {
            InitializeComponent();
        }

        private void btnTilbage_Click(object sender, EventArgs e)
        {
            this.Close();
            BoligForms boligForms = new BoligForms();
            boligForms.Show();
        }

        private void OpretBoligForms_Load(object sender, EventArgs e)
        {
            kundelist = kdb.Get();
            dgvKunde.DataSource = kundelist;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
