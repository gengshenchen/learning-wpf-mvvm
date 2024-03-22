using karl.View.Windows;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;

//wpf use winform controls
//using WinForm = System.Windows.Forms;


namespace karl.View.UserControls
{
    /// <summary>
    /// Interaction logic for menubar.xaml
    /// </summary>
    public partial class menubar : UserControl
    {
        public menubar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button clickedButton = sender as Button;
            if (clickedButton == null)
            {
                return;
            }

            switch (clickedButton.Name)
            {
                case "btnOpen":
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Multiselect = true;
                        openFileDialog.Filter = "CS file | *.cs| a file | *.a";

                        bool? b = openFileDialog.ShowDialog();
                        if (b == true)
                        {
                            string[] names = openFileDialog.FileNames;
                            txMenuDebug.Text = string.Join(Environment.NewLine, names) ;
                        }
                        else
                        {

                        }
                        // use winform dialog
//                         WinForm.FolderBrowserDialog folderBrowserDialog = new WinForm.FolderBrowserDialog();
//                         WinForm.DialogResult? r = folderBrowserDialog.ShowDialog();
//                         if (r == WinForm.DialogResult.OK)
//                         {
//                             txMenuDebug.Text = folderBrowserDialog.SelectedPath;
//                         }

                    }
                    break;
                case "btnStart":
                    {
                        MessageBoxResult result = MessageBox.Show("hello fucking world", "say hi", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    }
                    break;
                case "btnNormal":
                    {
                        var win = new NormalWindow();
                        win.Show();

                    }
                    break;
                case "btnModal":
                    {
                        var win = new ModalWindow();
                        win.ShowDialog();
                    }
                    break;
                case "btnProduct":
                    {
                        var win = new Product();
                        win.Show();
                    }
                    break;

            }

        }

        public void ChangeTheme(string themePath)
        {
            // 清除当前资源
            Application.Current.Resources.MergedDictionaries.Clear();

            // 创建新的资源字典并设置其源为新主题的路径
            ResourceDictionary newTheme = new ResourceDictionary();
            newTheme.Source = new Uri($"pack://application:,,,/Styles/{themePath}",
                UriKind.RelativeOrAbsolute);

            // 将新主题添加到当前资源
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }


        private void btnDarkTheme_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme("DarkTheme.xaml");
        }

        private void btnLightTheme_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme("LightTheme.xaml");
        }
    }
}
