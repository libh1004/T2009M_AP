using System;

namespace T2009M_AP.assignment_6.bai1
{
    public class Sports : Clothing
    {
        public override void Sales()
        {
            Console.WriteLine("All the places who were responsible for low sale: Sports Garments");
        }

        public override void Materials()
        {
            Console.WriteLine("Materials: ");
            Console.WriteLine("Viscose cotton\n Flax\n Wool\n Hemp\n  Ramie\n Silk\n Lyocell \n ");
        }

        public override void CommonWear()
        {
            throw new System.NotImplementedException();
        }
    }
}