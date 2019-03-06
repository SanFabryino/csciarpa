using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatore_Valori_Nutrizionali
{
    class Program
    {
        static void Main(string[] args)
        {
            double calorie, carboidrati, proteine,grassi, quant;
            calorie = 0;
            carboidrati = 0;
            proteine = 0;
            grassi = 0;
            quant = 0;
            //dialoghi--------------------------------------------------------------------------
            Console.WriteLine("Ciao, benvenuto nel calcolatore dei valori nutrizionali...");

            Console.WriteLine("Nel tuo cibo...quante calorie ci sono ogni 100 g?");
            calorie = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quanti carboidrati ogni 100 g?");
            carboidrati = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quante proteine ogni 100 g?");
            proteine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quanti grassi ogni 100 g?");
            grassi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adesso...quanti grammi vuoi mangiare di questo cibo??");
            quant = Convert.ToDouble(Console.ReadLine());
            //calcoli----------------------------------------------------------------------

            calorie = calorie * quant;
            calorie = calorie / 100;

            carboidrati = carboidrati * quant;
            carboidrati = carboidrati / 100;

            proteine = proteine * quant;
            proteine = proteine / 100;

            grassi = grassi * quant;
            grassi = grassi / 100;
            //risultati---------------------------------------------------------------------
            Console.WriteLine("Elaborazione...Nel tuo cibo adesso ci sono esattamente:");

            Console.WriteLine("Calorie:{0}", calorie);

            Console.WriteLine("Carboidrati:{0}", carboidrati);

            Console.WriteLine("Proteine:{0}", proteine);

            Console.WriteLine("Grassi:{0}", grassi);
            //END----------------------------------------------------------------------------
            Console.ReadKey();
        }
    }
}
