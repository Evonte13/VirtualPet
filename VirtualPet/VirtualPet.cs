using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {


         string typeOfDragon;
         int money;
         int hunger;
         int happiness;
         int sleepiness;
         string name;
         string dragonName;



        //Constructors
        
        public VirtualPet()
        {
            this.typeOfDragon ="dora";
            this.money = 5;
            this.hunger = 5;
            this.happiness = 2;
            this.name = dragonName;
            this.sleepiness = 2;
        }

        #region PROPERTIES
        //Properties

        public string TypeOfDragon
        {
            get { return this.typeOfDragon; }
            set { this.typeOfDragon = value; }
        }
        public int Money
        {
            get { return this.money; }
            set { this.money = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Happiness
        {
            get { return this.happiness; }
            set { this.hunger = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Sleepiness
        {
            get { return this.sleepiness; }
            set { this.sleepiness = value; }
        }

        public string DragonName
        {
            get { return this.dragonName; }
            set { this.dragonName = value; }
        }
        #endregion


        #region METHODS
        //Methods
        public void Raise()
        {
            money = money + 5;
        }

        public void Eat()
        {
            hunger = hunger - 1;
            money = money - 2;
            happiness = happiness + 1;
        }

        public void DrinkSoda()
        {
            money = money - 5;
            happiness = happiness + 2;
            sleepiness = sleepiness + 2;
        }

        public void Sleep()
        {
            sleepiness = sleepiness - 5;
            hunger = hunger + 2;
            happiness = happiness + 1;
        }

        public void Stats()
        {
            
            Console.WriteLine("Money: " + this.money);
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Happiness: " + this.happiness);
            Console.WriteLine("Sleepiness: " + this.sleepiness);
        }

        


        #endregion 











    }










}
 