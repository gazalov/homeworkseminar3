Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Calc(int num)
{
    int i = 1;
    Console.Write($"Таблица кубов чисел от 1 до {num}: ");
    while (i <= num)
    {
        Console.Write(i * i * i + " ");
        i++;
    }
}

int numberN = DataEntry("Введите N: ");
Calc(numberN);