using System;
using System.ComponentModel.Design;

class Combustivel : Carro
{
    public double valorAlcool;
    public double valorGasolina;

    public void Main()
    {
        Menu();
    }

    public void Menu(){
        Console.WriteLine("Informe o valor do litro do Alcool: ");
        valorAlcool = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor do litro da Gasolina: ");
        valorGasolina = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a autonomia do carro com Alcool (Km/L): ");
        custoAlcool = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a autonomia do carro com Gasolina (Km/L): ");
        custoGasolina = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine("Analisando os dados informados...");
        Thread.Sleep(1000);
        Console.Clear();
        Atribuicao(valorAlcool, valorGasolina, custoAlcool, custoGasolina);
    }

    public void Atribuicao(double valorAlcool, double valorGasolina, double custoAlcool, double custoGasolina)
    {
        this.valorAlcool = valorAlcool;
        this.valorGasolina = valorGasolina;
        this.custoAlcool = custoAlcool;
        this.custoGasolina = custoGasolina;

        ValorLitro();
        GastoCarro();
        GastoLitro();
        Consumo();
        SairVoltar();

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

    public void SairVoltar()
    {
        Console.WriteLine("\nDeseja voltar ao menu inicial? (S/N)");
        string resposta = Console.ReadLine().ToUpper();
        if (resposta == "S")
        {
            Console.Clear();
            Menu();
        }
        else if (resposta == "N")
        {
            Console.WriteLine("Saindo...");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Opção inválida. Saindo...");
            Thread.Sleep(1000);
            SairVoltar();
        }
    }

}