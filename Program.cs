//1. 1dan 1000 gacha sonlar yig'indisi
int i=1, sum=0;
while (i<=1000)
{
    sum+=i;
    i++;
}
Console.WriteLine(sum);
Console.WriteLine();

//2. Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini
Console.Write("ruyxat elmentlar soni=> ");
int n=Convert.ToInt32(Console.ReadLine());
int[] array= new int[n];
Console.WriteLine("Array elementlarini kiriting:");
for (int k =0; k<n; k++)
{
    array[k] = Convert.ToInt32(Console.ReadLine());
}
int min = array[0];
int max = array[0];
for (int k = 1; k < n; k++)
{
    if (array[k] < min)
    {
        min = array[k];
    }
    if (array[k] > max)
    {
        max = array[k];
    }
}
int p=min*max;
Console.WriteLine(p);
Console.WriteLine();

//3. factorial ni hisoblash
Console.Write("Btun son kiriting=>");
int factorial = 1;
int son=Convert.ToInt32(Console.ReadLine());
for(int j=1; j<=son; j++)
{
    factorial=factorial*j;
}
Console.WriteLine(factorial);
