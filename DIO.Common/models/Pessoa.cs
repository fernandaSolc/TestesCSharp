using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Common.models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos");
        }
        
    }
}