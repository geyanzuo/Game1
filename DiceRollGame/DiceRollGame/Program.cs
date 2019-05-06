using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the DICE ROLLING experiment......");
          

            int i = 0;
            int DiceNum = 0;

            Random RollDice = new Random();

            Console.WriteLine("Tell me how many times you want roll the dice");

            int size = int.Parse(Console.ReadLine());

            int[] result = new int[size];

            while (i<result.Length)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Type [R] to roll the Dice");
                Console.WriteLine("Or type [S] to Stop the experiment");
                string input = Console.ReadLine();

                if (input == "R")
                {
                    Console.WriteLine("Type a number for number of dice will be used");

                    int n = int.Parse(Console.ReadLine());

                    
                    DiceNum = RollDice.Next(1*n, 7*n-(n-1));
                    Console.WriteLine("the reslut is " + DiceNum);
                    result[i] = DiceNum;
                    i++;
                    Console.WriteLine("Slot " + i + " contains " + DiceNum);

                    int sum = result.Sum();

                    Console.WriteLine("We have " + string.Join(", ", result));
                    Console.WriteLine("The sum is " + sum);
                    Console.WriteLine("Average number is " + sum/i);
                }

                else if(input == "S")
                {
                    Console.WriteLine("Experiment is terminated, Press any key to Exit.....");
                    break;
                }
                else
                {
                    Console.WriteLine("You need to type [R] to continue the experiment!!");

                }

               
               
               
            }     

            
            Console.ReadKey();

        }
    }
}
