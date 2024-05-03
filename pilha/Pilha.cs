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

        public void push(Livro l)
        {
            //guarda o livro atual para nao perder referencia
            Livro aux;
            aux = this.topo;

            //adiciona o novo livro no topo
            this.topo = l;

            //usa a variavel auxiliar para guardar a referencia do antigo livro que estava no topo
            l.SetAnterior(aux);

            this.contador++;
        }

        public Livro pop()
        {
            //auxiliar guarda o topo para nao perder a referencia
            Livro aux = this.topo;

            //topo agora é o que estava abaixo dele
            topo = topo.GetAnterior();

            this.contador--;
            //retorna o objeto que foi retirado
            return aux;
        }

        bool IsEmpty()
        {
            if (topo == null) return true;
            else return false;
        }

        public void Print()
        {
            Livro aux = this.topo;
            if (IsEmpty()) 
            {
                Console.WriteLine("Pilha vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.Print());
                    aux = aux.GetAnterior();
                    if (aux == null) 
                    { 
                        Console.WriteLine("Fim da pilha. Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                } while (aux != null);
            }
        }

        public void RunOver(string livro)
        {
            int contadorAux = 0;
            Livro aux = this.topo;

            if (IsEmpty())
            {
                Console.WriteLine("Pilha vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                contadorAux = this.contador;

                do
                {
                    contadorAux--;
                    if (aux.GetTitulo() == livro)
                    {
                        Console.WriteLine($"Livro {livro} encontrado na posição: {contadorAux}\n" +
                            "Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    aux = aux.GetAnterior();
                } while (aux != null);
            }
        }
    }
}
