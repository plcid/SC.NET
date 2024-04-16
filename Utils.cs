using HtmlAgilityPack;

namespace scnet
{
    public static class Utils
    {
        public static Scraper scr = new Scraper("none");
        // convert season year to season ID
        static int startYear = 1996;
        public static int yearToSeason(int yr) { return yr - startYear; }
    }
}