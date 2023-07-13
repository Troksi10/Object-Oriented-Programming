
using OOP;

Car audi = new Car("Audi A4",250,"red");
audi.Drive();
audi.Details();
Car bmw = new Car("BMW M5",300);
bmw.Drive();
bmw.Details();

Console.WriteLine("Press 1 to stop the car");
string userInput = Console.ReadLine();

if(userInput == "1")
{
    audi.Stop();

}else if(userInput == "2")
{
    bmw.Stop();
}else
{
    Console.WriteLine("Cars drives indefinetely");
}

Console.ReadLine();
