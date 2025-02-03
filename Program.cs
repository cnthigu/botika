using System;
using Ikariambot;

class Program
{
    static void Main()
    {
        int idNumber;
        int coordenadaX;
        int coordenadaY;
        int quantidadeCatapulta, quantidadeHoplita;
        
        Console.Clear();

        string asciiArt = @"
                    ██╗██╗  ██╗ █████╗ 
                    ██║██║ ██╔╝██╔══██╗
                    ██║█████╔╝ ███████║  
                    ██║██╔═██╗ ██╔══██║
                    ██║██║  ██╗██║  ██║
                    ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝";
        Console.WriteLine(asciiArt);
        Console.WriteLine("Carregando o Ataque....");

            /// ID DA CIDADE///
        while (true)
        {
            Console.Write("Qual ID da Colonia deseja atacar? ");
            if (int.TryParse(Console.ReadLine(), out idNumber) && idNumber >= 0 && idNumber <= 16)
            {
                break;
            }
            else
            {
                Console.WriteLine("Número inválido. Tente novamente.");
            }
        }
        ///CORDENADAS X  Y////
        while (true)
        {
            Console.Write("Digite a coordenada X: ");
            if (int.TryParse(Console.ReadLine(), out coordenadaX) && coordenadaX >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Coordenada X inválida. Tente novamente.");
            }
        }
        while (true)
        {
            Console.Write("Digite a coordenada Y: ");
            if (int.TryParse(Console.ReadLine(), out coordenadaY) && coordenadaY >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Coordenada Y inválida. Tente novamente.");
            }
        }
        ///// QUANTIDADE DE TROPAS.. /////
        while (true)
        {
            Console.Write("Digite a quantidade de catapulta(recomendado 36) => ?: ");
            if (int.TryParse(Console.ReadLine(), out quantidadeCatapulta) && quantidadeCatapulta >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Quantidade Catapulta inválida. Tente novamente.");
            }
        }
        while (true)
        {
            Console.Write("Digite a quantidade de catapulta(recomendado 50) => ?: ");
            if (int.TryParse(Console.ReadLine(), out quantidadeHoplita) && quantidadeHoplita >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("quantidade Hoplita inválida. Tente novamente.");
            }
        }


        string xpath = $"//*[@id=\"js_cityLocation{idNumber}Link\"]";
        Console.WriteLine($"XPath gerado: {xpath}");

        ikaboattack attack = new ikaboattack();
        attack.SendAttack(xpath, coordenadaX, coordenadaY, quantidadeCatapulta, quantidadeHoplita);
        Console.WriteLine("Ataque finalizado....!");
    }
}