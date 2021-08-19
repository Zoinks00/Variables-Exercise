using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int petAge = 7;
            string petName = "Coco";
            char petSex;
            decimal petFood = 59.996m;
            double petMed = 120.60d;
            bool result = false;

            Console.WriteLine($"My dog's name is {petName}, He is {petAge} years old");
            //prompt use to enter pet sex
            
            Console.Write("Enter pets gender using m or f:");
            petSex = Convert.ToChar(Console.ReadLine());
            
            result = (petSex != 'f');
            // check if user inputed valid gender
            if(result)

            {
                Console.WriteLine($"Food for {petName} will be {petFood} per month.");
                Console.WriteLine($"{petName} medical bills will be {petMed} roughly every 3 months.");
            }
            else
            {
                Console.WriteLine("You have entered a invalide gender.");
            }
            

        }
    }
}
