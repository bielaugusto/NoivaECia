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
            Noivaecia noivaecia = new Noivaecia();
            noivaecia.CriarCerimonia(new DateTime(2024, 04, 11), 300,"111111112");
            noivaecia.Informacoes("1111111122");
        
            Console.ReadLine();


            
        }
    }
}
