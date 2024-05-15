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
            connStrings = ConfigurationManager.ConnectionStrings["default"].ToString();
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
                    string afdelingsNavn = (string)reader["Afdelings_Nr"];
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
            string command = "SELECT * FROM Afdeling";
            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int afdelingsNr = (int)reader["Afdelings_Nr"];
                    string afdelingsNavn = (string)reader["Afdelings_Nr"];
                    afdeling = new Afdeling { Afdelings_Nr = afdelingsNr, Afdelings_Navn = afdelingsNavn }; al.Add(afdeling);
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
        internal bool Create(Afdeling afdeling)
        {
            return false;
        }
        internal bool Update(Afdeling afdeling)
        {
            return false;
        }
        internal bool Delete(int id)
        {
            return false;
        }
    }
}
