using System;
using BankAccountForm.Data.SaveData;
using BankAccountForm.Data.GetData;
using BankAccountForm.BaseClasses;
using BankAccountForm.Data;
using BankAccountForm.Utilites;
using BankAccountForm.Views;

namespace BankAccountFormForm.BaseClasses
{
    class MainProgram:Consoles
    {
        SerializerClass serializerClass = new SerializerClass() ;
        ConstantClassData constantClassData = new ConstantClassData();
        DeserializerClass deserializerClass = new DeserializerClass();
        GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile();
        BankAccountForm<int> [ ] data;

        public MainProgram ( )
        {
            data = new BankAccountForm<int> [getQuantityDirectoryFile.GetQuantityDataFile()];
        }

        public BankAccountForm<int> this [ int index ]
        {
            get { return data [ index ]; } 
            set { data [ index ] = value; }
        }

        static void Main0 ( )
        {
            int i;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            MainProgram BankAccountForm = new MainProgram();
            MainProgram mainProgram = new MainProgram( );

            if (mainProgram.AuthorizModul(BankAccountForm,out i) == true)
            {
                Console.WriteLine(i);
                mainProgram.ConsoleControlPanel();
            }
            else
            {
                Console.WriteLine("Ошибка авторизации в системе!");
                Main0();
            }
        }
        public bool AuthorizModul(MainProgram BankAccountForm, out int i)
        {
            bool authorizBool = new bool();
            MainMethodNoShow(BankAccountForm);
            Console.WriteLine("Введите пользовательский логин");
            var tempLogin = Console.ReadLine();
            Console.WriteLine("Введите пользовательский пароль");
            var tempPassword = Console.ReadLine();
            for(  i = 0; i < BankAccountForm.data.Length - 1; i++ )
            {
               if( BankAccountForm[i].Login == tempLogin & BankAccountForm[i].Password == tempPassword ) 
                {
                    Console.WriteLine($"Добро пожаловать {tempLogin} !");
                    authorizBool = true; 
                    break;
                }
               else
                {
                    authorizBool = false;
                }
            }
            return authorizBool;

                
        }
        public void ConsoleControlPanel()
        {
            MainProgram BankAccountForm = new MainProgram();
            //ShowMessageWelcome();

            Console.WriteLine("Управление: \n" +
                "[DI Finance] >> Введите [1] для подрузки основных данных об аккаунтах \n" +
                "[DI Finance] >> Введите [11] для подрузки всех данных об аккаунтах \n" +
                "[DI Finance] >> Введите [2] для подгрузки учетных записей в системе \n" +
                "[DI Finance] >> Введите [3] для добавления нового банковского аккаунта \n" +
                "[DI Finance] >> Введите [9] для выхода \n");

            switch (Console.ReadLine())
            {
                case "1": 
                MainMethod(BankAccountForm);
                ConsoleControlPanel();
                break;

                case "11":
                MainMethodAllData(BankAccountForm);
                ConsoleControlPanel();
                break;

                case "2":
                Console.WriteLine("[DI Finance SYSTEM] >> В разработке ...");
                ConsoleControlPanel();
                break;

                case "3":
                Console.WriteLine("[DI Finance] >> Добавление новой учётной записи в систему");
                //AddNewAccount();
                ConsoleControlPanel();
                break;

                case "9":
                Console.WriteLine("[DI Finance SYSTEM] >> Завершение работы программы...");
                System.Environment.Exit(0);
                break;
            }
           
        }
        public void MainMethod(MainProgram BankAccountForm)
        {
            
            Console.WriteLine("[DI Finance SYSTEM] >> Подгрузка данных...");
            for ( int i = 0; i < BankAccountForm.data.Length-1; i++ )
            {
                BankAccountForm [ i ] = ( BankAccountForm<int> ) deserializerClass.Deserializ( constantClassData.FileNameBinary );
                ShowDataBankAccountForm( BankAccountForm [ i ]);
            }
            ShowNumber("[DI Finance SYSTEM] >> Колличество иттераций:", deserializerClass.itteration );
            deserializerClass.itteration = 0;
        }
        public void MainMethodAllData(MainProgram BankAccountForm)
        {
            Console.WriteLine("[DI Finance SYSTEM] >> Подгрузка всех данных...");
            for( int i = 0; i < BankAccountForm.data.Length - 1; i++ )
            {
                BankAccountForm [i] = (BankAccountForm<int>) deserializerClass.Deserializ(constantClassData.FileNameBinary);
                ShowDataBankAccountFormAll(BankAccountForm [i]);
            }
            deserializerClass.itteration = 0;
        }
        public void MainMethodNoShow(MainProgram BankAccountForm)
        {
            for( int i = 0; i < BankAccountForm.data.Length - 1; i++ )
            {
                BankAccountForm [i] = (BankAccountForm<int>) deserializerClass.Deserializ(constantClassData.FileNameBinary);
            }
            deserializerClass.itteration = 0;
        }

        //public void AddNewAccount()
        //{
        //    BankAccountForm<int> BankAccountForm = new BankAccountForm<int>();
        //    var i = getQuantityDirectoryFile.GetQuantityDataFile()-1;

        //    try
        //    {
        //        Console.WriteLine("[DI Finance] >> Введите данные нового аккаунта:");
        //        Console.WriteLine("");
        //        Console.WriteLine("[DI Finance] >> Введите логин для нового пользователя:");
        //        BankAccountForm.Login = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Введите пароль пользователя:");
        //        BankAccountForm.Password = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Внесите роль пользователя \n 1-user, 2-worker, 3-operator, 4 - mainoperator, 5-manager, 6-mainManager, 7-director");
        //        BankAccountForm.RoleUser = byte.Parse(Console.ReadLine());

        //        Console.WriteLine("[DI Finance] >> Введите роль в системе (1-user  2-moderator 3-admin):");
        //        BankAccountForm.RoleUserSystemAdmin = byte.Parse(Console.ReadLine());

        //        Console.WriteLine("[DI Finance] >> Внесите адресс:");
        //        BankAccountForm.Adress = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Внесите ФИО");
        //        BankAccountForm.FullName = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Введите групу пользователя: (0-для всех)");
        //        BankAccountForm.Group = Console.ReadLine();

        //        BankAccountForm.IdPerson = i ;

        //        Console.WriteLine("[DI Finance] >> Внесите телефонный номер");
        //        BankAccountForm.PhoneNumber = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Введите статус пользователя 0-обычный, 1-привелегии, 2-суперпривелегии, 99-основатель, 60-забанен");
        //        BankAccountForm.Status = Int32.Parse(Console.ReadLine());

        //        BankAccountForm.IdBankAccountForm = i;

        //        Console.WriteLine("[DI Finance] >> Внесите баланс пользователя, по умолчанию 0,00");
        //        BankAccountForm.Balance = decimal.Parse(Console.ReadLine());
        //    }
        //    catch (Exception e)
        //    {
        //        ErrorMessage(e);
        //    }

        //    Console.WriteLine("[DI Finance SYSTEM] >> Сохоанение данных в файл....");

        //    serializerClass.Serializ(BankAccountForm, constantClassData.FileNameBinary);
        //    Console.WriteLine("[DI Finance SYSTEM] >> Данные успешно сохранены!");
        //    ShowDataBankAccountFormAll(BankAccountForm);
        //}
    }
}
