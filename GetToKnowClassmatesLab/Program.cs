using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMatesLab
{
    class Program
    {
        static void Main(string[] args)
        {
                 
            List<string> names = new List<string>() { "Andrew", "James", "Trent", "Kate" };

            //How we tie hometowns and favoritefoods to particular person using index above

            List<string> foods = new List<string>() { "Sushi", "Itailian Cruisine", "Tacos", "Pizza" };
            List<string> hometown = new List<string>() { "Graylake", "Milwaukee", "Rochester", "Zeeland" };
            bool goOn = true;
            string name = "";
            int index = -1;
            while (goOn == true)
            {
                PrintWholeList(names);
                
                string input = GetUserInput("Which person would you like to learn about? ");



                
                string input2 = GetUserInput($"What would you like to learn about {name}? Hometown or Favorite food");
                if (input2 == "Hometown")
                {
                    string ht = hometown[index];
                    Console.WriteLine(ht);
                }
                else 
                {
                    string food = foods[index];
                    Console.WriteLine(food);
                }

               

            }
        }

            public static bool IsValidIndex(int collectionLength, int index)
            {
                if (index >= 0 && index < collectionLength)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void PrintWholeList(List<string> items)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i}: {items[i]}");
                }
            }

            public static string GetUserInput(string message)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine().ToLower().Trim();
                return input;
            }
        }
    }












