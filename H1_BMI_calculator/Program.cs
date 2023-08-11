namespace H1_BMI_calculator
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                // Uses a try catch, to avoid crashes by bad user input
                try
                {
                    // Asks user to write their height in cm and saves it to a new variable called "height"
                    Console.WriteLine("What is your height in cm?");
                    double height = double.Parse(Console.ReadLine());

                    // Asks user to write their weight, which gets saved in the "weight" variable
                    Console.WriteLine("What is your weight in kg?");
                    double weight = double.Parse(Console.ReadLine());

                    // Converts height to meters and calculates the BMI, which then gets rounded to 1 decimal
                    height /= 100;
                    double result = weight / (height * height);
                    result = Math.Round(result * 10) / 10;

                    // Changes the text color, based on the BMI value
                    if (result < 18.5)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    else if (result > 18.5 && result < 24)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (result > 24 && result < 30)
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    else if (result > 30 && result < 35)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (result > 35 && result < 40)
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;

                    // Outputs the results in the console
                    Console.WriteLine($"Your BMI is {result}");
                }
                catch
                {
                    // Throws an error, if the user input is not a valid number
                    Console.WriteLine("Please only use numbers");
                }

                // Clears the console and puts text back to white color
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}