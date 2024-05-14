namespace _1.SemesterProjekt.Models
{
    internal class Bolig
    {
        public int Bolig_Id { get; set; }
        public string Adresse { get; set; }
        public int Postnummer { get; set; }
        public string Type { get; set; }
        public int Udbudspris { get; set; }
        public int Størrelse { get; set; }
        public int Bolig_Kunde_Id { get; set; }
        public int Bolig_Ejendomsmægler_Id { get; set; }
        public string Bolig_Afdelings_Navn { get; set; }
        public string Salgsstatus { get; set; }
        public int Bolig_Kunde_Id_Køber { get; set; }
    }
}
