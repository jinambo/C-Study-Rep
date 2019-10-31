using System;

struct Complex {
    public double imaginarni;

    public Complex(double imaginarni) {
        this.imaginarni = imaginarni;
    }

    public double absolutka() {
        double absolutniHodnota = Math.Abs(imaginarni);
        return absolutniHodnota;
        //return (Convert.ToString(absolutniHodnota) + "i");
    }
}

