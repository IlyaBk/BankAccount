using AccountForm.Data.SaveData;
using AccountForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountForm.BaseClasses
{
    [Serializable]
    class AccountForm<T> : Person, IBalance<T>, IDeposite
    {
        public AccountForm()
        {

        }
        public T IdAccountForm { get; set; }
        public decimal Balance { get; set; }




        //метод подсчёта баланса
        public void BalanceCalculationDepositmoney(decimal depositmoney, int idperson, T idAccountForm)
        {
            IdPerson = idperson;
            IdAccountForm = idAccountForm;
            
            //актуализация баланса при пополнение счёта
            Balance += depositmoney;
        }

        //метод подсчёта баланса при снятие со счёта
        public void BalanceCalculationWithdrawal(decimal withdrawal, int idperson, T idAccountForm)
        {
            IdPerson = idperson;
            IdAccountForm = idAccountForm;

            //актуализация баланса при снятии со счёта 
            Balance -= withdrawal;
        }
    }
}
