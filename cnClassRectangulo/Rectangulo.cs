using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangulo
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public double CalcularArea()
    {
        return Ancho * Alto;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Ancho + Alto);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa de cálculo de área y perímetro de un rectángulo");

        Rectangulo rectangulo = new Rectangulo();

        Console.Write("Ingrese el ancho del rectángulo: ");
        rectangulo.Ancho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el alto del rectángulo: ");
        rectangulo.Alto = Convert.ToDouble(Console.ReadLine());

        double area = rectangulo.CalcularArea();
        double perimetro = rectangulo.CalcularPerimetro();

        Console.WriteLine("Área del rectángulo: " + area);
        Console.WriteLine("Perímetro del rectángulo: " + perimetro);

        Console.ReadLine();

        Console.ReadKey();
    }
}