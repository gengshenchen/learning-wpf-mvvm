using karl.ViewModel;
using System.Collections.Generic;
using System;
using System.Windows;

namespace karl.View.Windows
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        private ProductViewModel vm;
        public Product()
        {
            InitializeComponent();
             vm = new ProductViewModel();
            DataContext = vm;
            //在xaml 指定时失败，So add it in this place.I don't know.
            dg.ItemsSource = vm.Items;
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            vm.Items.Add(new Model.Item { 
                Name = "111name", 
                SerialNumber = "999999",
                Quantity = 10
            });
       
        }
    }
}
