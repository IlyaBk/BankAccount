using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.BaseClasses
{
    [Serializable]
    class AuthorizData
    {
        public string Login { get; set; }

        public string Password { get; set; }
        //role in system () 1-user, 2-moderator, 3-admin, 
        public byte RoleUserSystemAdmin { get; set; }

        //role in system for work 1-user, 2-worker, 3-operator, 4 - mainoperator, 5-manager, 6-mainmanager, 7-director
        public byte RoleUser { get; set; }
    }
}
