using AccountForm.Forms;
using AccountForm.Forms.NotificationForms;
using AccountForm.Utilites;
using AccountForm.Views;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AccountForm.Data.SaveData
{
    //класс ссериализации
    class SerializerClass
    {     
        public SerializerClass (  )
        {
        }

        //количество иттераций серриализации объектов
        public int QuantityItteration { get; set; }

        //статус серриализации
        public bool StatusSerializ { get; set; }


        //передаём объект серриализации и путь
        public async  void Serializ ( object obj, string FilePath)
        {
            NotificationForm notificationForm = new NotificationForm( );
            GetQuantityDirectoryFile getquantityDirectoryFile = new GetQuantityDirectoryFile();
            BinaryFormatter serializer = new BinaryFormatter( );
            try
            {
                if ( File.Exists(FilePath) )
                {
                    using ( FileStream SaveFileStream = new FileStream(FilePath + $"_{getquantityDirectoryFile.GetQuantityDataFile()-1}", FileMode.OpenOrCreate ) )
                    {
                        serializer.Serialize(SaveFileStream, obj );

                        SaveFileStream.Close( );
                    }
                }
                else 
                {
                    notificationForm.ShowTextNotification( "Ошибка доступа к дирректории или файлу!", "", Color.Red, Color.Red );
                }
            }
            catch (Exception e)
            {
                notificationForm.ShowTextNotification( "Ошибка серриализации!", e.ToString(), Color.Red, Color.Red );
                StatusSerializ = false; 
            }
        }
    }
}
