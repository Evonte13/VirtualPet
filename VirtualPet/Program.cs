using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            VirtualPet dragonPet = new VirtualPet();
            string option;
           
            Console.WriteLine("Welcome to Dragonland");
           
            int typeOfDragon;
            Console.WriteLine("What kind of Dragon do you want to be?");
            Console.WriteLine("Press 1 for Dragonite, \nPress 2 for Black dragon, \nPress 3 for White dragon,\nor Press 4 for Pink dragon");
            typeOfDragon = int.Parse(Console.ReadLine());
            
            if(typeOfDragon == 1)
            {
                Console.WriteLine("Dragonite");
            }
            else if(typeOfDragon== 2)
            {
                Console.WriteLine("Black Dragon");
            }
            else if (typeOfDragon == 3)
            {
                Console.WriteLine("White Dragon");
            }
            else if (typeOfDragon == 4)
            {
                Console.WriteLine("Pink Dragon");
            }
            else
            {
                Console.WriteLine("Gumpy the Dragon");
            }
            



            do
            {
               
                dragonPet.Stats();
                Console.WriteLine("What do you want to do? Earn Money, Drink soda, Eat, or Sleep?");
                Console.WriteLine("Press 1 to earn money, 2 to drink soda, 3 to eat, or 4 to sleep");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    dragonPet.Raise();

                }

                else if (answer == "2")
                {
                    dragonPet.DrinkSoda();
                }

                else if (answer == "3")
                {
                    dragonPet.Eat();
                }

                else if (answer == "4")
                {
                    dragonPet.Sleep();
                }

                else
                {
                    dragonPet.DrinkSoda();

                }

                dragonPet.Stats();

                Console.WriteLine("Do you want to go again? \nType yes to go again!");
                option = Console.ReadLine();
                option = option.ToUpper();
             

            } while (option == "Yes");
            Console.ReadLine();



        }
    }
}
