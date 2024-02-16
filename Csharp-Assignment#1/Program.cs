namespace Csharp_Assignment_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Weight (Kg):");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Height (CM):");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Systolic Value:");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Diastolic Value");
            int d = Convert.ToInt32(Console.ReadLine());

            Patient patient = new(firstName, lastName, weight, height);

            patient.printer(s, d);
        }//Main
    }//class
}//namespace