using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountForm.Data.GetData
{
    class DeserializerJsonClass : ConstantClassData
    {
        public int ItterationJson = 0;
        internal object obj = null;

        public async void DeserializerToJson ()
        {
            obj = null;
            try
            {
                Console.WriteLine( "Десериаллизация из JSON!" );
                using ( FileStream fileStream = new FileStream( FileNameJson, FileMode.Open ) )
                {
                   // obj = await JsonSerializer.DeserializeAsync<object>( fileStream );
                    ItterationJson++;
                }
            }
            catch ( Exception e )
            {
                //consoles.ErrorMessage( e );
            }
        }
    }
}
