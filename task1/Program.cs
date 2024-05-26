Console.Write("Введите количество элементов массива: ");

int dlinaMassiva = Convert.ToInt32(Console.ReadLine());

string[] Array = new string[dlinaMassiva];

for (int i = 0; i < dlinaMassiva; i++)
{
    Console.Write("Введите элемент массива: ");
    Array[i] = Console.ReadLine();
}
//проверка массива
// Console.WriteLine(Array[0]);
// Console.WriteLine(Array[1]);
// Console.WriteLine(Array[2]);
// Console.WriteLine(Array[3]);
// Console.WriteLine(Array[4]);

int rightAnswers = 0;
for (int ii = 0; ii < dlinaMassiva; ii++)
{
    if (Array[ii].Length <= 3)
    {
        rightAnswers++;
    }

}
//Console.WriteLine(rightAnswers);

string[] Array2 = new string[rightAnswers];
