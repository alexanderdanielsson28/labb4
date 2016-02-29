using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using newfriday.Helper;
using static newfriday.bin;


namespace newfriday
{
    public class MainViewModel:ObservableObject

    {
       
        public ObservableCollection<BaseMessage> listMail { get; protected set; }
        List<BaseMessage> listBase = new List<BaseMessage>();
        List<String> userName1 = new List<String>();
        List<String> userName2 = new List<String>();

        Model model = new Model();
        string getName;
        private string _button;
        private string _subject;
        private string _sender;
        private string _message;
        private string _reciever;
     
        public string Reciever
        {
            get { return _reciever; }
            set { _reciever = value;
                
            }
           
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public string Sender
        {
            get { return _sender; }
            set { _sender = value;
               
            }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }


        public string Button
        {
            get { return _button; }
            set
            {
                _button = value;
                
             
            }

        }
       private BaseMessage _selected;

        public BaseMessage selected
        {
            get { return _selected; }
            set {
                    _selected = value;
                    OnPropertyChanged("selected");
             

            }
                        
        }           
     

        public MainViewModel()
        {

            userName2 = Model.readFromXmlFile(userName2);
            listMail = new ObservableCollection<BaseMessage>();
            listBase = Model.readFromFile(listBase);
            



            foreach (BaseMessage line in listBase)
            {
                int count = 0;
                count++;
                listMail.Add(line);


            }




        }

  

        public ICommand button
        {
            get { return new CommandHandler(createMail); }
        }

        public ICommand buttonDelete
        {
            get { return new CommandHandler(deleteMail); }
        }

        public void createMail()
        {
            userName2 = Model.readFromXmlFile(userName2);
            BaseMessage meddelande = new BaseMessage();
            string _send = Sender;
            var it=userName2.Count();
            var v=it - 1;
            if (_send != userName2[(v)])
            {
                if (_send != null)
                {
                    userName2.Add(_send);
                    Model.writeToXmlFile(userName2);
                    userName2.Clear();
                


                }
                else
                {
                    _send = userName2[(v)];
                }

            }



            meddelande.Sender = _send;
            meddelande.Reciever = Reciever;
            meddelande.Subject = Subject;
            meddelande.Message = Message;
            listMail.Add(meddelande);
            listBase.Add(meddelande);

            userName2.Clear();
            Model.writeToFile(listBase);
         



        }

       

        private void deleteMail()
        {
            bool check=listMail.Contains(selected);
            if (check)
            {
                listMail.Remove(selected);

                 listBase = listMail.ToList();


              
                
                Model.writeToFile(listBase);
               
      
            }

        }
       


        
       
    }


}