using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class FortuneTeller
    {
        //Fields
        private string firstName;
        private string lastName;
        private int age;
        private int birthMonth;
        private string color;
        private int siblings;
        private int health = 100;
        //Properties
        public string GetFirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string GetLastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int GetAge
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int GetBirthMonth
        {
            get { return this.birthMonth; }
            set { this.birthMonth = value; }
        }

        public string GetColor
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int GetSiblings
        {
            get { return this.siblings; }
            set { this.siblings = value; }
        }

        public int GetHealth
        {
            get { return this.health; }
            set { this.health = value; }
        }
        //Constructors
        public FortuneTeller()
        {
            //default constructor
        }

        public FortuneTeller(string firstName, string lastName, int age, int birthMonth, string color, int siblings)
        {
            this.GetFirstName = firstName;
            this.GetLastName = lastName;
            this.GetAge = age;
            this.GetBirthMonth = birthMonth;
            this.GetColor = color;
            this.GetSiblings = siblings;
            GetHelp(color);
        }

        //Methods
        public string GetRetirement()
        {
            

            if ((age % 2) == 0)//determines whether the users age is even or odd
            {
                return "10 years";               
            }
            else
            {
                return "5 years";
            }            
        }

        public void GetHelp(string color)
        {
            
            if (color == "help")//displays a help menu if the user types in help
            {
                Console.WriteLine("Help Menu");
                Console.WriteLine("R - Red");
                Console.WriteLine("O - Orange");
                Console.WriteLine("Y - Yellow");
                Console.WriteLine("G - Green");
                Console.WriteLine("B - Blue");
                Console.WriteLine("I - Indigo");
                Console.WriteLine("V - Violet");
                Console.WriteLine("What is your favorite color? (Please select from ROYGBIV.)");
                this.GetColor = (Console.ReadLine().ToLower());
                Tic();
            }
        }
            public string GetVacationHome()
        {
            
            if (GetSiblings == 0)//determines the users vacation home based on the number of siblings
            {
                return "England";
            }
            else if (GetSiblings == 1)
            {
                return "France";
            }
            else if (GetSiblings == 2)
            {
                return "Spain";
            }
            else if (GetSiblings == 3)
            {
                return "Germany";
            }
            else if (GetSiblings > 3)
            {
                return "Ireland";
            }
            else
            {
                return "Iraq";
            }
        }

        public string GetTransportation()
        {
            switch (GetColor)//determines the mode of transportation based on their favorite color
            {
                case "r":
                    return "bike";

                case "o":
                    return "car";

                case "y":
                    return "plane";

                case "g":
                    return "horse";

                case "b":
                    return "camel";

                case "i":
                    return "wagon";

                case "v":
                    return "train";

                default:
                    return "no transportation";

            }
        }

        public string GetMoney()
        {
            //determines how much money the user will have based on their birth month
            if ((birthMonth >= 1) && (birthMonth <= 4))
            //if ((birthMonth==1)|| (birthMonth == 2) || (birthMonth == 3) || (birthMonth == 4))
            {
                return "$100";
                //return 100.00;
            }
            else if ((birthMonth >= 5) && (birthMonth <= 8))
            //else if ((birthMonth == 5) || (birthMonth == 6) || (birthMonth == 7) || (birthMonth == 8))
            {
                return "$1000";
                //return 1000.00;
            }
            else if ((birthMonth >= 9) && (birthMonth <= 12))
            //else if ((birthMonth == 9) || (birthMonth == 10) || (birthMonth == 11) || (birthMonth == 12))
            {
                return "$10,000";
                //return 10000.00;
            }
            else
            {
                return "$0";
                //return 0.00;
            }            
        }

        public void Tic()
        {
            GetHealth -= 20;
            Console.WriteLine("Your health is {0}", GetHealth);
            if (GetHealth <= 40)
            {
                Console.WriteLine("Do you want to recharge your health?");
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    GetHealth = 100;
                    Console.WriteLine("health restored to {0}", GetHealth);
                }
                if (GetHealth <= 20)
                {
                    GetHealth = 100;
                    Console.WriteLine("Health too low and has been restored to {0} automatically.", GetHealth);                   
                }                              
            }
        }
    }//class
}
