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
        public static void SerializeList<T>(string fileName, List<T> objList)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
            {
                foreach (T obj in objList)
                {
                    file.WriteLine(JsonConvert.SerializeObject(obj));
                }
            }
        }

        public static void Serialize<T>(string fileName, T obj)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
            {
                file.WriteLine(JsonConvert.SerializeObject(obj));
            }
        }

        public static List<T> DeserializeList<T>(string fileName)
        {
            List<T> result = new List<T>();

            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    result.Add(JsonConvert.DeserializeObject<T>(reader.ReadLine()));
                }
            }
            return result;
        }
    }
}
