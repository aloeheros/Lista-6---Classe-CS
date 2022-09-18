using Abstracao_6.Src;
using System;

namespace Abstracao_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal gato = new Animal("Gato", 4, "Tem", "Não tem");
            Animal cachorro = new Animal("Cachorro", 4, "Tem", "Não tem");
            Animal peixe = new Animal("Peixe", 0, "Não tem.", "Não tem.");
            Animal passarinho = new Animal("Pássaro", 2, "Não tem.", "Tem.");

            Console.WriteLine(gato.ToString());
            Console.WriteLine(cachorro.ToString());
            Console.WriteLine(peixe.ToString());
            Console.WriteLine(passarinho.ToString());
        }
    }
}
