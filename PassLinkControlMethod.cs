using System;
using System.Windows.Forms;

namespace PassLinkControlToClass
{
   // Передача ссылок в класс на элементы управления через метод
   public class PassLinkControlMethod
   {
      private TextBox _textBox;
      private ListBox _listBox;
      private RichTextBox _richTextBox;

      // Метод принимающий ссылки передачи элементов
      public void SetControls(TextBox textBox, ListBox listBox, RichTextBox richTextBox)
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
      public void AddToListBox(string text)
      {
         if (_listBox != null)
         {
            // ListBox
            _listBox.Items.Add(text);
            // Прокрутка ListBox вниз
            _listBox.TopIndex = _listBox.Items.Count - 1;
         }
      }

      // Добавляет текст в RichTextBox
      public void AddToRichTextBox(string text)
      {
         if (_richTextBox != null)
         {
            // RichTextBox
            _richTextBox.AppendText(text);
            _richTextBox.AppendText(Environment.NewLine);
            // Прокрутка RichTextBox вниз
            _richTextBox.ScrollToCaret();
         }
      }
   }
}