using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Dolznost;

namespace ClassLibrary1
{
    class SOTRUDNIKI
    {
        private string lastName;
        private string firstName;
        private string middleName;
        private string position;
        private Dolznost dolznost;

        public SOTRUDNIKI(string lastName, string firstName, string middleName, string position)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.position = position;
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
