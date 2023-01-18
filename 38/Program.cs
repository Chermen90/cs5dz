using static System.Console;
Write("Введите размер массива, min и max через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();

double min = GetMin(array);
double max = GetMax(array);
double dif = GetDif(max, min);
WriteLine($"Разница между {max} и {min} равна {dif}");

//метод для создания массива
double [] GetArray(int size, int minValue, int maxValue)
{
    double [] resultArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        resultArray[i] = Convert.ToDouble(new Random().Next(minValue, maxValue +1));
    }
    return resultArray;
}

//метод для вывода на экран массива
void PrintArray(double[] inArray)
{
    for(int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}");
}

//метод для поиска самого маленького элемента массива
double GetMin(double [] minArr)
{
    double min = array[0];
    for(int i = 1; i < minArr.Length; i++)
    {
        if(min > minArr[i])
        {
            min = minArr[i];
        }

    }
    return min;
}

//метод для поиска самого большого элемента массива
double GetMax(double [] maxArr)
{
    double max = array[0];
    for(int i = 1; i < maxArr.Length; i++)
    {
        if(max < maxArr[i])
        {
            max = maxArr[i];
        }
    }
    return max;
}

//метод для получения разницы между минимумом и максимумом
double GetDif(double maxVal, double minVal)
{
    double result = maxVal - minVal;
    return result;
}