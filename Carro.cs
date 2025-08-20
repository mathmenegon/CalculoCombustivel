using System;

class Carro
{
    public double cAlcool;
    public double cGasolina;

    public void GastoCarro()
    {
        Console.WriteLine("Seu carro roda " + cAlcool + " Km/L no Alcool");
        Console.WriteLine("Seu carro roda " + cGasolina + " Km/L na Gasolina");
    }
}