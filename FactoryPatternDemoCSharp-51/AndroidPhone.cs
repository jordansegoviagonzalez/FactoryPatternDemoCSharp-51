namespace FactoryPatternDemoCSharp_51;

public class AndroidPhone : IMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Calling with an AndroidPhone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with an AndroidPhone..");
    }
}