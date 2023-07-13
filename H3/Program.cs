Console.Clear();
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n; i++)
Console.WriteLine($"{i*i*i}");
