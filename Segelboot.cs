namespace SchiffeUndBoote
{
	class Segelboot
	{
		private string name;
		private Besitzer besitzer;
		private int laengeInMetern;
		private int breiteInMetern;
		private int hoheInMetern;
		private int tiefgangInMetern;
		private double segelflaecheInQm2;

		public Segelboot(string name, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int segelflaecheInQm2, Besitzer besitzer)
		{
			this.name = name;
			this.laengeInMetern = laengeInMetern;
			this.breiteInMetern = breiteInMetern;
			this.hoheInMetern = hoheInMetern;
			this.tiefgangInMetern = tiefgangInMetern;
			this.segelflaecheInQm2 = segelflaecheInQm2;
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
		public int SegelflaecheInQm2
		{
			get
			{
				return segelflaecheInQm2;
			}

			set
			{
				segelflaecheInQm2 = value;
			}
		}

		
	}
}
