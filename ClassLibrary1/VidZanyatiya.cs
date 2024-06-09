using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class VidZanyatiya
    {
        private string opisanie;

        public VidZanyatiya(string opisanie)
        {
            this.opisanie = opisanie;
        }

        public string Opisanie
        {
            get { return opisanie; }
            set { opisanie = value; }
        }
    }
}

