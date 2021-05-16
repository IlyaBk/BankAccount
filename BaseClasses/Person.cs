using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.BaseClasses
{
    [Serializable]
    class Person:AuthorizData
    {
        public int IdPerson { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Group { get; set; }
        public int Status { get; set; }

    }
}
