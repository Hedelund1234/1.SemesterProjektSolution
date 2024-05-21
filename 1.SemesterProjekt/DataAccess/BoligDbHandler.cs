using _1.SemesterProjekt.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _1.SemesterProjekt.DataAccess
{
    internal class BoligDbHandler
    {
        string connStrings;
        public BoligDbHandler()
        {
            ConnectionHandler connectionHandler = new ConnectionHandler();
            connStrings = connectionHandler.GetConnectionString();
        }
        internal List<Bolig> Get(string adresse, string postnummer, string type, string afdeling, string salgsstatus, string prismin, string prismax,
                                  string m2min, string m2max)
        {
            List<Bolig> bl = new List<Bolig>();
            Bolig bolig = new Bolig();
            string command = "SELECT * FROM Bolig WHERE Adresse LIKE '%" + adresse + "%' AND Postnummer LIKE '%" + postnummer + "%' AND Type LIKE '%" + type + "%' AND Bolig_Afdelings_Navn LIKE '%" + afdeling + "%' AND Salgsstatus LIKE '%" + salgsstatus + "%' AND Udbudspris BETWEEN " + prismin + " AND " + prismax + " AND Størrelse BETWEEN " + m2min + " AND " + m2max + "";
            SqlConnection conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int _boligId = (int)reader["Bolig_Id"];
                    string _adresse = (string)reader["Adresse"];
                    int _postnummer = (int)reader["Postnummer"];
                    string _type = (string)reader["Type"];
                    int _udbudspris = (int)reader["Udbudspris"];
                    int _størrelse = (int)reader["Størrelse"];
                    int _boligKundeId = (int)reader["Bolig_Kunde_Id"];
                    int _boligEjendomsmæglerId = (int)reader["Bolig_Ejendomsmægler_Id"];
                    string _boligAfdelingsNavn = (string)reader["Bolig_Afdelings_Navn"];
                    string _salgsstatus = (string)reader["Salgsstatus"];
                    int? _boligKundeIdKøber = reader["Bolig_Kunde_Id_Køber"] is DBNull ? (int?)null : (int)reader["Bolig_Kunde_Id_Køber"];
                    DateTime? _handelsDato = reader["Handels_Dato"] is DBNull ? (DateTime?)null : (DateTime)reader["Handels_Dato"];

                    bolig = new Bolig
                    {
                        Bolig_Id = _boligId,
                        Adresse = _adresse,
                        Postnummer = _postnummer,
                        Type = _type,
                        Udbudspris = _udbudspris,
                        Størrelse = _størrelse,
                        Bolig_Kunde_Id = _boligKundeId,
                        Bolig_Ejendomsmægler_Id = _boligEjendomsmæglerId,
                        Bolig_Afdelings_Navn = _boligAfdelingsNavn,
                        Salgsstatus = _salgsstatus,
                        Bolig_Kunde_Id_Køber = _boligKundeIdKøber ?? 0,
                        Handels_Dato = _handelsDato ?? DateTime.MinValue
                    };
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
                    int? boligKundeIdKøber = reader["Bolig_Kunde_Id_Køber"] is DBNull ? (int?)null : (int)reader["Bolig_Kunde_Id_Køber"];
                    DateTime? handelsDato = reader["Handels_Dato"] is DBNull ? (DateTime?)null : (DateTime)reader["Handels_Dato"];

                    bolig = new Bolig { Bolig_Id = boligId, Adresse = adresse, Postnummer = postnummer, Type = type,
                        Udbudspris = udbudspris, Størrelse = størrelse, Bolig_Kunde_Id = boligKundeId,
                        Bolig_Ejendomsmægler_Id = boligEjendomsmæglerId, Bolig_Afdelings_Navn = boligAfdelingsNavn,
                        Salgsstatus = salgsstatus, Bolig_Kunde_Id_Køber = boligKundeIdKøber ?? 0, Handels_Dato = handelsDato ?? DateTime.MinValue };
                    
                }
            }
            catch (Exception)
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
                    int? boligKundeIdKøber = reader["Bolig_Kunde_Id_Køber"] is DBNull ? (int?)null : (int)reader["Bolig_Kunde_Id_Køber"];
                    DateTime? handelsDato = reader["Handels_Dato"] is DBNull ? (DateTime?)null : (DateTime)reader["Handels_Dato"];
                    bolig = new Bolig
                    {
                        Bolig_Id = boligId,
                        Adresse = adresse,
                        Postnummer = postnummer,
                        Type = type,
                        Udbudspris = udbudspris,
                        Størrelse = størrelse,
                        Bolig_Kunde_Id = boligKundeId,
                        Bolig_Ejendomsmægler_Id = boligEjendomsmæglerId,
                        Bolig_Afdelings_Navn = boligAfdelingsNavn,
                        Salgsstatus = salgsstatus,
                        Bolig_Kunde_Id_Køber = boligKundeIdKøber ?? 0,
                        Handels_Dato = handelsDato ?? DateTime.MinValue
                    };
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
        internal bool Create(Bolig bolig)
        {
            string command = "INSERT INTO Bolig (Bolig_Id, Adresse, Postnummer, Type, Udbudspris, Størrelse, Bolig_Kunde_Id, Bolig_Ejendomsmægler_Id, Bolig_Afdelings_Navn, Salgsstatus, Bolig_Kunde_Id_Køber, Handels_Dato) VALUES (@bId, @adr, @postNr, @type, @uPris, @str, @bKid, @bEId, @bANavn, @SalgStatus, @bKundeIdKøb, @hDato)";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@bId", bolig.Bolig_Id);
            cmd.Parameters.AddWithValue("@adr", bolig.Adresse);
            cmd.Parameters.AddWithValue("@postNr", bolig.Postnummer);
            cmd.Parameters.AddWithValue("@type", bolig.Type);
            cmd.Parameters.AddWithValue("@uPris", bolig.Udbudspris);
            cmd.Parameters.AddWithValue("@str", bolig.Størrelse);
            cmd.Parameters.AddWithValue("@bKid", bolig.Bolig_Kunde_Id);
            cmd.Parameters.AddWithValue("@bEId", bolig.Bolig_Ejendomsmægler_Id);
            cmd.Parameters.AddWithValue("@bANavn", bolig.Bolig_Afdelings_Navn);
            cmd.Parameters.AddWithValue("@SalgStatus", bolig.Salgsstatus);
            cmd.Parameters.AddWithValue("@bKundeIdKøb", bolig.Bolig_Kunde_Id_Køber);
            cmd.Parameters.AddWithValue("@hDato", bolig.Handels_Dato);

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
        internal bool Update(Bolig bolig)
        {
            string command = "UPDATE Bolig SET Adresse = @adr, Postnummer = @postNr, Type = @type, Udbudspris = @uPris, Størrelse = @str, Bolig_Kunde_Id = @bKid, Bolig_Ejendomsmægler_Id = @bEId, Bolig_Afdelings_Navn = @bANavn, Salgsstatus = @SalgStatus, Bolig_Kunde_Id_Køber = @bKundeIdKøb, Handels_Dato = @hDato WHERE Bolig_Id = @bId";
            SqlConnection conn = new SqlConnection(connStrings);
            SqlCommand cmd = new SqlCommand(command, conn);

            cmd.Parameters.AddWithValue("@bId", bolig.Bolig_Id);
            cmd.Parameters.AddWithValue("@adr", bolig.Adresse);
            cmd.Parameters.AddWithValue("@postNr", bolig.Postnummer);
            cmd.Parameters.AddWithValue("@type", bolig.Type);
            cmd.Parameters.AddWithValue("@uPris", bolig.Udbudspris);
            cmd.Parameters.AddWithValue("@str", bolig.Størrelse);
            cmd.Parameters.AddWithValue("@bKid", bolig.Bolig_Kunde_Id);
            cmd.Parameters.AddWithValue("@bEId", bolig.Bolig_Ejendomsmægler_Id);
            cmd.Parameters.AddWithValue("@bANavn", bolig.Bolig_Afdelings_Navn);
            cmd.Parameters.AddWithValue("@SalgStatus", bolig.Salgsstatus);
            if (bolig.Bolig_Kunde_Id_Køber == 0)
            {
                cmd.Parameters.AddWithValue("@bKundeIdKøb", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@bKundeIdKøb", bolig.Bolig_Kunde_Id_Køber);
            }
            if (bolig.Bolig_Kunde_Id_Køber == null)
            {
                cmd.Parameters.AddWithValue("@hDato", bolig.Bolig_Kunde_Id_Køber);
            }
            else
            {
                cmd.Parameters.AddWithValue("@hDato", DBNull.Value);
            }
            
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
            string command = "DELETE FROM Bolig WHERE Bolig_Id = @id";
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
