
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
            this.copy_but = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_trans
            // 
            this.but_trans.AutoSize = true;
            this.but_trans.Location = new System.Drawing.Point(398, 690);
            this.but_trans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_trans.Name = "but_trans";
            this.but_trans.Size = new System.Drawing.Size(225, 77);
            this.but_trans.TabIndex = 0;
            this.but_trans.Text = "Преобразовать";
            this.but_trans.UseVisualStyleBackColor = true;
            this.but_trans.Click += new System.EventHandler(this.but_trans_Click);
            // 
            // input_text
            // 
            this.input_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_text.Location = new System.Drawing.Point(112, 353);
            this.input_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(748, 308);
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
            this.type_of_trans.Location = new System.Drawing.Point(135, 101);
            this.type_of_trans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type_of_trans.Name = "type_of_trans";
            this.type_of_trans.Size = new System.Drawing.Size(748, 28);
            this.type_of_trans.TabIndex = 2;
            // 
            // text_to_trans
            // 
            this.text_to_trans.Location = new System.Drawing.Point(135, 305);
            this.text_to_trans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_to_trans.Name = "text_to_trans";
            this.text_to_trans.Size = new System.Drawing.Size(748, 26);
            this.text_to_trans.TabIndex = 3;
            // 
            // key_code
            // 
            this.key_code.Location = new System.Drawing.Point(398, 197);
            this.key_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.key_code.Name = "key_code";
            this.key_code.Size = new System.Drawing.Size(223, 26);
            this.key_code.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(135, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите ключ (больше 0 и меньше 101)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(135, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(748, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите текст";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copy_but
            // 
            this.copy_but.Location = new System.Drawing.Point(763, 690);
            this.copy_but.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copy_but.Name = "copy_but";
            this.copy_but.Size = new System.Drawing.Size(231, 77);
            this.copy_but.TabIndex = 7;
            this.copy_but.Text = "Копировать";
            this.copy_but.UseVisualStyleBackColor = true;
            this.copy_but.Click += new System.EventHandler(this.copy_but_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(398, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 57);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите вид преобразования";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 781);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copy_but);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key_code);
            this.Controls.Add(this.text_to_trans);
            this.Controls.Add(this.type_of_trans);
            this.Controls.Add(this.but_trans);
            this.Controls.Add(this.input_text);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Encryption";
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
        private System.Windows.Forms.Button copy_but;
        private System.Windows.Forms.Label label4;
    }
}

