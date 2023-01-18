using static System.Console;
Write("Введите размер массива, min и max через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]),int.Parse(parameters[2]));
PrintArray(array);
WriteLine();
WriteLine($"Сумма элементов на нечётных позициях в массиве равна {OddSum(array)}");

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] resultArray = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue +1);
    }
    return resultArray;
}

int OddSum(int[] arrSum)
{
    int sum = 0;
    for(int i = 0; i < arrSum.Length; i++)
    {
        if(i % 2 == 0)
        {
            sum += arrSum[i];
        }
    }
    return sum;
}

void PrintArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}");
}