using System.Text;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Winforms = System.Windows.Forms;
using System.IO;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedPath = string.Empty;
        public string SelectedPath => selectedPath;

        public MainWindow()
        {
            InitializeComponent();
            MinHeight = 200;
            MinWidth = 500;
            MaxHeight = 300;
            MaxWidth = 600;
        }

        private void bwbutton_Click(object sender, RoutedEventArgs e)
        {
            string decodedname = string.Empty;

            Winforms.FolderBrowserDialog dialog = new();
            dialog.Description = "Select a folder";
            Winforms.DialogResult result = dialog.ShowDialog(); // shows the window
            if (result == Winforms.DialogResult.OK) // not if its OK just if it is clicked OK
            {
                selectedPath = dialog.SelectedPath;
                Directorytxt.Text = selectedPath;
                proceedbtn.IsEnabled = true;
                string codedprofile = System.IO.Path.GetFileName(selectedPath); // added system.io cause of ambiguity

                Namenot_fixed.Text = codedprofile; // puts the encoded name into the field duh.....

                decodedname = HttpUtility.UrlDecode(codedprofile);

                Oldprof_name.Text = decodedname; // adds the decoded name after urldecode in the oldprof field
                
            }
        }

        private void Directorytxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Oldprof_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Namenot_fixed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Swapbtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Createbtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void proceedbtn_Click(object sender, RoutedEventArgs e)
        {
            
            Console.WriteLine("pressed");
            string messageBoxText = "pressed";
            string caption = "a";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;

            result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }
    }
}
