using System.Windows.Forms;

namespace PassLinkControlToClass
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      // Кнопка, использует класс PassLinkControlConstructor
      private void ButtonConstructor_Click(object sender, System.EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылки на элементы: TextBox, ListBox, RichTextBox
         // Локальная переменная: создаётся здесь и живёт только в этом методе
         PassLinkControlConstructor constructor = new PassLinkControlConstructor(TextBoxReader, ListBoxReader, RichTextBoxReader);
         constructor.AddTextBoxText("Передача ссылки на TextBox через конструктор");
         constructor.AddToListBox("Передача ссылки на ListBox через конструктор");
         constructor.AddToRichTextBox("Передача ссылки на RichTextBox через конструктор");
      }

      // Кнопка, использует класс PassLinkControlMethod
      private void ButtonMethod_Click(object sender, System.EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылки на элементы: TextBox, ListBox, RichTextBox
         // Локальная переменная: создаётся здесь и живёт только в этом методе
         PassLinkControlMethod method = new PassLinkControlMethod();
         method.SetControls(TextBoxReader, ListBoxReader, RichTextBoxReader);
         // Теперь можно работать с элементами
         method.DoWork();
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