using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AccountForm.Forms.NotificationForms;
using System.Drawing;

namespace AccountForm.Data.GetData
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
                    notificationForm.ShowTextNotificationMini
                        ("Ошибка доступа к дирректории или файлу!",
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
