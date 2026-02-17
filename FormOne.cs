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
         // Создаём менеджер и передаём ссылки на элементы
         _manager = new PassLinkControlConstructor(
            TextBoxReader,   // ваш TextBox на форме
            listBox1,    // ваш ListBox на форме
            richTextBox1 // ваш RichTextBox на форме
         );

         _manager.SetTextBoxText("Привет из менеджера!");
         _manager.AddToListBox("Элемент 1");
         _manager.AppendToRichTextBox("Строка в RichTextBox");
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