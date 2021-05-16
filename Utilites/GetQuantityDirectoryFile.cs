using BankAccountForm.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Utilites
{
    class GetQuantityDirectoryFile: ConstantClassData
    {
        public int GetQuantityAuthorizFile ( )
        {
            return Directory.GetFiles( AutorizDataDirectory ).Length;
        }      
        
        public int GetQuantityDataFile ( )
        {
            return Directory.GetFiles( BinaryDataDirectory ).Length;
        }
    }
}
