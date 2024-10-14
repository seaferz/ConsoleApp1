Даны шесть монет, из которых одна фальшивая. Фальшивая монета отличается 
от настоящей только весом, причем она либо немного тяжелее, либо немного легче. Имея 
рычажные весы, определить ложную монету не более чем за три взвешивания

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
