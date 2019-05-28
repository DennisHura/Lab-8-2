using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace semestr4_praktichna_8_2
{

    public class Person
    {
        public string Name;
        public string Familia;
        public string Otchestvo;
        public int year;
        public double ves;

        public Person(string[] info)
        {
            Name = info[0];
            Familia = info[1];
            Otchestvo = info[2];
            year = Convert.ToInt32(info[3]);
            ves = Convert.ToDouble(info[4]);

        }

        public void Vivod()
        {
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Фамилия: {0}", Familia);
            Console.WriteLine("Отчество: {0}", Otchestvo);
            Console.WriteLine("Возраст: {0}", year);
            Console.WriteLine("Вес: {0}", ves);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("input.txt", System.Text.Encoding.Default);

            Queue<Person> database = new Queue<Person>();

            string input;

            while ((input = reader.ReadLine()) != null)
            {
                string[] info;
                info = input.Split(new char[] { ' ' });
                Person buff = new Person(info);
                database.Enqueue(buff);
            }

            Console.WriteLine("Моложе 40 лет :\n\n");

            foreach (Person chelovek in database)
            {

                if (chelovek.year < 40)
                {
                    chelovek.Vivod();
                    Console.WriteLine();
                }

            }

            Console.WriteLine("Старше 40 лет :\n\n");

            foreach (Person chelovek in database)
            {

                if (chelovek.year > 40)
                {
                    chelovek.Vivod();
                    Console.WriteLine();
                }

            }

            reader.Close();

        }

    }
}
