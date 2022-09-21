using System;

namespace SchiffeUndBoote
{
    public class Program
    {
        public static void Main()
        {
            Land china = new Land("China", "CH");
            Land deutschland = new Land ("Deutschland", "D");
            Land uk = new Land("United Kindgom", "UK");

            Besitzer chef = new Besitzer("Sherlock", "Holmes", "Baker Street", "221B", "NW1", "London", uk);


            Containerschiff c = new Containerschiff("Ever Given", china, 400,59, 33, 16, 20124, 59300);
            Tankschiff t = new Tankschiff("CABO SOUNION", deutschland, 229, 32, 15, 8, 40000, 20000);
            Segelboot falke = new Segelboot("Unsinkbar II", chef, 5, 3, 2, 1, 1);
            Sportboot iltis = new Sportboot("Unsink-Bar", chef, 16, 5, 5, 3, 25);
        }
    }
}