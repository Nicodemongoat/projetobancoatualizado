using projetobanco;

internal class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();
        meuBanco.Nome = "Banco do Brasil";
        meuBanco.CodigoBACEN = "001";

        ContaBancaria origem = new ContaBancaria();
        origem.Agencia = "0001";
        origem.NumeroConta = "12345-6";

        ContaBancaria destino = new ContaBancaria();
        destino.Agencia = "0001";
        destino.NumeroConta = "98765-4";

        Transacao minhaTransacao = new Transacao();
        minhaTransacao._valor = -40;
        minhaTransacao.Data = DateTime.Now;
        minhaTransacao.Tipo = "PIX";
        minhaTransacao.ContaOrigem = origem;
        minhaTransacao.ContaDestino = destino;

        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
        Console.WriteLine("----------------------");
        Console.WriteLine("Tipo: " + minhaTransacao.Tipo);
        Console.WriteLine("Valor: R$ " + minhaTransacao._valor);
        Console.WriteLine("Data: " + minhaTransacao.Data);
        Console.WriteLine("Origem: " + origem.Agencia + " / " + origem.NumeroConta);
        Console.WriteLine("Destino: " + destino.Agencia + " / " + destino.NumeroConta);
    }
}