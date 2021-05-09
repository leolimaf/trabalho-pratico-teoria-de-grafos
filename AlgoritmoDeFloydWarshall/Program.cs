using System;

namespace AlgoritmoDeFloydWarshall
{
    class Program
    {
        public static readonly int INF = 999999;
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
            int qntVertices = (int)Math.Sqrt(grafo.Length);
            int[,] distancia = new int[qntVertices, qntVertices];

            for (int i = 0; i < qntVertices; i++)
            {
                for (int j = 0; j < qntVertices; j++)
                {
                    distancia[i, j] = grafo[i, j];
                }
            }

            for (int k = 0; k < qntVertices; k++)
            {
                for (int i = 0; i < qntVertices; i++)
                {
                    for (int j = 0; j < qntVertices; j++)
                    {
                        if (distancia[i, k] + distancia[k, j] < distancia[i, j])
                        {
                            distancia[i, j] = distancia[i, k] + distancia[k, j];
                        }
                    }
                }
            }

            Console.WriteLine("Menor distância entre todos pares de vértices: ");

            for (int i = 0; i < qntVertices; i++)
            {
                for (int j = 0; j < qntVertices; j++)
                {
                    if (distancia[i, j] == INF)
                    {
                        Console.Write("INF".PadLeft(7));
                    }
                    else
                    {
                        Console.Write(distancia[i, j].ToString().PadLeft(7));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
