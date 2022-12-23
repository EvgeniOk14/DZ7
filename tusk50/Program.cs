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
 void Solution(int[,] matrix, int IndStr, int IndColumn)
{
    if (IndStr >= matrix.GetLength(0)|| IndColumn >= matrix.GetLength(1))
      {
       Console.WriteLine("Нет элемента с такими индексами! ");               
      }
} 

void ReleaseArray(int[,] matrix, int IndStr, int IndColumn)
{

           for(int i = 0; i < matrix.GetLength(0); i++)
           {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                   if (i == IndStr && j == IndColumn)
                    Console.Write("Элемент с заданными индексами равен: " + matrix[IndStr, IndColumn]);
                }
           }
}
Console.Clear();
Console.WriteLine("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix); 
Console.WriteLine("Введите индекс строки массива:");
int IndStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца массива:");
int IndColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Количество строк массива равно: " + IndStr);
Console.WriteLine("Количество столбцов массива равно: " + IndColumn);
Solution(matrix, IndStr, IndColumn); 
ReleaseArray(matrix,IndStr,IndColumn);
 
              
         
          
   
  
