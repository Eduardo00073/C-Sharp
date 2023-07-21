Console.WriteLine("Digite o primeiro número:");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);
Console.WriteLine("Digite o segundo número:");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

int soma = num1 + num2;

Console.WriteLine($"A soma de {num1} e {num2} é igual a {soma}.");