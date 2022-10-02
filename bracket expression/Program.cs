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
            int currentNesting = 0;

            Console.Write("Введиту выражение: ");
            expression = Console.ReadLine();

            foreach(var symbol in expression)
            {
                if (symbol == symbol1)
                {
                    currentNesting++;

                    if (maxNestingLevel < currentNesting)
                    {
                        maxNestingLevel = currentNesting;
                    }
                }
                else if (symbol == symbol2)
                {
                    currentNesting--;

                    if (currentNesting < 0)
                    {
                        break;
                    }
                }
            }

            if(currentNesting == 0)
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
