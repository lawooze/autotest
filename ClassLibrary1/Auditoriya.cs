using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Auditoriya;

namespace ClassLibrary1
{
    public class Auditoriya
    {
        private string nomer;

        public Auditoriya(string nomer)
        {
            this.nomer = nomer;
        }

        public string Nomer
        {
            get { return nomer; }
            set { nomer = value; }
        }
    }
}
