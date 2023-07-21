Console.WriteLine("Média de 5 valores");
Console.WriteLine("Digite o número 1:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o número 2:");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o número 3:");
double num3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o número 4:");
double num4 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o número 5:");
double num5 = double.Parse(Console.ReadLine());

double media = (num1 + num2 + num3 + num4 + num5) / 5;

Console.WriteLine($"Media é {media}");