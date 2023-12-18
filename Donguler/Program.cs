// See https://aka.ms/new-console-template for more information
for(int i=0;i<=100;i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("**************ÇİFT SAYILAR*****************");
for(int i=0;i<=100;i=i+2)
{
    Console.WriteLine(i);
}

Console.WriteLine("**************TEK SAYILAR*****************");
for(int i=1;i<=100;i=i+2)
{
    Console.WriteLine(i);
}
Console.WriteLine("**************5'er 5'er SAYILAR*****************");
for(int i=0;i<=100;i=i+5)
    Console.WriteLine(i);
{
}

Console.WriteLine("**************FARKLI YÖNTEM*****************");
for(int i=0;i<=100;i++)
{
    if(i%2==0)
    { Console.WriteLine(i);}
}

Console.WriteLine("**************HARFLER*****************");
for(char i='a'; i<='z' ; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("**************DO....WHİLE*****************");
int sayi = 100; //!!!!Bu döngü nolursa olsun en az 1 kez çalışır...!!!
do
{
    Console.WriteLine(sayi);
} while (sayi < 100);

Console.WriteLine("**************WHİLE*****************");
int sayi2 = 100;
while(sayi2<100)
{
    Console.WriteLine(sayi2);
    sayi2++;
}