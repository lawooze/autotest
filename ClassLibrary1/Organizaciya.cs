using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Класс организация
    /// Вариант 12
    /// Тарасов Илья
    /// </summary>
    public class Organizaciya
    {
        private string _nazvanie;
        private string _yuridicheskiyAdres;
        private string _fakticheskiyAdres;
        //private Sotrudnik _rukovoditel; //класс сотрудник еще не создан

        public Organizaciya(string nazvanie, string yuridicheskiyAdres, string fakticheskiyAdres /*Sotrudnik rukovoditel*/)// класс пока еще не создан
        {
            _nazvanie = nazvanie;
            _yuridicheskiyAdres = yuridicheskiyAdres;
            _fakticheskiyAdres = fakticheskiyAdres;
            //_rukovoditel = rukovoditel;
        }
    }
}
