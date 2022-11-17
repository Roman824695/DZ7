int ReadInt(string message)
{
    Console.Write(message + "->");
    return Convert.ToInt32(Console.ReadLine());
}
int[,] Array(int linelength, int elementlength)
{
int [,] array = new int[linelength, elementlength];


for(int i = 0; i < linelength; i++)
{
    for(int j = 0; j < elementlength; j++)
    {
      array[i,j] = new Random().Next(0,10);
      Console.Write(array[i,j] + " | ");
    }
    Console.WriteLine();
}
return array;
}
void PositionElement(int numbers, int[,]array)
{

    if(numbers < 100)
    {
    int line = numbers / 10;
    int element = numbers % 10;
    Console.WriteLine(array[line, element]);
    }      
    else
    {
      Console.WriteLine("Такого элемента не существует");
    }
}

     
PositionElement(ReadInt("Введите номер элемента массива "), Array(10,10));

