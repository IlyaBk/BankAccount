using AccountForm.Data.Guide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountForm.BaseClasses
{
    [Serializable]
    public class AuthorizData
    {
        public AuthorizData()
        {
        }

        public string Login { get; set; }

        public string Password { get; set; }
        //role in system () 1-user, 2-moderator, 3-admin, 
        public byte  RoleUserSystemAdmin { get; set; }
        public string  RoleUserSystemAdminDescription { get; set; }

        //role in system for work 1-user, 2-worker, 3-operator, 4 - mainoperator, 5-manager, 6-mainmanager, 7-director
        public byte  RoleUser { get; set; }
        public string RoleUserDescription { get; set; }   

        //статус 0-обычный, 1-добавлении, 2-суперпривелегии, 99-основатель, 60-забанен
        public byte StatusUser { get; set; }

    }
}


