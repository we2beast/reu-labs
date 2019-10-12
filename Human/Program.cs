using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfHumans listOfHumans = new ListOfHumans(5);
    
            listOfHumans[0] = new Man();
            listOfHumans[0].Age = 20;
            listOfHumans[0].Name = "Alesha";
            Console.WriteLine(listOfHumans[0]);

            listOfHumans[1] = new Worker();
            listOfHumans[1].Age = 21;
            listOfHumans[1].Name = "Bob";
            Console.WriteLine(listOfHumans[1]);

            listOfHumans[2] = new Teenager();
            listOfHumans[2].Age = 15;
            listOfHumans[2].Name = "Jastin";
            Console.WriteLine(listOfHumans[2]);

            listOfHumans[3] = new Man("Tony", 20);

            Console.WriteLine(listOfHumans.ToString());
        }
    }
}
