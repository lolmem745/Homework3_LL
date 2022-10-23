void cubeCounter(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i * i * i}");
        if (i != num)
            Console.Write(", ");
    }
}

Console.Write("Введите положительное число: ");

cubeCounter(Convert.ToInt32(Console.ReadLine()));