using System;

namespace classes
{
    class Student {
        public string Jmeno {get; private set;}
        public string Prijmeni {get; private set;}
        public int Vek;

        public Student(string Jmeno, string Prijmeni, int Vek) {
            EditStudenta(Jmeno, Prijmeni, Vek);
        }

        public void EditStudenta(string jmeno, string prijmeni, int vek) {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Vek = vek;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Curak", "Cepelka", 19);
            Student s2 = new Student("Smradlavej", "Wolf", 20);

            //s1.EditStudenta("Zamrdanec", "Cepelino", 22);

            Console.WriteLine(s1.Jmeno + " " + s1.Prijmeni + " " + s1.Vek);
            Console.WriteLine(s2.Jmeno + " " + s2.Prijmeni + " " + s2.Vek);
        }
    }
}
