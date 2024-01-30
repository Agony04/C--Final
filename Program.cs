using System;

public class Sekil
{
    public double En, Boy;

    public Sekil(double boy, double en)
    {
        this.Boy = boy;
        this.En = en;
    }
    public virtual double Alan()
    {
        return 0;
    }
}

public class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en)
    :base(boy, en) // parametredeki boy ve eni base classtan al
    {
        
    }
    public override double Alan()
    {
        return En * Boy;
    }
}

public class Ucgen : Sekil
{
    public Ucgen(int boy, int en)
        :base(boy, en) // parametredeki boy ve eni base classtan al
    {
        
    }
    public override double Alan()
    {
        return En * Boy / 2;
    }
}

public class DrawDemo
{
    public static void Main()
    {
        Ucgen ucgen = new Ucgen(10, 20); // instance'da constructor parametleri verilmek zorundadır.
        AlanBul(ucgen);
        Dikdortgen dikdortgen = new Dikdortgen(10, 20);
        AlanBul(dikdortgen);
        Sekil sekil = new Sekil(10, 20);
        AlanBul(sekil);
        Console.Read();
    }

    public static void AlanBul(Sekil sekil)
    {
        Console.WriteLine("Alan :" + sekil.Alan());
    }
}