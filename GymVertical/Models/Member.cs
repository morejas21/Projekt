using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymVertical.Models
{
    public class Member : object 
    {
        public int BrojKartice { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string MjestoStanovanja { get; set; }
        public string BrojMobitela { get; set; }
        public string StatusZlatniClan { get; set; }
        public string Pogodnost { get; set; }
    }
}
