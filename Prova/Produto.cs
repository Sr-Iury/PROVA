using System;
public class Produto
{
    public double Verfica(double valor, double imp1, double imp2, double imp3, double lucro)
    {
        double imposto = (((imp1 + imp2 + imp3) / 100.0) * valor);
        double dinheiro = valor + imposto;
        double lucro1 = ((lucro / 100.0) * dinheiro);
        double total = lucro1 + dinheiro;
        return total;
    }
}