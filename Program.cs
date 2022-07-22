void Zadacha19()
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int A1, A2, A3, A4, A5, number2;
    A1 = number % 10 * 10000;
    A2 = number/ 10 % 10 * 1000;
    A3 = number/ 100 % 10 * 100;
    A4 = number/ 1000 % 10 * 10;
    A5 = number/ 10000 % 10;
    number2 = A1 + A2 + A3 + A4 + A5;
    if (number == number2)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число не является палиндромом");
}
void Zadacha21()
{
    Console.WriteLine("Введите координаты двух точекю");
    Console.Write("Введите координату x1= ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y1= ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z1= ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату x2= ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y2= ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z2= ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine(c);
}
void Zadacha23()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int a = 1;
    while (a <= number)
    {
        double b = Math.Pow(a, 3);
        Console.Write(b + ",");
        a++;
    }
    Console.Write("\b.");
    Console.WriteLine();
}

Zadacha23();