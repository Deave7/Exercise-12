namespace Exercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exempel124();
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
            int[] temperature = new int[0];

            while (true)
            {
                Console.WriteLine("Var god välj ett alternativ ur menyn: ");
                Console.WriteLine("[L]ägg till temperaturmätning");
                Console.WriteLine("[S]kriv ut alla temperaturer och medeltemperatur");
                Console.WriteLine("[T]ag bort temperaturmätning");
                Console.WriteLine("[A]vsluta");

                string choice = Console.ReadLine();
                

                switch (choice.ToUpper())
                {
                    case "L":
                        Console.Write("Var god fyll i din temperaturmätning: ");
                        int newTemperature = Convert.ToInt32(Console.ReadLine());

                        int[] tempArray = new int[temperature.Length + 1]; //skapar ett nytt, temporärt fält till längden på temperature + 1 
                        Array.Copy(temperature, tempArray, temperature.Length); //Kopierar in värdena som finns i temperature till tempArray
                        tempArray[tempArray.Length - 1] = newTemperature; //sedan sätter vi den tomma platsen i tempArray till värdet användaren matade in 
                        temperature = tempArray; //här sätter vi hela temperature till det som finns i tempArray 

                        break;

                    case "S":
                        
                        if (temperature.Length == 0)
                        {
                            Console.WriteLine("Det finns inga värden än.");
                            break;
                        }
              
                        Console.WriteLine("Skriver ut temperaturer: ");

                        int elementSum = 0;
                        int iterations = 1;
                        //skriver ut temperaturvärden
                        foreach (int i in temperature) //eftersom jag inte vet hur stort fältet temperature är så tyckte jag en foreach loop passade bra 
                        {
                            Console.WriteLine($"Temperaturvärde nummer {iterations}: {i}");
                            elementSum += i;
                            iterations++;
                        }
                        //räknar ut medelvärdet 
                        int meanTemperature = elementSum / temperature.Length;

                        Console.WriteLine("Medeltemperaturen är: " + meanTemperature);

                        break;

                    case "T":

                        if (temperature.Length == 0)
                        {
                            Console.WriteLine("Det finns inga värden än.");
                            break;
                        }

                        //tar bort ett värde ur fältet genom att göra om det till en lista och sedan ta bort värdet innan man gör om det till ett fält igen 
                        Console.Write("Välj vilken temperaturmätning du vill ta bort genom att ange dess index: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        var tempList = temperature.ToList();
                        tempList.RemoveAt(index);
                        temperature = tempList.ToArray();

                        break;

                    case "A":
                        Console.WriteLine("Programmet avslutas, tack och hej!");
                        return;

                    default:
                        Console.WriteLine("Felaktig input \n");
                        break;
                }
            }
        }
    }
}