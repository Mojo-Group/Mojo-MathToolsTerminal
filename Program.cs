using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class Program
{
    // Function to display information about the program



    
    static void ShowInfo()
    {

        ShowLoading();

        Console.BackgroundColor = ConsoleColor.Blue; // Set background color to Blue
        Console.Clear(); // Clear the console to apply the background color
        Console.ForegroundColor = ConsoleColor.White; // Set text color to White
        Console.WriteLine("==================================");
        Console.WriteLine(@"
    __  ___        _       ______      __           __      __            
   /  |/  /___    (_)___  / ____/___ _/ /______  __/ /___ _/ /_____  _____
  / /|_/ / __ \  / / __ \/ /   / __ `/ / ___/ / / / / __ `/ __/ __ \/ ___/
 / /  / / /_/ / / / /_/ / /___/ /_/ / / /__/ /_/ / / /_/ / /_/ /_/ / /    
/_/  /_/\____/_/ /\____/\____/\__,_/_/\___/\__,_/_/\__,_/\__/\____/_/     
            /___/
");
        Console.WriteLine("This app made by C# Lang");
        Console.WriteLine("i will give negative.");
        Console.WriteLine("Nomreh Faramosh Nasheh.");
        Console.WriteLine("I'll kick anyone that make joke");
        Console.WriteLine("Shut Up Matin for 23/4 Min");
        Console.WriteLine("==================================");
        Console.ResetColor(); // Reset to default color
    }


    // Function to calculate GCD
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate LCM
    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    // Function to calculate LCM of an array of numbers
    static int LCMOfArray(int[] numbers)
    {
        int lcm = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            lcm = LCM(lcm, numbers[i]);
        }
        return lcm;
    }

    // اول بودن عدد
    static bool IsPrime(int number)
    {
        if (number <= 1) return false; // عدد 1 و 0 اول نیستند.
        for (int i = 2; i <= Math.Sqrt(number); i++) //میاد تا عدد کوچک تر از جذر عدد داده شده تقسیم میکنه.
        {
            if (number % i == 0) return false; // به تو چه خودم توضیح میدم.
        }
        return true; // هیچی انجام نشد عدد اوله/
    }

    // چرت و پرت: کسر داده شده رو مصری میکنه.
    static void ConvertToEgyptianFraction(int numerator, int denominator)
    {
        if (numerator <= 0 || denominator <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red; // مهم نی
            Console.WriteLine("Invalid fraction. Both numerator and denominator must be positive.");
            Console.ResetColor(); // مهم نی توجهی نکن
            return;
        }

        Console.ForegroundColor = ConsoleColor.White; // مهم نی
        Console.Write("Egyptian Fraction: ");
        while (numerator != 0)
        {
            // میگم
            int unitDenominator = (denominator + numerator - 1) / numerator; // میگم
            Console.Write($"1/{unitDenominator} ");

            // میگم
            numerator = numerator * unitDenominator - denominator;
            denominator = denominator * unitDenominator;
        }
        Console.WriteLine();
        Console.ResetColor(); // پرتوپلا
    }

    // Function to display a fraction as a fraction
    static void DisplayFractionAsFraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Set text color to Red for error
            Console.WriteLine("Denominator cannot be zero.");
            Console.ResetColor(); // Reset to default color
            return;
        }

        // Display the fraction using a simple format
        Console.ForegroundColor = ConsoleColor.White; // Set text color to White
        Console.WriteLine($"Fraction: {numerator} / {denominator}");

        // Display the fraction in a more visual way
        Console.WriteLine($"  {numerator}");
        Console.WriteLine($"  ————");
        Console.WriteLine($"  {denominator}");
        Console.ResetColor(); // Reset to default color
    }

    // Function to generate a random number within a specified range
    static void GenerateRandomNumber()
    {
        Console.ForegroundColor = ConsoleColor.White; // اگه چراغی بفهمه من چی نوشتم.
        Console.WriteLine("Please enter the minimum value:");
        if (!int.TryParse(Console.ReadLine(), out int min))
        {
            Console.ForegroundColor = ConsoleColor.Red; // به توچه
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.ResetColor(); // مهم نیس
            return;
        }

        Console.WriteLine("Please enter the maximum value:");
        if (!int.TryParse(Console.ReadLine(), out int max) || max <= min)
        {
            Console.ForegroundColor = ConsoleColor.Red; // پرت و پلا
            Console.WriteLine("Invalid input. Maximum value must be greater than minimum value.");
            Console.ResetColor(); // نی مهم
            return;
        }

        Random random = new Random();
        int randomNumber = random.Next(min, max + 1); // اصل کاری 
        Console.ForegroundColor = ConsoleColor.Green; // پروتپلا
        Console.WriteLine($"Random Number: {randomNumber}");
        Console.ResetColor(); // هیچی
    }

    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Blue; // Set background color to Blue
        Console.Clear(); // Clear the console to apply the background color
        ShowInfo(); // Call the info function
 

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White; // Set text color to White
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Calculate GCD and LCM");
            Console.WriteLine("2. Check if a number is prime");
            Console.WriteLine("3. Convert a fraction to Egyptian fractions");
            Console.WriteLine("4. Display a fraction");
            Console.WriteLine("5. Generate a random number");
            Console.WriteLine("6. Exit");
            Console.Write("Please select an option (1, 2, 3, 4, 5, or 6): ");
            Console.ResetColor(); // Reset to default color
            string option = Console.ReadLine();

            switch (option)
            {

                case "color":
                case "lcd":
                case "old":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;

                case "doz":
                case "tictac":
  
                    break;

                case "date":
                case "tarikh":
                    DateTime d = DateTime.Now;
                    PersianCalendar pc = new PersianCalendar();
                    Console.WriteLine(string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d)));
                    break;

                case "1":
                    // Calculate GCD and LCM
                    Console.ForegroundColor = ConsoleColor.White; // Set text color to White
                    Console.WriteLine("Please enter numbers separated by commas (or type 'exit' to quit):");
                    Console.ResetColor(); // Reset to default color
                    string input = Console.ReadLine();

                    if (input.Trim().ToLower() == "exit")
                    {
                        return; // Exit the program if the user types "exit"
                    }

                    string[] numberStrings = input.Split(',');

                    int[] numbers = new int[numberStrings.Length];
                    bool validInput = true;

                    for (int i = 0; i < numberStrings.Length; i++)
                    {
                        if (!int.TryParse(numberStrings[i].Trim(), out numbers[i]))
                        {
                            validInput = false;
                            break;
                        }
                    }

                    if (validInput && numbers.Length > 1)
                    {
                        int gcd = numbers[0];
                        for (int i = 1; i < numbers.Length; i++)
                        {
                            gcd = GCD(gcd, numbers[i]);
                        }

                        int lcm = LCMOfArray(numbers);

                        Console.ForegroundColor = ConsoleColor.Green; // Set text color to Green
                        Console.WriteLine($"Greatest Common Divisor (GCD): {gcd}");
                        Console.WriteLine($"Least Common Multiple (LCM): {lcm}");
                        Console.ResetColor(); // Reset to default color
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Set text color to Red for error
                        Console.WriteLine("Invalid input. Please enter at least two valid numbers separated by commas.");
                        Console.ResetColor(); // Reset to default color
                    }
                    break;

                case "2":
                    // Check if a number is prime
                    Console.ForegroundColor = ConsoleColor.White; // Set text color to White
                    Console.WriteLine("Please enter a number to check if it is prime (or type 'exit' to quit):");
                    Console.ResetColor(); // Reset to default color
                    string primeInput = Console.ReadLine();

                    if (primeInput.Trim().ToLower() == "exit")
                    {
                        return; // Exit the program if the user types "exit"
                    }

                    if (int.TryParse(primeInput.Trim(), out int numberToCheck))
                    {
                        if (IsPrime(numberToCheck))
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Set text color to Red for error
                            Console.WriteLine($"{numberToCheck} is a prime number.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // Set text color to Red for error
                            Console.WriteLine($"{numberToCheck} is not a prime number.");
                        }
                        Console.ResetColor(); // Reset to default color
                    }
                    break;

                case "3":
                    // Convert a fraction to Egyptian fractions
                    Console.ForegroundColor = ConsoleColor.White; // Set text color to White
                    Console.WriteLine("Please enter a fraction in the format 'numerator/denominator' (or type 'exit' to quit):");
                    Console.ResetColor(); // Reset to default color
                    string fractionInput = Console.ReadLine();

                    if (fractionInput.Trim().ToLower() == "exit")
                    {
                        return; // Exit the program if the user types "exit"
                    }

                    string[] fractionParts = fractionInput.Split('/');
                    if (fractionParts.Length == 2 &&
                        int.TryParse(fractionParts[0].Trim(), out int numerator) &&
                        int.TryParse(fractionParts[1].Trim(), out int denominator))
                    {
                        ConvertToEgyptianFraction(numerator, denominator);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Set text color to Red for error
                        Console.WriteLine("Invalid input. Please enter a valid fraction in the format 'numerator/denominator'.");
                        Console.ResetColor(); // Reset to default color
                    }
                    break;

                case "4":
                    // Display a fraction
                    Console.ForegroundColor = ConsoleColor.White; // Set text color to White
                    Console.WriteLine("Please enter a fraction in the format 'numerator/denominator' (or type 'exit' to quit):");
                    Console.ResetColor(); // Reset to default color
                    string displayFractionInput = Console.ReadLine();

                    if (displayFractionInput.Trim().ToLower() == "exit")
                    {
                        return; // Exit the program if the user types "exit"
                    }

                    string[] displayFractionParts = displayFractionInput.Split('/');
                    if (displayFractionParts.Length == 2 &&
                        int.TryParse(displayFractionParts[0].Trim(), out int displayNumerator) &&
                        int.TryParse(displayFractionParts[1].Trim(), out int displayDenominator))
                    {
                        DisplayFractionAsFraction(displayNumerator, displayDenominator);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Set text color to Red for error
                        Console.WriteLine("Invalid input. Please enter a valid fraction in the format 'numerator/denominator'.");
                        Console.ResetColor(); // Reset to default color
                    }
                    break;

                case "5":
                    // Generate a random number
                    GenerateRandomNumber();
                    break;

                case "6":
                    Console.ForegroundColor = ConsoleColor.White; // Set text color to White
                    Console.WriteLine("Program exited. Press any key to close the console.");
                    Console.ResetColor(); // Reset to default color
                    Console.ReadKey(); // Wait for user input before closing the console
                    return; // Exit the program
                case "Calc":
                    Calculate();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red; // Set text color to Red for error
                    Console.WriteLine("Invalid option. Please enter 1 for option 1, 2 for option 2, 3 for option 3, 4 for option 4, 5 for option 5, or 6 to exit.");
                    Console.ResetColor(); // Reset to default color
                    break;
            }
        }
    }

    public static void Calculate()
    {
        string input;

        Console.WriteLine("Please enter expressions (e.g., '23 + (5 * 2) - sqrt(16)') (press Enter when finished or type 'exit' to quit):");

        while (true)
        {
            input = Console.ReadLine();
            if (input.ToLower() == "exit") // اگر کاربر "exit" را تایپ کند
            {
                Console.WriteLine("Exiting the program.");
                return; // خروج از متد
            }

            if (string.IsNullOrWhiteSpace(input)) // اگر کاربر فقط اینتر را فشار دهد
            {
                break;
            }

            try
            {
                double result = EvaluateExpression(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    private static double EvaluateExpression(string expression)
    {
        // حذف فضاهای خالی
        expression = expression.Replace(" ", "");

        // بررسی وجود پرانتز
        if (expression.Contains("("))
        {
            int openIndex = expression.LastIndexOf('(');
            int closeIndex = expression.IndexOf(')', openIndex);
            if (closeIndex == -1)
            {
                throw new Exception("Mismatched parentheses.");
            }

            // محاسبه مقدار داخل پرانتز
            string subExpression = expression.Substring(openIndex + 1, closeIndex - openIndex - 1);
            double subResult = EvaluateExpression(subExpression);

            // جایگزینی پرانتز با نتیجه
            expression = expression.Remove(openIndex, closeIndex - openIndex + 1).Insert(openIndex, subResult.ToString());
            return EvaluateExpression(expression); // دوباره ارزیابی
        }

        // بررسی وجود توابع خاص
        if (expression.StartsWith("sqrt("))
        {
            string innerExpression = expression.Substring(5, expression.Length - 6);
            double innerResult = EvaluateExpression(innerExpression);
            return Math.Sqrt(innerResult);
        }

        // تجزیه و تحلیل عبارات
        return EvaluateSimpleExpression(expression);
    }

    private static double EvaluateSimpleExpression(string expression)
    {
        // عملگرها و اولویت‌ها
        char[] operators = new char[] { '+', '-', '*', '/', '%', '^' };
        List<double> numbers = new List<double>();
        List<string> operations = new List<string>();
        string currentNumber = "";

        foreach (char c in expression)
        {
            if (char.IsDigit(c) || c == '.')
            {
                currentNumber += c; // ساخت عدد
            }
            else if (operators.Contains(c))
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    numbers.Add(double.Parse(currentNumber)); // اضافه کردن عدد به لیست
                    currentNumber = ""; // بازنشانی عدد فعلی
                }
                operations.Add(c.ToString()); // اضافه کردن عملگر به لیست
            }
        }

        // اضافه کردن آخرین عدد
        if (!string.IsNullOrEmpty(currentNumber))
        {
            numbers.Add(double.Parse(currentNumber));
        }

        // انجام عملیات
        double result = numbers[0];
        for (int i = 0; i < operations.Count; i++)
        {
            switch (operations[i])
            {
                case "+":
                    result += numbers[i + 1];
                    break;
                case "-":
                    result -= numbers[i + 1];
                    break;
                case "*":
                    result *= numbers[i + 1];
                    break;
                case "/":
                    if (numbers[i + 1] != 0)
                    {
                        result /= numbers[i + 1];
                    }
                    else
                    {
                        throw new Exception("Division by zero is not allowed.");
                    }
                    break;
                case "%":
                    result %= numbers[i + 1];
                    break;
                case "^":
                    result = Math.Pow(result, numbers[i + 1]);
                    break;
            }
        }

        return result;
    }







static void ShowLoading()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue; // Set background color to Blue
        Console.ForegroundColor = ConsoleColor.White; // Set text color to White

        int width = 30; // Width of the loading bar
        Console.WriteLine("Loading, please wait...");

        // Draw the loading bar
        for (int i = 0; i <= width; i++)
        {
            Console.Write("["); // Start of the loading bar
            Console.Write(new string('=', i)); // Fill the bar
            Console.Write(new string(' ', width - i)); // Empty space
            Console.Write("]"); // End of the loading bar
            Console.Write($"\r"); // Return to the start of the line
            Thread.Sleep(100); // Adjust the speed of the loading
        }


    }
}













