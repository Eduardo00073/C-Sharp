Console.WriteLine("Digite um número para verificar se ele é primo:");
int num = int.Parse(Console.ReadLine());

if (IsPrime(num))
    Console.WriteLine($"{num} é um número primo.");
else
    Console.WriteLine($"{num} não é um número primo.");

static bool IsPrime(int number)
{
    if (number <= 1)
        return false;

    if (number == 2)
        return true;

    if (number % 2 == 0)
        return false;

    for (int i = 3; i * i <= number; i += 2)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}