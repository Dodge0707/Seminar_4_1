Console.Write("Введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int index = 1; index <= number; index++)
{
    result = result * index;
}
Console.WriteLine(result);
