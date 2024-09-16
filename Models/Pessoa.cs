using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas_Dio.Models
{
    public class Pessoa
    {
        public string Nome{ get; set; }
        public int Idade{get;set;}

        public void Apresentacao(){
            Console.WriteLine($"Olá mundo, me chamo {Nome}, eu tenho {Idade} Anos");
        }
    }
}