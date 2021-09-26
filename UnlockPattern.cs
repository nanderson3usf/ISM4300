using System;

namespace Unlock_Pattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,4),
                Tuple.Create(1,5), Tuple.Create(1,6), Tuple.Create(1,8),
                Tuple.Create(2,3), Tuple.Create(2,4), Tuple.Create(2,5),
                Tuple.Create(2,6), Tuple.Create(2,7), Tuple.Create(2,9),
                Tuple.Create(3,5), Tuple.Create(3,6), Tuple.Create(3,4),
                Tuple.Create(3,8), Tuple.Create(4,5), Tuple.Create(4,9),
                Tuple.Create(4,7), Tuple.Create(4,8), Tuple.Create(5,6),
                Tuple.Create(5,7), Tuple.Create(5,8), Tuple.Create(5,9),
                Tuple.Create(6,7), Tuple.Create(6,8), Tuple.Create(6,9),
                Tuple.Create(7,8), Tuple.Create(8,9)};
        }
    }
}
