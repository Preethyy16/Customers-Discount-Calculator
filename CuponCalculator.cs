//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;

public class CuponCalculator : DiscountCalculator
{
	protected Decimal cupondiscount;
    protected Decimal billamt;
    protected Decimal totaldiscountamt;


    public CuponCalculator(string name, int age, int units, decimal Totalamt) : base(name, age, units, Totalamt)
	{
	}
	public void calculatecupon()
	{
		if(DiscountTotalAmt>=600 && units >= 6) 
		{
           cupondiscount= 300;
            Console.WriteLine("yayyy cupon applied of rs." + cupondiscount);
        } else if (DiscountTotalAmt >= 400 && units >= 4)
        {
            cupondiscount = 200;
            Console.WriteLine("yayyy cupon applied of rs." + cupondiscount);
            
        }else if (DiscountTotalAmt >= 200 && units >= 2)
        {
            cupondiscount =100;
            Console.WriteLine("yayyy cupon applied of rs." + cupondiscount);
        }
        else
        {
            cupondiscount = 0;
            Console.WriteLine(" sorry!! There is no cupon avilable for you");

        }



    }
    public void finalbillamount()
    {
        billamt = DiscountTotalAmt - cupondiscount;
        Console.WriteLine("The Final amount = " + billamt);
        totaldiscountamt = Totalamt - billamt;

        Console.WriteLine("Congraducations...!! Your total Savings : " + totaldiscountamt);

    }
}
