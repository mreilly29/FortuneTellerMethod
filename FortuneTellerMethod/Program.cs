using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneTeller fortuneTeller = new FortuneTeller();
            //User interface displays a title then asks the user questions regarding first name, last name, age, birth month, favorite color, and number of siblings
            Console.WriteLine("Fortune Teller.");
            Console.WriteLine("Your starting health is {0}", fortuneTeller.GetHealth);

            Console.WriteLine("What is your first name?");
            fortuneTeller.GetFirstName = Console.ReadLine();
            fortuneTeller.Tic();

            Console.WriteLine("What is your last name?");
            fortuneTeller.GetLastName = Console.ReadLine();
            fortuneTeller.Tic();

            Console.WriteLine("What is your age?");
            fortuneTeller.GetAge = int.Parse(Console.ReadLine());
            fortuneTeller.Tic();

            Console.WriteLine("What is your birth month? (Please provide a numeric value 1 - 12)");
            fortuneTeller.GetBirthMonth = int.Parse(Console.ReadLine());
            fortuneTeller.Tic();

            Console.WriteLine("How many siblings do you have?");
            fortuneTeller.GetSiblings = int.Parse(Console.ReadLine());
            fortuneTeller.Tic();

            Console.WriteLine("What is your favorite color? (Please select from ROYGBIV. For help, enter \"help\"");
            fortuneTeller.GetColor = Console.ReadLine().ToLower();
            fortuneTeller.Tic();
            fortuneTeller.GetHelp(fortuneTeller.GetColor);


            Console.WriteLine("Fortune Teller, your ending health is {0}", fortuneTeller.GetHealth);

            //displays the fortune to the user based on their answers
            Console.WriteLine("{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4}, and a {5}.", fortuneTeller.GetFirstName, fortuneTeller.GetLastName, fortuneTeller.GetRetirement(), fortuneTeller.GetMoney(), fortuneTeller.GetVacationHome(), fortuneTeller.GetTransportation());
        }
    }
}
