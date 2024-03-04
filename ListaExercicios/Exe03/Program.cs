// Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.
int num1, num2;

Console.WriteLine("Insira o primeiro numero: ");
int.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("Insira o segundo numero: ");
int.TryParse(Console.ReadLine(), out num2);

int maior = num1;

if (num1 == num2)
{
  Console.WriteLine("Os numeros são iguais!");
}
else
{
  if (num2 > num1)
  {
    maior = num2;
  }
  Console.WriteLine($"O maior número é {maior}");
}



