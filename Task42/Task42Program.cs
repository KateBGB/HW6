// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double FindY(double k1, double k2, double b1, double b2)
{
    double y = k2*(b2-b1) /( k1-k2) +b2;
    return y;
}


double FindX(double k1, double k2, double b1, double b2)
{
    double x = (b2-b1) / (k1-k2);
    return x;
}

double EnterData(string text)
{
    Console.WriteLine(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}


//Попросить пользователя задать значения переменных
double k1 = EnterData("Введите значение k1: ");
double k2 = EnterData("Введите значение k2: ");
double b1 = EnterData("Введите значение b1: ");
double b2 = EnterData("Введите значение b2: ");
//Найти координату x
double x = FindX(k1, k2, b1, b2);
//Найти координату y
double y = FindY(k1, k2, b1, b2);
//Вывести координаты на экран
Console.WriteLine(String.Join(";", x,y));
