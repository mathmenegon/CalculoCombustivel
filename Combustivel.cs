using System;

class Combustivel : Carro
{
    public double valorAlcool;
    public double valorGasolina;

    public Combustivel(double valorAlcool, double valorGasolina, double custoAlcool, double custoGasolina)
    {
        this.valorAlcool = valorAlcool;
        this.valorGasolina = valorGasolina;
        this.custoAlcool = custoAlcool;
        this.custoGasolina = custoGasolina;

        ValorLitro();
        GastoCarro();
        GastoLitro();
        Consumo();
        
    }

    public double GastoAlcool()
    {
        return valorAlcool / custoAlcool;
    }

    public double GastoGasolina()
    {
        return valorGasolina / custoGasolina;
    }

    public void ValorLitro()
    {
        Console.WriteLine("Valor do Litro do Alcool R$" + valorAlcool);
        Console.WriteLine("Valor do Litro da Gasolina R$" + valorGasolina);
    }

    public void GastoLitro()
    {
        Console.WriteLine("\nNo Alcool seu carro gasta R$ " + GastoAlcool() + " por km rodado");
        Console.WriteLine("Na Gasolina seu carro gasta R$ " + GastoGasolina() + " por km rodado");
    }

    public void Consumo()
    {
        var retorno = "\nValor não informado corretamente";
        double gastoAlcool = GastoAlcool();
        double gastoGasolina = GastoGasolina();

        if (gastoAlcool > gastoGasolina)
            retorno = "\nCompensa abastecer com Gasolina";
        else
            retorno = "\nCompensa abastecer com Alcool";

        Console.WriteLine(retorno);
    }
}