namespace Exercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exempel123();
        }

        static void Exempel121() //Övning 12.1-12.2
        {
            string[] allNames = new string[5]; //Initierar fältet allNames och sätter dess storlek till 5

            for (int i = 0; i < allNames.Length; i++) //Loopar tills vi fyllt all plats i fältet
            {
                Console.WriteLine("Please input name number " + i + ": ");
                allNames[i] = Console.ReadLine(); //Sätter allNames[i] till användar input. För loopens första varv är i=0, sedan 1,2,3 etc

            }

            for (int i = 0; i < allNames.Length; i++) //Kör loopen lika många gånger som det finns antal element i allNames fältet
            {
                Console.WriteLine("Names " + i + ": " + allNames[i]); //skriver ut variablen i och även värdet på index plats i från fältet allNames
            }

            while (true)
            {
                Console.WriteLine("Do you want to [R]eplace a name in the array or [Q]uit?");
                string choice = Console.ReadLine(); //Sätter variablen choice som används till switch satsen under 

                switch (choice)
                {
                    case "R": //Om användaren skriver "R"
                        Console.WriteLine("Please input the index number of the name you want to replace: ");
                        int replace = Convert.ToInt32(Console.ReadLine()); // Initierar variablen replace som används för att välja vilket värde från allNames vi vill ta bort 

                        Console.WriteLine("Please input the new name: ");
                        allNames[replace] = Console.ReadLine(); //Ändrar värde på den indexplatsen användaren angivit 

                        for (int i = 0; i < allNames.Length; i++) //Kör loopen lika många gånger som det finns antal element i allNames fältet
                        {
                            Console.WriteLine("Names " + i + ": " + allNames[i]); //skriver ut variablen i och även värdet på index plats i från fältet allNames
                        }
                        break;

                    case "Q": //Om användaren skriver "Q"
                        Console.WriteLine("The program is shutting down, see you next time! :) ");
                        return;

                    default: //Om användaren inte skriver "Q" eller "R"
                        Console.WriteLine("Incorrect input, try again");
                        break;
                }
            }
        }

        static void Exempel123() //Övning 12.3
        {
            int[] temperature; //initierar fältet temperature

            Console.WriteLine("Please input how many measurements you took: ");
            int measurementNumber = Convert.ToInt32(Console.ReadLine()); //initierar variablen measurementNumber vilken styr hur stort vårt fält är

            temperature = new int[measurementNumber]; //Sätter längden på temperature till det användaren precis matade in 

            //Mer van vid for loop därför använde jag den här utan att tänka på det längre ned använder jag en foreach loop och inser att i detta fallet blir det samma sak fast med färre tecken
            for (int i = 0; i < temperature.Length; i++) //Kör loopen lika många varv som fältet temperature är långt 
            {
                Console.WriteLine("Please input measruement number " + i + ": "); 
                temperature[i] = Convert.ToInt32(Console.ReadLine()); //sätter värdet på temperature[i] i = varv på loopen, 0,1,2,3 etc
            }

            for (int i = 0; i < temperature.Length; i++) //Kör loopen lika många varv som fältet temperature är långt 
            {
                Console.WriteLine("Measurement number " + i + ": " + temperature[i]); //Skriver ut alla värden användaren matat in 
            }

            //För att räkna ut mellanvärdet
            int temperatureElementSum = 0; //sätter variablen på temperatureElementSum 

            foreach (int i in temperature) //Loopen körs ett varv för varje värde (i) innuti temperature 
            {
                temperatureElementSum += i; //lägger till värdet på variablen i till temperatureElementSum
            }

            double temperatureMean = temperatureElementSum / temperature.Length; //Initierar variablen temperatureMean och räknar ut medelvärdet 

            Console.WriteLine("The mean value of your measurements is: " + temperatureMean); //Skriver ut temperatureMean

        }

        static void Exempel124() //Övning 12.4
        {
            while (true)
            {
                Console.WriteLine("Var god välj ett alternativ ur menyn: ");
                Console.WriteLine("[L]ägg till temperaturmätning");
                Console.WriteLine("[S]kriv ut alla temperaturer och medeltemperatur");
                Console.WriteLine("[T]ag bort temperaturmätning");
                Console.WriteLine("[A]vsluta");

                string choice = Console.ReadLine();
                int[] temperature;

                switch (choice.ToUpper())
                {
                    case "L":
                        Console.WriteLine("Var god fyll i din temperaturmätning: ");
                        var list = new List<int>();
                        list.Add(Convert.ToInt32(Console.ReadLine()));
                        temperature = list.ToArray();
                        break;

                    default:
                        Console.WriteLine("Felaktig input \n");
                        break;
                }
            }
        }
    }
}