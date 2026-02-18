using System;
using System.Windows.Forms;

namespace PassLinkControlToClass
{
   // Передача ссылок на элементы управления через метод
   public class PassLinkControlMethod
   {
      private TextBox _textBox;
      private ListBox _listBox;
      private RichTextBox _richTextBox;

      // Метод для передачи элементов
      public void SetControls(TextBox textBox, ListBox listBox, RichTextBox richTextBox)
      {
         _textBox = textBox;
         _listBox = listBox;
         _richTextBox = richTextBox;
      }

      public void AddTextBoxText(string text)
      {
         if (_textBox != null)
         {
            // TextBox
            // Добавляет строку оставляя предыдущие
            _textBox.AppendText(text);
            _textBox.AppendText(Environment.NewLine);
            // Прокрутка TextBox вниз
            _textBox.ScrollToCaret();
         }
      }

      public void AddToListBox(string text)
      {
         if (_listBox != null)
         {
            // ListBox
            string text = "Передача ссылки на ListBox через метод";
            _listBox.Items.Add(text);
            // Прокрутка ListBox вниз
            _listBox.TopIndex = _listBox.Items.Count - 1;
         }
      }

      public void AddToRichTextBox()
      {
         if (_richTextBox != null)
         {
            // RichTextBox
            string text = "Передача ссылки на RichTextBox через метод";
            _richTextBox.AppendText(text);
            _richTextBox.AppendText(Environment.NewLine);
            // Прокрутка RichTextBox вниз
            _richTextBox.ScrollToCaret();
         }
      }
   }
}