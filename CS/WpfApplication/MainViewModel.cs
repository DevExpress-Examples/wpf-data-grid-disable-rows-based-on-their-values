﻿using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;

namespace WpfApplication {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Item> Items {
            get { return GetValue<ObservableCollection<Item>>(); }
            set { SetValue(value); }
        }
        public Item CurrentItem {
            get { return GetValue<Item>(); }
            set { SetValue(value); }
        }

        public MainViewModel() {
            Items = GetData();
            CurrentItem = Items.FirstOrDefault();
        }

        static ObservableCollection<Item> GetData() {
            var collection = Enumerable.Range(0, 15).Select(x => new Item { AllowEdit = x % 3 != 0, Name = $"Name{x}", ID = x });
            return new ObservableCollection<Item>(collection);
        }
    }

    public class Item : BindableBase {
        public string Name {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public int ID {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public bool AllowEdit {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }
    }
}
