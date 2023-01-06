int a,b,c;
int max = 0;

Console.WriteLine("Введите три числа ");
a = int.Parse(Console.ReadLine());  
b = int.Parse(Console.ReadLine()); 
c = int.Parse(Console.ReadLine());

if(a>b)
{
    max=a;
}
else
{
    max=b;
}
if(max<c)max=c;

Console.Write("max= "); 
Console.Write(max); 