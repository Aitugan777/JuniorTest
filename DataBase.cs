using System.Collections.Generic;
using System.Xml.Serialization;

namespace JuniorTest
{
    public class DataBase
    {
        [XmlArray("Literatures"), XmlArrayItem("Literature")]
        public List<Literature> Literatures = new List<Literature>();
    }
}
