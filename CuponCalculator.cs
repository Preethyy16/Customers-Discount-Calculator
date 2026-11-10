public class CouponCalculator : DiscountCalculator
{
    public decimal CouponDiscount { get; private set; }
    public decimal FinalBillAmount { get; private set; }
    public decimal TotalSavings { get; private set; }

    public void CalculateCoupon()
    {
        if (DiscountTotalAmount >= Constants.HighBillLimit && Units >= Constants.HighUnitLimit)
            CouponDiscount = Constants.HighCoupon;
        else if (DiscountTotalAmount >= Constants.MediumBillLimit && Units >= Constants.MediumUnitLimit)
            CouponDiscount = Constants.MediumCoupon;
        else if (DiscountTotalAmount >= Constants.LowBillLimit && Units >= Constants.LowUnitLimit)
            CouponDiscount = Constants.LowCoupon;
        else
            CouponDiscount = Constants.NoCoupon;

        Console.WriteLine(CouponDiscount > 0
            ? $"Yayyy! Coupon applied of Rs.{CouponDiscount:F2}"
            : "Sorry!! There is no coupon available for you");
    }

    public void CalculateFinalBill()
    {
        FinalBillAmount = DiscountTotalAmount - CouponDiscount;
        TotalSavings = TotalAmount - FinalBillAmount;
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine($"The Final amount = Rs.{FinalBillAmount:F2}");
        Console.WriteLine($"Congratulations...!! Your total savings: Rs.{TotalSavings:F2}");
        Console.Write("---------------------------------------------------------------------");
    }
}