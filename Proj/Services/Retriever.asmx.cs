using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.Script.Services;


namespace Proj.Services
{
    /// <summary>
    /// Summary description for Retriever
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [ScriptService]
    public class Retriever : System.Web.Services.WebService
    {


        [WebMethod]
        public string GetFromData()
        {
            return new JavaScriptSerializer().Serialize(Global.data.ToArray());
        }
        [WebMethod]

        public string GetStatsJSArray()
        {
            var stats = RandomStatGenerator(15,1234);
            //The Listing is Complete here
            //the rest of the code will create a JSON Array as string manually
            StringBuilder strb = new StringBuilder();
            strb.Append("[");
            var xStats = stats.ToArray<Stat>();

            for (int i = 0; i < xStats.Count(); i++)
            {
                if (i == 0)
                {
                    strb.AppendFormat("['{0}','{1}']", xStats[i].OS, xStats[i].Count);
                }
                else
                {
                    strb.AppendFormat(",['{0}',{1}]", xStats[i].OS, xStats[i].Count);
                }
            }

            strb.Append("]");


            string result = strb.ToString();



            return result;
        }
        [WebMethod]

        public string GetStatsJSON()
        {
            var stats = RandomStatGenerator(10,504);
            
            return new JavaScriptSerializer().Serialize(stats.ToArray());
        }
        List<Stat> RandomStatGenerator(int number,int seed)
        {
            Random rn = new Random(seed);

            List<Stat> stats = new List<Stat>();
            string[] x = new string[] { "Linux", "BSD", "Symbian", "Windows" };
            Stat view = new Stat();
            view.OS = "OS";
            view.Count = "Count";
            stats.Add(view);
            for (int i = 0; i < number; i++)
            {
                Stat y = new Stat();

                y.OS = x[rn.Next() % 3];
                y.Count = (rn.Next() % 2000).ToString();
                stats.Add(y);
            }
            return stats;
        }
    }
    public class Stat
    {
        public string OS;
        public string Count;

    }
    
}

