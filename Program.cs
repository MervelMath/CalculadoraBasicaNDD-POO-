using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNDD.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraBase1 calculator1 = new CalculadoraBase1();
            Menu menu = new Menu();
            while (true)
            {
                string check = menu.MainMenuMethod(calculator1);

                if (check == "1")
                    calculator1.Add();

                else if (check == "2")
                    calculator1.Sub();

                else if (check == "3")
                    calculator1.Mult();

                else if (check == "4")
                    calculator1.Div();

                else if (check == "5")
                    calculator1.ViewCounts();

                else if (check.Equals("S", StringComparison.OrdinalIgnoreCase))
                    break;

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: opção não existente...");
                    Console.ResetColor();
                }
            }
        }
    }
}
