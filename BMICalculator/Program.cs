namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We collect the users information
            Console.WriteLine("Indtast din vægt i kg");
            double weight = double.Parse(Console.ReadLine());         
            Console.WriteLine("Indtast din højde i m");
            double height = double.Parse(Console.ReadLine());

            //We calculate the bmi
            double bmi = (weight / (height * height));
            Console.Write("Din BMI er " + bmi.ToString("0.0") + " du er ");

            //checks the users bmi
            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Kropsvægt underskud");
            }
            else if (bmi >= 18.5 && bmi <24)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Normal");
            }
            else if (bmi >= 24 && bmi < 30)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Overvægtig");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Første grads overvægtig");
            }
            else if (bmi >= 35 && bmi < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Anden grads overvægtig");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Tredje grads overvægtig");
            }
            Console.Read();
        }
    }
}