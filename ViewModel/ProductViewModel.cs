using karl.Model;

using karl.MVVM;
using System.Collections.ObjectModel;
using System.Windows.Navigation;


namespace karl.ViewModel
{
    internal class ProductViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items;
        public RelayCommand addCommand => new RelayCommand( e => AddItem());
        public RelayCommand deleteCommand => new RelayCommand(e => DeleteItem(),canExe => { return SelectedItem != null; });

        public ProductViewModel() {

            Items = new ObservableCollection<Item>();
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set { 
                selectedItem = value;
                OnPropertyChanged();
                }
        }

        private void AddItem() {
            Items.Add(new Item
            {
                Name = "XXXXXXXXXX",
                SerialNumber = "qqqqqqq",
                Quantity = 0
            }) ;
        }

        private void DeleteItem()
        {
           Items.Remove(selectedItem);
        }
    }
}
