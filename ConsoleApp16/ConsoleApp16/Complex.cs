using System;

struct Complex
{
    public double imaginarni, realne;

    public Complex(double imaginarni, double realne)
    {
        this.imaginarni = imaginarni;
        this.realne = realne;
    }

    public double absolut()
    {
        double hodnota = 0;
        imaginarni = Math.Pow(imaginarni, 2);
        realne = Math.Pow(realne, 2);

       
        return hodnota = Math.Abs(Math.Sqrt(imaginarni + realne));
    }
}