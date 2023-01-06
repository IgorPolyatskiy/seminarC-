int a,b,max,min;  
  
Console.WriteLine("Введите два числа ");  
a = int.Parse(Console.ReadLine());  
b = int.Parse(Console.ReadLine());  
if (a < b)  
{  
    max = b;  
    min = a;  
}  
else  
{  
    max = a;  
    min = b;  
}  
Console.WriteLine($"max= {max}");  
Console.WriteLine($"min= {min}");