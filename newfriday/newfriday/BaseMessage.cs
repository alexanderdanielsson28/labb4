using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newfriday
{
    [Serializable]
  public  class BaseMessage
    {
            

            public BaseMessage()
            {
               // Sender = _sender;

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

        private string _sender;
        public string Sender
            {
            get { return _sender; }
    set
            {
                
                _sender = value;

            }

        }
        
    }
}
