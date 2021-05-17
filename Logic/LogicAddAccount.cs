using BankAccountForm.BaseClasses;
using BankAccountForm.Forms.AccountForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Logic
{
    class LogicAddAccount:BankAccountForm<int>
    {
        public LogicAddAccount()
        {

        }

        AddAccountForm addAccountForm = new AddAccountForm();

        public void AddAccout()
        {
            Login = addAccountForm.textBox_login.Text;

        }
    }
}
