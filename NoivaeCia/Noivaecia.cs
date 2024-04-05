using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCia
{
    internal class Noivaecia
    {
        public Espaco[] Espacos = new Espaco[8];
        
        public Noivaecia() 
        {
            Espaco A = new Espaco("A", 100);
            Espacos[0] = A;
            Espaco B = new Espaco("B", 100);
            Espacos[1] = B;
            Espaco C = new Espaco("C", 100);
            Espacos[2] = C;
            Espaco D = new Espaco("D", 100);
            Espacos[3] = D;
            Espaco E = new Espaco("E", 200);
            Espacos[4] = E;
            Espaco F = new Espaco("F", 200);
            Espacos[5] = F;
            Espaco G = new Espaco("G", 50);
            Espacos[6] = G;
            Espaco H = new Espaco("H", 500);
            Espacos[7] = H;
        }

        public Espaco VerificaEspaco(DateTime data, int convidados)
        {
            if (convidados <= 50)
            {
                Console.WriteLine("a proxima data disponivel é em " + Espacos[6].VerificaDataDisponivel(data)+" No espaço" + Espacos[6].Tipo
                + "\nDeseja essa Data?(disgite sim ou não)");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    Espacos[6].AdicionaData(Espacos[6].VerificaDataDisponivel(data));
                    return Espacos[6];
                }
                else return new Espaco("Z", -2);
                

            }
            else if (convidados <= 100)
            {
                DateTime menor = DateTime.MaxValue;
                Espaco disponivel = new Espaco("z",0);
                for(int i = 0; i < 4; i++)
                {
                    DateTime atual = Espacos[i].VerificaDataDisponivel(data);
                    if (atual <= menor)
                    {
                        menor = atual;
                        disponivel = Espacos[i];
                    }
                }               
                Console.WriteLine("a proxima data disponivel é em " + menor + " No espaço"+disponivel.Tipo+"\nDeseja essa Data?(disgite sim ou não)");
                string opcao =Console.ReadLine();
                if (opcao == "sim")
                {
                    disponivel.AdicionaData(disponivel.VerificaDataDisponivel(data));
                    return disponivel;
                }
                else return new Espaco("Z", -2);


            }
            else if (convidados <= 200)
            {
                DateTime menor = DateTime.MaxValue;
                Espaco disponivel = new Espaco("z", 0);
                for (int i = 4; i < 6; i++)
                {
                    DateTime atual = Espacos[i].VerificaDataDisponivel(data);
                    if (atual <= menor)
                    {
                        menor = atual;
                        disponivel = Espacos[i];
                    }
                }
                Console.WriteLine("a proxima data disponivel é em " + menor + " No espaço" + disponivel.Tipo + "\nDeseja essa Data?(disgite sim ou não)");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    disponivel.AdicionaData(disponivel.VerificaDataDisponivel(data));
                    return disponivel;
                }
                else return new Espaco("Z", -2);

            }
            else if (convidados <= 500)
            {
                Console.WriteLine("a proxima data disponivel é em " + Espacos[7].VerificaDataDisponivel(data) + " No espaço " + Espacos[7].Tipo + "\nDeseja essa Data?(disgite sim ou não)");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    Espacos[7].AdicionaData(Espacos[7].VerificaDataDisponivel(data));
                    return Espacos[7];
                }
                else return new Espaco("Z", -2);
                


            }
            else
            {
                return new Espaco ("Z",-1);
            }
        }

        public bool CriarCerimonia(DateTime data, int convidados, Espaco espaco)
        {
            Espaco disponivel = VerificaEspaco(data, convidados);
            if (disponivel.Capacidade == -1)
            {
                Console.WriteLine("o numero de convidados excede nossa capacidade maxima de pessoas");
                return false;
            }
            else if (disponivel.Capacidade==-2)
            {
                Console.WriteLine("Agendamento cancelado");
                return false;
            }
            else
            {
                new Cerimonia(data, convidados, disponivel);
                Console.WriteLine("Cerimonia no espaço {0} confirmada!", disponivel.Tipo);
                return true;
            }
        }
    }
}
