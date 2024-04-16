using HtmlAgilityPack; 

namespace scnet
{
    public class Team
    {
        public int ID { get; }
        private string page;

        public Team(int id)
        {
            ID = id;
            page = "https://www.swimcloud.com/team/" + ID;
        }

        // get team name as displayed
        public async Task<string> getName()
        {
            await Utils.scr.SetPage(page);

            var title = (await Utils.scr.getNodeListContaining("h1", "class", "c-toolbar__title")).ToList().FirstOrDefault();
            return title.InnerText.Trim();
        }

        // get all tags associated with team (ex division)
        public async Task<List<string>> getTags()
        {
            await Utils.scr.SetPage(page);

            var div = (await Utils.scr.getNodeListContaining("div", "class", "c-toolbar__meta")).ToList();
            var ul = div[0];
            var li = ul.ChildNodes[1];
            List<string> tags = new List<string>();

            var cnode = li.ChildNodes;

            for (int i = 0; i < cnode.Count; i++)
            {
                if (i % 2 == 0) continue; // ignores #text children nodes

                string val = cnode[i].ChildNodes[1].GetAttributeValue("title", "");
                if (!string.IsNullOrEmpty(val))
                    tags.Add(val);
            }

            return tags.Count > 0 ? tags : new List<string>() { "No Tags Available" };
        }

        // get team logo url
        public async Task<string> getLogoURL()
        {
            await Utils.scr.SetPage(page);

            var logoParent = (await Utils.scr.getNodeListContaining("figure", "class", "c-toolbar__media")).ToList().FirstOrDefault();
            var logo = logoParent.ChildNodes[1];
            return logo.GetAttributeValue("src", "");
        }

        // get team cover image url
        public async Task<string> getCoverURL()
        {
            await Utils.scr.SetPage(page);

            var cover = (await Utils.scr.getNodeListContaining("div", "class", "c-toolbar__cover"))
                .ToList()[0].GetAttributeValue("style", "");

            int croppedTextLength = "background-image: url(".Length;
            string croppedUrl = cover.Substring(croppedTextLength,
                /*removes paranthesis at end + accounts for already removed parts*/
                cover.Length - croppedTextLength - 2
                );
            return croppedUrl;
        }

        public async Task<string> getDescription()
        {
            try
            {
                await Utils.scr.SetPage(page + "/about/");
                var desc = (await Utils.scr.getNodeListContaining("div", "class", "o-grid--row-gap-30")).ToList()[1];
                return desc.ChildNodes[0].InnerText.Trim();
            }
            catch (Exception ex)
            {
                return "No Description Available: " + ex.Message;
            }
        }
    }
}