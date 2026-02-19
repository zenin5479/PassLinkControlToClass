using System;
using System.Windows.Forms;

namespace PassLinkControlToClass
{
   // Передача ссылок в класс на элементы управления через конструктор
   public class PassLinkControlConstructor
   {
      private readonly TextBox _textBox;
      private readonly ListBox _listBox;
      private readonly RichTextBox _richTextBox;

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
            // ListBox
            _listBox.Items.Add(item);
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