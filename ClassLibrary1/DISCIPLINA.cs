using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Disciplina; //была добавлена
using static ClassLibrary1.Dolznost; //была добавлена

namespace ClassLibrary1
{
    public class Disciplina
    {
        private string name;
        private string sokrasch;

        public Disciplina(string name, string sokrasch)
        {
            this.name = name;
            this.sokrasch = sokrasch;
        }

        public string Name()
        {
            return name;
        }

        public string Sokrasch()
        {
            return sokrasch;
        }
    }
}