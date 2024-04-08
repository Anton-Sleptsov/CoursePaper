using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    internal class SerializableSaver
    {
        public static T Load<T>() where T : class
        {
            var fileName = $"{typeof(T).Name}.json";

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<T>(json);
            }
            else
            {
                return null;
            }
        }

        public static void Save<T>(T item) where T : class
        {
            var fileName = $"{typeof(T).Name}.json";
            string json = JsonSerializer.Serialize(item);
            File.WriteAllText(fileName, json);
        }
    }
}
