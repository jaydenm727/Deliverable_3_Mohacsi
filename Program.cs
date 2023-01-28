/*
Name: Jayden Mohacsi
Date: 01/28/2023
Description: Print odd or even numbers between 0 and 100
*/

namespace Deliverable_3_Mohacsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index;
            int myInt;
            string mySeries;
            
            while (true)
            {
                Console.Write("Please enter an integer between 1 and 100: ");
                try
                {
                    myInt = int.Parse(Console.ReadLine());
                    if (myInt >= 1 && myInt <= 100)
                    {
                        break;
                    }
                }
                catch
                {

                }
            }
            
            while (true)
            {
                Console.Write("Please specify the series type, Odd or Even: ");
                mySeries = Console.ReadLine();
                if(mySeries.ToLower() == "even")
                {
                    index = 0;
                    break;
                }
                if(mySeries.ToLower() == "odd")
                {
                    index = 1;
                    break;
                }
            }
            
            Console.WriteLine("You have selected the " + mySeries + " series. The numbers between 0 and " + myInt + " are:");
            
            while(index <= myInt)
            {
                Console.WriteLine(index);
                index+= 2;
            }
        }
    }
}