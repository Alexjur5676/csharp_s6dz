// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        Console.WriteLine($"Введите число M{index + 1}:");
        int Number = Convert.ToInt32(Console.ReadLine());
        array[index] = Number;
    }
}
void PrintArray(int[] Array)

{
    int count = Array.Length;
    for (int index = 0; index < count; index++)
    {
       Console.Write(Array[index] + " ");
    }
}
Console.WriteLine("Какое колличество чисел M будет введено? ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int count = array.Length;
FillArray(array);
Console.WriteLine("Введенные числа: ");
PrintArray(array);

int sum = 0;
for (int i = 0; i < M; i++)
{
    if (array[i] > 0)
    {
        sum += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел {sum} ");


