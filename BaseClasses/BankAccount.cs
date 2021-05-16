using BankAccountForm.Data.SaveData;
using BankAccountForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.BaseClasses
{
    [Serializable]
    class BankAccountForm<T> : Person, IBalance<T>, IDeposite
    {
        public BankAccountForm(
            int idperson, 
            string fullname, 
            string adress, 
            string phonenumber,
            string group, 
            int status,
            T BankAccountForm,
            decimal balance
            ) 
        { 
            IdPerson = idperson;
            FullName = fullname;
            Adress = adress; 
            PhoneNumber = phonenumber; 
            Group = group; 
            Status = status; 
            IdBankAccountForm = BankAccountForm;
            Balance = balance;
         }
        public BankAccountForm()
        {

        }
        //конструктор данных авторизации
        public BankAccountForm(
            int idperson, 
            string login, 
            string password, 
            byte roleusersystemadmin, 
            byte roleuser,
            T BankAccountForm
            )
        {
            IdPerson = idperson;
            Login = login;
            Password = password;
            RoleUserSystemAdmin = roleusersystemadmin;
            RoleUser = roleuser;
            IdBankAccountForm = BankAccountForm;
        }


        public T IdBankAccountForm { get; set; }
        public decimal Balance { get; set; }

        //метод подсчёта баланса
        public void BalanceCalculationDepositmoney(decimal depositmoney, int idperson, T idBankAccountForm)
        {
            IdPerson = idperson;
            IdBankAccountForm = idBankAccountForm;
            
            //актуализация баланса при пополнение счёта
            Balance += depositmoney;
        }

        //метод подсчёта баланса при снятие со счёта
        public void BalanceCalculationWithdrawal(decimal withdrawal, int idperson, T idBankAccountForm)
        {
            IdPerson = idperson;
            IdBankAccountForm = idBankAccountForm;

            //актуализация баланса при снятии со счёта 
            Balance -= withdrawal;
        }
    }
}
