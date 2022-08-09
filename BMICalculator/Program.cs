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

            //checks the users bmi
            if (bmi >= 16 && bmi < 18.5)
            {
                Console.WriteLine("Kropsvægt underskud");
            }
            else if (bmi >= 18.5 && bmi <24)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 24 && bmi < 30)
            {
                Console.WriteLine("Overvægtig");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("Første grads overvægtig");
            }
            else if (bmi >= 35 && bmi < 40)
            {
                Console.WriteLine("Anden grads overvægtig");
            }
            else
            {
                Console.WriteLine("Tredje grads overvægtig");
            }
            Console.Read();
        }
    }
}