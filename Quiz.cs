int[] arr = { 5, 10, 15 };
int min = arr[0];
int max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
        min = arr[i];
}
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
        max = arr[i];
}
int count = 0;
for (int i = min; i<max; i++)
{
    count++;
}
Console.WriteLine(count-2);

