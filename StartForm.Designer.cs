namespace JuniorTest
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_listLiterature = new System.Windows.Forms.ListBox();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.btn_findLiterature = new System.Windows.Forms.Button();
            this.btn_addLiterature = new System.Windows.Forms.Button();
            this.btn_openLiterature = new System.Windows.Forms.Button();
            this.l_demonstration = new System.Windows.Forms.Label();
            this.cb_critetia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeLiterature = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_listLiterature
            // 
            this.lb_listLiterature.FormattingEnabled = true;
            this.lb_listLiterature.Items.AddRange(new object[] {
            " "});
            this.lb_listLiterature.Location = new System.Drawing.Point(12, 64);
            this.lb_listLiterature.Name = "lb_listLiterature";
            this.lb_listLiterature.Size = new System.Drawing.Size(460, 381);
            this.lb_listLiterature.TabIndex = 0;
            this.lb_listLiterature.Click += new System.EventHandler(this.lb_listLiterature_Click);
            // 
            // tb_find
            // 
            this.tb_find.Location = new System.Drawing.Point(12, 10);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(460, 20);
            this.tb_find.TabIndex = 2;
            // 
            // btn_findLiterature
            // 
            this.btn_findLiterature.Location = new System.Drawing.Point(350, 36);
            this.btn_findLiterature.Name = "btn_findLiterature";
            this.btn_findLiterature.Size = new System.Drawing.Size(122, 23);
            this.btn_findLiterature.TabIndex = 3;
            this.btn_findLiterature.Text = "Найти";
            this.btn_findLiterature.UseVisualStyleBackColor = true;
            this.btn_findLiterature.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_addLiterature
            // 
            this.btn_addLiterature.Location = new System.Drawing.Point(481, 422);
            this.btn_addLiterature.Name = "btn_addLiterature";
            this.btn_addLiterature.Size = new System.Drawing.Size(100, 23);
            this.btn_addLiterature.TabIndex = 4;
            this.btn_addLiterature.Text = "Добавить книгу";
            this.btn_addLiterature.UseVisualStyleBackColor = true;
            this.btn_addLiterature.Click += new System.EventHandler(this.btn_addLiterature_Click);
            // 
            // btn_openLiterature
            // 
            this.btn_openLiterature.Location = new System.Drawing.Point(672, 422);
            this.btn_openLiterature.Name = "btn_openLiterature";
            this.btn_openLiterature.Size = new System.Drawing.Size(100, 23);
            this.btn_openLiterature.TabIndex = 6;
            this.btn_openLiterature.Text = "Открыть";
            this.btn_openLiterature.UseVisualStyleBackColor = true;
            this.btn_openLiterature.Click += new System.EventHandler(this.btn_openLiterature_Click);
            // 
            // l_demonstration
            // 
            this.l_demonstration.AutoSize = true;
            this.l_demonstration.Location = new System.Drawing.Point(478, 10);
            this.l_demonstration.Name = "l_demonstration";
            this.l_demonstration.Size = new System.Drawing.Size(7, 13);
            this.l_demonstration.TabIndex = 9;
            this.l_demonstration.Text = "\r\n";
            // 
            // cb_critetia
            // 
            this.cb_critetia.FormattingEnabled = true;
            this.cb_critetia.Items.AddRange(new object[] {
            "названию",
            "содержанию",
            "автору"});
            this.cb_critetia.Location = new System.Drawing.Point(76, 36);
            this.cb_critetia.Name = "cb_critetia";
            this.cb_critetia.Size = new System.Drawing.Size(121, 21);
            this.cb_critetia.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Искать по";
            // 
            // btn_removeLiterature
            // 
            this.btn_removeLiterature.Location = new System.Drawing.Point(672, 393);
            this.btn_removeLiterature.Name = "btn_removeLiterature";
            this.btn_removeLiterature.Size = new System.Drawing.Size(100, 23);
            this.btn_removeLiterature.TabIndex = 13;
            this.btn_removeLiterature.Text = "Удалить";
            this.btn_removeLiterature.UseVisualStyleBackColor = true;
            this.btn_removeLiterature.Click += new System.EventHandler(this.btn_removeLiterature_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(749, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_removeLiterature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_critetia);
            this.Controls.Add(this.l_demonstration);
            this.Controls.Add(this.btn_openLiterature);
            this.Controls.Add(this.btn_addLiterature);
            this.Controls.Add(this.btn_findLiterature);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.lb_listLiterature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_listLiterature;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button btn_findLiterature;
        private System.Windows.Forms.Button btn_addLiterature;
        private System.Windows.Forms.Button btn_openLiterature;
        private System.Windows.Forms.Label l_demonstration;
        private System.Windows.Forms.ComboBox cb_critetia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removeLiterature;
        private System.Windows.Forms.Button btn_close;
    }
}

