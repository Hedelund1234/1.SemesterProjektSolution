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
    public partial class BoligDetails : Form
    {
        int id;
        BoligDbHandler db;
        Bolig bolig;
        public BoligDetails(int id)
        {
            InitializeComponent();

            this.id = id;

            SeedData();
        }
        void SeedData()
        {
            db = new BoligDbHandler();
            bolig = db.Get(id);
            txtBoligId.Text = bolig.Bolig_Id.ToString();
            txtAdresse.Text = bolig.Adresse;
            txtPostnummer.Text = bolig.Postnummer.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            BoligForms boligforms = new BoligForms();
            boligforms.Show();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            AfdelingForms afdeling = new AfdelingForms();
            afdeling.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
