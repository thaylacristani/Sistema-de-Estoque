namespace pti;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CONTROLE DE ESTOQUE - FARMÁCIA");

        Estoque estoque = new Estoque();

        int menu = 0;
        do
        {
            Console.WriteLine("\n[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Medicamento novoMedicamento = new Medicamento();

                Console.WriteLine("\nNome do Medicamento:");
                novoMedicamento.Nome = Console.ReadLine();

                Console.WriteLine("\nPreço:");
                novoMedicamento.Preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nLaboratório:");
                novoMedicamento.Laboratorio = Console.ReadLine();

                Console.WriteLine("\nPrincípio Ativo:");
                novoMedicamento.PrincipioAtivo = Console.ReadLine();

                Console.WriteLine("\nTipo:");
                novoMedicamento.Tipo = Console.ReadLine();

                estoque.Adicionar(novoMedicamento);

                Console.WriteLine("\nMedicamento adicionado!");
            }
        
            else if (menu == 2)
            {
                Console.WriteLine("\nItens no Estoque:");
                estoque.Listar();
            }
            else if (menu == 3)
            {
                Console.WriteLine("\nPosição do Medicamento:");
                int pos = Convert.ToInt32(Console.ReadLine());

                estoque.Remover(pos);

                Console.WriteLine("\nItem removido!");
            }
            else if (menu == 4)
            {
                Console.WriteLine("\nItens no Estoque:");
                estoque.Listar();

                Console.WriteLine("\nPosição do Medicamento:");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nQuantidade de Entrada:");
                int qtd = Convert.ToInt32(Console.ReadLine());

                estoque.Entrada(pos, qtd);

                Console.WriteLine("\nEntrada efetuda com sucesso!");
            }
            else if (menu == 5)
            {
                Console.WriteLine("\nItens no Estoque:");
                estoque.Listar();

                Console.WriteLine("\nPosição do Medicamento:");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nQuantidade de Saída:");
                int qtd = Convert.ToInt32(Console.ReadLine());

                estoque.Saida(pos, qtd);

                Console.WriteLine("\nSaída efetuda com sucesso!");
            }

        }while (menu != 0);

    }

}