
using System;
using System.Collections.Generic;
using System.Linq;

public class GraWTysiaca:Form
{
    public class Karta
    {
        public string Kolor { get; set; }
        public string Figura { get; set; }
        public int Wartosc { get; set; }

        public override string ToString() => $"{Figura} {Kolor}";
    }

    private List<Karta> talia = new();
    private List<Karta>[] receGraczy;
    private Dictionary<string, int> wartosciFigur = new()
    {
        { "As", 11 },
        { "Dziesiątka", 10 },
        { "Król", 4 },
        { "Dama", 3 },
        { "Walet", 2 },
        { "Dziewiątka", 0 }
    };

    private string[] kolory = { "Kier", "Karo", "Trefl", "Pik" };
    private string[] figury = { "As", "Dziesiątka", "Król", "Dama", "Walet", "Dziewiątka" };

    public int[] Wyniki { get; private set; }

    public GraWTysiaca(int liczbaGraczy)
    {
        if (liczbaGraczy is < 2 or > 3)
            throw new ArgumentException("Gra w Tysiąca wymaga 2 lub 3 graczy.");

        receGraczy = new List<Karta>[liczbaGraczy];
        Wyniki = new int[liczbaGraczy];

        for (int i = 0; i < liczbaGraczy; i++)
            receGraczy[i] = new List<Karta>();

        InicjalizujTalie();
        PotasujTalie();
        RozdajKarty();
    }

    private void InicjalizujTalie()
    {
        talia.Clear();
        foreach (var kolor in kolory)
        {
            foreach (var figura in figury)
            {
                talia.Add(new Karta
                {
                    Kolor = kolor,
                    Figura = figura,
                    Wartosc = wartosciFigur[figura]
                });
            }
        }
    }

    private void PotasujTalie()
    {
        Random rng = new();
        talia = talia.OrderBy(_ => rng.Next()).ToList();
    }

    private void RozdajKarty()
    {
        int indeks = 0;
        foreach (var reka in receGraczy)
        {
            reka.Clear();
            for (int i = 0; i < 10; i++)
                reka.Add(talia[indeks++]);
        }
    }

    public IEnumerable<Karta> PobierzRekeGracza(int indeksGracza)
    {
        return receGraczy[indeksGracza];
    }

    public void ZagrajLewe(Karta[] zagraneKarty)
    {
        if (zagraneKarty.Length != receGraczy.Length)
            throw new ArgumentException("Nieprawidłowa liczba zagranych kart.");

        int wygrywajacy = 0;
        Karta najwyzsza = zagraneKarty[0];

        for (int i = 1; i < zagraneKarty.Length; i++)
        {
            if (zagraneKarty[i].Kolor == najwyzsza.Kolor &&
                zagraneKarty[i].Wartosc > najwyzsza.Wartosc)
            {
                najwyzsza = zagraneKarty[i];
                wygrywajacy = i;
            }
        }

        int punkty = zagraneKarty.Sum(k => k.Wartosc);
        Wyniki[wygrywajacy] += punkty;
    }

    public bool CzyKoniecGry()
    {
        return Wyniki.Any(wynik => wynik >= 1000);
    }

    public int PodajZwyciezce()
    {
        int max = Wyniki.Max();
        return Array.IndexOf(Wyniki, max);
    }
}
