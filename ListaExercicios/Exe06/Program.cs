// Declara o vetor e preenche com números aleatórios
int[] vetor = new int[10];
Random random = new Random();

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(100);
}

// Imprime o vetor desordenado
Console.WriteLine("Vetor desordenado:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write($" {vetor[i]}");
}

// Ordena o vetor usando o Bubble Sort
int aux;
bool trocou = true;

while (trocou)
{
    trocou = false;

    for (int i = 0; i < vetor.Length - 1; i++)
    {
        // Compara os elementos adjacentes
        if (vetor[i] > vetor[i + 1])
        {
            // Troca os elementos se o da esquerda for maior
            aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            trocou = true;
        }
    }
}

// Imprime o vetor ordenado
Console.WriteLine("\nVetor ordenado:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write($" {vetor[i]}");
}
