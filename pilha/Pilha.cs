namespace pilha
{
    internal class Pilha
    {
        Livro topo;
        int contador;

        public Pilha() 
        {
            this.topo = null;
            this.contador = 0;
        }
    
        void push(Livro l)
        {
            //guarda o livro atual para nao perder referencia
            Livro aux;
            aux = this.topo;

            //adiciona o novo livro no topo
            this.topo = l;

            //usa a variavel auxiliar para guardar a referencia do antigo livro que estava no topo
            l.setAnterior(aux);

            this.contador++;
        }

        Livro pop()
        {
            //auxiliar guarda o topo para nao perder a referencia
            Livro aux;
            aux = this.topo;

            //topo agora é o que estava abaixo dele
            topo = topo.GetAnterior();

            //retorna o objeto que foi retirado
            return aux;
        }
    }
}
