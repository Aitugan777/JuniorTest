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
    public partial class AddLiterature : Form
    {
        public AddLiterature()
        {
            InitializeComponent();
            tb_name.Text = Program.SelectLiterature.Name;
            tb_description.Text = Program.SelectLiterature.Description;
            tb_author.Text = Program.SelectLiterature.Author; 
            tb_content.Text = Program.SelectLiterature.Content[0];
            Program.SelectContentList = 0;
            l_contentCount.Text = $"{Program.SelectContentList + 1}/{Program.SelectLiterature.Content.Count}";
        }

        private void btn_addContent_Click(object sender, EventArgs e)
        {
            Program.SelectLiterature.Content[Program.SelectContentList] = tb_content.Text;
            Program.SelectLiterature.Content.Add("Новая страница");
            Program.SelectContentList = Program.SelectLiterature.Content.Count - 1;
            tb_content.Text = Program.SelectLiterature.Content[Program.SelectContentList];
            l_contentCount.Text = $"{Program.SelectContentList + 1}/{Program.SelectLiterature.Content.Count}";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (Program.SelectContentList < Program.SelectLiterature.Content.Count -1)
            {
                Program.SelectLiterature.Content[Program.SelectContentList] = tb_content.Text;
                tb_content.Text = Program.SelectLiterature.Content[++Program.SelectContentList];
                l_contentCount.Text = $"{Program.SelectContentList +1}/{Program.SelectLiterature.Content.Count}";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Program.SelectContentList > 0)
            {
                Program.SelectLiterature.Content[Program.SelectContentList] = tb_content.Text;
                tb_content.Text = Program.SelectLiterature.Content[--Program.SelectContentList];
                l_contentCount.Text = $"{Program.SelectContentList + 1}/{Program.SelectLiterature.Content.Count}";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Program.SelectLiterature.Content[Program.SelectContentList] = tb_content.Text;
            Program.SelectLiterature.Name = tb_name.Text;
            Program.SelectLiterature.Description = tb_description.Text;
            Program.SelectLiterature.Author = tb_author.Text;
            Program.LiteratureDB.Literatures.Add(Program.SelectLiterature);

            Program.UpdateIDs();
            DBManager.Save(Program.LiteratureDB);
            this.Hide();
            new StartForm().Show();
        }
    }
}
