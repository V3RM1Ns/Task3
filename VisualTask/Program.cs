// Verilmiş 3 rəqəmli ədədin rəqəmlərinin hasilini tapan alqoritm.
//Misalçün alqoritmə 231 ədədini daxil etdikdə 2*3*1 in nəticəsini verməlidir.
using Internal;
using System;

int abc = Convert.ToInt32(Console.ReadLine());
int a = abc / 100;
int b = abc / 10 % 10;
int c = abc % 10;
Console.WriteLine(a * b * c);


//Supermarketdə belə bir aksiya keçirilir: 3 məhsul aldıqda ən ucuz məhsul pulsuz olur.
//Misalçün 40 , 50 və 20 manatlıq mıəhsullar alsam ümumilikdə 40+50 manat ödənilir.
//3 Mıhsulun qiyməti verildikdə müştərinin nə qədər ödəməli olduğunu tapan alqoritm
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int min = a;
if (b < min)
{
    min = b;
}
if (c < min)
{
    min = c;
}
Console.WriteLine(a + b + c - min);



//a ədədi 3-ə bölünən cüt ədəddirsə "3-e bolunur cutdur"
//,3-ə bölünən tək ədəddirsə " ,3-e bolunur tekdir"
//əks halda "3-e bolunmur" sözünü ekranda çap edin.

int a = Convert.ToInt32(Console.ReadLine());
if (a % 6 == 0)
{
    Console.WriteLine("3e bolunur cutdur");
}
else if (a % 3 == 0)
{
    Console.WriteLine("3e bolunur tekdir");
}
else
{
    Console.WriteLine("3e bolunmur");
}



//Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.

int a = Convert.ToInt32(Console.ReadLine());
if (a < 2)
{
    Console.WriteLine("ne sade ne murekkeb");
}
else
{
    bool sade = true;
    for (int i = 2; i * i <= a; i++)
    {
        if (a % i == 0)
        {
            sade = false;
            break;
        }
    }
    if (sade)
    {
        Console.WriteLine("sade");
    }
    else
    {
        Console.WriteLine("Murekkeb");
    }
}



//X, Y, Z  ədədləri verilib. Bu ədədlərin ən kiçiyini tapan alqoritm qurun

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int min = x;
if (y < min)
{
    min = y;
}
if (z < min)
{
    min = z;
}
Console.WriteLine(min);



//Verilmiş N ədədinin 3-ə və 7-ə bölünüb bölünmədiyini tapan alqoritm qurun

int a = Convert.ToInt32(Console.ReadLine());
if (a % 21 == 0)
{
    Console.WriteLine("3 ve 7 bolunur ");
}

else
{
    Console.WriteLine("3 ve 7 bolunmur");
}



//Verilmiş 3 ədəddən müsbət olanların sayını tapan alqoritm

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int say = 0;
if (a > 0)
{
    say++;
}
if (b > 0)
{
    say++;
}
if (c > 0)
{
    say++;
}
Console.WriteLine(say);


//Verilmiş M ədədindən verilmiş N ədədinədək olan ədədlərin cəmini tapan alqoritm

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int cem = 0;
for (int i = m; i <= n; i++)
{
    cem += i;

}
Console.WriteLine(cem);


//1-dən M-ədək ədədlər içərisində 15-ə bölünən ədədlərin sayını tapan alqoritm

int m = Convert.ToInt32(Console.ReadLine());
int say = 0;
for (int i = 1; i <= m; i++)
{
    if (i % 15 == 0)
    {
        say += 1;
    }
    else
    {
        continue;
    }
}
Console.WriteLine(say);


//1-dən M-ədək ədədlər içərisində 21-ə bölünən ədədlərin ədədi ortasını tapan alqoritm

int m = Convert.ToInt32(Console.ReadLine());
int cem = 0;
int say = 0;
for (int i = 1; i <= m; i++)
{
    if (i % 21 == 0)
    {
        cem += i;
        say++;
    }
}
if (say > 0)
{
    Console.WriteLine((float)cem / say);
}


//Verilmiş N ədədinin rəqəmlərinin cəmini tapan alqoritm. (ədəd 3 və ya daha cox rəqəmdən ibarət ola bilər)

long a = Convert.ToInt64(Console.ReadLine());
long cem = 0;
while (a > 0)
{
    cem += a % 10;
    a /= 10;
}
Console.WriteLine(cem);
