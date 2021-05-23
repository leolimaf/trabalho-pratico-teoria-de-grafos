using AlgoritmoDeBellmanFord.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmoDeBellmanFord
{
    class Program
    {
        static string[] vertices = { "S", "A", "B", "C", "D", "E" };

        static List<Caminho> grafo = new List<Caminho>()
        {
            new Caminho(partindoDe: "S", indoPara: "A", custo: 10 ),
            new Caminho(partindoDe: "S", indoPara: "E", custo: 8 ),
            new Caminho(partindoDe: "A", indoPara: "C", custo: 2 ),
            new Caminho(partindoDe: "B", indoPara: "A", custo: 1 ),
            new Caminho(partindoDe: "C", indoPara: "B", custo: -2 ),
            new Caminho(partindoDe: "D", indoPara: "C", custo: -1 ),
            new Caminho(partindoDe: "D", indoPara: "A", custo: -4 ),
            new Caminho(partindoDe: "E", indoPara: "D", custo: 1 )
        };

        static Dictionary<string, int> memorizando = new Dictionary<string, int>()
        {
            {"S", 0 },
            {"A", int.MaxValue },
            {"B", int.MaxValue },
            {"C", int.MaxValue },
            {"D", int.MaxValue },
            {"E", int.MaxValue }
        };

        static bool Iterar()
        {
            bool fazerDenovo = false;

            foreach (var vertice in vertices)
            {
                Caminho[] arestas = grafo.Where(x => x.PartindoDe == vertice).ToArray();
                foreach (var aresta in arestas)
                {
                    int custoPotencial = 0;
                    if (memorizando[aresta.PartindoDe] == int.MaxValue)
                        custoPotencial = int.MaxValue;
                    else
                        custoPotencial = memorizando[aresta.PartindoDe] + aresta.Custo;

                    if (custoPotencial < memorizando[aresta.IndoPara])
                    {
                        memorizando[aresta.IndoPara] = custoPotencial;
                        fazerDenovo = true;
                    }
                }
            }

            return fazerDenovo;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                if (!Iterar())
                    break;
            }

            Console.WriteLine("Caminho mais curto partindo do vértice S:");

            foreach (var chaveValor in memorizando)
            {
                Console.WriteLine($"{chaveValor.Key} => {chaveValor.Value}");
            }
        }
    }
}
