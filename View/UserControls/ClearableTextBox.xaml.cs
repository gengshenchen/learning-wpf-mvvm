using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace karl.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl, INotifyPropertyChanged
    {
        public ClearableTextBox()
        {
            DataContext = this;
            InitializeComponent();
        }
        private string placehoder;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Placehoder
        {
            get { return placehoder; }
            set { placehoder = value;
                onPropertyChanged();
            }
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            Placehoder = "set from code ";
            tbInput.Clear();
            tbInput.Focus();
        }

        private void tbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;

            }else {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
        
        private void onPropertyChanged([CallerMemberName]string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
