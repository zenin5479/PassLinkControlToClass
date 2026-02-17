using System.Windows.Forms;

namespace PassLinkControlToClass
{
   public partial class FormOne : Form
   {
      private PassLinkControlConstructor _constructor;

      private PassLinkControlMethod _method;

      public FormOne()
      {
         InitializeComponent();
      }

      // Кнопка, использует класс PassLinkControlConstructor
      private void ButtonConstructor_Click(object sender, System.EventArgs e)
      {
         // Создаём экземпляр класса PassLinkControlConstructor и передаём ссылки на элементы: TextBox, ListBox, RichTextBox
         _constructor = new PassLinkControlConstructor(TextBoxReader, ListBoxReader, RichTextBoxReader);
         _constructor.AddTextBoxText("Передача ссылки на TextBox через конструктор");
         _constructor.AddToListBox("Передача ссылки на ListBox через конструктор");
         _constructor.AddToRichTextBox("Передача ссылки на RichTextBox через конструктор");
      }

      private void ButtonMethod_Click(object sender, System.EventArgs e)
      {
         _method = new PassLinkControlMethod();
         _method.SetControls(TextBoxReader, ListBoxReader, RichTextBoxReader);
         // Теперь можно работать с элементами
         _method.DoWork();
      }

      // Кнопка очищает все злементы
      private void ButtonClear_Click(object sender, System.EventArgs e)
      {
         TextBoxReader.Clear();
         RichTextBoxReader.Clear();
         ListBoxReader.Items.Clear();
      }
   }
}