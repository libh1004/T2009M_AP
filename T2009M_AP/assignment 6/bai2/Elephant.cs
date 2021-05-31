using System;

namespace T2009M_AP.assignment_6
{
   
    public class Elephant : ISpecies,IBodyCharacteristics,IDiet,IReproduction,IDomestication
    {
        public void African()
        {
            Console.WriteLine("African elephants are found in 38 countries of African and stand up to 4m and weigh around 7000kgs.");
        }

        public void Asian()
        {
            Console.WriteLine("Asian elephants are 3.4m tall and weigh 5,400kgs.");
        }

        public void Trunk()
        {
            Console.WriteLine("Trunk is used to tear up their food and then, place it in their mouth.");
        }

        public void Tusk()
        {
            Console.WriteLine("Tusk used to dig for water, salt, and roots; to debark trees, to eat the bark;to dig into baobab trees to get at the pulp inside; and to move trees and branches when clearing a path.");
        }

        public void Teeth()
        {
            Console.WriteLine("They usually have 28 teeth");
        }

        public void Skin()
        {
            Console.WriteLine("It is extremely tough around most parts of its body and measures about 2.5cm (1 in) thick.");
        }

        public void LegsAndFeet()
        {
            Console.WriteLine("They are great straight pillars, as they must be to support its bulk weight.");
        }

        public void Ears()
        {
            Console.WriteLine("Elephant ears are made of a very thin layer of skin stretched over cartilage and a rich network of blood vessels.");
        }

        public void Herbivores()
        {
            Console.WriteLine("Elephants are herbivores, spending 16 hours a day collecting plant food.");
        }

        public void Interval()
        {
            Console.WriteLine("Females give birth at interval of about every 5 years.");
        }

        public void Weight()
        {
            Console.WriteLine("At birth, calves weigh around 90-115 kgs.");
        }

        public void Use()
        {
            Console.WriteLine("Elephants have been working animals used in various capacities by humans.");
        }
    }
}