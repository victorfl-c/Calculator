using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("OPERAÇÕES: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Adição ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Divisão ");
            Console.WriteLine("4 - Multiplicação ");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma das opções.");

            short resposta = short.Parse(Console.ReadLine());
            switch(resposta)
            {
                case 1 : Adicao(); break;
                case 2 : Subtracao(); break;
                case 3 : Divisao(); break;
                case 4 : Multiplicacao(); break;
                case 5 : Sair(); break;
                default : OpInvalida(); break;
            }
            Menu();
        }
        static void Adicao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = (valor1 + valor2);
            Console.WriteLine("");
            Console.WriteLine($"O resultado da adição é: {resultado}\n");
            VoltarMenu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = (valor1 - valor2);
            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é: {resultado}\n");
            VoltarMenu();
        }
        static void Divisao()
        {
             Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = (valor1 / valor2);
            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão é: {resultado}\n");
            VoltarMenu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é: {resultado}\n");
             VoltarMenu();
        }
        static void Sair()
        {
            Console.WriteLine("Saindo do programa...");
            System.Environment.Exit(0);
        }
        static void OpInvalida()
        {
            Console.WriteLine("Opção inválida");
            Console.WriteLine("Escolha entre 1 e 4!");
              VoltarMenu();
        }
        static void VoltarMenu()
        {
           Console.WriteLine("Pressione a tecla Enter para voltar ao Menu");
            Console.ReadKey();
            Menu(); 
        }
    }
}
