using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Strings_exc
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------------------------------------------
            /*int[] myArray = new int[10];
            for (int k = 0; k < 10; k++)
            {
                myArray[k] = k * 2;                 //stampo le tabelline (foreach loop)
            }

            foreach (var k in myArray)
            {
                Console.WriteLine(k);
            }

            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------------------
            /*int[] arr = { 12, 15, 28 };
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);                  //arr.Length 
            }
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------------------
            /*int[] arr = { 2, 7, 1, 5, 9 };

            Console.WriteLine(arr.Sum());                           //arr.Max/Min/Sum

            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------------------
            /*string a = "some text";
            Console.WriteLine(a.IndexOf('t'));                            //a.Length/IndexOf/Insert/Replace/Contains/Remove/Substring
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------------------
            /*string text = "questo è del testo riguardante un bel cane di nome 'cane', questo cane è moto bello e molto giocherellone, proprio come un vero cane";

            text = text.Replace("cane", "gatto");
                                                                                                                                                                         //text replacer
            Console.WriteLine(text);

            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------------------
            /*string[] names = new string[2] { "Fabrizio", "Gianluca"};
            Console.WriteLine("Come ti chiami?");
            names[1] = Convert.ToString(Console.ReadLine());                        //queste sono strings
            Console.WriteLine("Ciao{0} ", names[1]);
            
            Console.ReadKey();*/
        }
    }
}
