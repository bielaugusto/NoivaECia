using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCia
{
    internal class Espaco
    {
        public string Tipo { get; set; }
        public int Capacidade { get; set; }
        public DateTime[] Datas = new DateTime[31];

        public DateTime setDatas(int posicao)
        {
            return Datas[posicao];
        }

        public Espaco(string tipo,int capacidade)
        {
            this.Tipo = tipo;
            this.Capacidade = capacidade;
        }

        public DateTime VerificaDataDisponivell( DateTime dataAtual)
        {
            //aumenta 30 dias
            DateTime dataDesejada = dataAtual.AddDays(30);
                for (int i = 0; i < Datas.Length; i++)
                {            
                // verifica se a data na casa I é menor que a data desejada
                if (Datas[i] > dataDesejada)
                    {
                    
                        //verifica se a data desejada ja esta ocupada
                        if (Datas[i - 1] == dataDesejada)
                        {
                        //aumenta a data em 1 e verifica se essa nova data tem disponibilidade
                        int posicao = i;
                            do
                            {
                                
                                if (dataDesejada == Datas[posicao - 1])
                                {
                                dataDesejada = dataDesejada.AddDays(1);
                                }
                                if (dataDesejada > Datas[posicao-1] || dataDesejada < Datas[posicao])
                                {
                                    return dataDesejada;
                                }
                                posicao++;
                            } while (dataDesejada < Datas[posicao] || dataDesejada >= Datas[posicao - 1]);

                        }                      
                    }                    
                }
                return new DateTime(0);           
        }

        public bool AdicionaData(DateTime data)
        {
            for(int i = 0; i < Datas.Length; i++)
            {
                if (Datas[i] == DateTime.MinValue)
                {
                    Datas[i] = data;
                    Array.Sort(Datas);
                    return true;
                }
            }
            return false;
        }
        public DateTime VerificaDataDisponivel(DateTime dataAtual)
        {
            //aumenta 30 dias
            DateTime dataDesejada = dataAtual.AddDays(30);
            
            while((dataDesejada.DayOfWeek!=DayOfWeek.Saturday && dataDesejada.DayOfWeek != DayOfWeek.Friday)||Datas.Contains(dataDesejada))
            {
                dataDesejada = dataDesejada.AddDays(1);
            }
            return dataDesejada;
        }
    }

}
