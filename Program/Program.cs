/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами. */

 // Способ 1. Создание нового массива:
string[] myArray = new string[] {"hello", "2" ,"world", ":-)"};
string[] myArray2 = new string[myArray.Length];
void FirstArrayReplacement(string[] myArray, string[] myArray2)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
    if(myArray[i].Length <= 3)
        {
        myArray2[count] = myArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FirstArrayReplacement(myArray, myArray2);
PrintArray(myArray);
FirstArrayReplacement(myArray, myArray2);
PrintArray(myArray2);
Console.WriteLine();
// Способ 2. Простой, без методов и с одним массивом:

string[] myArray1 = new string[] {"hello", "2" ,"world", ":-)"};
    for (int i = 0; i < myArray1.Length; i++)
    {
    if(myArray1[i].Length <= 3)
       {
        Console.Write($"{myArray1[i]} ");
       }
       else
       {
          Console.Write(myArray1[i] = " ");
       }
    }
