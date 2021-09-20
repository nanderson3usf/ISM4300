using System; 

using System.Collections.Generic; 

using System.Linq; 

 

namespace Election_v2 

{ 

 

 

    public class Program 

 

    { 

 

        public static void Main() 

 

        { 

 

            //Input Candidates  

 

            var candidates = new Dictionary<string, string>(); 

 

            string str_ccount = Console.ReadLine(); 

 

            int int_ccount = int.Parse(str_ccount); 

 

            for (int i = 0; i < int_ccount; i++) 

 

            { 

 

                string n = Console.ReadLine(); 

 

                string p = Console.ReadLine(); 

 

                candidates.Add(n, p); 

 

            } 

 

            //Input Ballots  

 

            var ballots = new Dictionary<string, int>(); 

 

            string str_bcount = Console.ReadLine(); 

 

            int int_bcount = int.Parse(str_bcount); 

 

            for (int i = 0; i < int_bcount; i++) 

 

            { 

 

                string b = Console.ReadLine(); 

 

 

                if (ballots.ContainsKey(b)) 

 

                { 

 

                    ballots[b] += 1; 

 

                } 

 

                else 

 

                { 

 

                    ballots.Add(b, 1); 

 

                } 

 

            } 

 

 

 

            var winnervote = ballots.OrderByDescending(x => x.Value).First().Value; 

            var runnerupvote = ballots.OrderByDescending(x => x.Value).ElementAt(1).Value; 

 

            var winnername = ballots.OrderByDescending(x => x.Value).First().Key; 

 

            if (winnervote == runnerupvote) 

            { 

                Console.WriteLine("Tie"); 

            } 

            else if (candidates.ContainsKey(winnername)) 

            { 

                Console.WriteLine(candidates[winnername]); 

            } 

 

 

 

            //var winner = ballots.Keys where ballots.Values.Max();  

 

            //var winner = ballots.OrderByDescending(x => x.Value).First().Key;  

 

            //Console.WriteLine("And the winner is ", winner);  

 

 

 

            /*Proof Dict keys are adding  

 

            foreach (var ballot in ballots)  

 

            {  

 

            Console.WriteLine (ballot.Value.ToString());  

 

            }  

 

            */ 

 

        } 

 

    } 

 

} 

 

 
