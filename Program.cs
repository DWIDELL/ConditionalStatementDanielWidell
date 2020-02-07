using System;

namespace ConditionalStatementDanielWidell
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello! What total score, out of 100, do you expect to receive in ISM 4300?");
            int instructionResponse = Convert.ToInt32(Console.ReadLine());
            if (instructionResponse >= 98)
            {
                Console.WriteLine("You want an A+! This will take some work.");
            }
            else if (instructionResponse >= 92 && instructionResponse <= 98)
            {
                Console.WriteLine("You want an A. This is excellent.");
            }
            else if (instructionResponse >= 90 && instructionResponse <= 91)
            {
                Console.WriteLine("You want an A-.");

            }
            else if (instructionResponse >= 88 && instructionResponse <= 89)
            {
                Console.WriteLine("You want a B+.");
            }
            else if (instructionResponse >= 82 && instructionResponse <= 87)
            {
                Console.WriteLine("You want a B.");

            }
            else if (instructionResponse >= 80 && instructionResponse <= 81)
            {
                Console.WriteLine("You want a B-.");

            }
            else if (instructionResponse >= 78 && instructionResponse <= 79)
            {
                Console.WriteLine("You want a C+.");
            }
            else if (instructionResponse >= 72 && instructionResponse <= 77)
            {
                Console.WriteLine("You want a C.");

            }
            else if (instructionResponse >= 70 && instructionResponse <= 71)
            {
                Console.WriteLine("You want a C-.");
            }
            else if (instructionResponse >= 68 && instructionResponse <= 69)
            {
                Console.WriteLine("You want a D+.");
            }
            else if (instructionResponse >= 62 && instructionResponse <= 67)
            {
                Console.WriteLine("You want a D.");
            }
            else if (instructionResponse >= 60 && instructionResponse <= 61)
            {
                Console.WriteLine("You want a D-.");
            }
            else if (instructionResponse < 60)
            {
                Console.WriteLine("You want a F.");
            }
          
            }
        }
    }

