using System; 

 

namespace Bela 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            string line = Console.ReadLine(); 

            // reads in line for user, expecting input 

            int space = line.IndexOf(" "); 

            // identifies space in user input between # of hands and dominant suit 

            int hands = int.Parse(line.Substring(0, space)); 

            // identifies # of hands inputted by user, converts the string into a numerical unit 

            char suit = line[space + 1]; 

            // identifies dominant suit as being after the user input for a space. 

            int points = 0; 

            // variable for points to add card values all together 

            for (int x = 0; x < hands*4; x++) 

            { 

                string cards = Console.ReadLine(); 

                switch (cards[0]) 

                { 

                    case 'A': 

                        points += 11; 

                        break; 

                    case 'K': 

                        points += 4; 

                        break; 

                    case 'Q': 

                        points += 3; 

                        break; 

                    case 'J': 

                        if (cards[1] == suit) 

                            points += 20; 

                        else 

                        points += 2; 

                        break; 

                    case 'T': 

                        points += 10; 

                        break; 

                    case '9': 

                        if ((cards[1]) == suit) 

                            points += 14; 

                        else 

                        points += 0; 

                        break; 

                    case '8': 

                        points += 0; 

                        break; 

                    case '7': 

                        points += 0; 

                        break; 

 

                } 

 

 

            } 

            Console.WriteLine(points); 

 

        } 

    } 

} 
