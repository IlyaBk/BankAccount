using System;

namespace AccountForm.BaseClasses
{
    [Serializable]
    class Person:AuthorizData
    {
        public int IdPerson { get; set; }

        //основная информация
        //ФИО
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }

        //Адрес регистрации
        public string AdressRegistration{ get; set; }

        //Адрес фактического проживания
        public string AdressActual { get; set; } 
        
        //Место рождения
        public string BirthPlace{ get; set; }


        //разное
        public string BirthDate { get; set; } //день рождения
        public string EmploymentDate { get; set; } //дата приёма на рбаоту 

        public int Age { get; set; }
        public string Gender { get; set; } 
        public string Citizenship { get; set; } //гражданство
        public string EmployeeNumber { get; set; } //табельный номер
        

        //номерные данные гражданина
        public string NumberSocialSecurity { get; set; } //номер страховки
        public string NumberHealthInsurance { get; set; } //номер мед полиса
        public string NumberINN { get; set; } //ИНН
        
        //подразделение в организации
        public string Departament { get; set; }
        public string GroupDepartament { get; set; }
        public string Position { get; set; }



        //семья***
        public string FamilyStatus { get; set; } //семейное положение

        //паспорт
        public string PassportSeries { get; set; } //серия паспорта
        public string PassportNumber { get; set; } // номер паспорта
        public string PassportInstitutionName { get; set; } //отдел, кем выдан
        public string PassportDateOfIssue { get; set; } // дата выдачи

        //образование
        public string EducationCategory { get; set; } //вид образования
        public string EducationSpecialization { get; set; } //специализация



        //связь 
        public string Email { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }

        public string PersonDescription { get; set; }
        public string PersonDateCreationAccount { get; set; }

    }
}
