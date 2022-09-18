using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao_6.Src
{
    public class Animal
    {
        string Nome { get; set; }

        int Patas { get; set; }

        string Pelos { get; set; }

        string Bico { get; set; }

        public Animal(string nome, int patas, string pelos, string bico)
        {
            Nome = nome;
            Patas = patas;
            Pelos = pelos;
            Bico = bico;
        }

        public override string ToString()
        {
            return "O nome do animal é: " + Nome + "\n Quantidade de patas: " + Patas + "\n Tem pelos? " + Pelos + "\n Tem bico? " + Bico;
            

        }
    }
}
