Console.WriteLine("Задан массив : {12345,234,1,23,1234567}");
Console.WriteLine();

string[] one = { "12345", "234", "1", "23", "1234567" };

Console.WriteLine("Новый массив из строк,длина которых равна или меньше 3 будет выглядеть так:");
GetMassiv(one);

void GetMassiv(string[] arrayOne)
{
    int i = 0;
    int x = 0;
    int count = 0;
    while (i < arrayOne.Length)
    {
        if (arrayOne[i].Length <= 3)
        {
            count++;
        }
        i++;
    }
    i = 0;
    string[] arrayTwo = new string[count];
    while (i < arrayOne.Length)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[x] = arrayOne[i];
            Console.Write(arrayTwo[x] + ", ");
            x++;
        }
        i++;
    }
}
