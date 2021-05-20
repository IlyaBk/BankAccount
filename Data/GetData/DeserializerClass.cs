using BankAccountForm.Utilites;
using BankAccountForm.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BankAccountForm.Forms.NotificationForms;
using System.Drawing;

namespace BankAccountForm.Data.GetData
{
    //класс дессериализации
    class DeserializerClass
    {
        public DeserializerClass ( ) {}

        NotificationForm notificationForm = new NotificationForm();

        public bool StatusDeserializ { get; set; }
        public int itteration { get; set; }
        public object obj { get; set; }
        public object Deserializ ( string FilePath)
        {

            BinaryFormatter deserializer = new BinaryFormatter( );
            try
            {
                if ( File.Exists( FilePath ) )
                {
                    //Выполнение дессириализации из бинара:
                    using ( FileStream OpenFileStream = new FileStream( FilePath + $"_{itteration++}", FileMode.Open ) )
                    {
                           obj =  deserializer.Deserialize(OpenFileStream);
                        OpenFileStream.Close( );
                    }
                    StatusDeserializ = true;
                }
                else 
                {
                    notificationForm.ShowTextNotification
                        ("Ошибка доступа к дирректории или файлу!",
                        "", 
                        Color.Red,
                        Color.Red);
                }
            }
            catch(Exception e)
            {
                if( e == null )
                    notificationForm.ShowTextNotification
                        ("Ошибка дессириализации из бинара!",
                        e.ToString(), 
                        Color.Red,
                        Color.Red);

            }
            return obj;
        }
    } 
}
