using System;

public class DiscountCalculator
{
	protected int age, units;
	protected string name;
	protected Decimal Totalamt;
	protected Decimal DiscountAmt=0;
    protected Decimal DiscountTotalAmt = 0;
    public DiscountCalculator(string name,int age,int units,decimal Totalamt)
	{
		this.name = name;
		this.age = age;
		this.units = units;
		this.Totalamt = Totalamt;
	}
	public void CalculateDiscount()
	{
		if (Totalamt >= 5000)  //25% discount applied on 5000 and above
        {
			DiscountAmt = (Totalamt * 25) / 100;
			
            
        }
        else if (Totalamt >= 4000) //20% discount applied on 4000 and above
        {
            DiscountAmt = (Totalamt * 20) / 100;
            
            DiscountTotalAmt = Totalamt - DiscountAmt;
            
        }
        else if (Totalamt >= 2000) //10% discount applied on 2000 and above
        {
            DiscountAmt = (Totalamt * 10) / 100;
            DiscountTotalAmt = Totalamt - DiscountAmt;
            

        }
        else if (Totalamt >= 1000) //5% discount applied on 1000 and above
        {
            DiscountAmt = (Totalamt * 5) / 100;
            
            DiscountTotalAmt = Totalamt - DiscountAmt;
            

        }
		else
		{
			DiscountAmt = (Totalamt * 2) / 100; //2 % discount applied


            DiscountTotalAmt = Totalamt - DiscountAmt;
            
        }
    }
    public void printDiscount()
        
    {
        Console.WriteLine("The Discount amount for your purchase is: Rs." + DiscountAmt);
        DiscountTotalAmt = Totalamt - DiscountAmt;
        Console.WriteLine("After the Discount!! Your TOTAL AMOUNT will be Rs:" + DiscountTotalAmt);

    }
}
