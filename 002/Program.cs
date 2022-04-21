Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int kolvo = number.Length;
int result = 0;

for (int i = 0; i <= kolvo; i++)
{
    result = i;
}
Console.WriteLine(result);

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;

while(number !=0)
{
    number = number/10;
    index++;
}
Console.WriteLine(index);*/