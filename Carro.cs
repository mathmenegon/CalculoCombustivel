using System;

class Carro
{
    public double cAlcool = 8;
    public double cGasolina = 11;

    public void GastoCarro()
    {
        Console.WriteLine("Seu carro roda " + cAlcool + " Km/L no Alcool");
        Console.WriteLine("Seu carro roda " + cGasolina + " Km/L na Gasolina");
    }
}