using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;

namespace karl.View.UserControls
{
    /// <summary>
    /// Interaction logic for ListviewCtl.xaml
    /// </summary>
    public partial class ListviewCtl : UserControl
    {
        public ListviewCtl()
        {
            DataContext = this;
            Entries = new ObservableCollection<string>();
            InitializeComponent();
        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //             if (!string.IsNullOrEmpty(txtEntry.Text))
            //             {
            //                 lvEntries.Items.Add(txtEntry.Text);
            //                 txtEntry.Clear();
            //             }
            // 
            //             txtEntry.Focus();
            Entries.Add(txtEntry.Text);

        }

        private void btnDel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //             var items = lvEntries.SelectedItems.Cast<object>().ToList();
            //             foreach (var item in items)
            //             {
            //                 lvEntries.Items.Remove(item);
            //             }

            var items = lvEntries.SelectedItems.Cast<string>().ToList();
            foreach (var item in items)
            {
                Entries.Remove(item);

            }
        }

        private void btnClr_Click(object sender, System.Windows.RoutedEventArgs e)
        {
         //   lvEntries.Items.Clear();
         Entries.Clear();
        }
    }
}
