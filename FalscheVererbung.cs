namespace vererbung_fehlerhaft
{
    public static void main()
    {
        // Klasse Besitzer in diesem Beispiel ausgelassen
        // Erzeugen von Objekten funktioniert jedenfalls:
        // Sportboot sport = new Sportboot("Unsinbar I", 2, 1, 1, 1, 15, new Besitzer(...))
    }

    abstract class Boot:WasserFahrzeuge
    {
        protected string name;
        protected Besitzer besitzer;
    }


    abstract class WasserFahrzeuge
    {
        protected int laengeInMetern;
        protected int breiteInMetern;
        protected int hoheInMetern;
        protected int tiefgangInMetern;
    }


    class Segelboot:Boot
    {
        private int anzahlMasten;

        public Segelboot(string name, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int anzahlMasten, Besitzer besitzer)
        {
            this.name = name;
            this.laengeInMetern = laengeInMetern;
            this.breiteInMetern = breiteInMetern;
            this.hoheInMetern = hoheInMetern;
            this.tiefgangInMetern = tiefgangInMetern;
            this.besitzer = besitzer;
            this.anzahlMasten = anzahlMasten;

        }
    }


    class Sportboot:Boot
    {
        private int leistungInKw;

        public Sportboot(string name, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int leistungInKw, Besitzer besitzer)
        {
            this.name = name;
            this.laengeInMetern = laengeInMetern;
            this.breiteInMetern = breiteInMetern;
            this.hoheInMetern = hoheInMetern;
            this.tiefgangInMetern = tiefgangInMetern;
            this.besitzer = besitzer;
            this.leistungInKw = leistungInKw;
        }
    }
}
