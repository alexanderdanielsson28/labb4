using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newfriday
{
        public class Person //: INotifyPropertyChanged
        {
        private string _sender;

        public void BaseMessage()
        {
            Sender = _sender;

        }

        public string Time
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd HH.mm");
            }
            set { }
        }



        public string Reciever { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int count { get; set; }
        public string unread { get; set; }

        public string Sender
        {
            get { return _sender; }
            set
            {
                _sender = value;

            }

        }
    }

    //public string Name { get; set; }
    //public int Age { get; set; }

    //public Person(string name, int age)
    //{
    //    Name = name;
    //    Age = age;
    //}

    //public event PropertyChangedEventHandler PropertyChanged;

    //private void RaisePropertyChanged(string propName)
    //{
    //    PropertyChanged(this, new PropertyChangedEventArgs(propName));
    //}
}
    

