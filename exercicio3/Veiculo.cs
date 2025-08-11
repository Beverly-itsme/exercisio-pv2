/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Motor
{
    public bool Ligado { get; private set; }

    public void Ligar()
    {
        Ligado = true;
        Console.WriteLine("Motor ligado.");
    }

    public void Desligar()
    {
        Ligado = false;
        Console.WriteLine("Motor desligado.");
    }
}

class Veiculo
{
    public Motor Motor { get; private set; }
    public double DistanciaPercorrida { get; private set; }
    public double DistanciaDestino { get; private set; }
    public double Velocidade { get; private set; }

    public Veiculo(double distanciaDestino, double velocidade)
    {
        DistanciaDestino = distanciaDestino;
        Velocidade = velocidade;
        Motor = new Motor();
        DistanciaPercorrida = 0;
    }

    public void Viajar()
    {
        Motor.Ligar();

        while (DistanciaPercorrida < DistanciaDestino)
        {
            DistanciaPercorrida += Velocidade;

            if (DistanciaPercorrida > DistanciaDestino)
                throw new Exception("Tentativa de viajar além do destino!");

            Console.WriteLine($"Distância percorrida: {DistanciaPercorrida} km");
        }

        Motor.Desligar();
        Console.WriteLine("Destino alcançado!");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite a distância até o destino (km): ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade por etapa (km): ");
            double velocidade = double.Parse(Console.ReadLine());

            Veiculo carro = new Veiculo(distancia, velocidade);
            carro.Viajar();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}*/

