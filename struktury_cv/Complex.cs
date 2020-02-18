using System;

struct Complex {
    public double imaginarni;
    public double realne;

    public Complex(double imaginarni, double realne) {
        this.imaginarni = imaginarni;
        this.realne = realne;
    }

    public double absolutka() {
        double hodnota;

        imaginarni = Math.Pow(imaginarni, 2);
        realne = Math.Pow(realne, 2);
        hodnota = Math.Sqrt(imaginarni + realne);

        return Math.Abs(hodnota);
    }
}

