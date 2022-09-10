using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Seja bem vinda(o) a lista dos animais em exposição!");

            List<string> Animais = new List<string>();

            Animais.Add("Ornitorrinco");
            Animais.Add("Sapo");
            Animais.Add("Pato");
            Animais.Add("Cobra");

            Animais.Insert(2, "Axolote");

            Animais.Remove("Cobra");
            Animais.RemoveAt(1);

            foreach (string bicho in Animais)

            Console.WriteLine($"Esses são os animais em exposição no momento: {bicho}. \n");


        }
    }
}
