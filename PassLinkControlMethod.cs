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

      public void DoWork()
      {
         if (_textBox != null)
            _textBox.Text = "Работа выполнена";
      }
   }
}