// See https://aka.ms/new-console-template for more information

int[] num = new int[7];
Console.WriteLine("Digite 7 numeros: ");


for (int i = 0; i < 7; i++)
    num[i] = Convert.ToInt32(Console.ReadLine());


for (int i = 6; i >= 0; i--)
    Console.WriteLine(num[i]);
