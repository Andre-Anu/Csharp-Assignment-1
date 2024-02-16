using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1
{
    public class Patient(string firstName, string lastName, double weight, double height)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public double Weight { get; set; } = weight;
        public double Height { get; set; } = height;

        public string BPcheck(int s, int d)
        {
            if (s < 90 || d < 60)
            {
                return "WARNING: Blood Pressure levels are dangerously LOW.";
            }
            else if (s  <= 120 && d <= 80)
            {
                return "NORMAL";
            }
            else if (s <= 129 && d <= 84)
            {
                return "ELEVATED";
            }
            else if (s <= 139 || d <= 89)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if (s <= 180 || d <= 120)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else if ((s > 180 && d > 120) || (s > 180 || d > 120))
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            else
            {
                return "Something Went Wrong Please Verify The Equipment";
            }
        }//BPcheck

        public double BMIcalc()
        {
            double m = Height / 100;
            return Weight / (m * m);
        }//BMIcalc
        public void printer(int  s, int d)
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Height: {Height} CM");
            Console.WriteLine($"Blood Pressure: {BPcheck(s, d)}");
            Console.WriteLine($"BMI: {BMIcalc()}");
            if (BMIcalc() >= 25.0)
            {
                Console.WriteLine("BMI: Overweight");
            }
            else if (BMIcalc() >= 18.5 && BMIcalc() <= 24.9)
            {
                Console.WriteLine("BMI: Healthy");
            }
            else
            {
                Console.WriteLine("BMI: Underweight");
            }
        }//printer
    }//class
}//namespace