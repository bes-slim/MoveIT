using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace MovePricer.Service
{
    public static class JsonFormatterConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}