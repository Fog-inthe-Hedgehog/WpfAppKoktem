using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKoktem
{
    public class ApplicationViewModel : INotifyCollectionChanged
    {
        private User selectedUser;

        public ObservableCollection<User> Users { get; set; }
        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        private RelayCommand addCommand; // Добавление нового объекта
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        User user = new User();
                        Users.Insert(0, user);
                        SelectedUser = user;
                        user.Photo = "Images/5.png";
                    }));
            }
        }
        private RelayCommand removeCommand; // Удаление
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      User user = obj as User;
                      if (user != null)
                      {
                          Users.Remove(user);
                      }
                  },
                 (obj) => Users.Count > 0));
            }
        }

        RelayCommand imageCommand;
        public RelayCommand ImageCommand
        {
            get
            {
                return imageCommand ??
                    (imageCommand = new RelayCommand(obj =>
                    {
                        
                        if (SelectedUser != null)
                        {
                            User user = new User();
                            user = SelectedUser;
                            
                            OpenFileDialog openDialog = new OpenFileDialog();
                            openDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                            if(openDialog.ShowDialog()==true)
                            {
                                user.Photo = openDialog.FileName;
                                user.Name = user.Name;
                            }

                        }
                    }));
            }
        }

        public ApplicationViewModel()
        {
            Users = new ObservableCollection<User>
            {
                new User { Photo="Images/1.png", Name="Пупкин Василий Петрович", Old="1978", TelephoneNumber="+7(927)3452635" },
                new User { Photo="Images/2.jpg", Name="Иванов Иван Иванович", Old="1962", TelephoneNumber="+7(777)3546747" },
                new User { Photo="Images/3.png", Name="Добрынин Василевс Зевсович", Old="1972", TelephoneNumber="+7(777)7777777" },
                new User { Photo="Images/4.png", Name="Стрельникова Наталья Петровна", Old="1974", TelephoneNumber="+7(707)4569856" },

            };

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Image_MouseDown()
        {
            
        }
    }
}
