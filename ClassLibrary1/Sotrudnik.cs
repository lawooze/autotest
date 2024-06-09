using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Sotrudnik;

namespace ClassLibrary1
{
    public class Sotrudnik
    {
        public string Imya { get; set; }
        public string Familiya { get; set; }

        public Sotrudnik(string imya, string familiya)
        {
            Imya = imya;
            Familiya = familiya;
        }
    }
}
