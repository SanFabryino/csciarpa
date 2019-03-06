using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_e_Oggetti
{
    class Fabrizio
    {

        static void Main(string[] args)
        {
            int soldi;
            double altezza;
            string stato;

            string[] nome = new string[1] {"1"};

            Console.WriteLine("Come ti chiami? ");
            nome[0] = Console.ReadLine();
            Console.WriteLine("Benvenuto{0}", nome[0]);

            Console.WriteLine();

            Console.WriteLine("dimmi un po'... quanti soldi hai in questo momento?");
            soldi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quindi hai Eur{0}", soldi);

            Console.WriteLine("bene...adesso dimmi, quanto sei alto?");
            altezza = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quindi sei alto m{0}", altezza);

            Console.WriteLine("hmm...capisco, senti, in questo momento sei felice? si o no?");
             stato = Console.ReadLine();
            Console.WriteLine("vabene, grazie per esserti connesso con me! alla prossima <3");

            Console.WriteLine("premi un tasto qualsiasi per chiudere il programma...");
            Console.ReadKey();
        }
    }
}   
   

