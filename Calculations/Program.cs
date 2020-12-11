using System;

namespace Calculations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] machineModel = { "Synergy", "Precise" };
            int[] energy = { 6, 8, 10, 15 }; //mV
            double[] Dmax = { 1.5, 1.8, 2, 2.5 }; //cm
            string DmaxSIunit = "cm"; //Dim DmaxSIunit As String = "cm";
            string energySIunit = "mV"; //Dim energySIunit As String = "mV";


            Console.WriteLine("Please select machine type:");
            for (int i = 0; i < machineModel.Length; i++)
            {
                Console.WriteLine(i + " : " + machineModel[i]);

            }
            int selectedMachine = Convert.ToInt32(Console.ReadLine());

            string machineType = "";
            switch (selectedMachine)
            {
                case 0:
                    machineType = machineModel[0];
                    break;
                case 1:
                    machineType = machineModel[1];
                    break;
                default:
                    machineType = "";
                    break;
            }

            Console.WriteLine("Please enter energy level: ");
            for (int i = 0; i < energy.Length; i++)
            {
                Console.WriteLine(energy[i] + " " + energySIunit);
            }

            int energyLevel = Convert.ToInt32(Console.ReadLine());

            double selectedDmax = 0;

            switch (energyLevel)
            {
                case 6:
                    selectedDmax = Dmax[0];
                    break;
                case 8:
                    selectedDmax = Dmax[1];
                    break;
                case 10:
                    selectedDmax = Dmax[2];
                    break;
                case 15:
                    selectedDmax = Dmax[3];
                    break;
                default:
                    selectedDmax = 0;
                    break;
            }

            Console.WriteLine("Please enter SSD: ");
            double SSD = Convert.ToDouble(Console.ReadLine());  //Source To Surface Distance

            //Console.WriteLine("Please enter Field Size: ");
            //double fieldSize = Convert.ToDouble(Console.ReadLine());
            //int WF = 0;
            //int integerMUopen = 0;
            //int integerMUwedge = 0;

            Console.WriteLine("\nMachine Type: " + machineType);
            Console.WriteLine("Energy Level: " + energyLevel + " "+ energySIunit);
            Console.WriteLine("Dmax: " + selectedDmax + " " + DmaxSIunit);
                
        }
    }
}
