int[] numbers = { 33, 4, 76, 89, 5, 2, 11, 7 };
int reqem=0;
for (int i = 0; i < numbers.Length; i++)
{
	if (numbers[i]<10)
	{
		reqem++;
	}
}
Console.WriteLine(reqem);