// Задача_№64 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.


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

void ReplacementArray (int[,] a)
{
    for (int i = 0; i <a.GetLength(0); i++)
    {
       for (int j = 0; j < a.GetLength(1); j++)
       {
        if(j%2==0)
            {
                a[i,j]=a[i,j]*a[i,j];
                
            }
       } 
    }
}

int[,] a= new int[2,4];
Random random=new Random();

FillArray(a);
System.Console.WriteLine("Массив заполненный случайными числами:");
PrintArray(a);
System.Console.WriteLine();
ReplacementArray(a);
System.Console.WriteLine("В массиве заменили элементы у которых индекс чётный, на квадрат значения: ");
PrintArray(a);