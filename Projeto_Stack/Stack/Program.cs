using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vinda(o) à minha biblioteca particular!");

            Stack<string> Livros = new Stack<string>();

            Livros.Push("Percy Jackson e o ladrão de raios.");
            Livros.Push("Harry Potter e a Pedra Filosofal.");
            Livros.Push("A última música.");

            Console.WriteLine($"O primeiro livro da pilha é: {Livros.Peek()}");

            Livros.Pop();

            Console.WriteLine($"Restam {Livros.Count()} livros na biblioteca.");

            foreach (String livro in Livros)
            {
                Console.WriteLine($"Ainda temos os seguintes livros: {livro}");
            }
        }
    }
}
