// Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"]->["2",":-)""]
// ["1234","1567","-2","computer science"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]
Console.WriteLine("Введите количество строк: ");
int count = int.Parse(Console.ReadLine());
string [] array=new string[count];
Console.WriteLine("Введите строку:");
for (int i=0;i<array.Length;i++)
{
// Console.Write($"Введите строку {i+1}:  ");
string s=Console.ReadLine();
array[i]=s;
}
Console.WriteLine("строки с колличеством символов меньше либо равно 3:");
for (int j=0;j<array.Length; j++)
{
    if (array[j].Length<=3)
Console.Write($"{array[j]}  ");
}