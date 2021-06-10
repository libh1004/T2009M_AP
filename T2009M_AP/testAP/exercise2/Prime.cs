using System;

namespace T2009M_AP.testAP.exercise2
{
    public delegate int PrimeNumberFinder(int n);
    public class Prime{
        public event PrimeNumberFinder OnPrimeNumber;
        private int n;

        public int N
        {
            get => n;
            set => n = value;
        }
        
        public static bool FindPrime(int n)
        {
            if (n < 2) return false;
            if (n < 3) return true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        
        public int PrintResult(int n)
        {
            return n;
        }
        
        public int ShowNotification(int n)
        {
            if (OnPrimeNumber == null)
            {
            }
            return n;
        }

    }
}