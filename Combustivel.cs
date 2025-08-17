using System;

class Combustivel : Carro
{
    public double vAlcool = 3.45;
    public double vGasolina = 5.50;

    public Combustivel(double cAlcool, double cGasolina, double vAlcool, double vGasolina)
    {

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
            retorno = "Compensa abastercer com Gasolina";
        else
            retorno = "Compensa abastercer com Alcool";

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