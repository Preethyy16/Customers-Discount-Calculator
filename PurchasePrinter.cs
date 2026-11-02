using System;

public class PurchasePrinter
{
    public void PrintSummary(string name, int age, int units, decimal totalAmount)
    {
        Console.WriteLine("---------------Final purchase statment -------------");
        Console.WriteLine("***customer Details: *** ");
        Console.WriteLine("Customer name: " + name + " Age: " + age);
        Console.WriteLine("***Order Details: ***");
        Console.WriteLine("Ordered units are " + units + " the total amount " + totalAmount);
        Console.WriteLine("***Discount details***");
    }
}
