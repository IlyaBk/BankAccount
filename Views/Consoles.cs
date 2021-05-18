using BankAccountForm.BaseClasses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Views
{
    class Consoles
    {
        internal Consoles( )
        {

        }

        //приветствие
        internal void ShowMessageWelcome()
        {
            Console.Title = "Панель управления";
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("Добро пожаловать в Панель Управления!");      
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
        }

        //вывод данных об аккаунте
        internal void ShowDataBankAccountFormAll(BankAccountForm<int> bankAccountform )
        {
            try
            {
                if ( bankAccountform == null) 
                { 
                    Console.WriteLine("Нет объекта для вывода!"); 
                }
                else 
                { 
                    Console.WriteLine
                    (
                     "╔══════════════════════════════════════════════════╗\n" +
                    $"╠ Логин: {bankAccountform.Login}                     \n" +
                    $"╠ Пароль: {bankAccountform.Password}                  \n" +
                    $"╠ Роль пользователя: {bankAccountform.RoleUser}       \n" +
                    $"╠ Роль в ситеме: {bankAccountform.RoleUserSystemAdmin} \n" +
                    //$"╠ Адресс: {bankAccountform.Adress}                   \n" +
                   // $"╠ ФИО: {bankAccountform.FullName}                    \n" +
                    $"╠ Группа: {bankAccountform.Group}                    \n" +
                    //$"╠ Номер:  {bankAccountform.PhoneNumber}       \n" +
                    $"╠ Статус пользователя: {bankAccountform.Status}      \n" +
                    $"╠ ID Аккаунта: {bankAccountform.IdBankAccountForm}      \n" +
                    $"╠ ID Пользователя: {bankAccountform.IdPerson}        \n" +
                    $"╠ Баланс: {bankAccountform.Balance}               \n" +
                     "╚══════════════════════════════════════════════════╝\n"
                     );
                    //bankAccountform = null;
                }
            }
            catch (Exception e)
            {
                ErrorMessage( e );
            }
        }

        //вывод данных об аккаунте
        internal void ShowDataBankAccountForm(BankAccountForm<int> bankAccountform)
        {
            try
            {
                if( bankAccountform == null )
                {
                    Console.WriteLine("Нет объекта для вывода!");
                }
                else
                {
                    Console.WriteLine
                    (
                     "╔══════════════════════════════════════════════════╗\n" +
                    //$"╠ ФИО: {bankAccountform.FullName}                     \n" +
                    $"╠ ID Аккаунта:  {bankAccountform.IdBankAccountForm}       \n" +
                    $"╠ ID Пользователя: {bankAccountform.IdPerson}         \n" +
                    $"╠ Баланс: {bankAccountform.Balance}                   \n" +
                     "╚══════════════════════════════════════════════════╝\n"
                     );
                }
            }
            catch( Exception e )
            {
                ErrorMessage(e);
            }
        }

        internal void ShowSuccesSerializeData(int i)
        {
            Console.WriteLine($"Успешная серриализация!"); 
            Console.WriteLine($"Успешное сохранение данных! Количество сохранённых объектов: {i}"); 
        }

        internal void ErrorMessage(Exception e)
        {
            if (e == null) { 
            Console.WriteLine( $"╔══════════════════════════════════════════════════╗" );
            Console.WriteLine( $"    Возникла ошибка! {e}");
            Console.WriteLine( $"╚══════════════════════════════════════════════════╝" );
            }
        }

        internal void ShowNumber(string mes, int i)
        {
            Console.WriteLine( $"╠═══{mes} {i} ═══╣\n" );
        }

        internal void ShowAuthorizData(AuthorizData authorizData)
        {
            try
            {
                Console.WriteLine
                    (
                     "╔════════════════════════════════════════════════════╗\n" +
                    $"╠ Login: {authorizData.Login}                     \n" +
                    $"╠ Password:  {authorizData.Password}       \n" +
                    $"╠ Id Role User in system: {authorizData.RoleUserSystemAdmin}  \n" +
                    $"╠ Id Role: {authorizData.RoleUser}                   \n" +
                     "╚════════════════════════════════════════════════════╝\n"
                     );
            }
            catch ( Exception e )
            {
                ErrorMessage( e );
            }
        }
        internal void ShowMessageWelcomeAuthorize( )
        {
            Console.WriteLine( "+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+" );
            Console.WriteLine( "Аккаунты авторизации:" );
            Console.WriteLine( "+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n" );
        }
    }
}
