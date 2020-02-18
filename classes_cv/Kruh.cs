using System;

class Kruh {
    public double polomer;

    public Kruh(double polomer) {
        this.polomer = polomer;
    }

    public double obsahKruhu() {
        double obsah = Math.PI * Math.Pow(polomer, 2);

        return obsah;
    }

    public double obvodKruhu() {
        double obvod = 2 * Math.PI * polomer;

        return obvod;
    }

    public string porovnejPolomery(Kruh kruh1, Kruh kruh2) {
        if (kruh1.obvodKruhu() == kruh2.obvodKruhu()) {
            return "Polomer je stejnej.";
        } else {
            return "Polomer neni stejnej.";
        }
    }
}