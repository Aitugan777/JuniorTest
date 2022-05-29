using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuniorTest
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            lb_listLiterature.Items.Clear();
            foreach (Literature literature in Program.LiteratureDB.Literatures)
                lb_listLiterature.Items.Add(literature);
            FindLiterature();
        }

        private void FindLiterature()
        {
            Program.UpdateIDs();
            if (tb_find.Text != "")
            {
                switch (cb_critetia.Text)
                {
                    case "автору":
                        Program.FindLiteratureList = Program.LiteratureDB.Literatures.FindAll(x => x.Author.ToLower().Contains(tb_find.Text.ToLower()));
                        break;
                    case "названию":
                        Program.FindLiteratureList = Program.LiteratureDB.Literatures.FindAll(x => x.Name.ToLower().Contains(tb_find.Text.ToLower()));
                        break;
                    case "содержанию":
                        List<Literature> list = new List<Literature>();
                        foreach (Literature literature in Program.LiteratureDB.Literatures)
                        {
                            foreach (string content in literature.Content)
                            {
                                if (content.ToLower().Contains(tb_find.Text.ToLower()))
                                {
                                    list.Add(literature);
                                    break;
                                }
                            }
                        }
                        Program.FindLiteratureList = list;
                        break;
                    default:
                        Program.FindLiteratureList = Program.LiteratureDB.Literatures;
                        break;
                }
            }
            else
                Program.FindLiteratureList = Program.LiteratureDB.Literatures;

            lb_listLiterature.Items.Clear();

            foreach (Literature literature in Program.FindLiteratureList)
                lb_listLiterature.Items.Add(literature);

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            FindLiterature();
        }

        private void btn_addLiterature_Click(object sender, EventArgs e)
        {
            Program.SelectLiterature = new Literature();
            Program.SelectLiterature.Content = new List<string>() { "Первая страница", "Вторая страница" };
            this.Hide();
            new AddLiterature().Show();
        }

        private void lb_listLiterature_Click(object sender, EventArgs e)
        {
            try
            {
                l_demonstration.Text = Program.FindLiteratureList[lb_listLiterature.SelectedIndex].Demonstration();
            }
            catch { }
        }

        private void btn_openLiterature_Click(object sender, EventArgs e)
        {
            if (lb_listLiterature.SelectedIndex < 0)
            {
                l_demonstration.Text = "Выберите книгу!";
                return;
            }
            Program.SelectLiterature = Program.FindLiteratureList[lb_listLiterature.SelectedIndex];
            Program.LiteratureDB.Literatures.RemoveAt(Program.FindLiteratureList[lb_listLiterature.SelectedIndex].ID);
            this.Hide();
            new AddLiterature().Show();
        }

        private void btn_removeLiterature_Click(object sender, EventArgs e)
        {
            if (lb_listLiterature.SelectedIndex < 0)
            {
                l_demonstration.Text = "Выберите книгу!";
                return;
            }
            Program.LiteratureDB.Literatures.RemoveAt(Program.FindLiteratureList[lb_listLiterature.SelectedIndex].ID);
            FindLiterature();
            l_demonstration.Text = "";
            Program.UpdateIDs();
            DBManager.Save(Program.LiteratureDB);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DBManager.Save(Program.LiteratureDB);
            this.Close();
            Application.Exit();
        }
    }
}
