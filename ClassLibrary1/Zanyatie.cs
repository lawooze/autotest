using System;
using static ClassLibrary1.Disciplina;
using static ClassLibrary1.Dolznost;
using static ClassLibrary1.Gruppa;
using static ClassLibrary1.Para;
using static ClassLibrary1.Sotrudnik;
using static ClassLibrary1.Zanyatie;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Zanyatie
    {
        private DateTime dataProvedeniya;
        private Disciplina disciplina;
        private Sotrudnik sotrudnik;
        private Auditoriya auditoriya;
        private Gruppa gruppa;
        private Para para;
        private VidZanyatiya vidZanyatiya;

        public Zanyatie(
            DateTime? dataProvedeniya,
            Disciplina disciplina,
            Sotrudnik sotrudnik,
            Auditoriya auditoriya,
            Gruppa gruppa,
            Para para,
            VidZanyatiya vidZanyatiya)
        {
            this.dataProvedeniya = dataProvedeniya ?? DateTime.Now;
            this.disciplina = disciplina;
            this.sotrudnik = sotrudnik;
            this.auditoriya = auditoriya;
            this.gruppa = gruppa;
            this.para = para;
            this.vidZanyatiya = vidZanyatiya;
        }

        public DateTime DataProvedeniya
        {
            get { return dataProvedeniya; }
            set { dataProvedeniya = value; }
        }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        public Sotrudnik Sotrudnik
        {
            get { return sotrudnik; }
            set { sotrudnik = value; }
        }

        public Auditoriya Auditoriya
        {
            get { return auditoriya; }
            set { auditoriya = value; }
        }

        public Gruppa Gruppa
        {
            get { return gruppa; }
            set { gruppa = value; }
        }

        public Para Para
        {
            get { return para; }
            set { para = value; }
        }

        public VidZanyatiya VidZanyatiya
        {
            get { return vidZanyatiya; }
            set { vidZanyatiya = value; }
        }
    }
}
