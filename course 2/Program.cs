﻿using System;
using System.Globalization;

namespace course_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new();

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
        }
    }
}