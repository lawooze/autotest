using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Organizaciya;

namespace ClassLibrary1
{
    public class Podrazdelenie
    {
        private string nazvanie;
        private PodrazdelenieSotrudnik rukovoditel;
        private PodrazdelenieOrganizaciya ssylkaNaOrganizatsiyu;

        public Podrazdelenie(string nazvanie, PodrazdelenieSotrudnik rukovoditel, PodrazdelenieOrganizaciya ssylkaNaOrganizatsiyu)
        {
            this.nazvanie = nazvanie;
            this.rukovoditel = rukovoditel;
            this.ssylkaNaOrganizatsiyu = ssylkaNaOrganizatsiyu;
        }

        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }

        public PodrazdelenieSotrudnik Rukovoditel
        {
            get { return rukovoditel; }
            set { rukovoditel = value; }
        }

        public PodrazdelenieOrganizaciya SsylkaNaOrganizatsiyu
        {
            get { return ssylkaNaOrganizatsiyu; }
            set { ssylkaNaOrganizatsiyu = value; }
        }
    }

    public class PodrazdelenieSotrudnik
    {
        public string Imya { get; set; }
        public string Familiya { get; set; }

        public PodrazdelenieSotrudnik(string imya, string familiya)
        {
            Imya = imya;
            Familiya = familiya;
        }
    }

    public class PodrazdelenieOrganizaciya
    {
        public string Nazvanie { get; set; }

        public PodrazdelenieOrganizaciya(string nazvanie)
        {
            Nazvanie = nazvanie;
        }
    }
}
