// Задача_№62 В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]).
// Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

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

void ClArray (int[,] a)

{

 for (int i = 0;i< a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i,j]%2==0)
                {
                    a[i,j]=-a[i,j];
                }
        }
    }



}

int[,] a= new int[2,4];
Random random=new Random();
FillArray(a);
PrintArray(a);
ClArray(a);
System.Console.WriteLine();
PrintArray(a);



























