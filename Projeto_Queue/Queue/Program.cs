using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Para sair do nosso programa por favor, entre na fila!");

            Queue<Pessoa> Pessoas = new Queue<Pessoa>();

            Pessoas.Enqueue(new Pessoa("Roseli Aparecida", 50));
            Pessoas.Enqueue(new Pessoa("Juliana", 24));
            Pessoas.Enqueue(new Pessoa("Rafael Lemos", 27));
            Pessoas.Enqueue(new Pessoa("Nina", 86));
            Pessoas.Enqueue(new Pessoa("José", 39));

            Console.WriteLine($"A primeira pessoa da fila é: {Pessoas.Dequeue()}");

            Console.WriteLine($"Tem {Pessoas.Count} pessoas na fila!");

            foreach (var gente in Pessoas)
            {
                Console.WriteLine(gente.ToString());
            }
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public override string ToString()
            {
                return $"{Nome}, {Idade} anos.";
            }
        }
    }
}
