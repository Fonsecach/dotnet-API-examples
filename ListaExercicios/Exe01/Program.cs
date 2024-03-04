double altura;
double largura;

Console.WriteLine("Insira a altura: ");
double.TryParse(Console.ReadLine(), out altura);

// é possivel utilizar o Covert como no exemplo abaixo:
//altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a largura: ");
double.TryParse(Console.ReadLine(), out largura);

double area = altura * largura;
Console.WriteLine($"Área do retângulo: {area}");




