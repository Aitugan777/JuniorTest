using System.IO;
using System.Xml.Serialization;

namespace JuniorTest
{
    public class DBManager
    {
        public static string FileName = "DataBase.xml";
        public static DataBase GetDB()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataBase));
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                DataBase derver = (DataBase)xmlSerializer.Deserialize(fs);
                return derver;
            }
        }

        public static void ServializeDB()
        {
            DataBase dataBase = new DataBase();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataBase));
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, dataBase);
            }
        }

        public static void Save(DataBase server)
        {
            FileInfo fileInfo = new FileInfo(FileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataBase));
            fileInfo.Delete();
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, server);
            }
        }
    }
}
