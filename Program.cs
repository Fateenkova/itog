// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
string[] array = { "Hello", "Привет", "Hey", "Bay", "Bonjour" };
for (int k = 0; k < array.Length; k++)
{
    Console.Write($"{array[k]} ");
}
Console.WriteLine();
int count = 0;
int max = 3;
int j = 0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k].Length <= max)
    {
        count = count + 1;
    }
}
string[] array2 = new string[count];
for (int k = 0; k < array.Length; k++)
{
    if (array[k].Length <= max)
    {
        array2[j] = array[k];
        Console.Write(array2[j] + ",");
        // j++;
    }
}