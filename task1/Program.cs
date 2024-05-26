Console.Write("Введите количество элементов массива: ");

int dlinaMassiva = int.Parse(Console.ReadLine());

//int[] massiv = new int[dlinaMassiva];
string[] Array = new string[dlinaMassiva];

for (int i = 0; i < dlinaMassiva; i++)
{
    Console.Write("Введите элемент массива: ");
    Array[i] = Console.ReadLine();
}
Console.WriteLine(Array[0]);
Console.WriteLine(Array[1]);
Console.WriteLine(Array[2]);
Console.WriteLine(Array[3]);
Console.WriteLine(Array[4]);