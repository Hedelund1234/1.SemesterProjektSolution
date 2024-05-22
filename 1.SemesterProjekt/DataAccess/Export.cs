using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;

namespace _1.SemesterProjekt.DataAccess
{
    internal class Export
    {
        internal bool ExportToCsv(List<Bolig> bl, string path, string navn)
        {
            string[] csvArray = new string[bl.Count + 1];
            string idkøber;
            string dato;
            csvArray[0] = "Bolig_Id;Adresse;Postnummer;Type;Udbudspris;Størrelse;Bolig_Kunde_Id;Bolig_Ejendomsmægler_Id;Bolig_Afdelings_Navn;Salgsstatus;Bolig_Kunde_Id_Køber;Handels_Dato";
            for (int i = 0; i < bl.Count; i++)
            {
                if (bl[i].Bolig_Kunde_Id_Køber == 0)
                {
                    idkøber = "";
                }
                else
                {
                    idkøber = bl[i].Bolig_Kunde_Id_Køber.ToString();
                }
                if (bl[i].Handels_Dato == DateTime.MinValue)
                {
                    dato = "";
                }
                else
                {
                    dato = bl[i].Handels_Dato.ToString();
                }
                csvArray[i + 1] = $"{bl[i].Bolig_Id};{bl[i].Adresse};{bl[i].Postnummer};{bl[i].Type};{bl[i].Udbudspris};{bl[i].Størrelse};{bl[i].Bolig_Kunde_Id};{bl[i].Bolig_Ejendomsmægler_Id};{bl[i].Bolig_Afdelings_Navn};{bl[i].Salgsstatus};{idkøber};{dato}";
            }

            try
            {
                File.WriteAllLines(Path.Combine(path, navn), csvArray);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;

        }
    }
}
