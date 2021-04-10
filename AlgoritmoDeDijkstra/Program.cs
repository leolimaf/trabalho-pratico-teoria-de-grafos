using System;

namespace AlgoritmoDeDijkstra
{
    enum Vertices
    {
        A, B, C, D, E
    }

    class Program
    {
        private static int DistanciaMinima(int[] distancia, bool[] caminhoMaisCurto, int qntVertices)
        {
            int min = int.MaxValue;
            int minIndice = 0;

            for (int v = 0; v < qntVertices; v++)
            {
                if (caminhoMaisCurto[v] == false && distancia[v] <= min)
                {
                    min = distancia[v];
                    minIndice = v;
                }
            }

            return minIndice;
        }

        public static void DijkstraAlgoritmo(int[,] grafo, Vertices origem)
        {
            int qntVertices = (int)Math.Sqrt(grafo.Length);

            int[] distancia = new int[qntVertices];
            bool[] caminhoMaisCurto = new bool[qntVertices];

            for (int i = 0; i < qntVertices; i++)
            {
                distancia[i] = int.MaxValue;
                caminhoMaisCurto[i] = false;
            }

            distancia[(int)origem] = 0;

            for (int i = 0; i < qntVertices - 1; i++)
            {
                int u = DistanciaMinima(distancia, caminhoMaisCurto, qntVertices);
                caminhoMaisCurto[u] = true;

                for (int v = 0; v < qntVertices; ++v)
                    if (!caminhoMaisCurto[v] && Convert.ToBoolean(grafo[u, v]) && distancia[u] != int.MaxValue && distancia[u] + grafo[u, v] < distancia[v])
                        distancia[v] = distancia[u] + grafo[u, v];
            }
            Console.WriteLine("Caminho mais curto partindo do vértice {0}:", origem);
            for (int i = 0; i < qntVertices; i++)
                Console.WriteLine("{0} => {1}", (Vertices)i, distancia[i]);
        }

        static void Main(string[] args)
        {
            int[,] grafo =
            {
                {0, 6, 0, 1, 0},
                {6, 0, 5, 2, 2},
                {0, 5, 0, 0, 5},
                {1, 2, 0, 0, 1},
                {0, 2, 5, 1, 0},
            };

            DijkstraAlgoritmo(grafo, Vertices.A);
        }
    }
}
