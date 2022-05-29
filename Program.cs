using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuniorTest
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                LiteratureDB = DBManager.GetDB();
            }
            catch
            {
                DBManager.ServializeDB();
            }
            LiteratureDB = DBManager.GetDB();
            SelectContentList = 0; 


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());


        }

        public static DataBase LiteratureDB = new DataBase();
        public static List<Literature> FindLiteratureList = new List<Literature>();
        public static Literature SelectLiterature;
        public static int SelectContentList;

        public static void UpdateIDs()
        {
            int id = 0;
            foreach(Literature literature in LiteratureDB.Literatures)
                literature.ID = id++;
        }
    }
}
