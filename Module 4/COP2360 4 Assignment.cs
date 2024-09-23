using System;

class Assignment
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();

        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            int result = Divide(number1, number2);
            Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: Invalid input. '{ex.Input}' is not a valid integer.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero. Please input a non zero number.");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: Number inputted is to big.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occured.");  
        }

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

        static int Divide(int a, int b)
    {
        return a/b;
    }
}
   
       


         