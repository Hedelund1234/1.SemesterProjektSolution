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
    }
}
