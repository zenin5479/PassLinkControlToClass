using System.Windows.Forms;

namespace PassLinkControlToClass
{
   public partial class FormOne : Form
   {
      private PassLinkControlConstructor _manager;

      public FormOne()
      {
         InitializeComponent();
      }

      private void ButtonConstructor_Click(object sender, System.EventArgs e)
      {
         // Создаём менеджер и передаём ссылки на элементы// ваш TextBox на форме // ваш ListBox на форме// ваш RichTextBox на форме
         _manager = new PassLinkControlConstructor(TextBoxReader, ListBoxReader, RichTextBoxReader);
         _manager.SetTextBoxText("Передача ссылок через конструктор");
         _manager.AddToListBox("Передача ссылок через конструктор");
         _manager.AppendToRichTextBox("Передача ссылок через конструктор");
      }

      // Пример: кнопка, которая использует менеджер
      private void ButtonMethod_Click(object sender, System.EventArgs e)
      {

      }

      private void ButtonInterface_Click(object sender, System.EventArgs e)
      {

      }

      private void ButtonClear_Click(object sender, System.EventArgs e)
      {
         TextBoxReader.Clear();
         RichTextBoxReader.Clear();
         ListBoxReader.Items.Clear();
      }
   }
}