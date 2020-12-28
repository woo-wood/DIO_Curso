using System;

namespace Distancia_DIO
{
    class Program
    {
        static void Main() {
        Console.WriteLine("digite a distancia percorrida");
        int quilometros = Int32.Parse(Console.ReadLine());
        int minutos = quilometros * 60 / 30; // Digite aqui o calculo dos minutos
        Console.WriteLine(minutos + " minutos");
    }
}
}
