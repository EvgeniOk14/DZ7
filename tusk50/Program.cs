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

void ReleaseArray(int[,] matrix, int IndStr, int IndColumn)
{
  if (matrix.GetLength(0) < IndStr || matrix.GetLength(1) < IndColumn )
      {
       Console.WriteLine("Нет элемента с такими индексами! ");
                    
      }

           for(int i = 0; i < matrix.GetLength(0); i++)
           {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                   if (i == IndStr && j == IndColumn)
                    Console.Write(matrix[IndStr, IndColumn]);
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
ReleaseArray(matrix,IndStr,IndColumn);
 
              
         
          
   
  
