using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Голубов Фёдор Олегович
    /// </summary>
    public class Gruppa
    {
        private string name;
        private string sokrasch;
        private int amount;
        private int year;
        private string link;
        private string boss;

        public Gruppa(string name, string sokrasch, int amount, int year, string link, string boss)
        {
            this.name = name;
            this.sokrasch = sokrasch;
            this.amount = amount;
            if (year == 0)
            {
                this.year = DateTime.Now.Year;
            }
            else
            {
                this.year = year;
            }
            this.link = link;
            this.boss = boss;
        }
    }
}


