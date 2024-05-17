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
    public partial class OpretEjendomsmæglerForms : Form
    {
        public OpretEjendomsmæglerForms()
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
            BoligForms bolig = new BoligForms();
            bolig.Show();
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

        private void btnTilbage_Click(object sender, EventArgs e)
        {
            EjendomsmæglerForms ejendomsmægler = new EjendomsmæglerForms();
            ejendomsmægler.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
