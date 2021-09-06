using System;
                    
public class Program
{
    public static void Main()
    {
        string inp = Console.ReadLine();
        int count = int.Parse(inp);
        int iter = 1;
        
        while (iter <= count)
        {
            Console.WriteLine(iter + " Abracadabra");
            iter++;
        }
    }
}
