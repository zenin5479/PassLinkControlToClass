using System.Windows.Forms;

namespace PassLinkControlToClass
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      private void ButtonConstructor_Click(object sender, System.EventArgs e)
      {

      }

      private void ButtonClear_Click(object sender, System.EventArgs e)
      {
         TextBoxReader.Clear();
         RichTextBoxReader.Clear();
         ListBoxReader.Items.Clear();
      }

      private void ButtonInterface_Click(object sender, System.EventArgs e)
      {

      }

      private void ButtonMethod_Click(object sender, System.EventArgs e)
      {

      }
   }
}