//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(n);
while (s.Length!=5)
{
    Console.Write($"Attention {s.Length}\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
    s = Convert.ToString(n);
}

if ((s[0] == s[4]) & (s[1] == s[3]))
    Console.WriteLine($"Число {n} -> палиндром");
else
    Console.WriteLine($"Число {n} -> не палиндром");


/*Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double LongLine (int x1, int x2, int y1, int y2, int z1, int z2)

{
    double lenghtAB = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return lenghtAB;
}

Console.WriteLine ("Input X coordinat of A: ");
int XCoordA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of A: ");
int YCoordA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Z coordinat of A: ");
int ZCoordA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input X coordinat of B: ");
int XCoordB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of B: ");
int YCoordB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Z coordinat of B: ");
int ZCoordB = Convert.ToInt32 (Console.ReadLine());

double dist = LongLine (XCoordA, XCoordB, YCoordA, YCoordB, ZCoordA, ZCoordB);

Console.WriteLine ($"Distance AB is {dist:f2}");


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void CubeFinder()

{
    Console.WriteLine ("Input number : ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberN > 0)
        {
        int current_i = 1;
        while (current_i <= numberN)
        {
            int res = current_i * current_i * current_i;
            Console.Write ($"{res},");
            current_i ++;
        } 
    }
    else Console.WriteLine ("Impossible value!");
}

CubeFinder();

*/
