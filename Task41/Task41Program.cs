//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositive(int[] array)
{
    int count = 0;
    for(int i = 0; i <array.Length; i++)
    {
        if(array[i] > 0)
        {
            count = count + 1;
        } 
    }
    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = EnterData("Введите элемент массива: ");
    }
    return array;
}


int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Ввести размер массива
int m = EnterData("Введите желаемое количество чисел: ");

//Создать массив вводом
int[] myarray = FillArray(m);

//Посчитать количество четных чисел в массиве
int positiveNumbers = CountPositive(myarray);

//Вывести результат на экран
Console.WriteLine($"Количество положительных элементов массива равно {positiveNumbers}");