using System;
namespace CviceniAP1PA
{
    class Student
    {
        public int Id { get; private set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public Student(int id)
        {
            Id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Definujte Tridu Student, ktera bude mit property Jmeno a Prijmeni a jeden konstruktor s jednim parametrem a to id studenta
            // 2. Vytvorte instanci tridy student s vyuzitim Object Initializeru pro Jmeno a Prijmeni, tak aby sel prelozit nasledujici prikaz.
            Student student = new Student(1) { Jmeno = "Karel", Prijmeni = "Novy"};
            Console.WriteLine($"id: {student.Id} jmeno: {student.Jmeno} prijmeni: {student.Prijmeni}"); // Vypise napriklad id: 1 jmeno: Karel prijmeni: Novy
            // a nesel po odpoznamkovani prelozit tento prikaz:
            //student.Id = 2;
        }
    }
}