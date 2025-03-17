namespace FactoryPatternDemoCSharp_51;
//'namespace' is used to organize code and prevent name conflicts.
//'FactoryPatternDemoCSharp-51' is the name of the namespace that groups realted classes.


public class GooglePhone: IMobilePhone
//public allows this class to be accessed from other parts of the program.
//'class' defines a blueprint for creating objects.
//'GooglePhone' is the name of the class representing a Google phone.
//':IMobilePhone' means this class implments the 'IMobilePhone' interface.
{
    public void Call()
    //'public' allows this method to be accessed from outside the class.
    //'void' means this method does not return any value.
    //'Call' is the method name, which presents making a phone call.
    {
        Console.WriteLine("Call with a Google Phone..");
        //'Console.WriteLine' prints the given text to the console.
        // The message informs the user that a call is being made with a Goolge Phone.
    }

    public void Text()
    //'public' allows this method to be accessed from outside of the class.
    //'void' means this method dose not return any value.
    //'Text' is the method name, which represents sending a text message.
    {
        Console.WriteLine("Texting with a Google Phone..");
        // Console.WriteLine' prints the given text to the console.
        // The message informs the user that a text is being sent with a Google Phone.
    }
}