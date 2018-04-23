using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public static class Serializer
    {
        public static void Serialize(string fileName, params object[] obj)
        {
            string json;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fileName, true))
            {
                foreach (var i in obj)
                {
                    json = JsonConvert.SerializeObject(obj);
                    file.WriteLine(json);
                }
            }

        }

        public static List<T> Deserialize<T>(string fileName)
        {
            string json = System.IO.File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
