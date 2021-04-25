using System.Collections.Generic;

namespace AlgoritmoDeBuscaEmProfundidade.Entidades
{
    public class Empregado
    {
        private List<Empregado> _listaDeSubordinados = new List<Empregado>();
        public string Nome { get; set; }
        public List<Empregado> Subordinados { 
            get 
            {
                return _listaDeSubordinados;
            }
        }
        public Empregado(string nome)
        {
            Nome = nome;
        }
    }
}
