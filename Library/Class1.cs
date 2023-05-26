using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Library
{
    public class DataSerialization
    {
        // Сериализация данных объекта в JSON и запись в файл
        public static void SerializeToFile<T>(T data, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, jsonData);
        }

        // Десериализация данных из файла в объект заданного типа
        public static T DeserializeFromFile<T>(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            T data = JsonConvert.DeserializeObject<T>(jsonData);
            return data;
        }
    }
}