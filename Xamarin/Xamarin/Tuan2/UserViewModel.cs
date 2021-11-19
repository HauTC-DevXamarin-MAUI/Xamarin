using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.Tuan2
{
    public class UserViewModel : BindableObject, INotifyPropertyChanged
    {

        public string SelectedItemText { get; private set; }
        public ICommand OutputAgeCommand { get; set; }
        public ObservableCollection<UserModel> UserList { get; set; }

        public UserViewModel()
        {
            UserList = new ObservableCollection<UserModel>()
            {
                new UserModel("Hậu", 0),
                new UserModel("Nhựt", 1),
                new UserModel("Hân", 1),
            };
            OutputAgeCommand = new Command<UserModel>(HandleOutputAgeCommand);
        }

        private void HandleOutputAgeCommand(UserModel user)
        {
            int sex = user.Sex;
            string gt = sex == 0 ? (gt = "Male") : (gt = "Female");

            SelectedItemText = string.Format("Gender of {0} is {1}", user.Name, gt);
            OnPropertyChanged("SelectedItemText");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;

            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
    public class UserModel
    {
        public string Name { get; set; }
        public int Sex { get; set; }
        public UserModel(string name, int sex)
        {
            this.Name = name;
            this.Sex = sex;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
