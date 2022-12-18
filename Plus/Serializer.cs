using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Plus
{
    public class Serializer
    {
        private string _json;

        public string json
        {
            get { return _json; }
            private set { _json = value; }
        }

        public Serializer(string json)
        {
            this.json = json;
        }

        public List<string> keys()
        {
            return JObject.Parse(json).Properties().Select(p => p.Name).ToList();
        }

        public string snippet(string key)
        {
            string value = (string)JObject.Parse(json)[key];
            return value;
        }

    }
}
