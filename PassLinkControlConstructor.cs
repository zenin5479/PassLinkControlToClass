using System;
using System.Windows.Forms;

namespace PassLinkControlToClass
{
   // Передача ссылок через конструктор
   public class PassLinkControlConstructor
   {
      private TextBox _textBox;
      private ListBox _listBox;
      private RichTextBox _richTextBox;

      // Конструктор, принимающий ссылки
      public PassLinkControlConstructor(TextBox textBox, ListBox listBox, RichTextBox richTextBox)
      {
         _textBox = textBox;
         _listBox = listBox;
         _richTextBox = richTextBox;
      }

      // Добавляет текст в TextBox
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

      // Добавляет элемент в ListBox
      public void AddToListBox(string item)
      {
         if (_listBox != null)
         {
            _listBox.Items.Add(item);
            // ListBox
            ListBoxReader.Items.Add(line);
            // Прокрутка ListBox вниз
            ListBoxReader.TopIndex = ListBoxReader.Items.Count - 1;

         }
      }

      // Пример: добавляем текст в RichTextBox
      public void AddToRichTextBox(string text)
      {
         if (_richTextBox != null)
         {
            _richTextBox.AppendText(text + "\n");
         }
      }
   }
}