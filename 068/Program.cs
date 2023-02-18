// Задача_№68 Написать программу, которая обменивает элементы первой строки и последней строки

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

void Swap(ref int a, ref int b)
{
    int t=a;
        a=b;
        b=t;
}

void ReplacingAStringArray( int[,] a, int row1,int row2)
{
     for(int j=0;j<a.GetLength(1);j++)
       {
          Swap(ref a[row1,j], ref a[row2,j]);
       }   
}

int[,] a= new int[2,4];
Random random=new Random();
FillArray (a);
PrintArray (a);
ReplacingAStringArray (a,0,a.GetLength(0)-1);
System.Console.WriteLine();
PrintArray (a);

