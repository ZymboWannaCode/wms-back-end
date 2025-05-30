using Newtonsoft.Json.Linq;
using System.Net;

namespace wms_back_end.Helper
{
    public class EncodeData
    {
        public static string[] HtmlEncodeObject(JObject data)
        {
            var encodedData = new List<string>();

            foreach (var property in data.Properties())
            {
                encodedData.Add(WebUtility.HtmlEncode(property.Value.ToString()));
            }

            return encodedData.ToArray();
        }
    }
}
