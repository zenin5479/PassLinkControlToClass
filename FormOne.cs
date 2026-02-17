using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassLinkControlToClass
{
   public partial class FormOne : Form
   {
      private PassLinkControlConstructor _manager;

      private PassLinkControlMethod _processor = new PassLinkControlMethod();

      public FormOne()
      {
         InitializeComponent();
      }

      // Кнопка, использует класс PassLinkControlConstructor
      private void ButtonConstructor_Click(object sender, System.EventArgs e)
      {
         // Создаём экземпляр класса PassLinkControlConstructor и передаём ссылки на элементы: TextBox, ListBox, RichTextBox
         _manager = new PassLinkControlConstructor(TextBoxReader, ListBoxReader, RichTextBoxReader);
         _manager.AddTextBoxText("Передача ссылки на TextBox через конструктор");
         _manager.AddToListBox("Передача ссылки на ListBox через конструктор");
         _manager.AddToRichTextBox("Передача ссылки на RichTextBox через конструктор");
      }

      private void ButtonMethod_Click(object sender, System.EventArgs e)
      {
         _processor.SetControls(TextBoxReader, ListBoxReader, RichTextBoxReader);
         // Теперь можно работать с элементами
         _processor.DoWork(); 
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