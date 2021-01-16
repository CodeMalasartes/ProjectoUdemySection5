using System.Globalization;

namespace UdemyExe
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValotTotalEmStock()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            //Quantidade = Quantidade + quantidade;
            Quantidade += quantidade;

        }
        public void RemoverProdutos(int quantidade)
        {
            //Quantidade = Quantidade - quantidade;
            Quantidade -= quantidade;

        }
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValotTotalEmStock().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}