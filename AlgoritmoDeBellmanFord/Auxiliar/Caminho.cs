namespace AlgoritmoDeBellmanFord.Auxiliar
{
    class Caminho
    {
        public string PartindoDe { get; set; }
        public string IndoPara { get; set; }
        public int Custo { get; set; }

        public Caminho(string partindoDe, string indoPara, int custo)
        {
            PartindoDe = partindoDe;
            IndoPara = indoPara;
            Custo = custo;
        }
    }
}
