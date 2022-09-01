int sumNum (int num) {
int a = 1;
int res = 0;
while ( num > 0) {
a = num%10;
num = num/10;
res = res + a;
}
return res;
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int sum = sumNum(num);
Console.WriteLine(sum);