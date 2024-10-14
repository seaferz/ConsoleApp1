Даны шесть монет, из которых одна фальшивая. Фальшивая монета отличается 
от настоящей только весом, причем она либо немного тяжелее, либо немного легче. Имея 
рычажные весы, определить ложную монету не более чем за три взвешивания

using System;

class Program
{
    static void Main()
    {
        int[] coins = { 0, 0, 0, 0, 0, 1 }; // 0 - настоящая монета, 1 - фальшивая (может быть легче или тяжелее)
        FindFakeCoin(coins);
    }

    static void FindFakeCoin(int[] coins)
    {
        // Первое взвешивание: сравниваем 1 и 2 с 3 и 4
        int result1 = Compare(coins, new int[] { 0, 1 }, new int[] { 2, 3 });
        if (result1 == 0)
        {
            // Первое взвешивание в равновесии - фальшивая монета среди 5 и 6
            int result2 = Compare(coins, new int[] { 4 }, new int[] { 0 });
            if (result2 == 0)
            {
                Console.WriteLine("Фальшивая монета: 6");
            }
            else
            {
                Console.WriteLine("Фальшивая монета: 5");
            }
        }
        else
        {
            // Первое взвешивание не в равновесии - фальшивая среди 1, 2, 3, 4
            int result2 = Compare(coins, new int[] { 0 }, new int[] { 1 });
            if (result2 == 0)
            {
                // 1 и 2 равны, значит фальшивая - 3 или 4
                int result3 = Compare(coins, new int[] { 2 }, new int[] { 0 });
                if (result3 != 0)
                {
                    Console.WriteLine("Фальшивая монета: 3");
                }
                else
                {
                    Console.WriteLine("Фальшивая монета: 4");
                }
            }
            else
            {
                // 1 и 2 не равны, значит фальшивая либо 1, либо 2
                if (result2 > 0)
                {
                    Console.WriteLine("Фальшивая монета: 1");
                }
                else
                {
                    Console.WriteLine("Фальшивая монета: 2");
                }
            }
        }
    }

    // Функция для взвешивания двух групп монет
    // Возвращает 0, если группы равны, >0 если левая группа тяжелее, <0 если правая группа тяжелее
    static int Compare(int[] coins, int[] left, int[] right)
    {
        int leftWeight = 0;
        int rightWeight = 0;
        foreach (int i in left)
            leftWeight += coins[i];
        foreach (int i in right)
            rightWeight += coins[i];
        return leftWeight - rightWeight;
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
