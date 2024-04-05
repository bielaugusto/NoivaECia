using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Espaco a = new Espaco("a",100);

            a.AdicionaData(new DateTime(2024, 05, 01));
            a.AdicionaData(new DateTime(2024, 05, 04));
            a.AdicionaData(new DateTime(2024, 05, 11));
            a.AdicionaData(new DateTime(2024, 05, 10));
            a.AdicionaData(new DateTime(2024, 05, 28));
            a.AdicionaData(new DateTime(2024, 05, 15));

            
            Console.WriteLine("a proxima data disponivel é em:" + a.VerificaDataDisponivel(new DateTime(2024, 04, 06)));
            Console.ReadLine();
        }
    }
}
