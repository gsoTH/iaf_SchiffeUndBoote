namespace SchiffeUndBoote
{
	class Sportboot : Boot
    {
        private int leistungInKw;

		public Sportboot(string name, Besitzer besitzer, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int leistungInKw)
			:base(name, besitzer, laengeInMetern, breiteInMetern, hoheInMetern, tiefgangInMetern)
		{
			this.leistungInKw = leistungInKw;
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
