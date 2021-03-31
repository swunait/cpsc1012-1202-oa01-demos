using System;

namespace BodyMassIndexApp
{
    // Define a new class named BMI with properties for the
    // name, age, weight, and height of a person.
    // The mutator for name will validate that name contains at least two characters
    // The mutator for age will validate that age is >= 18 and <= 80
    // The mutator for weight/height will validate that weight/height > 0
    // Define a method named BmiValue() in BMI that calculates and returns
    // the bmi value this formula:
    //         bmiValue = 703 * weight / (height * height)
    // Define a method named Status() in BMI that returns
    //  a string indicate if the person is
    //  "Underweight" (bmiValue < 18.5),
    //  "Normal", (bmiValue >= 18.5 and bmiValue < 25)
    //  "Overweight", (vmiValue >= 25 and bmiValue < 30)
    //  "Obese" (bmiValue >= 30)

    // Use the BMI class in a program that prompts the user for the 
    // name, age, weight, and height 
    // then display a message with their bmi value and bmi status.
    public class BMI
    {
        private string _name = "default_name";
        private int _age;
        private double _weight;
        private double _height;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length <= 2)
                {
                    throw new Exception("Name must be at least two characters");
                }
                else
                {
                    //Name = value;
                    _name = value;
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Age must be greater than 18");
                }
                else if (value > 80)
                {
                    throw new Exception("Age must be less than 80");
                }
                else
                {
                    //Age = value;
                    _age = value;
                }
            }

        }
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Weight must be greater than 0");
                }
                else
                {
                    //Weight = value;
                    _weight = value;
                }
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Height must be greater than 0");
                }
                else
                {
                    //Height = value;
                    _height = value;
                }
            }
        }
        public BMI()
        {
            Name = "No Name";//_name;
            Age = 18;//_age;
            Weight = 100;//_weight;
            Height = 160;// _height;
        }
        public BMI(string userName, int userAge, double userWeight, double userHeight)
        {
            Name = userName;
            Age = userAge;
            Weight = userWeight;
            Height = userHeight;
        }
        public double BmiValue()
        {
            return (703 * Weight / (Height * Height));
        }
        public string Status()//public string Status(double BmiValue)
        {
            string BmiStatus;
            // "Underweight" (bmiValue < 18.5),
            // "Normal", (bmiValue >= 18.5 and bmiValue < 25)
            // "Overweight", (vmiValue >= 25 and bmiValue < 30)
            // "Obese" (bmiValue >= 30)
            double currentBmiValue = BmiValue();
            if (currentBmiValue < 18.5)
            {
                BmiStatus = "Underweight";
            }
            else if (currentBmiValue >= 18.5 && currentBmiValue < 25)
            {
                BmiStatus = "Normal";
            }
            else if (currentBmiValue >= 25 && currentBmiValue < 30)
            {
                BmiStatus = "Overweight";
            }
            else
            {
                BmiStatus = "Obese";
            }
            return BmiStatus;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
