using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Dolznost; //была добавлена
using static ClassLibrary1.Disciplina; //была добавлена

namespace ClassLibrary1
{
    public class Dolznost
    {
        /// <summary>
        /// Класс Должность
        /// Вариант 10
        /// Сделал Ли Михаил
        /// </summary>
        private string nazvanie;
        private double oklad;
        private Podrazdelenie podrozdelenie;

        public Dolznost(string nazvanie, double oklad, Podrazdelenie podrazdelenie)
        {
            this.nazvanie = nazvanie;
            this.oklad = oklad;
            this.podrozdelenie = podrazdelenie;
        }

        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }

        public double Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }
        /// <summary>
        /// Класс Подразделение
        /// Вариант 11
        /// Сделал ...
        /// </summary>
        public class Podrazdelenie
        {
            private string nazvanie;
            public string Nazvanie
            {
                get { return nazvanie; }
                set { nazvanie = value; }
            }
        }
    }
}
