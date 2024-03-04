
using System;
using System.Globalization;

class Program
{
  const decimal Dolar = 5.17m;
  const decimal Euro = 6.14m;
  const decimal PesoArgentino = 0.05m;

  static decimal ConverterMoeda(decimal taxaCambio, decimal valorReal)
  {
    return valorReal / taxaCambio;
  }

  static void Main(string[] args)
  {
    decimal valorReal;
    int opcao = 0;

    while (opcao != 4)
    {
      Console.WriteLine("Digite o valor em reais a ser convertido: R$ ");

      if (!decimal.TryParse(Console.ReadLine(), out valorReal))
      {
        Console.WriteLine("Valor inválido. Insira um número válido.");
        continue;
      }

      Console.WriteLine("Insira a moeda para converter o valor: ");
      Console.WriteLine("(1)\tDólar");
      Console.WriteLine("(2)\tEuro");
      Console.WriteLine("(3)\tPeso Argentino");
      Console.WriteLine("(4)\tSair");

      if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
      {
        Console.WriteLine("Opção inválida. Insira um número válido.");
        continue;
      }

      switch (opcao)
      {
        case 1:
          MostrarResultado("Dólar", ConverterMoeda(Dolar, valorReal), valorReal);
          break;
        case 2:
          MostrarResultado("Euro", ConverterMoeda(Euro, valorReal), valorReal);
          break;
        case 3:
          MostrarResultado("Peso Argentino", ConverterMoeda(PesoArgentino, valorReal), valorReal);
          break;
        case 4:
          Console.WriteLine("Programa encerrado");
          break;
      }
    }
  }

  static void MostrarResultado(string moeda, decimal resultado, decimal valorReal)
  {
    Console.WriteLine($"{valorReal:C2} reais equivalem a {resultado:C2} {moeda}.");
  }
}
