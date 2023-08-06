namespace Exercise_12
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}