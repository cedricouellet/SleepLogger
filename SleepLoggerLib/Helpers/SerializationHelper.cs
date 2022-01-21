using System.Runtime.Serialization.Formatters.Binary;

namespace SleepLoggerLib.Helpers
{
    public static class SerializationHelper
    {
#pragma warning disable SYSLIB0011 // Type or member is obsolete

        public static void Dump<T>(string filename, T contents)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using FileStream fs = File.OpenWrite(filename);

            bf.Serialize(fs, contents ?? throw new ArgumentException("Contents must not be null."));
        }

        public static T? Load<T>(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The serialized file does not exist.");
            }

            BinaryFormatter bf = new BinaryFormatter();
            using FileStream fs = File.OpenRead(filename);

            try
            {
                return (T)bf.Deserialize(fs);
            }
            catch
            {
                return default;
            }
        }
#pragma warning restore SYSLIB0011 // Type or member is obsolete
    }
}