using System;

struct Point2D
{
    public int x;
    public int y;

    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point2D sectiVektory(Point2D vect1, Point2D vect2) {
        Point2D vect3 = new Point2D((vect1.x + vect2.x), (vect1.y + vect2.y));

        return vect3; 
    }

    public Point2D soucinVektoru(Point2D vect1, Point2D vect2)
    {
        Point2D vect3 = new Point2D((vect1.x * vect2.x), (vect1.y * vect2.y));

        return vect3;
    }

    public int skalarniSoucinVektoru(Point2D vect1, Point2D vect2)
    {
        int skalar = (vect1.x * vect2.x) + (vect1.y * vect2.y);

        return skalar;
    }

    public int sectiBody()
    {
        return x + y;
    }
    public int odectiBody()
    {
        return x - y;
    }

    public int vynasobBody()
    {
        return x * y;
    }

    public int vydelBody()
    {
        return x / y;
    }

}