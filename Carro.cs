using System;

class Carro
{
    public double custoAlcool;
    public double custoGasolina;

    public void GastoCarro()
    {
        Console.WriteLine("\nCarro com autonomia de " + custoAlcool + " Km/L no Alcool");
        Console.WriteLine("Carro com autonomia de " + custoGasolina + " Km/L na Gasolina");
    }
}