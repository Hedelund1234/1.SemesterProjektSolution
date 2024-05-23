using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    internal class BoligJoinKunde : Bolig
    {
        public int Kunde_Id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public int Telefon_Nr { get; set; }
        public string Kunde_Type { get; set; }
    }
}
