using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOne, inputTwo;

            Console.WriteLine("Hello there! What type of activity would you like to do today?");
            Console.WriteLine("Here are your options.");
            Console.WriteLine("Press 1 for something exciting.");
            Console.WriteLine("Press 2 for something laid back.");
            Console.WriteLine("Press 3 if you'd like to learn something new." );
            Console.WriteLine("Press 4 if you're looking for a good place to eat.");

            inputOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ok, great! How many people are going with you?");
            inputTwo = Convert.ToInt32(Console.ReadLine());



            switch(inputOne)
            {
                case 1 when inputTwo == 0:
                    Console.WriteLine("So you're in the mood for something exciting? You should check out an Amusement Park, it would be best for you to take a bike ride.");
                    break;
                case 1 when inputTwo <= 4 && inputTwo > 0:
                    Console.WriteLine("So you're in the mood for something exciting? You should check out an Amusement Park, it would be best for you to take a Smart Car.");
                    break;
                case 1 when inputTwo >= 5 && inputTwo <= 10:
                    Console.WriteLine("So you're in the mood for something exciting? You should check out an Amusement Park, it would be best for you to take a large SUV or Van.");
                    break;
                case 1 when inputTwo >= 11:
                    Console.WriteLine("So you're in the mood for something exciting? You should check out an Amusement Park, it would be best for you to take a bus or plane");
                    break;
                case 2 when inputTwo == 0:
                    Console.WriteLine("So you're in the mood for something laid back? You should check out an the Movie Theater, it would be best for you to take a bike ride.");
                    break;
                case 2 when inputTwo <= 4 && inputTwo > 0:
                    Console.WriteLine("So you're in the mood for something laid back? You should check out an the Movie Theater, it would be best for you to take a Smart Car.");
                    break;
                case 2 when inputTwo >= 5 && inputTwo <= 10:
                    Console.WriteLine("So you're in the mood for something laid back? You should check out an the Movie Theater, it would be best for you to take a large SUV or Van");
                    break;
                case 2 when inputTwo >= 11:
                    Console.WriteLine("So you're in the mood for something laid back? You should check out an the Movie Theater, it would be best for you to take a bus or plane");
                    break;
                case 3 when inputTwo == 0:
                    Console.WriteLine("So you want to learn something new? You should check out the Library! It would be best for you to take a bike ride!");
                    break;
                case 3 when inputTwo <= 4 && inputTwo > 0:
                    Console.WriteLine("So you want to learn something new? You should check out the Library! It would be best for you to take a Smart Car.");
                    break;
                case 3 when inputTwo >= 5 && inputTwo <= 10:
                    Console.WriteLine("So you want to learn something new? You should check out the Library! It would be best for you to take a large SUV or Van.");
                    break;
                case 3 when inputTwo >= 11:
                    Console.WriteLine("So you want to learn something new? You should check out the Library! It would be best for you to take a bus or plane.");
                    break;
                case 4 when inputTwo == 0:
                    Console.WriteLine("So you're looking for some food? Head over to Rudy's Hot Dog! It would be best for you to take a bike ride.");
                    break;
                case 4 when inputTwo <= 4 && inputTwo > 0:
                    Console.WriteLine("So you're looking for some food? Head over to Rudy's Hot Dog! It would be best for you to take a Smart Car.");
                    break;
                case 4 when inputTwo >= 5 && inputTwo <= 10:
                    Console.WriteLine("So you're looking for some food? Head over to Rudy's Hot Dog! It would be best for you to take a large SUV or Van.");
                    break;
                case 4 when inputTwo >= 11:
                    Console.WriteLine("So you're looking for some food? Head over to Rudy's Hot Dog! It would be best for you to take a bus or plane.");
                    break;


            }
            Console.WriteLine("Have a great day!");
            Console.ReadLine();
        }
        }
        }
              



       
   

