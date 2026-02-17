using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

      public void DoWork()
      {
         if (_textBox != null)
         {
            _textBox.Text = "Работа выполнена";
         }

         if (_listBox != null)
         {
            // ListBox
            //_listBox.Items.Add(item);
            // Прокрутка ListBox вниз
            _listBox.TopIndex = _listBox.Items.Count - 1;
         }

         if (_richTextBox != null)
         {
            // RichTextBox
            //_richTextBox.AppendText(text);
            _richTextBox.AppendText(Environment.NewLine);
            // Прокрутка RichTextBox вниз
            _richTextBox.ScrollToCaret();
         }
      }
   }
}