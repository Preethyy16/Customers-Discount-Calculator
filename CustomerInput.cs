using System;
using System.Diagnostics.Metrics;
public class CustomerInput
{
    //The constant values has been declared
    private const int MinAge = 1;
    private const int MaxAge = 120;
    private const int MinUnit = 1;
    private const int MinTotalAmount = 0;

    //Properties(getter and setter)
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int Units { get; private set; }
    public decimal TotalAmount { get; private set; }

    public void ReadDetails()
    {
        Console.WriteLine("---Enter the details below----------");

        Console.Write("Enter a Customer name: ");
        Name = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Name))
        {
            Console.WriteLine("Name cannot be empty. Please try again.");
            Console.Write("Enter a Customer name: ");
            Name = Console.ReadLine();
        }

        while (true)
        {
            try
            {
                Console.Write("Enter age: ");
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age >= MinAge && Age <= MaxAge)
                    break;
                Console.WriteLine("Sorry, you have entered an invalid age. Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Value cannot be empty and must be a valid number. Please try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large. Please try again.");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Enter purchased units: ");
                Units = Convert.ToInt32(Console.ReadLine());
                if (Units >= MinUnit)
                    break;
                Console.WriteLine("Sorry, you have entered an invalid units. Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Value cannot be empty and must be a valid number. Please try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large. Please try again.");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Enter Total amount of the purchase: ");
                TotalAmount = Convert.ToDecimal(Console.ReadLine());
                if (TotalAmount > MinTotalAmount)
                    break;
                Console.WriteLine("Amount must be greater than 0. Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Value cannot be empty and must be a valid amount. Please try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large. Please try again.");
            }
        }
    }
}