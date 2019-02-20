using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la tua età");
            int age;

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 14)
            {
                if (age > 18)
                {
                    Console.WriteLine("Adulto");
                }
                else
                {
                    Console.WriteLine("Teenager");
                }
            }
            else
            {
                if (age > 0)
                {
                    Console.WriteLine("Bambino");
                }
                else
                {
                    Console.WriteLine("Qualcosa e' andato storto!");
                }
            }

            //Questo si usa per non far chiudere subito il programma una volta eseguito il codice
            Console.WriteLine("Premi invio per chiudere il programma...");
            Console.ReadLine();
            }        
    }
}
