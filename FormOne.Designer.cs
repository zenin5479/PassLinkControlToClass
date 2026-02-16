namespace PassLinkControlToClass
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         ButtonClear = new System.Windows.Forms.Button();
         RichTextBoxReader = new System.Windows.Forms.RichTextBox();
         ListBoxReader = new System.Windows.Forms.ListBox();
         TextBoxReader = new System.Windows.Forms.TextBox();
         ButtonConstructor = new System.Windows.Forms.Button();
         ButtonMethod = new System.Windows.Forms.Button();
         button2 = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // ButtonClear
         // 
         ButtonClear.Location = new System.Drawing.Point(670, 12);
         ButtonClear.Name = "ButtonClear";
         ButtonClear.Size = new System.Drawing.Size(90, 23);
         ButtonClear.TabIndex = 18;
         ButtonClear.Text = "Clear";
         ButtonClear.UseVisualStyleBackColor = true;
         ButtonClear.Click += ButtonClear_Click;
         // 
         // RichTextBoxReader
         // 
         RichTextBoxReader.Location = new System.Drawing.Point(12, 227);
         RichTextBoxReader.Name = "RichTextBoxReader";
         RichTextBoxReader.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
         RichTextBoxReader.Size = new System.Drawing.Size(370, 180);
         RichTextBoxReader.TabIndex = 17;
         RichTextBoxReader.Text = "";
         // 
         // ListBoxReader
         // 
         ListBoxReader.FormattingEnabled = true;
         ListBoxReader.ItemHeight = 15;
         ListBoxReader.Location = new System.Drawing.Point(388, 41);
         ListBoxReader.Name = "ListBoxReader";
         ListBoxReader.ScrollAlwaysVisible = true;
         ListBoxReader.Size = new System.Drawing.Size(372, 184);
         ListBoxReader.TabIndex = 16;
         // 
         // TextBoxReader
         // 
         TextBoxReader.Location = new System.Drawing.Point(12, 41);
         TextBoxReader.Multiline = true;
         TextBoxReader.Name = "TextBoxReader";
         TextBoxReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         TextBoxReader.Size = new System.Drawing.Size(370, 180);
         TextBoxReader.TabIndex = 15;
         // 
         // ButtonConstructor
         // 
         ButtonConstructor.Location = new System.Drawing.Point(12, 12);
         ButtonConstructor.Name = "ButtonConstructor";
         ButtonConstructor.Size = new System.Drawing.Size(220, 23);
         ButtonConstructor.TabIndex = 14;
         ButtonConstructor.Text = "Передача ссылок через конструктор";
         ButtonConstructor.UseVisualStyleBackColor = true;
         ButtonConstructor.Click += ButtonConstructor_Click;
         // 
         // ButtonMethod
         // 
         ButtonMethod.Location = new System.Drawing.Point(238, 12);
         ButtonMethod.Name = "ButtonMethod";
         ButtonMethod.Size = new System.Drawing.Size(185, 23);
         ButtonMethod.TabIndex = 19;
         ButtonMethod.Text = "Передача ссылок через метод";
         ButtonMethod.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         button2.Location = new System.Drawing.Point(429, 12);
         button2.Name = "button2";
         button2.Size = new System.Drawing.Size(210, 23);
         button2.TabIndex = 20;
         button2.Text = "Передача ссылок через интерфейс";
         button2.UseVisualStyleBackColor = true;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(772, 414);
         Controls.Add(button2);
         Controls.Add(ButtonMethod);
         Controls.Add(ButtonClear);
         Controls.Add(RichTextBoxReader);
         Controls.Add(ListBoxReader);
         Controls.Add(TextBoxReader);
         Controls.Add(ButtonConstructor);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Передача ссылок на элементы управления в класс";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button ButtonClear;
      private System.Windows.Forms.RichTextBox RichTextBoxReader;
      private System.Windows.Forms.ListBox ListBoxReader;
      private System.Windows.Forms.TextBox TextBoxReader;
      private System.Windows.Forms.Button ButtonConstructor;
      private System.Windows.Forms.Button ButtonMethod;
      private System.Windows.Forms.Button button2;
   }
}