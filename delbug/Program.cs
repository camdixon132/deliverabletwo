public static class Constants
{
    public const double coffeeprice = 2;
    public const double waterprice = 1;
    public const double personprice = 9.99;
}

class program
{

    static void Main()
    {
        Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge");

        Console.WriteLine("extra for coffee. How many people are in your group? Please, parties");

        Console.WriteLine("of 6 or lower.");

        decimal people = decimal.Parse(Console.ReadLine());

        if (people <= 6)
        {
            Console.WriteLine("A table for " + people + "! Please follow me to be seated.");

            Console.WriteLine("Let's get everyone started with some drinks.");

            Console.WriteLine("We've got water or coffee.");

            int n = 1;

            int watercount = 0;

            int coffeecount = 0;

            while (n <= people)
            {
                Console.WriteLine("Alright, customer " + n + ", water or coffee?");
                n++;

                string choice = Console.ReadLine();

                if (choice == "coffee")
                {
                    Console.WriteLine("Coffee, great choice.");

                    coffeecount++;
                }
                else if (choice == "water")
                {
                    Console.WriteLine("Water, okay.");

                    watercount++;
                }
                else
                {
                    Console.WriteLine("Sorry, we only offer water and coffee.");
                }
            }

            Console.WriteLine("Okay, so that's " + coffeecount + " coffees and " + watercount + " waters.");

            Console.WriteLine("I'll have those right out for you.");

            Console.WriteLine("Feel free to grab your food!");

            decimal coffeecost = 2m;

            decimal coffeetotal = Decimal.Multiply(coffeecost, coffeecount);

            decimal buffetprice = 9.99m;

            decimal buffettotal = Decimal.Multiply(people, buffetprice);

            decimal totalprice = watercount + buffettotal + coffeetotal;

            Console.WriteLine("Here's your bill. Total price: $" + totalprice + ".");
        }
        else
        {
            Console.WriteLine("Sorry, we can only seat parties up to 6.");
        }

    }
}
