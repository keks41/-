Console.WriteLine("Ведите первое число  ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < numberA)
{
    if ( i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
    i++;
}