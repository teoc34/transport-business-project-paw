using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace transport_business_project.Utilities
{
    public static class SerializationUtility
    {
        public static void SerializeToFile<T>(T data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static T DeserializeFromFile<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (T?)serializer.Deserialize(reader) ?? throw new InvalidOperationException("Deserialization returned null.");
            }
        }
    }
}
