using System;

namespace aplicado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Problema solucionado através da utilização de uma classe abstrata contendo o template dos dois impostos condicionais

            Orcamento orcamento = new Orcamento();

            orcamento.AdicionaItem(new Item("Arroz", 100));
            orcamento.AdicionaItem(new Item("Feijão", 200));
            orcamento.AdicionaItem(new Item("Batata", 300));
            orcamento.AdicionaItem(new Item("Alface", 400));
            orcamento.AdicionaItem(new Item("Tomate", 500));
            orcamento.AdicionaItem(new Item("Bife", 600));

            IImposto icms = new ICMS();
            IImposto iss = new ISS();
            IImposto pis = new PIS();
            IImposto cofins = new COFINS();

            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            Console.WriteLine(orcamento.Valor);
            Console.WriteLine(calc.CalculaImposto(orcamento, icms));
            Console.WriteLine(calc.CalculaImposto(orcamento, iss));
            Console.WriteLine(calc.CalculaImposto(orcamento, pis));
            Console.WriteLine(calc.CalculaImposto(orcamento, cofins));

            Console.ReadKey();

        }
    }
}
