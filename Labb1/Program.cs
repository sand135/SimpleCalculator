using System;

namespace Labb1
{
    class MainClass
    {
      
        public static int NumberFromUser() 
        {
            var number = 0;
            while (true)
            {
                Console.WriteLine("Write a number:");
                var input = Console.ReadLine();
                try
                {
                    number = System.Convert.ToInt32(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Unvalid number....");
                }
            }
       
            return number;
        }

    


        public static void Main(string[] args)
        {
            var isPlaying = true;
            var calculator = new Calculator();

            do
            {
                Console.WriteLine("1.Add two numbers");
                Console.WriteLine("2.Multiply two numbers");
                Console.WriteLine("3.Sum the numbers between two numbers");
                Console.WriteLine("4.Add number to memory");
                Console.WriteLine("5.Clear memory");
                Console.WriteLine("6.Print calculator contents.");
                Console.WriteLine("7.Quit");
                Console.WriteLine("\nVälj ett alternativ.");

                var userInput = Console.ReadLine();
                 

                switch (userInput)
                {
                    case "1":
                        calculator.FirstNumber = NumberFromUser();
                        calculator.SecondNumber = NumberFromUser();
                        Console.WriteLine(calculator.SumNumbers());
                        break;
                    case "2":
                        calculator.FirstNumber = NumberFromUser();
                        calculator.SecondNumber = NumberFromUser();
                        Console.WriteLine(calculator.MultiplyNumbers());
                        break;
                    case "3":
                        calculator.FirstNumber = NumberFromUser();
                        calculator.SecondNumber = NumberFromUser();
                        Console.WriteLine(calculator.SumInBetween());
                        break;
                    case "4":
                        calculator.NumberInMemory = NumberFromUser();
                        Console.WriteLine("Number successfully added to memory");
                        break;
                    case "5":
                        calculator = new Calculator();
                        Console.WriteLine("Number in memory cleared");
                        break;
                    case "6":
                        Console.WriteLine(calculator.ToString());
                        break; 
                    case "7":
                        Console.WriteLine("Goodbye!");
                        isPlaying = false;
                        break; 
                    default:
                        break;
                }
            } while (isPlaying);
            
        }

    }
}
