﻿using System;
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
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string AdressCountry { get; set; }
        public string AdressRegion { get; set; }
        public string AdressPostcode { get; set; }
        public string AdressCity { get; set; }
        public string AdressStreet { get; set; }
        public string AdressNumberHome { get; set; }
        public string AdressNumberApartment { get; set; }
        public string Email { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        //группы - 1 - клиенты, 2  - сотрудники, 3 - прочее
        public string Group { get; set; }

        //статус 0-обычный, 1-привелегии, 2-суперпривелегии, 99-основатель, 60-забанен
        public int Status { get; set; }
        public string PersonDescription { get; set; }
        public string PersonDateCreation { get; set; }

    }
}
