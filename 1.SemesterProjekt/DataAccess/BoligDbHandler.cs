using _1.SemesterProjekt.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace _1.SemesterProjekt.DataAccess
{
    internal class BoligDbHandler
    {
        string connStrings;
        public BoligDbHandler()
        {
            connStrings = ConfigurationManager.ConnectionStrings["default"].ToString();
        }
        internal Bolig Get(int id)
        {
            Bolig bolig = new Bolig();
            string command = "SELECT * FROM Bolig WHERE Bolig_Id = @id";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int boligId = (int)reader["Bolig_Id"];
                    string adresse = (string)reader["Adresse"];
                    int postnummer = (int)reader["Postnummer"];
                    string type = (string)reader["Type"];
                    int udbudspris = (int)reader["Udbudspris"];
                    int størrelse = (int)reader["Størrelse"];
                    int boligKundeId = (int)reader["Bolig_Kunde_Id"];
                    int boligEjendomsmæglerId = (int)reader["Bolig_Ejendomsmægler_Id"];
                    string boligAfdelingsNavn = (string)reader["Bolig_Afdelings_Navn"];
                    string salgsstatus = (string)reader["Salgsstatus"];
                    int boligKundeIdKøber = (int)reader["Bolig_Kunde_Id_Køber"];
                    bolig = new Bolig { Bolig_Id = boligId, Adresse = adresse, Postnummer = postnummer, Type = type, Udbudspris = udbudspris, Størrelse = størrelse, Bolig_Kunde_Id = boligKundeId, Bolig_Ejendomsmægler_Id = boligEjendomsmæglerId, Bolig_Afdelings_Navn = boligAfdelingsNavn, Salgsstatus = salgsstatus, Bolig_Kunde_Id_Køber = boligKundeIdKøber };
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return bolig;
        }
        internal List<Bolig> Get()
        {
            List<Bolig> bl = new List<Bolig>();
            Bolig bolig = new Bolig();
            string command = "SELECT * FROM Bolig";
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
                    int udbudspris = (int)reader["Udbudspris"];
                    int størrelse = (int)reader["Størrelse"];
                    int boligKundeId = (int)reader["Bolig_Kunde_Id"];
                    int boligEjendomsmæglerId = (int)reader["Bolig_Ejendomsmægler_Id"];
                    string boligAfdelingsNavn = (string)reader["Bolig_Afdelings_Navn"];
                    string salgsstatus = (string)reader["Salgsstatus"];
                    int boligKundeIdKøber = (int)reader["Bolig_Kunde_Id_Køber"];
                    bolig = new Bolig { Bolig_Id = boligId, Adresse = adresse, Postnummer = postnummer, Type = type, Udbudspris = udbudspris, Størrelse = størrelse, Bolig_Kunde_Id = boligKundeId, Bolig_Ejendomsmægler_Id = boligEjendomsmæglerId, Bolig_Afdelings_Navn = boligAfdelingsNavn, Salgsstatus = salgsstatus, Bolig_Kunde_Id_Køber = boligKundeIdKøber};
                    bl.Add(bolig);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return bl;
        }
        internal bool Create(Bolig bolig)
        {
            return false;
        }
        internal bool Update(Bolig bolig)
        {
            return false;
        }
        internal bool Delete(int id)
        {
            return false;
        }
    }
}
