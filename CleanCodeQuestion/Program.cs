using System;
using System.Collections.Generic;
namespace CleanCode {
    class Program {
        public static void Main(string[] args)
        {
            List<string> RegisterColor = new List<string>();
            CarPark obj = new CarPark();
            Console.WriteLine("Enter capacity of the parking lot");
            int Capacity = Convert.ToInt16(Console.ReadLine());
            string Option;
            int Counter = 1;
            Console.WriteLine("Do you wish to enter car details(yes/no)");
            Option = Convert.ToString(Console.ReadLine());
            if(Option == "no")
            {
                Environment.Exit(-1);
            }
            while (Option == "yes") 
            {
                if (Counter > Capacity)
                {
                    Console.WriteLine("Exceeds capacity of parking lot");
                    break;
                }
                if( Option == "yes")
                {
                    Console.WriteLine("Enter registration and color separated by a space:");
                    RegisterColor.Add(Convert.ToString(Console.ReadLine()));
                }
                else if(Option == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                    continue; 
                }
                Counter++;
                Console.WriteLine("Do you want to enter again?(yes/no)");
                Option = Convert.ToString(Console.ReadLine());
            }                               
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Find  Registration numbers and slot numbers of all cars of a particular color. ");
            Console.WriteLine("2. Slot number in which a car with a given registration number is parked.");        
            Console.WriteLine("3. Vacate a slot. ");
            int OptionNum = Convert.ToInt16(Console.ReadLine());
            string color;
            switch (OptionNum)
            {
                case 1:
                    Console.WriteLine("Enter color");
                    color = Convert.ToString(Console.ReadLine());                    
                    obj.ColorRegNumber(color, RegisterColor);                    
                    break;
                case 2:
                    Console.WriteLine("Enter Register number");
                    string RegNumber = Convert.ToString(Console.ReadLine());
                    obj.SlotCalculator(RegNumber, RegisterColor);
                    break;
                case 3:
                    Console.WriteLine("Enter the slot you want to delete");
                    int SlotNumber = Convert.ToInt16(Console.ReadLine());
                    obj.SlotVacator(SlotNumber, RegisterColor);
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;                       
            }
        }
    }
}