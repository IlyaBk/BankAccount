using BankAccountForm.Data;
using BankAccountForm.Data.SaveData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountForm.Data.GetData;
using BankAccountForm.Utilites;
using BankAccountForm.BaseClasses;
using BankAccountForm.Forms.AccountForms;

namespace BankAccountForm.Logic
{
    class LogicGetAccount
    {
        ConstantClassData constantClassData = new ConstantClassData( );
        DeserializerClass deserializerClass = new DeserializerClass( );
        GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile( );
        
        BankAccountForm<int> [ ] data;

        public LogicGetAccount ( )
        {
            data = new BankAccountForm<int> [ getQuantityDirectoryFile.GetQuantityDataFile( )-1];
        }

        public BankAccountForm<int> this [ int index ]
        {
            get { return data [ index ]; }
            set { data [ index ] = value; }
        }

        public void MethodGetAllData (  )
        {
            var lengthMass = getQuantityDirectoryFile.GetQuantityDataFile( )-1;
            LogicGetAccount BankAccountForm = new LogicGetAccount();
            for ( int i = 0; i < data.Length ; i++ )
            {
                BankAccountForm [ i ] = ( BankAccountForm<int> ) deserializerClass.Deserializ( constantClassData.FileNameBinary );
            }
            deserializerClass.itteration = 0;

            AccountMainForm accountMainForm = new AccountMainForm( BankAccountForm.data, lengthMass );
            accountMainForm.Show( );
        }

        public void MethodGetNoData()
        {
            AccountMainForm accountMainForm = new AccountMainForm();
            accountMainForm.Show();
        }



    }
}
