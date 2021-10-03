using System; 

using System.Collections.Generic; 

using System.Linq; 

 

namespace Recount 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            var ballots = new Dictionary<string, int>(); 

 

 

 

            for (int x = 0; x <100000; x++) 

            { 

                string candidatename = Console.ReadLine(); 

 

 

                if (candidatename == "***") 

                { 

                    break; 

                } 

                else 

                { 

                    if (ballots.ContainsKey(candidatename)) 

                    { 

                        ballots[candidatename] += 1; 

                    } 

 

                    else 

                    { 

                        ballots.Add(candidatename, 1); 

                    } 

                } 

 

            } 

 

            var winnervote = ballots.OrderByDescending(x => x.Value).First().Value; 

            var runnerupvote = ballots.OrderByDescending(x => x.Value).ElementAt(1).Value; 

 

            var winnername = ballots.OrderByDescending(x => x.Value).First().Key; 

 

            if (winnervote == runnerupvote) 

            { 

                Console.WriteLine("Runoff!"); 

            } 

            else 

            { 

                Console.WriteLine(winnername); 

            } 

        } 

    } 

} 

 
