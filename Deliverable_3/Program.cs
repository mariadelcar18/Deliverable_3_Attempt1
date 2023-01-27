/* Author: Maria del Carmen Perez-Soto de Paiva
 * Date: 1/26/2023
 * Description: Create a C# Console Application with iterative statements
 */

using System;
using System.ComponentModel;

namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter an integer value between 1 and 100: ");
                int input = int.Parse(Console.ReadLine());
                
                Console.Write("Please specify the series type: Even or Odd: ");
                string series = Console.ReadLine();

                if (series == "Odd")
                {
                    Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "Even")
                {
                    Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric integer value between 1 and 100 and specify the series type.");
            }
        }
    }
}