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
    public partial class EjendomsmæglerDetails : Form
    {
        EjendomsmæglerDbHandler db;
        int ejen_Id;    
        public EjendomsmæglerDetails(int SelectedEjendomsmæglerId)
        {
            InitializeComponent();
            ejen_Id = SelectedEjendomsmæglerId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SaveEjendomsmæglerData();
            MessageBox.Show("Du har opdateret din ejendomsmægler:");
            this.Close();
        }

        void Get()
        {
            Ejendomsmægler ejendomsmægler = new Ejendomsmægler();
            //db = EjendomsmæglerDbHandler;
           // ejendomsmægler = db.Get(SelectedEjendomsmæglerId);



        }

        void SaveEjendomsmæglerData()
        {


        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Forside forside = new Forside();
            forside.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            OpretEjendomsmæglerForms opretEjendomsmægler = new OpretEjendomsmæglerForms();
            opretEjendomsmægler.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
