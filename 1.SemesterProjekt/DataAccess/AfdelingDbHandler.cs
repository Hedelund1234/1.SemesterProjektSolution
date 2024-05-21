using _1.SemesterProjekt.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace _1.SemesterProjekt.DataAccess
{
    internal class AfdelingDbHandler
    {
        string connStrings;
        public AfdelingDbHandler()
        {
            ConnectionHandler connectionHandler = new ConnectionHandler();
            connStrings = connectionHandler.GetConnectionString();
        }
        internal Afdeling Get(int id)
        {
            Afdeling afdeling = new Afdeling();
            string command = "SELECT * FROM Afdeling WHERE Afdelings_Nr = @afdelingsNr";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@afdelingsNr", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int afdelingsNr = (int)reader["Afdelings_Nr"];
                    string afdelingsNavn = (string)reader["Afdelings_Navn"];
                    afdeling = new Afdeling { Afdelings_Nr = afdelingsNr, Afdelings_Navn = afdelingsNavn };
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return afdeling;
        }
        internal List<Afdeling> Get()
        {
            List<Afdeling> al = new List<Afdeling>();
            Afdeling afdeling = new Afdeling();
            string command = "SELECT * FROM Afdeling ORDER BY Afdelings_Nr";
            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int afdelingsNr = (int)reader["Afdelings_Nr"];
                    string afdelingsNavn = (string)reader["Afdelings_Navn"];
                    afdeling = new Afdeling { Afdelings_Nr = afdelingsNr, Afdelings_Navn = afdelingsNavn };
                    al.Add(afdeling);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return al;
        }
        internal List<Bolig> GetJoinBolig(string join, string navn)
        {
            List<Bolig> bl = new List<Bolig>();
            Bolig bolig = new Bolig();
            
            string command = "SELECT * FROM Afdeling, " + join + " WHERE Bolig_Afdelings_Navn = Afdelings_Navn AND Afdelings_Navn = '" + navn + "' ";

            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int boligId = (int)reader["Bolig_Id"];
                    string adresse = (string)reader["Adresse"];
                    int postnummer = (int)reader["Postnummer"];
                    string type = (string)reader["Type"];
                    int pris = (int)reader["Udbudspris"];
                    int størrelse = (int)reader["Størrelse"];
                    int boligKundeId = (int)reader["Bolig_Kunde_Id"];
                    int boligEjendomsmæglerId = (int)reader["Bolig_Ejendomsmægler_Id"];
                    string boligAfdelingsNavn = (string)reader["Bolig_Afdelings_Navn"];
                    string salgsStatus = (string)reader["Salgsstatus"];
                    int? boligKundeIdKøber = reader["Bolig_Kunde_Id_Køber"] is DBNull ? (int?)null : (int)reader["Bolig_Kunde_Id_Køber"];
                    DateTime? handelsDato = reader["Handels_Dato"] is DBNull ? (DateTime?)null : (DateTime)reader["Handels_Dato"];
                    bolig = new Bolig { Bolig_Id = boligId, Adresse = adresse, Postnummer = postnummer, Type = type, Udbudspris = pris, Størrelse = størrelse, Bolig_Kunde_Id = boligKundeId, Bolig_Ejendomsmægler_Id = boligEjendomsmæglerId, Bolig_Afdelings_Navn = boligAfdelingsNavn, Salgsstatus = salgsStatus, Bolig_Kunde_Id_Køber = boligKundeIdKøber ?? 0, Handels_Dato = handelsDato ?? DateTime.MinValue };
                    bl.Add(bolig);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return bl;
        }
        internal List<Ejendomsmægler> GetJoinEjendomsmægler(string join, int nr)
        {
            List<Ejendomsmægler> el = new List<Ejendomsmægler>();
            Ejendomsmægler ejendomsmægler = new Ejendomsmægler();

            string command = "SELECT * FROM Afdeling, " + join + " WHERE Ejendomsmægler_Afdeling_Nr = Afdelings_Nr AND Afdelings_Nr = " + nr + " ";

            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ejendomsmæglerId = (int)reader["Id"];
                    string navn = (string)reader["Navn"];
                    int telefonnummer = (int)reader["Telefon_Nr"];
                    string email = (string)reader["Email"];
                    int mæglerId = (int)reader["Ejendomsmægler_Afdeling_Nr"];
                    ejendomsmægler = new Ejendomsmægler { Id = ejendomsmæglerId, Navn = navn, Telefon_Nr = telefonnummer, Email = email, Ejendomsmægler_Afdeling_Nr = mæglerId };
                    el.Add(ejendomsmægler);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return el;
        }
        internal List<Afdeling> Get(string nr, string _navn)
        {
            List<Afdeling> al = new List<Afdeling>();
            Afdeling afdeling = new Afdeling();
            string command = "SELECT * FROM Afdeling WHERE Afdelings_Nr LIKE '%" + nr + "%' AND Afdelings_Navn LIKE '%" + _navn + "%'";
            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int afdelingsNr = (int)reader["Afdelings_Nr"];
                    string afdelingsNavn = (string)reader["Afdelings_Navn"];

                    afdeling = new Afdeling { Afdelings_Nr = afdelingsNr, Afdelings_Navn = afdelingsNavn };
                    al.Add(afdeling);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return al;
        }
        internal bool SaveDataToCsv(List<Bolig> boligList, List<Ejendomsmægler> ejendomsmæglerList, string filename, int arraySize)
        {
            string[] csvArray = new string[arraySize + 3];
            csvArray[0] = "Bolig_Id;Adresse;Postnummer;Type;Udbudspris;Størrelse;Bolig_Kunde_Id;Bolig_Ejendomsmægler_Id;Bolig_Afdelings_Navn;Salgsstatus;Bolig_Kunde_Id_Køber;Handels_Dato";
            csvArray[arraySize + 1] = "Id;Navn;Telefon_Nr;Email;Ejendomsmægler_Afdeling_Nr";
            for (int i = 0; i < boligList.Count; i++)
            {
                csvArray[i + 1] = $"{boligList[i].Bolig_Id};{boligList[i].Adresse};{boligList[i].Postnummer};{boligList[i].Type};{boligList[i].Udbudspris};{boligList[i].Størrelse};{boligList[i].Bolig_Kunde_Id};{boligList[i].Bolig_Ejendomsmægler_Id};{boligList[i].Bolig_Afdelings_Navn};{boligList[i].Salgsstatus};{boligList[i].Bolig_Kunde_Id_Køber};{boligList[i].Handels_Dato}";
            }
            csvArray[arraySize + 2] = $"{ejendomsmæglerList[0].Id};{ejendomsmæglerList[0].Navn};{ejendomsmæglerList[0].Telefon_Nr};{ejendomsmæglerList[0].Email};{ejendomsmæglerList[0].Ejendomsmægler_Afdeling_Nr}";
            bool isSuccess = false;
            try
            {
                File.WriteAllLines(Path.Combine("C:\\Users\\hjalt\\OneDrive\\Skrivebord\\", filename), csvArray);
                
                isSuccess = true;
            }
            catch (Exception)
            {

            }
            return isSuccess;
        }
    }
}
