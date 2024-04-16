using HtmlAgilityPack;

namespace scnet
{
    public class Meet
    {
        public int ID { get; }
        private string page;
        public Meet(int id) 
        {
            ID = id;
            page = "https://www.swimcloud.com/results/" + id;
        }

        public async Task<string> getName()
        {
            await Utils.scr.SetPage(page);

            var name = (await Utils.scr.getNodeListContaining("h1", "id", "meet-name")).ToList()[0];
            return name.InnerText.Trim();
        }
    }
}