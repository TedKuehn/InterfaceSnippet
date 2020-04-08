using System;

namespace DivCheck
{
    public class DivCheckArray:IDivCheck<DivCheckArray>
    {
        public int[] arrayOfInts {get; set;}

        public DivCheckArray(int[] intitialArrayOfInts)
        {
            this.arrayOfInts = intitialArrayOfInts;
        }
        
        public void DivisibilityCheck(int a, int b)
        {
            foreach (int currentInt in this.arrayOfInts)
            {
                if ((currentInt % a == 0) && (currentInt % b == 0))
                {
                    Console.WriteLine("["+currentInt+"]: "+a+" and "+b);        
                }
                else if (currentInt % a == 0)
                {
                    Console.WriteLine("["+currentInt+"]: "+a);
                }
                else if (currentInt % b == 0)
                {
                    Console.WriteLine("["+currentInt+"]: "+b);
                }
            }
        }
    }
}