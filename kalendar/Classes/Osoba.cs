using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalendar.Classes
{
    public class Osoba
    {
        public string Name;
        public string Prezime { get; }
        public string email { get; }
        public DateTime EndDate { get; }
        public int god;
        public List<string> osobe { get; private set; }
        public Dictionary<string, bool> osobe_dict { get; private set; }
    }
}
