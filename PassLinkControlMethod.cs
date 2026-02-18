using System;
using System.Drawing;
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
         // Изменение цвета текста в TextBox
         _textBox.ForeColor = Color.Red;
         if (_textBox != null)
         {
            // TextBox
            // Добавляет строку оставляя предыдущие
            _textBox.AppendText(text);
            _textBox.AppendText(Environment.NewLine);
            // Прокрутка TextBox вниз
            _textBox.ScrollToCaret();

            //_textBox.ResetForeColor();
            //_textBox.ForeColor = SystemColors.WindowText;
         }
      }

      public void AddToListBox(string text)
      {
         // Изменение цвета текста в ListBox
         _listBox.ForeColor = Color.Yellow;
         if (_listBox != null)
         {
            // ListBox
            _listBox.Items.Add(text);
            // Прокрутка ListBox вниз
            _listBox.TopIndex = _listBox.Items.Count - 1;

            //_listBox.ResetForeColor();
            //_listBox.ForeColor = SystemColors.WindowText;
         }
      }

      public void AddToRichTextBox(string text)
      {
         // Изменение цвета текста в RichTextBox
         _richTextBox.ForeColor = Color.Green;
         if (_richTextBox != null)
         {
            // RichTextBox
            _richTextBox.AppendText(text);
            _richTextBox.AppendText(Environment.NewLine);
            // Прокрутка RichTextBox вниз
            _richTextBox.ScrollToCaret();

            _richTextBox.ResetForeColor();
            _richTextBox.ForeColor = SystemColors.WindowText;
         }
      }
   }
}