using _1.SemesterProjekt.Models;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _1.SemesterProjekt.DataAccess
{
    internal class EjendomsmæglerDbHandler
    {
        string connStrings;
        public EjendomsmæglerDbHandler()
        {
            ConnectionHandler connectionHandler = new ConnectionHandler();
            connStrings = connectionHandler.GetConnectionString();
        }
        internal Ejendomsmægler Get(int id)
        {
            Ejendomsmægler ejendomsmægler = new Ejendomsmægler();
            string command = "SELECT * FROM Ejendomsmægler WHERE Id = @id";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int _id = (int)reader["Id"];
                    string navn = (string)reader["Navn"];
                    int telefonNr = (int)reader["Telefon_Nr"];
                    string email = (string)reader["Email"];
                    int ejendomsmæglerAfdelingNr = (int)reader["Ejendomsmægler_Afdeling_Nr"];
                    ejendomsmægler = new Ejendomsmægler { Id = _id, Navn = navn, Email = email, Telefon_Nr = telefonNr, Ejendomsmægler_Afdeling_Nr = ejendomsmæglerAfdelingNr };
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return ejendomsmægler;
        }
        internal List<Ejendomsmægler> Get()
        {
            List<Ejendomsmægler> el = new List<Ejendomsmægler>();
            Ejendomsmægler ejendomsmægler = new Ejendomsmægler();
            string command = "SELECT * FROM Ejendomsmægler";
            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int _id = (int)reader["Id"];
                    string navn = (string)reader["Navn"];
                    int telefonNr = (int)reader["Telefon_Nr"];
                    string email = (string)reader["Email"];
                    int ejendomsmæglerAfdelingNr = (int)reader["Ejendomsmægler_Afdeling_Nr"];
                    ejendomsmægler = new Ejendomsmægler { Id = _id, Navn = navn, Email = email, Telefon_Nr = telefonNr, Ejendomsmægler_Afdeling_Nr = ejendomsmæglerAfdelingNr };
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
        internal bool Create(Ejendomsmægler ejendomsmægler)
        {
            string command = "insert Ejendomsmægler (Navn, Telefon_Nr, Email, Ejendomsmægler_Afdeling_Nr) Values (@navn, @tlf, @email, @afdNr)";

            using SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);

            cmd.Parameters.AddWithValue("@navn", ejendomsmægler.Navn);
            cmd.Parameters.AddWithValue("@tlf", ejendomsmægler.Telefon_Nr);
            cmd.Parameters.AddWithValue("@email", ejendomsmægler.Email);
            cmd.Parameters.AddWithValue("@afdNr", ejendomsmægler.Ejendomsmægler_Afdeling_Nr);
            int rows = 0;
            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
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
        internal bool Update(Ejendomsmægler ejendomsmægler)
        {
             string command = "UPDATE Ejendomsmægler SET Navn= @navn, Telefon_Nr= @tlf, Email= @email, Ejendomsmægler_Afdeling_Nr= @afdNr WHERE Id = @Id";

            using SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);

            cmd.Parameters.AddWithValue("@Id", ejendomsmægler.Id);
            cmd.Parameters.AddWithValue("@navn", ejendomsmægler.Navn);
            cmd.Parameters.AddWithValue("@tlf", ejendomsmægler.Telefon_Nr);
            cmd.Parameters.AddWithValue("@email", ejendomsmægler.Email);
            cmd.Parameters.AddWithValue("@afdNr", ejendomsmægler.Ejendomsmægler_Afdeling_Nr);
            int rows = 0;
            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
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
        internal bool Delete(int id)
        {
             string command = "DELETE FROM Ejendomsmægler WHERE Id = @Id";

            using SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);

            cmd.Parameters.AddWithValue("@Id", id);
            int rows = 0;
            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
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
