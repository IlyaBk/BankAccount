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
    class DeserializerEncryptorClass
    {
        Consoles consoles;

        public DeserializerEncryptorClass()
        {
            // Deserializ(  itteration );
        }

        public bool StatusDeserializEncrypt { get; set; }

        public int itteration { get; set; }
        public object obj { get; set; }

        public object DeserializEncrypt(string FilePath)
        {

            Aes aes = Aes.Create();
            BinaryFormatter deserializer = new BinaryFormatter();
            try
            {
                if( File.Exists(FilePath) )
                {
                    //Выполнение дессириализации из бинара:
                    using( FileStream OpenFileStream = new FileStream(FilePath + $"_{itteration++}", FileMode.Open) )
                    {
                        using( CryptoStream cs = new CryptoStream(OpenFileStream, aes.CreateEncryptor(), CryptoStreamMode.Read) )
                        {
                            obj = deserializer.Deserialize(OpenFileStream);
                        }
                        OpenFileStream.Close();
                    }
                    StatusDeserializEncrypt = true;
                }
                else 
                { 
                    Console.WriteLine("Ошибка доступа к дирректории или файлу!"); 
                }
            }
            catch( Exception e )
            {
                if( e == null ) consoles.ErrorMessage(e);
                StatusDeserializEncrypt = false;
            }
            return obj;
        }
    }
}
