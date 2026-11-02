using System;

public class PurchaseProcessor
{
    public void Run()
    {
        CustomerInput input = new CustomerInput();
        input.ReadDetails();

        PurchasePrinter printer = new PurchasePrinter();
        printer.PrintSummary(input.Name, input.Age, input.Units, input.TotalAmount);

        DiscountCalculator discountAmtCalculator = new DiscountCalculator();
        discountAmtCalculator.CalculateDiscount();
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
}