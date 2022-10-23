// Решил сделать для любого числа, а не только для пятизначного
// Поэтому получилось сложновато =)

int[] toIntegerArray(int number) // Перевод числа в массив
{
    int a = number;
    List<int> l = new List<int>();
    while (a > 0)
    {
        l.Add(a % 10);
        a = a / 10;
    }
    l.Reverse();
    return l.ToArray();
}

void palindromCheck(int[] numba) // Проверка на палиндром(ность?)
{
    var j = 0;
    for (int i = 0; i < (numba.Length / 2); i++)
    {
        if (numba[i] == numba[numba.Length - i - 1]) // Проверка равны ли два числа. Проход с начала и с конца.
        {
            j++;
        }

    }
    if (j == (numba.Length / 2))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int[] arr = toIntegerArray(Convert.ToInt32(Console.ReadLine()));

palindromCheck(arr);