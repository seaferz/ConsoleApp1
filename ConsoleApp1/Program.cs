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

        // Если группы равны, значит фальшивой монеты среди этих групп нет
        if (a + b + c == d + e + f)
        {
            Console.WriteLine("Фальшивая монета вне этих монет");
        }
        // Если левая группа тяжелее, значит фальшивая монета в правой группе
        else if (a + b + c > d + e + f)
        {
            // Взвешиваем монеты 4 и 5
            if (d == e)
            {
                // Если они равны, значит 6 - фальшивая
                Console.WriteLine("Фальшивая монета - 6");
            }
            else if (d < e)
            {
                // Если 4 легче, значит 5 - фальшивая
                Console.WriteLine("Фальшивая монета - 5");
            }
            else
            {
                // Если 5 легче, значит 4 - фальшивая
                Console.WriteLine("Фальшивая монета - 4");
            }
        }
        // Если правая группа тяжелее, значит фальшивая монета в левой группе
        else
        {
            // Взвешиваем 1 и 2
            if (a == b)
            {
                // Если они равны, значит 3 - фальшивая
                Console.WriteLine("Фальшивая монета - 3");
            }
            else if (a < b)
            {
                // Если 1 легче, значит 2 - фальшивая
                Console.WriteLine("Фальшивая монета - 1");
            }
            else
            {
                // Если 2 легче, значит 1 - фальшивая
                Console.WriteLine("Фальшивая монета - 2");
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
