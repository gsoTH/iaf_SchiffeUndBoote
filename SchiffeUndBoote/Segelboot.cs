namespace SchiffeUndBoote
{
	class Segelboot : Boot
	{
		private int anzahlMasten;

		public Segelboot(string name, Besitzer besitzer, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int anzahlMasten)
			: base(name, besitzer, laengeInMetern, breiteInMetern, hoheInMetern, tiefgangInMetern)
		{
			this.anzahlMasten = anzahlMasten;
		}
		public int AnzahlMasten
		{
			get
			{
				return anzahlMasten;
			}

			set
			{
				anzahlMasten = value;
			}
		}

		
	}
}
