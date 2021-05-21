using AccountForm.Data;
using AccountForm.Data.SaveData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountForm.Data.GetData;
using AccountForm.Utilites;
using AccountForm.BaseClasses;
using AccountForm.Forms.AccountForms;
using AccountForm.Forms.NotificationForms;
using System.Drawing;

namespace AccountForm.Logic
{
    class LogicGetAccount
    {
        NotificationForm notificationForm = new NotificationForm( );
        ConstantClassData constantClassData = new ConstantClassData( );
        DeserializerClass deserializerClass = new DeserializerClass( );
        GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile( );
        
        AccountForm<int> [ ] data;

        public LogicGetAccount ( )
        {
            data = new AccountForm<int> [ getQuantityDirectoryFile.GetQuantityDataFile( )-1];
        }

        public AccountForm<int> this [ int index ]
        {
            get { return data [ index ]; }
            set { data [ index ] = value; }
        }

        public void MethodGetAllData (  )
        {
            var lengthMass = getQuantityDirectoryFile.GetQuantityDataFile( )-1;
            LogicGetAccount account = new LogicGetAccount();
            try
            {
                for ( int i = 0; i < data.Length; i++ )
                {
                    account [ i ] = ( AccountForm<int> ) deserializerClass.Deserializ( constantClassData.FileNameBinary );
                }
                deserializerClass.itteration = 0; 
                AccountMainForm accountMainForm = new AccountMainForm( account.data, lengthMass );
                accountMainForm.Show( );
            }
            catch (System.Exception ex)
            {
                notificationForm.ShowTextNotification
                    ( "Ошибка дессериализации объектов!", 
                    ex.ToString( ),
                    Color.Red, 
                    Color.Green );
            }



        }

        public void MethodGetNoData()
        {
            AccountMainForm accountMainForm = new AccountMainForm();
            accountMainForm.Show();
        }



    }
}
