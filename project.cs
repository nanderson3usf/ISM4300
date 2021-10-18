using System;
                    
public class Program
{
    public static void Main()
    {
        //Build users object and populate with users
        string[,] users = new string[9, 3] {{"Bob Bowes","bb@email.com","33701"},
                                      {"Robin Rogers","rr@email.com","64211"}, 
                                      {"Andrew Aeills","aa@email.com","97455"},                                              
                                      {"Yadi Yannis","yy@email.com","78231"},                                              
                                      {"Mary Mollis","mm@email.com","10211"},                                              
                                      {"Phil Phillis","pp@email.com","61322"},                                              
                                      {"Eddy Edwards","ee@email.com","97455"},                                              
                                      {"Steve Sur","ss@email.com","33701"},                                                                                            
                                      {"Teddy Toes","tt@email.com","10211"} };
        
        //Query for zip
        Console.WriteLine("What zip code do you want to find friends in?");
        string zip = Console.ReadLine();

 

        //Output matches
        Console.WriteLine("The following friends are in your desired zip code:");        
        for (int i = 0; i < users.GetLength(0); i++)
        {
                    if (users[i, 2] == zip)
                    {
                        Console.WriteLine(users[i, 0] + ", " + users[i, 1] + ", " + users[i, 2]);
                    }
        }
    }
}
