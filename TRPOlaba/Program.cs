using System;
using ClassLibrary1;

class Program
{
    static void Main()
    {
        Disciplina disciplina = new Disciplina("Matematika", "Mat");
        Sotrudnik sotrudnik = new Sotrudnik("Ivan", "Ivanov");
        Auditoriya auditoriya = new Auditoriya("101");
        Gruppa gruppa = new Gruppa("Gruppa A", "GA", 30, 2023, "link", "boss");
        Para para = new Para(new DateTime(2024, 6, 1, 9, 0, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 45, 0));
        VidZanyatiya vidZanyatiya = new VidZanyatiya("Lektsiya");

        Zanyatie zanyatie = new Zanyatie(
            DateTime.Now,
            disciplina,
            sotrudnik,
            auditoriya,
            gruppa,
            para,
            vidZanyatiya
        );
        Console.WriteLine("Hello World!");
        Console.WriteLine($"Zanyatie: {zanyatie.DataProvedeniya}, {zanyatie.Disciplina.Name()}, {zanyatie.VidZanyatiya.Opisanie}, {zanyatie.Sotrudnik.Imya} {zanyatie.Sotrudnik.Familiya}");
    }
}


