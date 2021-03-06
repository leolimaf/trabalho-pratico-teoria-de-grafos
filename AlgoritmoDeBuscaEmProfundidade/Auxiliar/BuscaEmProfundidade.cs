using AlgoritmoDeBuscaEmProfundidade.Entidades;
using System;

namespace AlgoritmoDeBuscaEmProfundidade.Auxiliar
{
    public class BuscaEmProfundidade
    {
        public Empregado ConstruirGrafo()
        {
            Empregado raiz = new Empregado("Leonardo");
            Empregado subordinado1 = new Empregado("Alex");
            Empregado subordinado2 = new Empregado("Maria");
            raiz.Subordinados.Add(subordinado1);
            raiz.Subordinados.Add(subordinado2);

            Empregado subordinado3 = new Empregado("Ellen");
            Empregado subordinado4 = new Empregado("Yuri");
            subordinado1.Subordinados.Add(subordinado3);
            subordinado1.Subordinados.Add(subordinado4);

            Empregado subordinado5 = new Empregado("Gabi");
            Empregado subordinado6 = new Empregado("Marcelo");
            Empregado subordinado7 = new Empregado("Jean");
            subordinado2.Subordinados.Add(subordinado5);
            subordinado2.Subordinados.Add(subordinado6);
            subordinado2.Subordinados.Add(subordinado7);

            return raiz;
        }

        public Empregado BuscarEmProfundidade(Empregado raiz, string nomeDoColaborador)
        {
            if (nomeDoColaborador == raiz.Nome.ToUpper().Trim())
                return raiz;

            Empregado empregadoEncontrado = null;
            for (int i = 0; i < raiz.Subordinados.Count; i++)
            {
                empregadoEncontrado = BuscarEmProfundidade(raiz.Subordinados[i], nomeDoColaborador);
                if (empregadoEncontrado != null)
                {
                    break;
                }
            }
            return empregadoEncontrado;
        }

        public void LiscarColaboradores(Empregado emp)
        {
            Console.WriteLine(emp.Nome);
            for (int i = 0; i < emp.Subordinados.Count; i++)
            {
                LiscarColaboradores(emp.Subordinados[i]);
            }
        }
    }
}
