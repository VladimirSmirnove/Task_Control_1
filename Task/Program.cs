/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"]->["2", ":-)"]
["Russia", "Denmark", "Kazan"]->[]
*/
Console.WriteLine ("Введите число строк:");
int m = int.Parse (Console.ReadLine()); 
string[] GetArray (int m)
{
string [] OneArray = new string [m]; 
Console.WriteLine("Введите в массив строку:");
for (int i = 0; i < m; i++)
{
    OneArray[i] = Console.ReadLine();
}
return OneArray;
}
void PrintOneArray (string[] OneArray)
{
Console.WriteLine("Начальный массив:");
for (int i = 0; i < m; i++)
{
    Console.Write(OneArray[i] + "\t");
}
Console.WriteLine();
}
string[] OneArray = GetArray(m);
PrintOneArray(OneArray);
string[] SecondArray = new string[OneArray.Length];
void ArraySecond(string[] OneArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
    if (OneArray[i].Length <= 3)
        {
        SecondArray[count] = OneArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.WriteLine("Массив из 3 символов и меньше:");
    for (int i = 0; i < m; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
ArraySecond(OneArray, SecondArray);
PrintArray(SecondArray);


