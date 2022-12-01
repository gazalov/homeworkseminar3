Console.Clear();

int DataInput(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Palindrome(int testNumber)
{
    int i = 0;
    int testNumberReverse = 0;
    while (i < 5)
    {
        testNumberReverse = testNumberReverse * 10 + (testNumber) % 10;
        testNumber = testNumber / 10;
        i++;
    }
    return testNumberReverse;
}

int fiveUnitNumber = DataInput("Введите пятизначное число: ");
int palindrome = Palindrome(fiveUnitNumber);

if (palindrome == fiveUnitNumber)
{
    Console.WriteLine($"Число {fiveUnitNumber} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {fiveUnitNumber} не является палиндромом.");
}

