namespace SFP
{
    partial class Form1
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
            this.buttonStartDirectory = new System.Windows.Forms.Button();
            this.textBoxStartDirectory = new System.Windows.Forms.TextBox();
            this.textBoxFileNameTemplate = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.richTextBoxOutPut = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileNameTemplateEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartDirectory
            // 
            this.buttonStartDirectory.Location = new System.Drawing.Point(649, 21);
            this.buttonStartDirectory.Name = "buttonStartDirectory";
            this.buttonStartDirectory.Size = new System.Drawing.Size(139, 23);
            this.buttonStartDirectory.TabIndex = 0;
            this.buttonStartDirectory.Text = "Стартовая директория";
            this.buttonStartDirectory.UseVisualStyleBackColor = true;
            this.buttonStartDirectory.Click += new System.EventHandler(this.buttonStartDirectory_Click);
            // 
            // textBoxStartDirectory
            // 
            this.textBoxStartDirectory.Location = new System.Drawing.Point(191, 23);
            this.textBoxStartDirectory.Name = "textBoxStartDirectory";
            this.textBoxStartDirectory.Size = new System.Drawing.Size(437, 20);
            this.textBoxStartDirectory.TabIndex = 1;
            // 
            // textBoxFileNameTemplate
            // 
            this.textBoxFileNameTemplate.Location = new System.Drawing.Point(191, 63);
            this.textBoxFileNameTemplate.Name = "textBoxFileNameTemplate";
            this.textBoxFileNameTemplate.Size = new System.Drawing.Size(377, 20);
            this.textBoxFileNameTemplate.TabIndex = 2;
            this.textBoxFileNameTemplate.Text = "*";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(191, 106);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(437, 20);
            this.textBoxText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стартовая директория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаблон имени файла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст, содержащийся в файле";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(649, 104);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // richTextBoxOutPut
            // 
            this.richTextBoxOutPut.Location = new System.Drawing.Point(12, 188);
            this.richTextBoxOutPut.Name = "richTextBoxOutPut";
            this.richTextBoxOutPut.Size = new System.Drawing.Size(776, 250);
            this.richTextBoxOutPut.TabIndex = 8;
            this.richTextBoxOutPut.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Число обработаных файлов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Обрабатываемый файл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "1";
            this.label6.Visible = false;
            // 
            // textBoxFileNameTemplateEnd
            // 
            this.textBoxFileNameTemplateEnd.Location = new System.Drawing.Point(574, 63);
            this.textBoxFileNameTemplateEnd.Name = "textBoxFileNameTemplateEnd";
            this.textBoxFileNameTemplateEnd.Size = new System.Drawing.Size(54, 20);
            this.textBoxFileNameTemplateEnd.TabIndex = 13;
            this.textBoxFileNameTemplateEnd.Text = ".*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFileNameTemplateEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxOutPut);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxFileNameTemplate);
            this.Controls.Add(this.textBoxStartDirectory);
            this.Controls.Add(this.buttonStartDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartDirectory;
        private System.Windows.Forms.TextBox textBoxStartDirectory;
        private System.Windows.Forms.TextBox textBoxFileNameTemplate;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RichTextBox richTextBoxOutPut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFileNameTemplateEnd;
        private System.Windows.Forms.Label label7;
    }
}

