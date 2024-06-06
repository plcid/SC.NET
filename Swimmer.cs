using HtmlAgilityPack;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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

        public string Name
        {
            get
            {
                async Task<string> _impl()
                {
                    try
                    {
                        await Utils.scr.SetPage(page);

                        var parent = Utils.scr.getNodeListContaining("h1", "class", "c-toolbar__title").Result.ToList();

                        return parent[0].InnerText.Trim();
                    }
                    catch (Exception ex)
                    {
                        return "Could not get name: " + ex.Message;
                    }
                }

                return _impl().Result;
            }
        }

        public string Location
        {
            get
            {
                async Task<string> _impl()
                {
                    try
                    {
                        await Utils.scr.SetPage(page);

                        var divP = (await Utils.scr.getNodeListContaining("div", "class", "c-toolbar__meta")).ToList()[0];

                        var listP = divP.ChildNodes[1];

                        return listP.ChildNodes[1].InnerText.Trim();
                    }
                    catch (Exception ex)
                    {
                        return "Could not get location: " + ex.Message;
                    }
                }

                return _impl().Result;
            }
        }

        public Team Team
        {
            get {
                async Task<Team> _impl() {
                    try
                    {
                        await Utils.scr.SetPage(page);

                        var divP = (await Utils.scr.getNodeListContaining("div", "class", "c-toolbar__meta")).ToList()[0];

                        var listP = divP.ChildNodes[1];

                        return new Team(Int32.Parse(listP.ChildNodes[3].ChildNodes[1].GetAttributeValue("href", "").Substring("/team/".Length)));
                    }
                    catch
                    {
                        return null;
                    }
                }

                return _impl().Result;
            }
        }

        public List<Team> AllTeams
        {
            get {
                async Task<List<Team>> _impl() {
                    try
                    {
                        await Utils.scr.SetPage(page);

                        List<Team> ret = new List<Team>();

                        var teamRef = (await Utils.scr.getNodeListContaining("a", "class", "u-is-hidden@palm")).ToList();

                        foreach (var team in teamRef)
                        {
                            ret.Add(new Team(Int32.Parse(team.GetAttributeValue("href", "").Substring("/team/".Length))));
                        }

                        return ret;
                    }
                    catch
                    {
                        return null;
                    }
                }

                return _impl().Result;
            }
        }

        public Meet MostRecentMeet
        {
            get {
                async Task<Meet> _impl() {
                    try
                    {
                        await Utils.scr.SetPage(page + "/meets/");

                        var href = (await Utils.scr.getNodeListContaining("a", "class", "c-swimmer-meets__link-mask")).ToList()[0];

                        var atval = href.GetAttributeValue("href", "");

                        return new Meet(Int32.Parse(atval.Substring("/results/".Length, atval.Length - "/results/".Length - "/swimmer/".Length - ID.ToString().Length - "/".Length)));
                    }
                    catch
                    {
                        return null;
                    }
                }

                return _impl().Result;
            }
        }

        public List<Meet> AllMeets
        {
            get {
                async Task<List<Meet>> _impl() {
                    try
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
                    catch
                    {
                        return null;
                    }
                }

                return _impl().Result;
            }
        }
    }
}