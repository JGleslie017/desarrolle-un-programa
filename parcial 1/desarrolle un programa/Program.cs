using System.Collections.Generic;
using System;

Console.WriteLine("calcular bisiestos n");
Console.WriteLine("año a calcular \n");
string ano1 = Console.ReadLine();
Console.WriteLine("año final a calcular \n");
string ano2 = Console.ReadLine();
List<int> anosbi = new List<int>();
for (int a = Convert.ToInt32(ano1); a <= Convert.ToInt32(ano2); a++)
{

    if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
    {
        Console.WriteLine("Es bisiesto {0}\n", a);
        anosbi.Add(a);
    }
    else
    {
        Console.WriteLine("no es bisiesto {0} \n", a);
    }
}
Console.WriteLine("+" + anosbi.Count);
Console.ReadKey();