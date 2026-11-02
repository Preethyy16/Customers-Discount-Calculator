

using System;

public class DiscountCalculator
{
    private const decimal HighLimit = 5000;
    private const decimal MediumHighLimit = 4000;
    private const decimal MediumLimit = 2000;
    private const decimal LowLimit = 1000;

    private const decimal HighDiscount = 25;
    private const decimal MediumHighDiscount = 20;
    private const decimal MediumDiscount = 10;
    private const decimal LowDiscount = 5;
    private const decimal DefaultDiscount = 2;

    private decimal totalAmount;

    public string Name { get; set; }
    public int Age { get; set; }
    public int Units { get; set; }

 
    public decimal TotalAmount { get; set; }
    public decimal DiscountAmount { get; private set; }
    public decimal DiscountTotalAmount { get; private set; }

    public void CalculateDiscount()
    {
        decimal discountPercent = GetDiscountPercent();

        DiscountAmount = (TotalAmount * discountPercent) / 100;
        DiscountTotalAmount = TotalAmount - DiscountAmount;
    }

    private decimal GetDiscountPercent()
    {
        if (TotalAmount >= HighLimit)
            return HighDiscount;
        else if (TotalAmount >= MediumHighLimit)
            return MediumHighDiscount;
        else if (TotalAmount >= MediumLimit)
            return MediumDiscount;
        else if (TotalAmount >= LowLimit)
            return LowDiscount;
        else
            return DefaultDiscount;
    }

    public void PrintDiscount()
    {
        Console.WriteLine($"The Discount amount for your purchase is: Rs.{DiscountAmount:F2}");
        Console.WriteLine($"After the Discount!! Your TOTAL AMOUNT will be Rs.{DiscountTotalAmount:F2}");
    }
}