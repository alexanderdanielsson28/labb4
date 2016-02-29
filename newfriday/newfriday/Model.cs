using newfriday.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static newfriday.bin;
using static newfriday.writeReadXml;

namespace newfriday
{
    
    class Model:ObservableObject
    {
        

        public static void writeToFile(List<BaseMessage> listBase)
        {
            BinarySerialization.WriteToBinaryFile<List<BaseMessage>>("C:/Users/Alex/Desktop/mail/inbox/idai", listBase);
        }

        public static List<BaseMessage> readFromFile(List<BaseMessage>listBase)
        {
           


            listBase = BinarySerialization.ReadFromBinaryFile<List<BaseMessage>>(@"C:\Users\Alex\Desktop\mail\inbox\idai");

           
            return listBase;
        }


        public static void writeToXmlFile(List<string> sender)
        {
            XmlSerialization.WriteToXmlFile<List<string>>("C:/Users/Alex/Desktop/mail/User_sender.xml", sender);
         
        }

        public static List<string> readFromXmlFile(List<string>sender)
        {
            List<string> people= XmlSerialization.ReadFromXmlFile<List<string>>(@"C:\Users\Alex\Desktop\mail\User_sender.xml");
            return people;
        }

    }
    
}
