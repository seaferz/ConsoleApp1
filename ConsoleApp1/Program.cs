Даны шесть монет, из которых одна фальшивая. Фальшивая монета отличается 
от настоящей только весом, причем она либо немного тяжелее, либо немного легче. Имея 
рычажные весы, определить ложную монету не более чем за три взвешивания

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите вес монеты 1: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вес монеты 2: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вес монеты 3: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вес монеты 4: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вес монеты 5: ");
        double e = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вес монеты 6: ");
        double f = Convert.ToDouble(Console.ReadLine());

        // Первое взвешивание: взвешиваем (1, 2, 3) против (4, 5, 6)
        if (a + b + c == d + e + f)
        {
            // Если равны, значит фальшивая монета не среди этих шести
            Console.WriteLine("Фальшивая монета не найдена.");
        }
        else if (a + b + c > d + e + f)
        {
            // Если (1, 2, 3) тяжелее, значит фальшивая монета среди 1, 2, 3, и она тяжелее или фальшивая среди 4, 5, 6 и она легче.
            // Второе взвешивание: взвешиваем (1) против (2)
            if (a == b)
            {
                // Если равны, значит фальшивая монета — 3, и она тяжелее.
                Console.WriteLine("Фальшивая монета - 3 (тяжелее)");
            }
            else if (a > b)
            {
                // Если (1) тяжелее, то 1 — фальшивая и тяжелее.
                Console.WriteLine("Фальшивая монета - 1 (тяжелее)");
            }
            else
            {
                // Если (2) тяжелее, то 2 — фальшивая и тяжелее.
                Console.WriteLine("Фальшивая монета - 2 (тяжелее)");
            }
        }
        else
        {
            // Если (4, 5, 6) тяжелее, значит фальшивая монета среди 4, 5, 6, и она тяжелее или среди 1, 2, 3 и она легче.
            // Второе взвешивание: взвешиваем (4) против (5)
            if (d == e)
            {
                // Если равны, значит фальшивая монета — 6, и она легче.
                Console.WriteLine("Фальшивая монета - 6 (легче)");
            }
            else if (d > e)
            {
                // Если (4) тяжелее, то 4 — фальшивая и тяжелее.
                Console.WriteLine("Фальшивая монета - 4 (тяжелее)");
            }
            else
            {
                // Если (5) тяжелее, то 5 — фальшивая и тяжелее.
                Console.WriteLine("Фальшивая монета - 5 (тяжелее)");
            }
        }
    }
}


Console.Write("Vvdi a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvdi b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvdi c = ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvdi d = ");
double d = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvdi e = ");
double e = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvdi f = ");
double f = Convert.ToDouble(Console.ReadLine());

//Если группы равны, значит фальшивой монеты среди этих групп нет
if (a + b + c == d + e + f)
{
    Console.WriteLine("Фальшивая монета вне этих монет");
}

//Если левая группа легче, значит фальшивая монета среди правой группы
else if (a + b + c > d + e + f)

//Взвешиваем монеты 1 и 2
{
    if (d == e)
    {
        //если они равны, значит 6 монета тяжелее и она фальшивая
        Console.WriteLine("Фальшивая монета - 6");
    }

    //взвешиваем 4 и 5 монеты
    else if (d < e)
    {
        //если 4 легче, значит 5 монета фальшивая
        Console.WriteLine("Фальшивая монета - 5");
    }
    else
    {
        Console.WriteLine("Фальшивая монета - 4");
    }
}

//если правая группа легче, значит фальшивая монета в левой группе
else
{
    //если 1 и 2 равны, значит фальшивая 3
    if (a == b)
    {
        Console.WriteLine("Фальшивая монета - 3");
    }

    //если 1 легче 2, значит фальшивая - 2
    else if (a < b)
    {
        Console.WriteLine("Фальшивая монета - 1");
    }

    //если 1 тяжелее 2, фальшивая - 2
    else
    {
        Console.WriteLine("Фальшивая монета - 2");
    }

}
