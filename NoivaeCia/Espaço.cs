﻿using System;
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

        public Espaco(string tipo,int capacidade)
        {
            this.Tipo = tipo;
            this.Capacidade = capacidade;
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
