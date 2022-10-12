//Задача 19

/*Console.Write("Введите пятизначное число: ");
string Num = Console.ReadLine()!;
if ((Num.Length == 5))
{
int A = Convert.ToInt32(Num[0]+Num[1]);
int B = Convert.ToInt32(Num[3]+Num[4]);
if(A==B)
{
    Console.WriteLine("Данное число является полиндромом.");
}
else
{
Console.WriteLine("Данное число не является полиндромом.");
}
}
else
{
    Console.WriteLine("Число не пятизначное!");
}

//Задача 21
Console.Write("Введите координату x первой точки: ");
int Ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y первой точки: ");
int Ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z первой точки: ");
int Az = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату x второй точки: ");
int Bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y второй точки: ");
int By = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z второй точки: ");
int Bz = int.Parse(Console.ReadLine()!);
double lengthx = Math.Pow((Bx-Ax), 2);
double lengthy = Math.Pow((By-Ay), 2);
double lengthz = Math.Pow((Bz-Az), 2);
double result = lengthx + lengthy + lengthz;
result = Math.Sqrt(result);
result = Math.Round(result, 2);
Console.WriteLine(result);*/

//Задача 23

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
double number = 1;
while(N>number || N==number)
{
    Console.Write($"{Math.Pow(number, 3)} ");
    number++;
}