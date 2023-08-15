namespace References_Dallas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call sedan set it to object called myfirst sedan with a vaule of 0.
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            //assigns myothersedan equal to ne sedan then gives it a increasing speed vaule.
            Sedan myOtherSedan = new Sedan(0);
            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            //assigns myothersedan to an object and gives it an incresing speed vaule.
            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            //assigns Truck to an object with a weight and plate.
            Truck myTruck = new Truck(50, 500, "DIStruck");

            //Calls Stringify method and descibes automobiles.
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}