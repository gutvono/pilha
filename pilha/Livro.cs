namespace pilha
{
    internal class Livro
    {
        string Titulo;
        Livro Anterior;

        public Livro(string titulo) 
        {
            this.Titulo1 = titulo;
            this.Anterior1 = null;
        }

        public string Titulo1 { get => Titulo; set => Titulo = value; }
        internal Livro Anterior1 { get => Anterior; set => Anterior = value; }


    }
}
