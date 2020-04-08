using System;
using System.Collections.Generic;

namespace DivCheck
{
    public class DivCheckList:IDivCheck<DivCheckList>
    {
       List<int> listOfInts {get; set;}

        public DivCheckList(List<int> intitialListOfInts)
        {
            this.listOfInts = intitialListOfInts;
        }
        
        public void DivisibilityCheck(int a, int b)
        {
            DivCheckArray myArray = new DivCheckArray(this.listOfInts.ToArray());
            myArray.DivisibilityCheck(a, b);
        }
    }
}