namespace JuniorTest
{
    partial class AddLiterature
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_content = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.l_contentCount = new System.Windows.Forms.Label();
            this.btn_addContent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(12, 12);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(400, 408);
            this.tb_content.TabIndex = 0;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(240, 426);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(23, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(142, 426);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(23, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // l_contentCount
            // 
            this.l_contentCount.AutoSize = true;
            this.l_contentCount.Location = new System.Drawing.Point(188, 431);
            this.l_contentCount.Name = "l_contentCount";
            this.l_contentCount.Size = new System.Drawing.Size(0, 13);
            this.l_contentCount.TabIndex = 3;
            // 
            // btn_addContent
            // 
            this.btn_addContent.Location = new System.Drawing.Point(288, 426);
            this.btn_addContent.Name = "btn_addContent";
            this.btn_addContent.Size = new System.Drawing.Size(124, 23);
            this.btn_addContent.TabIndex = 4;
            this.btn_addContent.Text = "Добавить страницу";
            this.btn_addContent.UseVisualStyleBackColor = true;
            this.btn_addContent.Click += new System.EventHandler(this.btn_addContent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(476, 15);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(296, 20);
            this.tb_name.TabIndex = 6;
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(476, 41);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(296, 20);
            this.tb_author.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Автор";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(476, 67);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(296, 80);
            this.tb_description.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Описание";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(697, 426);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AddLiterature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addContent);
            this.Controls.Add(this.l_contentCount);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.tb_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddLiterature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLiterature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label l_contentCount;
        private System.Windows.Forms.Button btn_addContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
    }
}