using System;

public class DiscountCalculator
{
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
        if (TotalAmount >= Constants.HighLimit)
            return Constants.HighDiscount;
        else if (TotalAmount >= Constants.MediumHighLimit)
            return Constants.MediumHighDiscount;
        else if (TotalAmount >= Constants.MediumLimit)
            return Constants.MediumDiscount;
        else if (TotalAmount >= Constants.LowLimit)
            return Constants.LowDiscount;
        else
            return Constants.DefaultDiscount;
    }
    public void PrintDiscount()
    {
        Console.WriteLine($"The Discount amount for your purchase is: Rs.{DiscountAmount:F2}");
        Console.WriteLine($"After the Discount!! Your TOTAL AMOUNT will be Rs.{DiscountTotalAmount:F2}");
    }
}