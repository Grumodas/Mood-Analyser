using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;
using AWSLambdaClient;

namespace MiddleService
{
    /// <summary>
    /// Summary description for Simple
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Simple : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return EmotDetector.Hi();
        }

        [WebMethod]
        public string Mocking(int a)
        {
            for(int i = 0; i < a; i++)
            {
                Thread.Sleep(1000);
            }

            return Thread.CurrentThread.Name; 
        }
    }
}
