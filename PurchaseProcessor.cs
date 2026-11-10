using System;
public class PurchaseProcessor
{
    public void Run()
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            ProcessPurchase();
            continueRunning = AskToContinue();
        }

        Console.WriteLine("Thank you! Exiting the program.");
    }
    private void ProcessPurchase()
    {
        CustomerInput input = new CustomerInput();
        input.ReadDetails();

        PurchasePrinter printer = new PurchasePrinter();
        printer.PrintSummary(input.Name, input.Age, input.Units, input.TotalAmount);

        CouponCalculator couponAmtCalculator = new CouponCalculator();
        couponAmtCalculator.Name = input.Name;
        couponAmtCalculator.Age = input.Age;
        couponAmtCalculator.Units = input.Units;
        couponAmtCalculator.TotalAmount = input.TotalAmount;
        couponAmtCalculator.CalculateDiscount();
        couponAmtCalculator.PrintDiscount();
        couponAmtCalculator.CalculateCoupon();
        couponAmtCalculator.CalculateFinalBill();
    }

    private bool AskToContinue()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to process another purchase?");
            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Stop");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine()?.Trim())
            {
                case "1":
                    Console.WriteLine();
                    return true;
                case "2":
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }
    }
}