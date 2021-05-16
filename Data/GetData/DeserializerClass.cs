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

namespace BankAccountForm.Data.GetData
{
    //класс дессериализации
    class DeserializerClass
    {
        Consoles consoles;
        GetQuantityDirectoryFile getQuantityDirectoryFile;
        public DeserializerClass ( )
        {

        }

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
                    Console.WriteLine("Ошибка доступа к дирректории или файлу!"); 
                }
            }
            catch(Exception e)
            {
                if (e == null) consoles.ErrorMessage( e );
                StatusDeserializ = true;
            }
            return obj;
        }
    } 
}
