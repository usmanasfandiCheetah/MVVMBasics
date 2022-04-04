using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.ViewModels
{
    public class UsersViewModel : BaseNotifier
    {
        private ObservableCollection<User> _usersList;

        public ObservableCollection<User> UsersList { get => _usersList; set => SetProperty(ref _usersList,value); }

        private User _currentUser;
        public User CurrentUser { get => _currentUser; set => SetProperty(ref _currentUser,value); }

        public ICommand AddUserCommand { get; set; }
        public ICommand NewCommand { get; set; }

        public UsersViewModel()
        {
            CurrentUser = new User();
            UsersList = new ObservableCollection<User>();

            AddUserCommand = new RelayCommand(new Action<object>(ExecuteAddUserCommand));
            NewCommand = new RelayCommand(new Action<object>(ExecuteNewCommand));


        }

        private void ExecuteNewCommand(object obj)
        {
            CurrentUser = new User();
        }

        private void ExecuteAddUserCommand(object obj)
        {
            UsersList.Add(CurrentUser);
        }
    }
}
