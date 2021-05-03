using System;

namespace AlgoritmoDeFloydWarshall
{
    class Program
    {
        public static readonly int INF = int.MaxValue;
        static void Main(string[] args)
        {
            int[,] grafo =
            {
                { 0,    3,    4,    INF },
                { INF,  0,    INF,  5 },
                { INF,  INF,  0,    3 },
                { 8,    INF,  INF,  0}
            };

            FloydWarshall(grafo);
        }

        private static void FloydWarshall(int[,] grafo)
        {
            throw new NotImplementedException();
        }
    }
}
