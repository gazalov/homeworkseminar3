Console.Clear();

int DataEntryXYZ(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine(dist);
}

int x1 = DataEntryXYZ("Введите координаты x1 = ");
int y1 = DataEntryXYZ("Введите координаты y1 = ");
int z1 = DataEntryXYZ("Введите координаты z1 = ");

int x2 = DataEntryXYZ("Введите координаты x2 = ");
int y2 = DataEntryXYZ("Введите координаты y2 = ");
int z2 = DataEntryXYZ("Введите координаты z2 = ");

Distance(x1, y1, z1, x2, y2, z2);