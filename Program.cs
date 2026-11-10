try
{
    PurchaseProcessor PurchaseProcessCalculation = new PurchaseProcessor();
    PurchaseProcessCalculation.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong: " + ex.Message);
}