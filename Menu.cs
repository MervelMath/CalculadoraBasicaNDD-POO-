using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNDD.ConsoleApp
{
    class Menu
    {
        public string MainMenuMethod(CalculadoraBase1 calc)
        {
                Console.WriteLine("Deseja fazer uma nova soma (1), uma subratração (2)," +
                    "\numa multiplicação (3), uma divisão (4), ver tudo (5) ou sair (S)?");
                string check = Console.ReadLine();

                if (check == "1" || check == "2" || check == "3" || check == "4")
                {
                    Console.Write("Digite o primeiro número: ");
                    calc.Num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    calc.Num2 = int.Parse(Console.ReadLine());
                }
                return check;
        }
    }
}
