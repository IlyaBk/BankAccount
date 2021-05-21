using System;
using AccountForm.Data.SaveData;
using AccountForm.Data.GetData;
using AccountForm.BaseClasses;
using AccountForm.Data;
using AccountForm.Utilites;
using AccountForm.Views;

namespace AccountForm.BaseClasses
{
    class MainProgram:Consoles
    {
        SerializerClass serializerClass = new SerializerClass() ;
        ConstantClassData constantClassData = new ConstantClassData();
        DeserializerClass deserializerClass = new DeserializerClass();
        GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile();
        AccountForm<int> [ ] data;

        public MainProgram ( )
        {
            data = new AccountForm<int> [getQuantityDirectoryFile.GetQuantityDataFile()];
        }

        public AccountForm<int> this [ int index ]
        {
            get { return data [ index ]; } 
            set { data [ index ] = value; }
        }

        static void Main0 ( )
        {
            int i;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            MainProgram AccountForm = new MainProgram();
            MainProgram mainProgram = new MainProgram( );

            if (mainProgram.AuthorizModul(AccountForm,out i) == true)
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
        public bool AuthorizModul(MainProgram AccountForm, out int i)
        {
            bool authorizBool = new bool();
            MainMethodNoShow(AccountForm);
            Console.WriteLine("Введите пользовательский логин");
            var tempLogin = Console.ReadLine();
            Console.WriteLine("Введите пользовательский пароль");
            var tempPassword = Console.ReadLine();
            for(  i = 0; i < AccountForm.data.Length - 1; i++ )
            {
               if( AccountForm[i].Login == tempLogin & AccountForm[i].Password == tempPassword ) 
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
            MainProgram AccountForm = new MainProgram();
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
                MainMethod(AccountForm);
                ConsoleControlPanel();
                break;

                case "11":
                MainMethodAllData(AccountForm);
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
        public void MainMethod(MainProgram AccountForm)
        {
            
            Console.WriteLine("[DI Finance SYSTEM] >> Подгрузка данных...");
            for ( int i = 0; i < AccountForm.data.Length-1; i++ )
            {
                AccountForm [ i ] = ( AccountForm<int> ) deserializerClass.Deserializ( constantClassData.FileNameBinary );
                ShowDataAccountForm( AccountForm [ i ]);
            }
            ShowNumber("[DI Finance SYSTEM] >> Колличество иттераций:", deserializerClass.itteration );
            deserializerClass.itteration = 0;
        }
        public void MainMethodAllData(MainProgram AccountForm)
        {
            Console.WriteLine("[DI Finance SYSTEM] >> Подгрузка всех данных...");
            for( int i = 0; i < AccountForm.data.Length - 1; i++ )
            {
                AccountForm [i] = (AccountForm<int>) deserializerClass.Deserializ(constantClassData.FileNameBinary);
                ShowDataAccountFormAll(AccountForm [i]);
            }
            deserializerClass.itteration = 0;
        }

        public void MainMethodNoShow(MainProgram AccountForm)
        {
            for( int i = 0; i < AccountForm.data.Length - 1; i++ )
            {
                AccountForm [i] = (AccountForm<int>) deserializerClass.Deserializ(constantClassData.FileNameBinary);
            }
            deserializerClass.itteration = 0;
        }

        //public void AddNewAccount()
        //{
        //    AccountForm<int> AccountForm = new AccountForm<int>();
        //    var i = getQuantityDirectoryFile.GetQuantityDataFile()-1;

        //    try
        //    {
        //        Console.WriteLine("[DI Finance] >> Введите данные нового аккаунта:");
        //        Console.WriteLine("");
        //        Console.WriteLine("[DI Finance] >> Введите логин для нового пользователя:");
        //        AccountForm.Login = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Введите пароль пользователя:");
        //        AccountForm.Password = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Внесите роль пользователя \n 1-user, 2-worker, 3-operator, 4 - mainoperator, 5-manager, 6-mainManager, 7-director");
        //        AccountForm.RoleUser = byte.Parse(Console.ReadLine());

        //        Console.WriteLine("[DI Finance] >> Введите роль в системе (1-user  2-moderator 3-admin):");
        //        AccountForm.RoleUserSystemAdmin = byte.Parse(Console.ReadLine());

        //        Console.WriteLine("[DI Finance] >> Внесите адресс:");
        //        AccountForm.Adress = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Внесите ФИО");
        //        AccountForm.FullName = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Введите групу пользователя: (0-для всех)");
        //        AccountForm.Group = Console.ReadLine();

        //        AccountForm.IdPerson = i ;

        //        Console.WriteLine("[DI Finance] >> Внесите телефонный номер");
        //        AccountForm.PhoneNumber = Console.ReadLine();

        //        Console.WriteLine("[DI Finance] >> Введите статус пользователя 0-обычный, 1-привелегии, 2-суперпривелегии, 99-основатель, 60-забанен");
        //        AccountForm.Status = Int32.Parse(Console.ReadLine());

        //        AccountForm.IdAccountForm = i;

        //        Console.WriteLine("[DI Finance] >> Внесите баланс пользователя, по умолчанию 0,00");
        //        AccountForm.Balance = decimal.Parse(Console.ReadLine());
        //    }
        //    catch (Exception e)
        //    {
        //        ErrorMessage(e);
        //    }

        //    Console.WriteLine("[DI Finance SYSTEM] >> Сохоанение данных в файл....");

        //    serializerClass.Serializ(AccountForm, constantClassData.FileNameBinary);
        //    Console.WriteLine("[DI Finance SYSTEM] >> Данные успешно сохранены!");
        //    ShowDataAccountFormAll(AccountForm);
        //}
    }
}
