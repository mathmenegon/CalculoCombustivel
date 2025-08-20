using System;

class Combustivel : Carro
{
    public double vAlcool;
    public double vGasolina;

    public Combustivel(double vAlcool, double vGasolina, double cAlcool, double cGasolina)
    {
        this.vAlcool = vAlcool;
        this.vGasolina = vGasolina;
        this.cAlcool = cAlcool;
        this.cGasolina = cGasolina;

        ValorLitro();
        GastoLitro();
        GastoCarro();
        Consumo();
        
    }

    public double GastoAlcool()
    {
        return vAlcool / cAlcool;
    }

    public double GastoGasolina()
    {
        return vGasolina / cGasolina;
    }

    public void Consumo()
    {
        var retorno = "Valor não informado corretamente";
        double gastoAlcool = GastoAlcool();
        double gastoGasolina = GastoGasolina();

        if (gastoAlcool > gastoGasolina)
            retorno = "Compensa abastecer com Gasolina";
        else
            retorno = "Compensa abastecer com Alcool";

        Console.WriteLine(retorno);
    }

    public void ValorLitro()
    {
        Console.WriteLine("Valor do Litro do Alcool " + vAlcool);
        Console.WriteLine("Valor do Litro da Gasolina " + vGasolina);
    }

    public void GastoLitro()
    {
        Console.WriteLine("No Alcool seu carro gasta R$ " + GastoAlcool() + " por km rodado");
        Console.WriteLine("Na Gasolina seu carro gasta R$ " + GastoGasolina() + " por km rodado");
    }
}