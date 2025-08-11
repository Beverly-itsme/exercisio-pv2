using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Shape
{
    public double Comprimento { get; set; }
    public double Largura { get; set; }
    public double Altura { get; set; }
    public double Raio { get; set; }

    // Construtor para cubo
    public Shape(double comprimento, double largura, double altura)
    {
        Comprimento = comprimento;
        Largura = largura;
        Altura = altura;
    }

    // Construtor para cone
    public Shape(double raio, double altura)
    {
        Raio = raio;
        Altura = altura;
    }

    // Construtor para esfera
    public Shape(double raio, bool esfera)
    {
        Raio = raio;
    }

    public double VolumeCubo()
    {
        return Comprimento * Largura * Altura;
    }

    public double VolumeCone()
    {
        return (Math.PI * Math.Pow(Raio, 2) * Altura) / 3;
    }

    public double VolumeEsfera()
    {
        return (4 * Math.PI * Math.Pow(Raio, 3)) / 3;
    }
}

class ShapeApp
{
    static void Main()
    {
        // Criando um cubo (3,3,3)
        Shape cubo = new Shape(3, 3, 3);

        // Criando um cone (raio=2, altura=5)
        Shape cone = new Shape(2, 5);

        // Criando uma esfera (raio=4, true para diferenciar)
        Shape esfera = new Shape(4, true);

        Console.WriteLine($"Volume do Cubo: {cubo.VolumeCubo():F2}");
        Console.WriteLine($"Volume do Cone: {cone.VolumeCone():F2}");
        Console.WriteLine($"Volume da Esfera: {esfera.VolumeEsfera():F2}");
    }
}
