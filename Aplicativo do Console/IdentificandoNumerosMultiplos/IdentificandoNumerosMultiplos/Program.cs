// Leitura da quantidade de números na lista
int quantidadeNumeros = int.Parse(Console.ReadLine());

// Leitura da lista de números e separação em um array de inteiros
string[] numerosString = Console.ReadLine().Split(' ');

// Verifica se a quantidade de números informada é igual ao tamanho do array
if (numerosString.Length != quantidadeNumeros)
{
    Console.WriteLine("A quantidade de números informada não é igual à quantidade real de números.");
    return;
}

int[] numeros = new int[quantidadeNumeros];
for (int i = 0; i < quantidadeNumeros; i++)
{
    numeros[i] = int.Parse(numerosString[i]);
}

// Inicialização das variáveis que vão contar os múltiplos
int multiplo2 = 0;
int multiplo3 = 0;
int multiplo4 = 0;
int multiplo5 = 0;

// Percorre a lista de números
for (int i = 0; i < quantidadeNumeros; i++)
{
    int numeroAtual = numeros[i];

    // Verifica se o número atual é múltiplo de 2, 3, 4 e 5, incrementando as variáveis apropriadas
    if (numeroAtual % 2 == 0)
        multiplo2++;

    if (numeroAtual % 3 == 0)
        multiplo3++;

    if (numeroAtual % 4 == 0)
        multiplo4++;

    if (numeroAtual % 5 == 0)
        multiplo5++;
}

// Exibe o resultado
Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);