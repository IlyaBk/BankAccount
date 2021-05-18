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
        public BankAccountForm()
        {

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
