using System;

namespace CalcolatriceLybrary
{
    public class Calcolatrice
    {
        public  int Somma(int [] addendi)
        {
            if (addendi == null || addendi.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int sum = 0;

            foreach (int x in addendi)
            {
                sum += x;
            }

            return sum;
        }
    }
}
