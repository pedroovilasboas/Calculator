using System;
using System.Runtime.Serialization.Formatters;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;

            Console.WriteLine("CALCULADORA\n\n");
            Console.WriteLine("Por favor, escolha a operação.\n 1 - Adição\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n");
            int op = int.Parse(Console.ReadLine());

            if (op > 0 && op < 5)
            {
                Console.WriteLine("\nNumero:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNumero:");
                b = int.Parse(Console.ReadLine());


                switch (op)
                {

                    case 1:

                        c = a + b;
                        Console.WriteLine($"\nO Resultado da soma é:\n{c}");
                        break;

                    case 2:
                        c = a - b;
                        Console.WriteLine($"\nO Resultado da subtração é:\n{c}");
                        break;

                    case 3:
                        c = a * b;
                        Console.WriteLine($"\nO Resultado da multiplicação é:\n{c}");
                        break;

                    case 4:
                        c = a / b;
                        Console.WriteLine($"\nO Resultado da divisão é:\n{c}");
                        break;

                }


            }
            else
            {
                Console.WriteLine("numero invalido");
            }

            Console.WriteLine("\n\nOperação adicional - 1-sim 2-não");
            int resposta = int.Parse(Console.ReadLine());
            Console.Clear();    

            switch (resposta)
            {
                case 1:
                    int d; // this variable will receive an integer and use the value to calculate the previous result
                    Console.WriteLine($"Resultado anterior:{c} \nPor favor, escolha a operação.\n 1 - Adição\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n");
                    int op2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nNumero:");
                    int e = int.Parse(Console.ReadLine());


                    switch (op2)
                    {
                        case 1:
                           d = c + e;
                            Console.WriteLine($"\nO Resultado da soma é:\n{d}");
                            break;

                        case 2:
                            d = c - e;
                            Console.WriteLine($"\nO Resultado da subtração é:\n{d}");
                            break;

                        case 3:
                            d = c * e;
                            Console.WriteLine($"\nO Resultado da multiplicação é:\n{d}");
                            break;

                        case 4:
                            d = c / e;
                            Console.WriteLine($"\nO Resultado da divisão é:\n{d}");
                            break;

                        default:
                            Console.WriteLine("\n\noperação invalida");
                            break;

                    }
                    break;

                case 2:
                    break;


            }

            
        }
    }
}