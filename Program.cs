﻿using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

double a;
double b;
double c;
double delta;
double raiz;
double x1;
double x2;

Console.Clear();
Console.WriteLine( "-- Equação do segundo grau -- " );

while (true)
{
    Console.WriteLine("insira o valor de a...:");
    if (double.TryParse(Console.ReadLine(), out a ))
    {
        break;
    }
    Console.WriteLine("ERRO: por favor, insira um número válido.");
}
while (true)
{
    Console.WriteLine("insira o valor de b...:");
    if (double.TryParse(Console.ReadLine(), out b ))
    {
        break;
    }
    Console.WriteLine("ERRO: por favor, insira um número válido.");
}

while (true)
{
    Console.WriteLine("insira o valor de c...:");
    if (double.TryParse(Console.ReadLine(), out c ))
    {
        break;
    }
    Console.WriteLine("ERRO: por favor, insira um número válido.");
}

delta = (b * b) - (4 * a * c);
raiz = Math.Sqrt(delta);


Console.WriteLine($"delta...:{delta:N2}");
if(delta < 0)
{
    Console.WriteLine("não existem raizes reais");
}
else if (delta==0)
{
    x1 = (-b + raiz) / (2 * a);
    Console.WriteLine($"delta =0 , valores de x1 e x2 são iguais...{x1} ");

}

else 
{
    x1 = (-b +raiz) / (2 * a);
     x2 = (-b - raiz) / (2 * a);
    
    Console.WriteLine($"raiz de delta...:{raiz:n2}");
    Console.WriteLine($"x1...:{x1:n2}");
    Console.WriteLine($"x2...:{x2:n2}");
    
}
