int[] numbers = { 21, 34, 20, 47, 49 };
int min;
min = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]<min)
    {
        min = numbers[i];
    }

}
Console.WriteLine(min);