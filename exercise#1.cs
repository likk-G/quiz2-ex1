// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;

Console.Write("Enter Amount Of Elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter Element Number {i} :");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0, mul = 1;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
    {
        mul *= arr[i];
    }
    else
    {
        sum += arr[i];
    }
}
Console.WriteLine($"Sum Of Odd Elements = {sum}");
Console.WriteLine($"Product Of Multiplied Even Elements = {mul}");

int count;
for (int i = 0; i < n; i++)
{
    count = 1;
    if (i == 0)
    {
        for (int j = 1; j < n; j++)
        {
            if (arr[j] == arr[0])
            {
                count++;
            }
        }
        Console.WriteLine($"Number \"{arr[0]}\" has been used {count} time(s);");
    }
    else if (arr[i] != arr[0])
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] == arr[i])
            {
                count++;
                arr[j] = arr[0];
            }
        }
        Console.WriteLine($"Number \"{arr[i]}\" has been used {count} time(s);");
        arr[i] = arr[0];

    }
}


