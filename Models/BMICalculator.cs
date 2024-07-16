using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApp.Models
{
    internal class BMICalculator
    {
        private int _id;
        private string _name;
        private int _age;
        private double _height;
        private double _weight;
        static double DEFAULT_WEIGHT = 50;
        static double DEFAULT_HEIGHT = 1.55;

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public int Age 
        { 
            set { _age = value; }
            get { return _age; }
        }
        public double Height
        {
            set { _height = value; }
            get { return _height; }
        }
        public double Weight
        {
            set { _weight = value; }
            get { return _weight; }
        }

        public BMICalculator(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = DEFAULT_HEIGHT;  
            Weight = DEFAULT_WEIGHT;
        }
        public BMICalculator(int id, string name, int age, double height, double weight):this(id, name, age)
        {
            Weight = weight;
            Height = height;
        }
        public static double CalculateBMI(BMICalculator user) { 
            double BMI =  user.Weight / (user.Height*user.Height);
            return BMI;
        }

        public string GetUserBMI(double BMI) {

            if (BMI <= 18.4)
            {
                return "UnderWeight";
            }
            else if (BMI > 18.4 && BMI < 25)
            {
                return  "Normal";
            }
            else if (BMI >= 25 && BMI < 40)
            {
                return  "OverWeight";
            }
            else {
                return "Obese";
            }
        }

        public override string ToString()
        {
            Console.WriteLine($"=========User No {Id}===========");
            Console.WriteLine($"User no: {Id}");
            Console.WriteLine($"User Name: {Name}");
            Console.WriteLine($"Height : {Height}");
            Console.WriteLine($"Weight : {Weight}");
            Console.WriteLine("==================================");
            return " ";
        }


    }
}
