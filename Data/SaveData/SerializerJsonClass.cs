using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using AccountForm.Views;

namespace AccountForm.Data.SaveData
{
    class SerializerJsonClass : ConstantClassData
    {
        public int ItterationJson = 0;

        Consoles consoles = new Consoles();

        public async void  SerializerToJson ( object obj)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            try
            {
                //Console.WriteLine( "Серриализация в JSON!" );
                using (FileStream fileStream = new FileStream( FileNameJson, FileMode.Append ))
                { 
                    await JsonSerializer.SerializeAsync( fileStream, obj, options);
                    ItterationJson++;
                } 
            }
            catch(Exception e)
            {
                consoles.ErrorMessage( e );
            }
        }
    }
}
