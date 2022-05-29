using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JuniorTest
{
    public class Literature
    {
        public Literature()
        {
            this.ID = Program.LiteratureDB.Literatures.Count;
            this.Name = "Название книги";
            this.Description = "Описание книги";
            this.Author = "Иргалин А.И.";
            this.DateAdded = DateTime.Now.ToString();
        }

        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlAttribute("Author")]
        public string Author { get; set; }

        [XmlAttribute("DateAdded")]
        public string DateAdded { get; set; }

        [XmlArray("Content"), XmlArrayItem("Text")]
        public List<string> Content { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name} | {Author}";
        }
        public string Demonstration()
        {
            return $"{Name}\n\n{Description}\n\nАвтор: {Author}\nКоличество страниц: {Content.Count}\nДата добавления: {DateAdded}";
        }

    }
}
