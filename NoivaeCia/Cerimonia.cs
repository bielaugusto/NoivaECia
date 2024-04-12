using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCia
{
    internal class Cerimonia
    {
        public Espaco Espaco { get; set; }
        public int Convidados { get; set; }
        public DateTime Data { get; set; }

        public string CPFNoiva { get; set; }

        public Cerimonia(DateTime data, int convidados, Espaco espaco, string cpfnoiva) 
        {
            this.Convidados = convidados;
            this.Data = data;
            this.Espaco = espaco;
            this.CPFNoiva = cpfnoiva;
        }
    }
}
