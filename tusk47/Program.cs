void InputArray(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
   {
     for(int j = 0; j < matrix.GetLength(1); j++)
     {
        matrix[i, j] = new Random().Next(-1000, 1001);
        Console.Write($"{matrix[i, j]} \t");
     }
   Console.WriteLine();
   }
} 
Console.Clear();
Console.WriteLine("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix); 

