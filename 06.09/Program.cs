int odd = 0; // ne parni
int even = 0; // parni

int Nep = 0;
int Par = 0;
Console.WriteLine(" перше число діапазону : ") ;
int a = int.Parse(Console.ReadLine());
Console.WriteLine("другке число діапазону: ");
int limit = int.Parse(Console.ReadLine());

while (a <= limit)
{
    if (a % 2 == 0)
    {
        even++;
        Par += a;

    }
    else
    {
        odd++;
        Nep += a;
    }
    a++;
}

Console.WriteLine(" кільківсь не парних: " + odd );
Console.WriteLine(" кількість парних:  " + even);
Console.WriteLine(" сума не парних " + Nep);
Console.WriteLine(" сума парних " + Par);
Console.ReadLine();