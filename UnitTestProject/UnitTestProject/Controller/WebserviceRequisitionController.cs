using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace UnitTestProject.Controller
{
    /// <summary>
    /// Classe para auxiliar nas chamadas ao webservice.
    /// </summary>
    public class WebserviceRequisitionController
    {
        public dynamic makeRequisition( string url, string method, string jsonDados)
        { 
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Method = method;
            
            if( jsonDados != null )
            { 
                StreamWriter writer = new StreamWriter(request.GetRequestStream());

                writer.Write(jsonDados);
                writer.Close();
            }

            string responseData = string.Empty;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader reader = new StreamReader(response.GetResponseStream());

            responseData = reader.ReadToEnd();
            reader.Close();

            response.Close();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(responseData);

            return item;
        }
    }
}
