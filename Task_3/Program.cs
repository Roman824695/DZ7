int ReadInt(string message)
{
    Console.Write(message + "->");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] Array(int element)
{
double [,] array = new double[element, element];


for(int i = 0; i < element; i++)
{
    for(int j = 0; j < element; j++)
    {
      array[i,j] = new Random().Next(0,10);
      Console.Write(array[i,j] + " | ");
    }
    Console.WriteLine();
}
return array;
}

void ArithmeticMean(double[,] array)
{
double[] arithmetic = new double[array.GetLength(0)];  

for(int i = 0; i < array.GetLength(0); i++)
{   
    for(int j = 0; j < array.GetLength(0); j++)
    {
      arithmetic[i] += array[j,i];
      
    }
        
    Console.Write(arithmetic[i] / array.GetLength(0) + " | ");
}
}


ArithmeticMean(Array(ReadInt("Введите колличество строк")));

