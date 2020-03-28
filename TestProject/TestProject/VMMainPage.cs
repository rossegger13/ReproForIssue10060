using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestProject {
    public class VMMainPage : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<MainPageModel> _myItems;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<MainPageModel> MyItems {
            get {
                return _myItems;
            }
            set {
                if (value == _myItems) {
                    return;
                }
                _myItems = value;
                OnPropertyChanged();
            }
        }

        public VMMainPage() {
            if (MyItems == null) {
                MyItems = new ObservableCollection<MainPageModel>();
            }

            MyItems.Add(new MainPageModel {
                Id = 3,
                Name = "First Item",
                Description = "This is the description of the first item"
            });

            MyItems.Add(new MainPageModel {
                Id = 5,
                Name = "Second Item",
                Description = "This is the description of the second item"
            });

            MyItems.Add(new MainPageModel {
                Id = 6,
                Name = "Third Item",
                Description = "This is the description of the third item"
            });
        }


        public void DeleteItem(int id) {
            List<MainPageModel> ItemToRemove = new List<MainPageModel>();
            foreach (var item in MyItems) {
                if (item.Id == id) {
                    ItemToRemove.Add(item);
                }
            }
            foreach (var item in ItemToRemove) {
                MyItems.Remove(item);
            }
        }
    }
}
