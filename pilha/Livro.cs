namespace pilha
{
    internal class Livro
    {
        string Titulo;
        Livro Anterior;

        public Livro(string titulo) 
        {
            this.Titulo = titulo;
            this.Anterior = null;
        }

        public void SetAnterior(Livro l) { this.Anterior = l; }

        public Livro GetAnterior() { return this.Anterior; }

        public string GetTitulo() { return this.Titulo; }

        public string Print() { return $"Título: {this.Titulo}"; }
    }
}
