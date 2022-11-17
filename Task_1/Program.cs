int ReadInt(string message)
{
    Console.Write(message + "->");
    return Convert.ToInt32(Console.ReadLine());
}

int line = ReadInt("Введите число строк");
int element = ReadInt("Введите число элементов");



void Array(int line, int element)
{
double[,] array = new double[line, element];
Random rand = new Random();

for(int i = 0; i < line; i++)
{
    for(int j = 0; j < element; j++)
    {
      array[i,j] = rand.Next(-10,10) + Math.Round(rand.NextDouble(), 2);
      Console.Write(array[i,j] + " | ");
    }
    Console.WriteLine();
}
}

Array(line, element);