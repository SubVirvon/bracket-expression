using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bracket_expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = '(';
            char symbol2 = ')';
            string expression;
            int maxNestingLevel = int.MinValue;
            int nestingLevel = 0;
            int symbol1Count = 0;
            int symbol2Count = 0;

            Console.Write("Введиту выражение: ");
            expression = Console.ReadLine();

            for(int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == symbol1)
                {
                    nestingLevel++;
                    symbol1Count++;
                }
                else if (expression[i] == symbol2)
                {
                    symbol2Count++;

                    if (maxNestingLevel < nestingLevel)
                    {
                        maxNestingLevel = nestingLevel;
                    }

                    nestingLevel = 0;
                }
            }

            if(symbol1Count == symbol2Count && expression[0] != symbol2 && expression[expression.Length - 1] != symbol1)
            {
                Console.WriteLine("Выражение коректно, уровень вложенности: " + maxNestingLevel);
            }
            else
            {
                Console.WriteLine("Выражение не коректно");
            }

            Console.ReadKey();
        }
    }
}
