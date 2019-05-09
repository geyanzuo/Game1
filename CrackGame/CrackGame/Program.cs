using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Password = new Random();

            List<string> WordBank = new List<string>();
            WordBank.Add("cake");
            WordBank.Add("hangman");
            WordBank.Add("officer");
            WordBank.Add("swinburne");
            WordBank.Add("steam");
            WordBank.Add("keyboard");
            WordBank.Add("nuke");
            WordBank.Add("automatic");

            int life = 10;

            Console.WriteLine("Welcome to word guessing game. Type [y] to strat game, or type [n] to leave the game");

            while (life >= -1)
            {
               

                string input = Console.ReadLine();

                if (input == "y")
                {
                    int PasswordNum = Password.Next(WordBank.Count);
                    string ChosenOne = WordBank[PasswordNum];

                    Console.WriteLine("===============================================================================" +
                        "");
                    Console.WriteLine("Guess the password...");
                    Console.WriteLine("The password is " + ChosenOne);

                    string answer = Console.ReadLine();

                    if (answer == ChosenOne)
                    {
                        Console.WriteLine("That is right");
                        break;
                    }

                    else if (answer != ChosenOne)
                    {
                        Console.WriteLine("Password is wrong");
                        life = life - 1;
                        Console.WriteLine("You have " + life + " chance left...");
                    }
                   
                }

                else if(input == "n")
                {
                    Console.WriteLine("You leave the game...........");
                    break;
                }

              
                else
                {
                    Console.WriteLine("You need to type [y] to strate game");
                }
                

            }




            Console.ReadKey();

        }



    }
}
