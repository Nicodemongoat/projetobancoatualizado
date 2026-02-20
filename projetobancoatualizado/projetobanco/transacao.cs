using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetobanco
{ 
    public class Transacao
    {
        public decimal _valor
        {
            get { return _valor;}
            set
            {
                if (value > 0)
                {
                    _valor = value;
                }
                else
                {
                    Console.WriteLine("ERRO: o valor nao pode ser negativo ou zero!!");
                }
            }
        }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }

        public ContaBancaria ContaOrigem { get; set; }
        public ContaBancaria ContaDestino { get; set; }
    }
}
