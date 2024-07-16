using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMIApp.Models;

namespace BMIApp
{
    
    internal class Program
    {
        static void GetBMIdetails(BMICalculator user)
        {
            double bmiScore = BMICalculator.CalculateBMI(user);
            string output = user.GetUserBMI(bmiScore);
            Console.WriteLine($"User {user.Id} BMI score is: {bmiScore} \n" +
                $"User body status is {output}");
        }
        static void Main(string[] args)
        {
            BMICalculator user1 = new BMICalculator(101, "Ramesh", 23);
            BMICalculator user2 = new BMICalculator(102, "Suresh", 23, 1.74, 90);
            Console.WriteLine(user1);
            GetBMIdetails(user1);
            Console.WriteLine(user2);
            GetBMIdetails(user2);
        }
    }
}
