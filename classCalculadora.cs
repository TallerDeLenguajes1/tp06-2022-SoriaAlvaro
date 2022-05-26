using System;
using System.Diagnostics;

class Calculadora
{
    private double x;

    public double X { get => x; set => x = value;}

    public Calculadora(double num){X = num;}

    public void Suma(double num){X += num;}
    public void Resta(double num){X -= num;}
    public void Multp(double num){X *= num;}
    public void Div(double num){X = (num != 0)? X/=num : X = 0;}
    public void Limpiar(){X = 0;}
}