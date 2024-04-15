public class Estoque
{
    Medicamento[] medicamentos = new Medicamento[0];

    public void Adicionar(Medicamento medicamento)
    {
        Medicamento[] novoVetor = new Medicamento[medicamentos.Length + 1];
        for (int pos = 0; pos < medicamentos.Length; pos++)
        {
            Medicamento item = medicamentos[pos];
            novoVetor[pos] = item;
        }
        novoVetor[novoVetor.Length - 1] = medicamento;

        medicamentos = novoVetor;
    }

    public void Listar()
    {
        int cont = 1;
        foreach (Medicamento item in medicamentos)
        {
            Console.WriteLine($"{cont}. {item.Nome} ({item.Preco}) - {item.Estoque} no estoque");
            cont ++;
        }
    }

    public void Remover(int pos)
    {
       Medicamento medicamento = medicamentos[pos - 1];
       medicamento.Estoque -= pos;
    }

    public void Entrada(int pos, int qtd)
    {
        Medicamento medicamento = medicamentos[pos - 1];
        medicamento.Estoque += qtd;
    }

    public void Saida(int pos, int qtd)
    {
        Medicamento medicamento = medicamentos[pos - 1];
        medicamento.Estoque -= qtd;
    }
}