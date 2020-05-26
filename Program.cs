using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace expoente
{
    class Program
    {
        static void Main(string[] args)
        {
            int base1;
            int expoente;


            Console.Write("Digite o numero da base: ");
            base1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            expoente = Convert.ToInt32(Console.ReadLine());

            ObterTotal(base1, expoente);
        }
        public static void ObterTotal(int base1, int expoente)
        {
            int respt = 1;

            for (int i = 0; i < expoente; i++)
            {
                respt *= base1;
            }

            Console.Write("O valor total da exponencicao e " + respt);
            Console.Read();
        }
    }
}
