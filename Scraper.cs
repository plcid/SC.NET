using HtmlAgilityPack;

namespace scnet
{
    public class Scraper
    {
        private string url;
        private bool initF;

        HttpClient client;
        string html;
        HtmlDocument doc;

        public Scraper(string url) 
        {
            this.url = url;
        }

        private async Task Initialize()
        {
            client = new HttpClient();
            html = await client.GetStringAsync(url);
            doc = new HtmlDocument();
            doc.LoadHtml(html);

            initF = true;
        }

        public async Task SetPage(string newurl)
        {
            if (newurl != url)
            {
                url = newurl;
                await Initialize();
            }
        }

        public async Task<List<HtmlNode>> getNodeListContaining(string nodeType, string attribute, string value)
        {
            if (!initF) await Initialize();

            var nodes = doc.DocumentNode.Descendants(nodeType)
                .Where(node => node.GetAttributeValue(attribute, "")
                .Contains(value)).ToList();

            return nodes;
        }

        public async Task<IEnumerable<HtmlNode>> getNodeList(string nodeType, string attribute)
        {
            if (!initF) await Initialize();

            var nodes = doc.DocumentNode.Descendants(nodeType)
                .Where(node => !string.IsNullOrWhiteSpace(node.InnerText));

            return nodes;
        }
    }

}