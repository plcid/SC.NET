using HtmlAgilityPack;
using System.Net.Http.Headers;

namespace scnet
{
    public class Swimmer
    {
        public int ID { get; }
        private string page;
        
        public Swimmer(int swID)
        {
            ID = swID;
            page = "https://www.swimcloud.com/swimmer/" + swID;
        }

        // get first+last name
        public async Task<string> getName()
        {
            await Utils.scr.SetPage(page);

            var parent = Utils.scr.getNodeListContaining("h1", "class", "c-toolbar__title").Result.ToList();

            return parent[0].InnerText.Trim();
        }

        // get location 

        public async Task<string> getLocation()
        {
            await Utils.scr.SetPage(page);

            var divP = (await Utils.scr.getNodeListContaining("div", "class", "c-toolbar__meta")).ToList()[0];

            var listP = divP.ChildNodes[1];

            return listP.ChildNodes[1].InnerText.Trim();
        }

        // get school

        public async Task<Team> getCurrentTeam()
        {
            await Utils.scr.SetPage(page);

            var divP = (await Utils.scr.getNodeListContaining("div", "class", "c-toolbar__meta")).ToList()[0];

            var listP = divP.ChildNodes[1];

            return new Team(Int32.Parse(listP.ChildNodes[3].ChildNodes[1].GetAttributeValue("href", "").Substring("/team/".Length)));
        }

        public async Task<string> getCurrentTeamName()
        {
            await Utils.scr.SetPage(page);

            var divP = (await Utils.scr.getNodeListContaining("div", "class", "c-toolbar__meta")).ToList()[0];

            var listP = divP.ChildNodes[1];

            return listP.ChildNodes[3].InnerText.Trim();
        }

        // get most recent meet

        public async Task<List<Team>> getAllTeams()
        {
            await Utils.scr.SetPage(page);

            List<Team> ret = new List<Team>();

            var teamRef = (await Utils.scr.getNodeListContaining("a", "class", "u-is-hidden@palm")).ToList();

            foreach (var team in teamRef )
            {
                ret.Add(new Team(Int32.Parse(team.GetAttributeValue("href", "").Substring("/team/".Length))));
            }

            return ret;
        }

        public async Task<List<string>> getAllTeamNames()
        {
            await Utils.scr.SetPage(page);

            List<string> ret = new List<string>();

            var teamRef = (await Utils.scr.getNodeListContaining("a", "class", "u-is-hidden@palm")).ToList();

            foreach (var team in teamRef)
            {
                ret.Add(team.GetAttributeValue("title", ""));
            }

            return ret;
        }


        public async Task<Meet> getMostRecentMeet()
        {
            await Utils.scr.SetPage(page + "/meets/");
            
            var hrefs = (await Utils.scr.getNodeListContaining("a", "class", "c-swimmer-meets__link-mask")).ToList()[0];

            var atval = hrefs.GetAttributeValue("href", "");

            return new Meet(Int32.Parse(atval.Substring("/results/".Length, atval.Length - "/results/".Length - "/swimmer/".Length - ID.ToString().Length - "/".Length)));
        }

        public async Task<List<Meet>> getAllMeets()
        {
            await Utils.scr.SetPage(page + "/meets/");
            
            var hrefs = (await Utils.scr.getNodeListContaining("a", "class", "c-swimmer-meets__link-mask")).ToList();

            List<Meet> ret = new List<Meet>();
            
            foreach (var href in hrefs)
            {
                var atval = href.GetAttributeValue("href", "");
                ret.Add(new Meet(Int32.Parse(atval.Substring("/results/".Length, atval.Length - "/results/".Length - "/swimmer/".Length - ID.ToString().Length - "/".Length))));
            }

            return ret;
        }

        public async Task<List<string>> getAllMeetNames()
        {
            await Utils.scr.SetPage(page + "/meets/");

            var hdrs = (await Utils.scr.getNodeListContaining("h3", "class", "c-title--small")).ToList();

            List<string> ret = new List<string>();

            foreach (var hdr in hdrs)
                ret.Add(hdr.InnerText);

            return string.IsNullOrEmpty(ret[0]) ? new List<string>() { "No Available Meets Found" } : ret;
        }
    }
}
