using System;
using System.Globalization;

namespace entradasDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string frase = Console.ReadLine();
            
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char genero = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);



            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            */

            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em sua casa?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");

            string[] vet = Console.ReadLine().Split(' ');

            string nomeVet = vet[0];
            int idadeVet = int.Parse(vet[1]);
            double alturaVet = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Seu nome: " + nomeCompleto);
            Console.WriteLine("Quantidade de quartos: " + quantidadeQuartos);
            Console.WriteLine("Preço do produto: " + precoProduto);

            Console.WriteLine("Os dados digitados em sequência foram:");
            Console.WriteLine(nomeVet);
            Console.WriteLine(idadeVet);
            Console.WriteLine(alturaVet);
        }
    }
}


