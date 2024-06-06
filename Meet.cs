using HtmlAgilityPack;
using System.Xml.Linq;

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

        public string Name
        {
            get
            {
                async Task<string> _impl()
                {
                    try
                    {
                        await Utils.scr.SetPage(page);

                        var node = (await Utils.scr.getNodeListContaining("h1", "id", "meet-name")).ElementAt(0);
                        return node.InnerText.Trim();
                    }
                    catch (Exception ex)
                    {
                        return "Could not get name: " + ex.Message;
                    }
                }

                return _impl().Result;
            }
        }

        public string Date
        {
            get
            {
                async Task<string> _impl()
                {
                    try
                    {
                        await Utils.scr.SetPage(page);

                        var node = (await Utils.scr.getNodeListContaining("li", "id", "meet-date")).ElementAt(0);
                        return node.InnerText.Trim();
                    }
                    catch (Exception ex)
                    {
                        return "Could not get date: " + ex.Message;
                    }
                }

                return _impl().Result;
            }
        }

        public string Course
        {
            get
            {
                async Task<string> _impl()
                {
                    try
                    {
                        await Utils.scr.SetPage(page);

                        var node = (await Utils.scr.getNodeListContaining("li", "id", "meet-course")).ElementAt(0);
                        return node.InnerText.Trim();
                    }
                    catch (Exception ex)
                    {
                        return "Could not get course: " + ex.Message;
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

                        var node = (await Utils.scr.getNodeListContaining("li", "id", "meet-location")).ElementAt(0);
                        return node.InnerText.Trim();
                    }
                    catch (Exception ex)
                    {
                        return "Could not get location: " + ex.Message;
                    }
                }

                return _impl().Result;
            }
        }
    }
}