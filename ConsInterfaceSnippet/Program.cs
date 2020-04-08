using System;
using System.Collections.Generic;
using DivCheck;


namespace ConsInterfaceSnippet
{
    //create a function that takes an array of integers  
    //For each value:  
    //Print "[i]: 3" if only divisible by 3  
    //Print "[i]: 5" if only divisible by 5  
    //Print "[i]: 3 and 5" if divisible by 3 and 5
    //use an interface so that a list can be passed instead of an array 
    class Program{
        public static void Main(string[] args)
        {
            int[] arrayOfInts = new int[] {15, 9, 30, 25, 8, 101};
            DivCheckArray myArray = new DivCheckArray(arrayOfInts);
            myArray.DivisibilityCheck(3, 5);
            
            List<int> listOfInts = new List<int>();
            listOfInts.Add(35);
            listOfInts.Add(49);
            listOfInts.Add(40);
            listOfInts.Add(42);
            DivCheckList myList = new DivCheckList(listOfInts);
            myList.DivisibilityCheck(3, 5);
            myList.DivisibilityCheck(6, 7);
        }
    }
}


    // takes array of integers
// goes through items checks if item is divisible by 3
/*
ceate a function that takes an array of integers  
For each value:  
Print "[i]: 3" if only divisible by 3  
Print "[i]: 5" if only divisible by 5  
Print "[i]: 3 and 5" if divisible by 3 and 5  
*/




