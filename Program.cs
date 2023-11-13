using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)

        { 

        //Rotulo para inicio:
        Inicio:
            //Variavel para armazenar dados
            int resultado = 0;

            //Entrada de dados:
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Operações
            Console.Write("Escolha a operação (x / - ou +): ");
            string operacao = Console.ReadLine();

            //Estrutura switch:
            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    Console.Write("O resultado da soma é: " + resultado);
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    Console.Write("O resultado da subtração é: " + resultado);
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    Console.Write("O resultado da divisão é: " + resultado);
                    break;

                case "x":
                    resultado = numero1 * numero2;
                    Console.Write("O resultado da multiplicação é: " + resultado);
                    break;

                default:
                    Console.Write("Digite uma operação válida " );
                    goto Inicio;
                    break;
            }

            //Rotulo para repetir
            Repetir:

            //Fazer novo calculo
            Console.Write("\nDeseja calcular novamente? (s/n): ");
            string repetir = Console.ReadLine();

            if(repetir == "s" || repetir == "S"){
                //Resetando valor para calcular novamente
                resultado = 0;
                goto Inicio;
            }

            else if (repetir == "n" || repetir == "N")
            {
                
            }
            else{
                Console.Write("\nDigite uma opção válida! ");
                goto Repetir;
            }


        }
    }
}
