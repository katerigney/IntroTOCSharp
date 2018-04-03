using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroTOCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create the following vairbles. Use the type you think would be the best

            //number of dogs running around a dog park
            int numDogs = 8;
            Console.WriteLine($"There are {numDogs} dogs in the dog park.");


            //the number of sandwhiches You can eat when you are hungry
            double numSandwich = 1.5;
            Console.WriteLine($"I can eat {numSandwich} sandwiches when I'm hungry.");


            //the amount of money it costs to buy a nice dinner
            //decimal dinnerCost = 37.73;
            // Console.WriteLine($"It costs {dinnerCost} to buy a nice dinner.");

            string[] car = new string[3] { "charcoal gray", "vintage Toyota", "Land Cruiser" };

            // what color your dream car is
            Console.WriteLine($"My dream car is {car[0]}.");


            //what make your dream car is
            Console.WriteLine($"My dream car is a {car[1]}.");


            //what model your dream car is
            Console.WriteLine($"My dream car is a {car[2]}.");


            //todays date
            // Console.WriteLine($"Today is {date}.");


            //the first letter of you name
            char firstInitial = 'K';
            Console.WriteLine($"{firstInitial} is the first letter of my name.");


            //the number of stars in the sky
            string numStars = "infinite";
            Console.WriteLine($"There are {numStars} stars in the sky.");


            //Print out each variable in the middle of string describing the variable.
            //ex: for the number of dogs in the park, I want you to print out There are 5 dogs running around the park


            Console.ReadLine();

        }
    }
}
