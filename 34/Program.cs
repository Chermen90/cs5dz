using static System.Console;
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
int[] arr =GetArr(length);
PrintArray(arr);
WriteLine();
WriteLine($"Количество чётных элементов в массиве равно {CountEven(arr)}");

//метод для создания массива
int[] GetArr(int size)
{

    int [] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] =  new Random().Next(100, 999);
    }

    return array;
}

//метод для печати массива
void PrintArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}");
}

int CountEven(int[]arCount)
{
    int result = 0;
    foreach(int a in arCount)
    {
        if(a%2 ==0)
        {
            result++;
        }
    }
    return result;
}