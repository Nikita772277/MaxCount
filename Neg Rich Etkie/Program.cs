Console.WriteLine("Введите текс");
string l = Console.ReadLine();
char[] c = l.ToCharArray();
int MaxCount = 0;
int currentcount = 0;
foreach (char c2 in c)
{
    if (char.IsDigit(c2))
    {
        currentcount++;
        if (MaxCount <= currentcount)
        {
            MaxCount = currentcount;
        }
    }
    else if (char.IsDigit(c2) == false)
    {
        currentcount = 0;
        continue;
    }                                                                                                    
}
Console.WriteLine($"максимальная последовательность чисел идущих подряд - {MaxCount}");

