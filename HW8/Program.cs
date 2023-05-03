// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Prompt("Введите координату X1: ");
int y1 = Prompt("Введите координату Y1: ");
int z1 = Prompt("Введите координату Z1: ");
int x2 = Prompt("Введите координату X2: ");
int y2 = Prompt("Введите координату Y2: ");
int z2 = Prompt("Введите координату Z2: ");

double d = FindLenght(x1, y1, z1, x2, y2, z2);

double FindLenght(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = Math.Sqrt(
        ((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)) + ((zb - za) * (zb - za))
    );
    Console.WriteLine(result);
    return result;
}

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    int FindQuarter = Convert.ToInt32(value);
    return FindQuarter;
}
