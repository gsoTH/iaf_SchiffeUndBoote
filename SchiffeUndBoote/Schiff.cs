namespace SchiffeUndBoote
{
    abstract class Schiff
    {
        protected string name;
        protected Land land;
        protected int laengeInMetern;
        protected int breiteInMetern;
        protected int hoheInMetern;
        protected int tiefgangInMetern;
        protected int leistungInKw;

        protected Schiff(string name, Land land, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int leistungInKw)
        {
            this.name = name;
            this.land = land;
            this.laengeInMetern = laengeInMetern;
            this.breiteInMetern = breiteInMetern;
            this.hoheInMetern = hoheInMetern;
            this.tiefgangInMetern = tiefgangInMetern;
            this.leistungInKw = leistungInKw;
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

        public Land Land
        {
            get
            {
                return land;
            }

            set
            {
                land = value;
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
        public int LeistungInKw
        {
            get
            {
                return leistungInKw;
            }

            set
            {
                leistungInKw = value;
            }
        }
    }
}