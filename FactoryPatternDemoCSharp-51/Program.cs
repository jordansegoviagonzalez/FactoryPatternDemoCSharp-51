
using FactoryPatternDemoCSharp_51;

Console.WriteLine("What kind of phone do you have ('IPhone/Apple','Android', Google)"); 
var phoneType = Console.ReadLine();

var phone = PhoneFactory.BuildPhone(phoneType);

phone.Call();
phone.Text();
