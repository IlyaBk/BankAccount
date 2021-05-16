using BankAccountForm.Encryptor;
using BankAccountForm.Utilites;
using BankAccountForm.Views;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BankAccountForm.Data.SaveData
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
                else { Console.WriteLine("Ошибка доступа к дирректории или файлу!"); }
            }
            catch (Exception e)
            {
                Console.WriteLine( $"Ошибка серриализации! Ошибка:\n {e}");
                StatusSerializ = false; 
            }
        }
    }
}
