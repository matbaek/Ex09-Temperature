using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Temperature temp = new Temperature();
            System.IO.StreamReader file = 
                new System.IO.StreamReader("C:/Users/mathi/source/repos/Ex09-Temperature/Ex09-Temperature/InputFil.txt");

            line = file.ReadLine();
            string[] words = line.Split();
            for (int i = 0; i < words.Length; i++)
            {
                temp.Celsius = double.Parse(words[i]);
                Console.WriteLine(temp.Celsius);
            }

            line = file.ReadLine();
            words = line.Split();
            for (int i = 0; i < words.Length; i++)
            {
                temp.Fahrenheit = double.Parse(words[i]);
                Console.WriteLine(temp.Fahrenheit);
            }

            file.Close();
            Console.ReadLine();
        }
    }
}
