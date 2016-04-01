using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//using Proj.Models;
using System.Web.Script.Services;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ComponentModel;

namespace Proj.Services
{
    /// <summary>
    /// Summary description for Listener
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [ScriptService]
    public class Listener : System.Web.Services.WebService
    {
        public object Request { get; private set; }



        // [WebMethod]
        // public void Record(Token tok)//This Method Will get a Request from a Client-side JQuery Scipt that POSTs an AJAX with a JSON inside
        //  {
        //    MyModel db = new MyModel();
        //   var check = (from token in db.Tokens
        //              where token.ID == tok.ID
        //               select token).FirstOrDefault();
        // if (check != null)
        //  {
        // Visit visit = new Visit();
        // visit.IP= GetUserIP();
        // visit.Platform = null;//ToDO
        //visit.Browser = null;//ToDO

        //visit.Date = DateTime.Now;
        // visit.Token_ID = tok.ID;
        //         db.Visits.Add(visit);
        //       db.SaveChanges();
        //    }
        //  else
        //todo

        //  }
        [WebMethod]
        public string HelloTwo(string str)
        {
            Global.data.Add(str);

            return str + "  Hello Client! Submitted with a parameter";
        }
        [WebMethod]
        public string HelloOne()
        {
            


            return "Hello Client! Submitted";
        }
        [WebMethod]
        public string HelloZero()
        {



            return "Hello Client!";
        }
       
        //***************************************************************************************

       

            //*************************************************************************************

        public string GetUserIP()//Gets Request's IP Address and returns as String
        {
            string strIP = String.Empty;
            HttpRequest httpReq = HttpContext.Current.Request;

            //test for non-standard proxy server designations of client's IP
            if (httpReq.ServerVariables["HTTP_CLIENT_IP"] != null)
            {
                strIP = httpReq.ServerVariables["HTTP_CLIENT_IP"].ToString();
            }
            else if (httpReq.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {
                strIP = httpReq.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            //test for host address reported by the server
            else if
            (
                //if exists
                (httpReq.UserHostAddress.Length != 0)
                &&
                //and if not localhost IPV6 or localhost name
                ((httpReq.UserHostAddress != "::1") || (httpReq.UserHostAddress != "localhost"))
            )
            {
                strIP = httpReq.UserHostAddress;
            }
            //finally, if all else fails, get the IP from a web scrape of another server
            else
            {
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    strIP = sr.ReadToEnd();
                }
                //scrape ip from the html
                int i1 = strIP.IndexOf("Address: ") + 9;
                int i2 = strIP.LastIndexOf("</body>");
                strIP = strIP.Substring(i1, i2 - i1);
            }

            if (strIP == "::1")
                return "127.0.0.1";
            else
                return strIP;
        }
        public string IPRequestHelper(string url)
        {

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
            string responseRead = responseStream.ReadToEnd();

            responseStream.Close();
            responseStream.Dispose();

            return responseRead;
        }
        public string GetCountryByIP(string ipAddress)
        {
            string strReturnVal;
            string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + ipAddress);

            //return ipResponse;
            XmlDocument ipInfoXML = new XmlDocument();
            ipInfoXML.LoadXml(ipResponse);
            XmlNodeList responseXML = ipInfoXML.GetElementsByTagName("query");

            NameValueCollection dataXML = new NameValueCollection();

            dataXML.Add(responseXML.Item(0).ChildNodes[2].InnerText, responseXML.Item(0).ChildNodes[2].Value);

            strReturnVal = responseXML.Item(0).ChildNodes[1].InnerText.ToString(); // Contry
            strReturnVal += "(" +

    responseXML.Item(0).ChildNodes[2].InnerText.ToString() + ")";  // Contry Code 
            return strReturnVal;
        }
        //public string GetOS()
        // {
        //HttpBrowserCapabilities browse = Request.Browser;

        //  return browse.Platform;
        // }
        //private string GetBrowser()
        // {
        //Request.
        //return Request.Browser.Type.ToString();
        //}
    }
}
