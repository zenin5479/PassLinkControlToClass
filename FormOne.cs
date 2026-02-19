using System.Windows.Forms;

namespace PassLinkControlToClass
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      // Кнопка, использует класс PassLinkControlConstructor принимающий ссылки на элементы управления
      private void ButtonConstructor_Click(object sender, System.EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылки на элементы управления: TextBox, ListBox, RichTextBox
         // Локальная переменная: создаётся здесь и живёт только в этом методе
         PassLinkControlConstructor constructor = new PassLinkControlConstructor(TextBoxReader, ListBoxReader, RichTextBoxReader);
         // Вызываем метод AddTextBoxText()
         constructor.AddTextBoxText("Передача ссылки в класс на TextBox через конструктор");
         // Вызываем метод AddToListBox()
         constructor.AddToListBox("Передача ссылки в класс на ListBox через конструктор");
         // Вызываем метод AddToRichTextBox()
         constructor.AddToRichTextBox("Передача ссылки в класс на RichTextBox через конструктор");
      }

      // Кнопка, использует класс PassLinkControlMethod
      private void ButtonMethod_Click(object sender, System.EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылки на элементы управления: TextBox, ListBox, RichTextBox
         // Локальная переменная: создаётся здесь и живёт только в этом методе
         PassLinkControlMethod method = new PassLinkControlMethod();
         method.SetControls(TextBoxReader, ListBoxReader, RichTextBoxReader);
         // Вызываем метод AddTextBoxText()
         method.AddTextBoxText("Передача ссылки в класс на TextBox через метод");
         // Вызываем метод AddToListBox()
         method.AddToListBox("Передача ссылки в класс на ListBox через метод");
         // Вызываем метод AddToRichTextBox()
         method.AddToRichTextBox("Передача ссылки в класс на RichTextBox через метод");
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