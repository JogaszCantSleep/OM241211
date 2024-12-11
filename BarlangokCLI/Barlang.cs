﻿namespace BarlangokCLI;

internal class Barlang
{
    private int melyseg = 0;
    private int hossz = 0;

    public int Azon { get; private set; }
    public string Nev { get; private set; }

    public int Hossz
    {
        get => hossz;
        set
        {
            if (value >= hossz) hossz = value;
        }
    }

    public int Melyseg
    {
        get => melyseg;
        set
        {
            if (value >= melyseg) melyseg = value;
        }
    }

    public string Telepules { get; private set; }
    public string Vedettseg { get; private set; }

    public Barlang(string sor)
    {
        string[] m = sor.Split(';');
        Azon = int.Parse(m[0]);
        Nev = m[1];
        Hossz = int.Parse(m[2]);
        Melyseg = int.Parse(m[3]);
        Telepules = m[4];
        Vedettseg = m[5];
    }

    public override string ToString() => 
        $"\tAzon: {Azon}\n\t" +
        "Név: {Nev}\n\t" +
        "Hossz: {Hossz} m\n\t" +
        "Mélység: {Melyseg} m\n\t" +
        "Település: {Telepules}";
}