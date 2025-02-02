using System;
using Ikariambot;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Carregando o Ataque....");
        ikaboattack attack = new ikaboattack();
        attack.SendAttack();
        Console.WriteLine("Ataque finalizado....!");


    }
}