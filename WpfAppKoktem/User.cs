using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKoktem
{
    
    //public void DefaultUsers()
    //{
    //    user defaultUser = new user();
    //    defaultUser.name = "Воронюк Надежда Степановна";
    //    defaultUser.telephoneNumber = "+1(234)5678301";
    //    defaultUser.old = "1972";
    //    defaultUser.photo = "C:\\Users\\Prigo\\Desktop\\3.png";

    //    //listUsers.Items.Clear();
    //    listUsers.Items.Add(defaultUser);
    //}
    public class User : INotifyPropertyChanged
    {
        private string photo;
        private string name;
        private string old;
        private string telephoneNumber;

        public string Photo
        {
            get { return photo; }
            set
            {
                photo = value;
                OnPropertyChanged("C:\\Users\\Prigo\\Desktop\\3.png");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("");
            }
        }
        public string Old
        {
            get { return old; }
            set
            {
                old = value;
                OnPropertyChanged("");
            }
        }
        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set
            {
                telephoneNumber = value;
                OnPropertyChanged("");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

