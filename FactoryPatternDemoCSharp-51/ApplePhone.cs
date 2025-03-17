namespace FactoryPatternDemoCSharp_51;

public class ApplePhone : IMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Calling with an IPhone.."); 
        
    }

    public void Text()
    {
        Console.WriteLine("Texting with an IPhone.."); 
        
    }
}