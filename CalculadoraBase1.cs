using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculadoraNDD.ConsoleApp
{
    public class CalculadoraBase1
    {
        private double num1;
        private double num2;
        private double result;
        private char oper;
        private string[] operationsDone = new string[100];
        private int counter = 0;


        public void Add()
        {
            Result = Num1 + Num2;
            Console.WriteLine(Result);
            Oper = '+';
            RegisterOperations(Oper);
        }

        public void Div()
        {
            if (num2 != 0)
            {
                Result = Num1 / Num2;
                Console.WriteLine(Result);
                Oper = '/';
                RegisterOperations(Oper);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O divisor não pode ser 0...");
                Console.ResetColor();
            }
        }

        public void Mult()
        {
            Result = Num1 * Num2;
            Console.WriteLine(Result);
            Oper = '*';
            RegisterOperations(Oper);
        }

        public void Sub()
        {
            Result = Num1 - Num2;
            Console.WriteLine(Result);
            Oper = '-';
            RegisterOperations(Oper);
        }

        public void RegisterOperations(char countOperator)
        {
            OperationsDone[Counter] = $"{Num1} {countOperator} {Num2} = {Result}";
            Counter++;
        }

        public void ViewCounts()
        {
            if(OperationsDone[0] == null)
            {
                Console.WriteLine("Opção inválida, nenuma operação feita.");
            }
            else
            {
                for (int i = 0; i < OperationsDone.Length; i++)
                {
                    if(OperationsDone[i]!=null)
                    Console.WriteLine(OperationsDone[i]); ;
                }
            }
        }

        //Gets e Sets...
        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }
        public double Result { get => result; set => result = value; }
        public char Oper { get => oper; set => oper = value; }
        public string[] OperationsDone { get => operationsDone; set => operationsDone = value; }
        public int Counter { get => counter; set => counter = value; }
    }
}