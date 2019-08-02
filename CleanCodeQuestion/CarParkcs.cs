using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CleanCode {
    class CarPark {
        public void ColorRegNumber(string Color, List<string> RegisterColor)
        {
            Console.WriteLine("SlotNo.  RegNumber  Color");
            for(int i =0; i<RegisterColor.Count; i++)
            {
                if (RegisterColor[i].Contains(Color))
                {
                    Console.WriteLine("{0}        {1}", i+1, RegisterColor[i]);
                }
            }
            Console.ReadLine();
        }
        public void SlotCalculator(string RegNumber, List<string> RegisterColor)
        {
            
            for (int i = 0; i < RegisterColor.Count; i++)
            {
                if (RegisterColor[i].Contains(RegNumber))
                {
                    Console.WriteLine("Slot Number is: {0}",i+1);
                    break;
                }
            }
            Console.ReadLine();
        }
        public void SlotVacator(int SlotNumber, List<string> RegisterColor)
        {
            RegisterColor[SlotNumber-1] = "0";
            Console.WriteLine("Slot{0} is free:)", SlotNumber);
            Console.ReadLine();
        }
    }
}