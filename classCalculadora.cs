using System;
using System.Diagnostics;

class Calculadora
{
    private int x;

    public int X { get => x; set => x = value;}

    public Calculadora(int num){X = num;}

    public void Suma(int num){X += num;}
    public void Resta(int num){X -= num;}
    public void Multp(int num){X *= num;}
    public void Div(int num){X = (num != 0)? X/=num : X = 0;}
    public void Limpiar(){X = 0;}
}