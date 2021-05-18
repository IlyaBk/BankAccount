using BankAccountForm.BaseClasses;
using BankAccountForm.Data.SaveData;
using BankAccountForm.Forms;
using BankAccountForm.Forms.AccountForms;
using BankAccountForm.Utilites;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountForm.Data;

namespace BankAccountForm.Logic
{
    class LogicAddAccount:BankAccountForm<int>
    {

        public LogicAddAccount() {  }

        
        GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile( );
        SerializerClass serializerClass = new SerializerClass( );
        ConstantClassData constantClassData = new ConstantClassData( );

        public void AddAccout( AccountAddForm addAccountForm )
        {
            NotificationForm notificationForm = new NotificationForm( );
            try
            {
                Login = addAccountForm.textBox_login.Text;
                Password = addAccountForm.textBox_password.Text;
                RoleUserSystemAdmin = byte.Parse( addAccountForm.comboBox_roleSystem.SelectedIndex.ToString( ) );
                RoleUser = byte.Parse( addAccountForm.comboBox_roleUser.SelectedIndex.ToString( ) );
                IdPerson = getQuantityDirectoryFile.GetQuantityDataFile( ) - 1;
                Name1 = addAccountForm.textBox_name1.Text;
                Name2 = addAccountForm.textBox_name2.Text;
                Name3 = addAccountForm.textBox_name3.Text;
                AdressCountry = addAccountForm.textBox_AdressCountry.Text;
                AdressRegion = addAccountForm.textBox_AdressRegion.Text;
                AdressPostcode = addAccountForm.textBox_AdressPostcode.Text;
                AdressCity = addAccountForm.textBox_AdressCity.Text;
                AdressStreet = addAccountForm.textBox_AdressStreet.Text;
                AdressNumberHome = addAccountForm.textBox_AdressNumberHome.Text;
                AdressNumberApartment = addAccountForm.textBox_AdressNumberApartment.Text;
                Email = addAccountForm.textBox_Email.Text;
                PhoneNumber1 = addAccountForm.textBox_PhoneNumber1.Text;
                Group = byte.Parse( addAccountForm.comboBox_Group.SelectedIndex.ToString( ) );
                Status = byte.Parse( addAccountForm.comboBox_Status.SelectedIndex.ToString());

                serializerClass.Serializ( addAccountForm, constantClassData.FileNameBinary );

                notificationForm.ShowTextNotification( "Успешное добавление данных!", "ОК!", Color.Red, Color.Green );
                notificationForm.Show( );
            }
            catch (Exception e)
            {
                notificationForm.ShowTextNotification("Произошла ошибка при добавлении данных!",e.ToString( ),Color.Red,Color.Green);
                notificationForm.Show( );
            }
        }
    }
}
