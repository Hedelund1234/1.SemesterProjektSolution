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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _1.SemesterProjekt
{
    public partial class OpretEjendomsmæglerForms : Form
    {
        public OpretEjendomsmæglerForms()
        {
            InitializeComponent();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(txtTelefonNr.Text, out int tnr);
            string email = txtEmail.Text;
            string[] nymailstring = email.Split('@');
            string afdeling;
            EjendomsmæglerDbHandler ejendomsmægler = new EjendomsmæglerDbHandler();

            if (txtNavn.Text.Length > 50)
            {
                MessageBox.Show("Navn skal være i mellem 1 og 50 bogstaver");
            }
            else if (!success || tnr < 8 && tnr > 8)
            {
                MessageBox.Show("Telefonnummer skal indeholde tal og 8 cifre!");
            }
            else if (!email.Contains('@'))
            {
                Console.WriteLine($"Indtast email (Skal indeholde @)");
                nymailstring = email.Split('@');
            }
            else if (nymailstring[0].Length < 2 && nymailstring[1].Length < 2)
            {
                Console.WriteLine($"Indtast email (så kort kan den ikke være)");
                nymailstring = email.Split('@');
            }
            else if (!nymailstring[1].Contains(".dk") && !nymailstring[1].Contains(".com"))
            {
                Console.WriteLine($"Indtast email (skal slutte på .dk eller .com)");
                nymailstring = email.Split('@');
            }
            else
            {
                MessageBox.Show("Noget gik galt, prøv igen!");
            }

            if(ComboBox1.Text.Length > 0) 
            { 
                afdeling = ComboBox1.Text;
            }

            ejendomsmægler.Create(new Ejendomsmægler { Navn = txtNavn.Text, Telefon_Nr = Convert.ToInt32(txtTelefonNr.Text), Email = txtEmail.Text, Ejendomsmægler_Afdeling_Nr = Convert.ToInt32(txtTelefonNr.Text) });
            MessageBox.Show("Du har oprettet en ny ejendomsmægler:");
        }
    }
}
