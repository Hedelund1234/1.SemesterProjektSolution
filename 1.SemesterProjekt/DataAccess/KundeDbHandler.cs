using _1.SemesterProjekt.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace _1.SemesterProjekt.DataAccess
{
    internal class KundeDbHandler
    {
        string connStrings;
        public KundeDbHandler()
        {
            ConnectionHandler connectionHandler = new ConnectionHandler();
            connStrings = connectionHandler.GetConnectionString();
        }
        internal Kunde Get(int id)
        {
            Kunde kunde = new Kunde();
            string command = "SELECT * FROM Kunde WHERE Kunde_Id = @id";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int kunde_id = (int)reader["Kunde_Id"];
                    string navn = (string)reader["Navn"];
                    string email = (string)reader["Email"];
                    int telefon_nr = (int)reader["Telefon_Nr"];
                    string kunde_type = (string)reader["Kunde_Type"];
                    kunde = new Kunde { Kunde_Id = kunde_id, Navn = navn, Email = email, Telefon_Nr = telefon_nr, Kunde_Type = kunde_type };
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return kunde;
        }
        internal List<Kunde> Get(string id, string _navn, string _email, string _telefon_nr, string _kunde_type)
        {
            List<Kunde> kl = new List<Kunde>();
            Kunde kunde = new Kunde();
            string command = "SELECT * FROM Kunde WHERE Kunde_Id LIKE @stringId AND Navn LIKE @stringNavn AND Email LIKE @stringEmail AND Telefon_Nr LIKE @stringTelefonnummer AND Kunde_Type LIKE @stringKundeType";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@stringId", "%" +  id + "%");
            cmd.Parameters.AddWithValue("@stringNavn", "%" + _navn + "%");
            cmd.Parameters.AddWithValue("@stringEmail", "%" + _email + "%");
            cmd.Parameters.AddWithValue("@stringTelefonnummer", "%" + _telefon_nr + "%");
            cmd.Parameters.AddWithValue("@stringKundeType", "%" + _kunde_type + "%");
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int kunde_id = (int)reader["Kunde_Id"];
                    string navn = (string)reader["Navn"];
                    string email = (string)reader["Email"];
                    int telefon_nr = (int)reader["Telefon_Nr"];
                    string kunde_type = (string)reader["Kunde_Type"];

                    kunde = new Kunde { Kunde_Id = kunde_id, Navn = navn, Email = email, Telefon_Nr = telefon_nr, Kunde_Type = kunde_type };
                    kl.Add(kunde);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return kl;
        }
        internal List<Kunde> Get()
        {
            List<Kunde> kl = new List<Kunde>();
            Kunde kunde = new Kunde();
            string command = "SELECT * FROM Kunde";
            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int kunde_id = (int)reader["Kunde_Id"];
                    string navn = (string)reader["Navn"];
                    string email = (string)reader["Email"];
                    int telefon_nr = (int)reader["Telefon_Nr"];
                    string kunde_type = (string)reader["Kunde_Type"];

                    kunde = new Kunde { Kunde_Id = kunde_id, Navn = navn, Email = email, Telefon_Nr = telefon_nr, Kunde_Type = kunde_type};
                    kl.Add(kunde);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return kl;
        }
        internal bool Create(Kunde kunde)
        {
            string command = "INSERT INTO Kunde (Navn, Email, Telefon_Nr, Kunde_Type) VALUES (@navn, @email, @telefonNr, @kType)";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);

            cmd.Parameters.AddWithValue("@kId", kunde.Kunde_Id);
            cmd.Parameters.AddWithValue("@navn", kunde.Navn);
            cmd.Parameters.AddWithValue("@email", kunde.Email);
            cmd.Parameters.AddWithValue("@telefonNr", kunde.Telefon_Nr);
            cmd.Parameters.AddWithValue("@kType", kunde.Kunde_Type);
            int rows = 0;
            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            if (rows == 0)
            {
                return false;
            }
            return true;
        }
        internal bool Update(Kunde kunde)
        {
            string command = "UPDATE Kunde SET Navn = @navn, Email = @email, Telefon_Nr = @telefonNr, Kunde_Type = @kType WHERE Kunde_Id = @kId";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@kId", kunde.Kunde_Id);
            cmd.Parameters.AddWithValue("@navn", kunde.Navn);
            cmd.Parameters.AddWithValue("@email", kunde.Email);
            cmd.Parameters.AddWithValue("@telefonNr", kunde.Telefon_Nr);
            cmd.Parameters.AddWithValue("@kType", kunde.Kunde_Type);
            int rows = 0;
            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            if (rows == 0)
            {
                return false;
            }
            return true;
        }
        internal bool Delete(int id)
        {
            string command = "DELETE FROM Kunde WHERE Kunde_Id = @id";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);

            cmd.Parameters.AddWithValue("@id", id);
            int rows = 0;
            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            if (rows == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
