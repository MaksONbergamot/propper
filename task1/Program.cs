Console.Write("Введите количество элементов массива: ");

int dlinaMassiva = Convert.ToInt32(Console.ReadLine());

string[] Array = new string[dlinaMassiva];

for (int i = 0; i < dlinaMassiva; i++)
{
    Console.Write("Введите элемент массива " + i + ": ");
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
//Console.WriteLine("правильных ответов " + rightAnswers); //проверка

string[] Array2 = new string[rightAnswers];
int n = 0;

for (int schet = 0; schet < rightAnswers; schet++)
{
    if (Array[schet].Length <= 3)
    {
        Array2[n] = Array[schet];
        n++;
    }
    else 
    {
        rightAnswers++;
    }
}

for (int schet2 = 0; schet2 < Array2.Length; schet2++)
{
Console.Write(Array2[schet2] + ", ");

}

