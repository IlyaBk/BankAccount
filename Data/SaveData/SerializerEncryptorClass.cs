using AccountForm.Encryptor;
using AccountForm.Views;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AccountForm.Data.SaveData
{
    //класс ссериализации
    class SerializerEncryptorClass : ConstantClassData
    {
        //количество иттераций серриализации объектов 
        public int QuantityItterationSerializEncrypt { get; set; }

        public SerializerEncryptorClass()
        {
        }

        //статус серриализации
        public bool StatusSerializEncrypt { get; set; }

        public int itteration = 0;

        //передаём объект серриализации и путь
        public void SerializEncrypt(object obj, string FilePath)
        {
            Aes aes = Aes.Create();
            BinaryFormatter serializer = new BinaryFormatter();
            try
            {
                if( File.Exists(FilePath) )
                {
                    using( FileStream SaveFileStream = new FileStream(FilePath + $"_{itteration++}", FileMode.OpenOrCreate) )
                    {
                        using ( CryptoStream cs = new CryptoStream(  SaveFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write ) )
                        { 
                            serializer.Serialize(SaveFileStream, obj);
                            StatusSerializEncrypt = true;
                        }
                        SaveFileStream.Close();
                    }
                }
                else { Console.WriteLine("Ошибка с доступом к дирректории или файле!"); }
            }
            catch( Exception e )
            {
                Console.WriteLine($"Ошибка серриализации! Ошибка:\n {e}");
                StatusSerializEncrypt = false;
            }
        }
    }
}
