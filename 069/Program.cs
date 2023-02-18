// Задача_№69 Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void FillArray (int [,] a) 
{
    for (int i = 0;i< a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j]=new Random().Next(1,10);
        }
    }


}

void PrintArray ( int[,] a)
{
   for (int i = 0;i< a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j],5}");
        }       
        System.Console.WriteLine();
    }
}

void SortArray(int[,] a)
{
    for (int k = 0; k < a.GetLength(1); k++)
    {   
        for (int s = 0; s< a.GetLength(0); s++)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1)-1; j++)
                {
                    if (a[i,j] < a[i,j + 1])
                    {
                        int t = a[i,j];
                        a[i,j] = a[i,j + 1];
                        a[i,j + 1] = t;
                    }
                }   
            }    
        }
    }
    
}
    
int[,] a= new int[2,8];
Random random=new Random();
FillArray(a);
System.Console.WriteLine("Массив заполненый случайными числами:");
PrintArray(a);
SortArray(a);
System.Console.WriteLine("Массив отсортирован в порядке убывания по строкам:");
PrintArray(a);







