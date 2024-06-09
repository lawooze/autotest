using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Para
    {
        private DateTime startPair;
        private DateTime endPair;
        private DateTime startBreak;
        private DateTime endBreak;

        public Para(DateTime startPair, DateTime endPair, DateTime startBreak, DateTime endBreak)
        {
            this.startPair = startPair;
            this.endPair = endPair;
            this.startBreak = startBreak;
            this.endBreak = endBreak;
        }

        public DateTime StartPair
        {
            get { return startPair; }
            set { startPair = value; }
        }

        public DateTime EndPair
        {
            get { return endPair; }
            set { endPair = value; }
        }

        public DateTime StartBreak
        {
            get { return startBreak; }
            set { startBreak = value; }
        }

        public DateTime EndBreak
        {
            get { return endBreak; }
            set { endBreak = value; }
        }
    }
}

