using System;
using AlgoritmoDeBuscaEmProfundidade.Auxiliar;
using AlgoritmoDeBuscaEmProfundidade.Entidades;

namespace AlgoritmoDeBuscaEmProfundidade
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buscarNovamente;
            var algoritmo = new BuscaEmProfundidade();
            Empregado raiz = algoritmo.ConstruirGrafo();
            do 
            {
                Console.WriteLine("Lista dos colaboradores presentes no grafo: ");
                algoritmo.LiscarColaboradores(raiz);
                Console.WriteLine();

                Console.Write("Informe o nome do colaborador que deseja buscar no grafo: ");
                string nomeDoColaborador = Console.ReadLine();
                algoritmo.BuscarEmProfundidade(raiz, nomeDoColaborador); // TODO Implemetar busca em profundidade

                Console.Write("Deseja realizar outra busca? (S/N) ");
                buscarNovamente = Console.ReadLine().ToUpper().Trim() == "S" ? true : false;
                Console.Clear();
            } while (buscarNovamente);
        }
    }
}
