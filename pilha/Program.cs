namespace pilha;

internal class Program
{
    private static void Main(string[] args)
    {
        Pilha PilhaLivros = new Pilha();
        int opcao = 0;

        static Livro CriarLivro()
        {
            Console.WriteLine("Informe o título do livro:");
            return new Livro(Console.ReadLine());
        }

        do
        {
            Console.Clear();
            Console.WriteLine($"MENU\n" +
                $"1 - Inserir livro;\n" +
                $"2 - Remover livro;\n" +
                $"3 - Imprimir livro;\n" +
                $"4 - Imprimir livro especifico;\n" +
                $"0 - SAIR;\n" +
                $"Informe a opção desejada: < >\b\b");
            opcao = int.Parse( Console.ReadLine() );

            switch (opcao)
            {
                case 1:
                    PilhaLivros.push(CriarLivro());
                    break;
                case 2:
                    PilhaLivros.pop();
                    break;
                case 3:
                    PilhaLivros.Print();
                    break;
                case 4:
                    Console.WriteLine("Informe o livro que deseja buscar:");
                    PilhaLivros.RunOver(Console.ReadLine());
                    break;
                default:
                    break;
            }
        } while (opcao != 0);
    }
}