int exponentiation(int A, int B)
{
int c = A;
for (int i = 1; i < B; i++) {
c = c*A;
}
return c;
}

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

int ex = exponentiation(a, b);
Console.WriteLine(ex);
