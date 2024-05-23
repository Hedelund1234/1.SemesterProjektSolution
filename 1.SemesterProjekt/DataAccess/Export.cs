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
		KundeDbHandler kdb = new KundeDbHandler();
		internal bool ExportToCsv(List<Bolig> bl, string path, string navn)
		{
			Kunde kunde = new Kunde();
			string[] csvArray = new string[bl.Count + 1];
			string idkøber;
			string dato;
			for (int i = 0; bl.Count > i; i++)
			{
				csvArray[0] = "Bolig_Id;Adresse;Postnummer;Type;Udbudspris;Størrelse;Bolig_Kunde_Id;Bolig_Ejendomsmægler_Id;Bolig_Afdelings_Navn;Salgsstatus;Bolig_Kunde_Id_Køber;Handels_Dato;Kunde_Id;Navn;Email;Telefon_Nr";
					for (int j = 0; j < bl.Count; j++)
					{
					kunde = kdb.Get(bl[j].Bolig_Kunde_Id);
					if (bl[j].Bolig_Kunde_Id_Køber == 0)
						{
							idkøber = "";
						}
						else
						{
							idkøber = bl[j].Bolig_Kunde_Id_Køber.ToString();
						}
						if (bl[j].Handels_Dato == DateTime.MinValue)
						{
							dato = "";
						}
						else
						{
							dato = bl[j].Handels_Dato.ToString();
						}
						csvArray[j + 1] = $"{bl[j].Bolig_Id};{bl[j].Adresse};{bl[j].Postnummer};{bl[j].Type};{bl[j].Udbudspris};{bl[j].Størrelse};{bl[j].Bolig_Kunde_Id};{bl[j].Bolig_Ejendomsmægler_Id};{bl[j].Bolig_Afdelings_Navn};{bl[j].Salgsstatus};{idkøber};{dato};{kunde.Kunde_Id};{kunde.Navn};{kunde.Email};{kunde.Telefon_Nr}";
				}
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
		}
		internal bool SaveDataToCsv(List<BoligJoinKunde> boligJoinKunde, string filename, int arraySize)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			string[] csvArray = new string[arraySize + 1];
			csvArray[0] = "Bolig_Id;Adresse;Postnummer;Type;Pris;Størrelse;Tilknyttet ejendomsmægler;Afdeling;Kunde_Id;Navn;Email;Telefon:Nr";
			for (int i = 0; i < boligJoinKunde.Count; i++)
			{
				csvArray[i + 1] = $"{boligJoinKunde[i].Bolig_Id};{boligJoinKunde[i].Adresse};{boligJoinKunde[i].Postnummer};{boligJoinKunde[i].Type};{boligJoinKunde[i].Udbudspris};{boligJoinKunde[i].Størrelse};{boligJoinKunde[i].Bolig_Ejendomsmægler_Id};{boligJoinKunde[i].Bolig_Afdelings_Navn};{boligJoinKunde[i].Kunde_Id};{boligJoinKunde[i].Navn};{boligJoinKunde[i].Email};{boligJoinKunde[i].Telefon_Nr}";
			}
			bool isSuccess = false;
			try
			{
				File.WriteAllLines(Path.Combine(path, filename), csvArray);
				isSuccess = true;
			}
			catch (Exception)
			{

			}
			return isSuccess;
		}
	}
}
