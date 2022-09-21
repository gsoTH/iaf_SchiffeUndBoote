namespace SchiffeUndBoote
{
    abstract class Boot
    {
        protected string name;
        protected Besitzer besitzer;
        protected int laengeInMetern;
        protected int breiteInMetern;
        protected int hoheInMetern;
        protected int tiefgangInMetern;

        protected Boot(string name, Besitzer besitzer, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern)
        {
            this.name = name;
            this.laengeInMetern = laengeInMetern;
            this.breiteInMetern = breiteInMetern;
            this.hoheInMetern = hoheInMetern;
            this.tiefgangInMetern = tiefgangInMetern;
            this.besitzer = besitzer;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public Besitzer Besitzer
        {
            get
            {
                return besitzer;
            }

            set
            {
                besitzer = value;
            }
        }
        public int LaengeInMetern
        {
            get
            {
                return laengeInMetern;
            }

            set
            {
                laengeInMetern = value;
            }
        }
        public int BreiteInMetern
        {
            get
            {
                return breiteInMetern;
            }

            set
            {
                breiteInMetern = value;
            }
        }
        public int HoheInMetern
        {
            get
            {
                return hoheInMetern;
            }

            set
            {
                hoheInMetern = value;
            }
        }
        public int TiefgangInMetern
        {
            get
            {
                return tiefgangInMetern;
            }

            set
            {
                tiefgangInMetern = value;
            }
        }
    }
}