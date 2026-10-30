Console.WriteLine("---Enter the details below----------");
try
{
    Console.Write("Enter a Customer name: ");
    string name = Console.ReadLine();
    Console.Write("Enter age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(age);
    while (age < 0)
    {
        Console.WriteLine("Sorry, you have entered an invalid age. Please try again.");
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Enter purchased units: ");
    int units = Convert.ToInt32(Console.ReadLine());
    while (units <= 0)
    {
        Console.WriteLine("Sorry, you have entered an invalid units. Please try again.");
        Console.Write("Enter purchased units: ");
        units = Convert.ToInt32(Console.ReadLine());
    }
    //Console.WriteLine(units);
    Console.Write("Enter Total amount of the purchase: ");
    Decimal Totalamt = Convert.ToDecimal(Console.ReadLine());
    //Console.WriteLine(Totalamt);
   
  
    Console.WriteLine("---------------Final purchase statment -------------");
    Console.WriteLine("***customer Details: *** ");
    Console.WriteLine("Customer name:"+name+" Age : " +age);
    Console.WriteLine("***Order Details: ***");
    Console.WriteLine("Ordered units are" + units + "the total amount"+ Totalamt);
    Console.WriteLine("***Discount details***");
    DiscountCalculator DC = new DiscountCalculator(name, age, units, Totalamt);
    
    DC.CalculateDiscount();
    CuponCalculator CC = new CuponCalculator(name, age, units, Totalamt);
    CC.CalculateDiscount();
    CC.printDiscount();
    CC.calculatecupon();
    CC.finalbillamount();

}
catch(Exception e)
{
    Console.Write(e.ToString());
}







