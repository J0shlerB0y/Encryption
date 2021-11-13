
namespace TestWinForms
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
            this.but_trans = new System.Windows.Forms.Button();
            this.input_text = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.type_of_trans = new System.Windows.Forms.ComboBox();
            this.text_to_trans = new System.Windows.Forms.TextBox();
            this.key_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_trans
            // 
            this.but_trans.AutoSize = true;
            this.but_trans.Location = new System.Drawing.Point(265, 400);
            this.but_trans.Name = "but_trans";
            this.but_trans.Size = new System.Drawing.Size(150, 50);
            this.but_trans.TabIndex = 0;
            this.but_trans.Text = "Преобразовать";
            this.but_trans.UseVisualStyleBackColor = true;
            this.but_trans.Click += new System.EventHandler(this.but_trans_Click);
            // 
            // input_text
            // 
            this.input_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_text.Location = new System.Drawing.Point(90, 190);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(500, 200);
            this.input_text.TabIndex = 1;
            this.input_text.Text = "Здесь появится преобразованный тескт";
            this.input_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_of_trans
            // 
            this.type_of_trans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_of_trans.FormattingEnabled = true;
            this.type_of_trans.Items.AddRange(new object[] {
            "Перевод из зашифрованного текста в читаемый",
            "Перевод из читаемого текста в зашифрованный"});
            this.type_of_trans.Location = new System.Drawing.Point(90, 15);
            this.type_of_trans.Name = "type_of_trans";
            this.type_of_trans.Size = new System.Drawing.Size(500, 21);
            this.type_of_trans.TabIndex = 2;
            // 
            // text_to_trans
            // 
            this.text_to_trans.Location = new System.Drawing.Point(90, 150);
            this.text_to_trans.Name = "text_to_trans";
            this.text_to_trans.Size = new System.Drawing.Size(500, 20);
            this.text_to_trans.TabIndex = 3;
            // 
            // key_code
            // 
            this.key_code.Location = new System.Drawing.Point(265, 80);
            this.key_code.Name = "key_code";
            this.key_code.Size = new System.Drawing.Size(150, 20);
            this.key_code.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(265, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите ключ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(265, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите текст";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key_code);
            this.Controls.Add(this.text_to_trans);
            this.Controls.Add(this.type_of_trans);
            this.Controls.Add(this.but_trans);
            this.Controls.Add(this.input_text);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_trans;
        private System.Windows.Forms.Label input_text;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox type_of_trans;
        private System.Windows.Forms.TextBox text_to_trans;
        private System.Windows.Forms.TextBox key_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

