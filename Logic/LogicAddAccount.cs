using AccountForm.BaseClasses;
using AccountForm.Data.SaveData;
using AccountForm.Forms.NotificationForms;
using AccountForm.Forms;
using AccountForm.Forms.AccountForms;
using AccountForm.Utilites;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountForm.Data;

namespace AccountForm.Logic
{
    class LogicAddAccount
    {
        public LogicAddAccount(AccountAddForm addAccountForm) 
        {
            AddAccout(addAccountForm);
        }

        
        GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile( );
        SerializerClass serializerClass = new SerializerClass( );
        ConstantClassData constantClassData = new ConstantClassData( );

        public void AddAccout( AccountAddForm addAccountForm)
        {
            AccountForm<int> bankAccountForm = new AccountForm<int>();
            NotificationForm notificationForm = new NotificationForm( );
            try
            {
                bankAccountForm.Login = addAccountForm.textBox_login.Text;
                bankAccountForm.Password = addAccountForm.textBox_password.Text;
                bankAccountForm.RoleUserSystemAdmin = byte.Parse( addAccountForm.comboBox_roleSystem.SelectedIndex.ToString( ) );
                bankAccountForm.RoleUser = byte.Parse( addAccountForm.comboBox_roleUser.SelectedIndex.ToString( ) );
                bankAccountForm.IdPerson = getQuantityDirectoryFile.GetQuantityDataFile() - 1;
                bankAccountForm.Name1 = addAccountForm.textBox_name1.Text;
                bankAccountForm.Name2 = addAccountForm.textBox_name2.Text;
                bankAccountForm.Name3 = addAccountForm.textBox_name3.Text;
                //bankAccountForm.AdressCountry = addAccountForm.textBox_AdressCountry.Text;
                //bankAccountForm.AdressRegion = addAccountForm.textBox_AdressRegion.Text;
                //bankAccountForm.AdressPostcode = addAccountForm.textBox_AdressPostcode.Text;
                //bankAccountForm.AdressCity = addAccountForm.textBox_AdressCity.Text;
                //bankAccountForm.AdressStreet = addAccountForm.textBox_AdressStreet.Text;
                //bankAccountForm.AdressNumberHome = addAccountForm.textBox_AdressNumberHome.Text;
                //bankAccountForm.AdressNumberApartment = addAccountForm.textBox_AdressNumberApartment.Text;
                bankAccountForm.Email = addAccountForm.textBox_Email.Text;
                bankAccountForm.PhoneNumber1 = addAccountForm.textBox_PhoneNumber1.Text;
               // bankAccountForm.Group = byte.Parse(addAccountForm.comboBox_Group.SelectedIndex.ToString());
                //bankAccountForm.Status = byte.Parse(addAccountForm.comboBox_Status.SelectedIndex.ToString());

                serializerClass.Serializ(bankAccountForm, constantClassData.FileNameBinary );

                notificationForm.ShowTextNotification( "Успешное добавление данных!", "ОК!", Color.Green, Color.Green );
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
