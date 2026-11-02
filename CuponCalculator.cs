
public class CouponCalculator : DiscountCalculator
{ 
    private const decimal HighBillLimit = 600;
    private const int HighUnitLimit = 6;
    private const decimal HighCoupon = 300;

    private const decimal MediumBillLimit = 400;
    private const int MediumUnitLimit = 4;
    private const decimal MediumCoupon = 200;

    private const decimal LowBillLimit = 200;
    private const int LowUnitLimit = 2;
    private const decimal LowCoupon = 100;

    private const decimal NoCoupon = 0;

    public decimal CouponDiscount { get; private set; }
    public decimal FinalBillAmount { get; private set; }
    public decimal TotalSavings { get; private set; }

    public void CalculateCoupon()
    {
        if (DiscountTotalAmount >= HighBillLimit && Units >= HighUnitLimit)
        {
            CouponDiscount = HighCoupon;
        }
        else if (DiscountTotalAmount >= MediumBillLimit && Units >= MediumUnitLimit)
        {
            CouponDiscount = MediumCoupon;
        }
        else if (DiscountTotalAmount >= LowBillLimit && Units >= LowUnitLimit)
        {
            CouponDiscount = LowCoupon;
        }
        else
        {
            CouponDiscount = NoCoupon;
        }

        if (CouponDiscount > 0)
        {
            Console.WriteLine($"Yayyy! Coupon applied of Rs.{CouponDiscount:F2}");
        }
        else
        {
            Console.WriteLine("Sorry!! There is no coupon available for you");
        }
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
