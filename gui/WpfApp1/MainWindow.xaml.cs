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
using System.Linq.Expressions;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedPath = string.Empty;
        public string SelectedPath => selectedPath;
        
        private string selectednewPath = string.Empty;
        public string SelectednewPath => selectednewPath;

        public MainWindow()
        {
            InitializeComponent();
            MinHeight = 200;
            MinWidth = 500;
            MaxHeight = 300;
            MaxWidth = 600;
        }


        /* 
         pense que podia hacer esto ahora pero tengo que implementar mas botones
        en la logica del programa asi q no
        esto se supone q deberia manejar la logica de MODIFICAR un perfil ya creado
        por lo que deberia primero revisar si existen los archivos antiguos, si no, se copian los anteriores y se ponen

        aun que pensandolo bien deberia probar si cambio el nombre encriptado con ATF-8 para URLs solamente
        aparece en el juego y es usable
        si es asi seria mas facil, puedo solamente modificar el archivo existente
         
         
         RESUELTO
         */

        public void Modifyprofile()
        {
            if (string.IsNullOrEmpty(selectedPath) || !Directory.Exists(selectedPath))
            {
                System.Windows.MessageBox.Show("Source directory is invalid or does not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(selectednewPath))
            {
                System.Windows.MessageBox.Show("Destination directory is invalid or not selected.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // Copy directories
                foreach (string directory in Directory.GetDirectories(selectedPath, "*", SearchOption.AllDirectories))
                {
                    string relativePath = System.IO.Path.GetRelativePath(selectedPath, directory);
                    string targetDirectory = System.IO.Path.Combine(selectednewPath, relativePath);

                    // Create the directory in the destination
                    Directory.CreateDirectory(targetDirectory);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

                try
                {
                    // Define the profile file names
                    string codedname = System.IO.Path.GetFileName(selectedPath);
                    string codednewname = System.IO.Path.GetFileName(selectednewPath);

                    string[] profileFiles = new[]
                    {
            $"{codedname}.Arma3Profile",
            $"{codedname}.vars.Arma3Profile",
            $"{codedname}.3den.Arma3Profile"
        };

                    foreach (string profileFile in profileFiles)
                    {
                        string sourceFilePath = System.IO.Path.Combine(selectedPath, profileFile);

                        // Check if the file exists
                        if (File.Exists(sourceFilePath))
                        {
                            // Rename the file
                            string newFileName = profileFile.Replace(codedname, codednewname);
                            string destinationFilePath = System.IO.Path.Combine(selectednewPath, newFileName);

                            // Ensure the destination directory exists
                            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(destinationFilePath) ?? string.Empty);

                            // Copy the file to the destination
                            File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
                        }
                    }

                    System.Windows.MessageBox.Show("Profile files copied successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        private void Createnewprofile()
        {
            if (string.IsNullOrEmpty(selectedPath) || !Directory.Exists(selectedPath))
            {
                System.Windows.MessageBox.Show("Source directory is invalid or does not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Prompt the user to select the parent directory for the new profile
            Winforms.FolderBrowserDialog dialog = new();
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "Select your \"Arma 3 - Other Profiles\" folder";
            Winforms.DialogResult result = dialog.ShowDialog();

            if (result != Winforms.DialogResult.OK || string.IsNullOrEmpty(dialog.SelectedPath))
            {
                System.Windows.MessageBox.Show("No parent directory selected.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Serialize the new profile name
            string newProfileName = newprofile_name.Text;
            if (string.IsNullOrEmpty(newProfileName))
            {
                System.Windows.MessageBox.Show("New profile name cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string serializedNewProfileName = StrictHttpEncode(newProfileName);
            selectednewPath = System.IO.Path.Combine(dialog.SelectedPath, serializedNewProfileName);

            try
            {
                // Create the new profile directory
                Directory.CreateDirectory(selectednewPath);

                // Copy directories
                foreach (string directory in Directory.GetDirectories(selectedPath, "*", SearchOption.AllDirectories))
                {
                    string relativePath = System.IO.Path.GetRelativePath(selectedPath, directory);
                    string targetDirectory = System.IO.Path.Combine(selectednewPath, relativePath);

                    // Create the directory in the destination
                    Directory.CreateDirectory(targetDirectory);
                }

                // Define the profile file names
                string codedname = System.IO.Path.GetFileName(selectedPath);

                string[] profileFiles = new[]
                {
            $"{codedname}.Arma3Profile",
            $"{codedname}.vars.Arma3Profile",
            $"{codedname}.3den.Arma3Profile"
        };

                foreach (string profileFile in profileFiles)
                {
                    string sourceFilePath = System.IO.Path.Combine(selectedPath, profileFile);

                    // Check if the file exists
                    if (File.Exists(sourceFilePath))
                    {
                        // Rename the file
                        string newFileName = profileFile.Replace(codedname, serializedNewProfileName);
                        string destinationFilePath = System.IO.Path.Combine(selectednewPath, newFileName);

                        // Ensure the destination directory exists
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(destinationFilePath) ?? string.Empty);

                        // Copy the file to the destination
                        File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
                    }
                }

                System.Windows.MessageBox.Show("New profile created successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
            string messageBoxText = "BEWARE! This software does NOT create a backup of your settings as of yet. If you want one in case the software fails, press cancel and do it. If you're feeling reckless, press OK.";
            string caption = "BACKUP?";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;

            result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.MessageBox.Show("YE!");
                if (Swapbtn.IsChecked == true)
                    {
                    Modifyprofile();
                } else
                {
                    Createnewprofile();
                }
            }
            else
            {
                Winforms.MessageBox.Show("You were wise! Canceling...");
            }
        }

        private void swapbtn_Click(object sender, RoutedEventArgs e)
        {
            string decodednewname = string.Empty;

            Winforms.FolderBrowserDialog dialog2 = new();
            dialog2.Description = "Select a folder";
            Winforms.DialogResult result = dialog2.ShowDialog(); // shows the window
            if (result == Winforms.DialogResult.OK) // not if its OK just if it is clicked OK
            {
                selectednewPath = dialog2.SelectedPath;
                newprofiledir.Text = selectednewPath;
                proceedbtn.IsEnabled = true;
                string codednewprofile = System.IO.Path.GetFileName(selectednewPath); // added system.io cause of ambiguity

                Newprof_notfixed.Text = codednewprofile; // puts the encoded name into the field duh.....

                decodednewname = HttpUtility.UrlDecode(codednewprofile);

                Newprof_fixedtxt.Text = decodednewname; // adds the decoded name after urldecode in the oldprof field

            }
        }

        private void newprofiledir_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Newprof_notfixed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Newprof_fixedtxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public static string StrictHttpEncode(string input)
        {
            var sb = new StringBuilder();
            foreach (char c in input)
            {
                // Encode everything except A-Z, a-z, 0-9
                if ((c >= 'a' && c <= 'z') ||
                    (c >= 'A' && c <= 'Z') ||
                    (c >= '0' && c <= '9'))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append($"%{(int)c:X2}");
                }
            }
            return sb.ToString();
        }

        private void newprofile_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Ensure newprofile_serialized gets updated whenever newprofile_name changes
            if (newprofile_name != null && newprofile_serialized != null)
            {
                newprofile_serialized.Text = StrictHttpEncode(newprofile_name.Text);
            }
        }

        private void newprofile_serialized_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
