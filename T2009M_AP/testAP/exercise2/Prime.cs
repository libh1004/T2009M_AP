using System;

namespace T2009M_AP.testAP.exercise2
{
    public delegate int PrimeNumberFinder(int n);
    public class Prime
    {
        public event PrimeNumberFinder OnPrimeNumber;

        public static bool FindPrime(int n)
        {
            if (n < 2) return false;
            if (n < 3) return true;
            for (int i = 3; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
                return true;
        }
/*
        public 
        public void ShowEvent()
        {
            if (OnPrimeNumber != null)
            {
                
            }
            OnPrimeNumber += FindPrime;
        }*/
        
    }
}