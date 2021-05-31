using System;

namespace T2009M_AP.assignment_6.bai1
{
    public class TrendSetting : Clothing
    {
        public override void Sales()
        {
            Console.WriteLine("All the places who bring in the maximum sale: Trend Setting Garments");

            
        }

        public override void Materials()
        {
            Console.WriteLine("Materials: ");
            Console.WriteLine("Cotton Polyester\n Rayon\n Linen\n Satin\n Georgette\n Moss crepe\n Net\n Lace\n Jacquard velvet");
        }

        public override void CommonWear()
        {
            throw new System.NotImplementedException();
        }
    }
}