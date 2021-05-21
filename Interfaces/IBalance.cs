using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountForm.Interfaces
{
    interface IBalance<T>
    {

        //баланс размер
        decimal Balance 
        { 
            get; 
            set; 
        }

        //определение метода расчёта баланса
        void BalanceCalculationDepositmoney
            (
            decimal depositmoney, 
            int idperson,
            T idAccountForm
            );  

        void BalanceCalculationWithdrawal
            (
            decimal withdrawal,
            int idperson,
            T idAccountForm
            );
    }
}
