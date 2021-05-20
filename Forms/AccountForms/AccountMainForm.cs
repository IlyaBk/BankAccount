﻿using BankAccountForm.BaseClasses;
using BankAccountForm.Forms.NotificationForms;

using BankAccountForm.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountForm.Forms.AccountForms
{
    public partial class AccountMainForm : Form
    {
        internal AccountMainForm( BankAccountForm<int> [ ] logicGetAccount, int lengthmass )
        {
            statusForm = true;
            InitializeComponent();
            DSAddAllData( logicGetAccount, lengthmass );
        }

        NotificationForm notification = new NotificationForm();
        

        public bool statusForm { get; set; }

        internal AccountMainForm ( )
        {
            InitializeComponent( );
        }

        private void button_AddAccount_Click ( object sender, EventArgs e )
        {
            AccountAddForm accountAddForm = new AccountAddForm();
            
           // if( accountAddForm.StatusAccountAddForm == false )
            //{
                accountAddForm.Show();
           // }
           // else
          //  {
              //  notification.ShowTextNotificationMini("Форма уже открыта!", Color.Red );
          //  }
            
        }

        private void AccountMainForm_Load ( object sender, EventArgs e )
        {
            
        }

        internal void DSAddAllData(BankAccountForm<int> [] logicGetAccount, int lengthmass)
        {
            if( logicGetAccount != null)
            {
                BankAccountForm<int> [ ] bankAccountForms = new BankAccountForm<int> [ lengthmass ];
                bankAccountForms = ( BankAccountForm<int> [ ] ) logicGetAccount;

                for ( int i = 0; i < lengthmass; i++ )
                {
                    DGV.Rows.Add( );
                    DGV [ 0, i ].Value = bankAccountForms [ i ].IdPerson;
                    DGV [ 1, i ].Value = bankAccountForms [ i ].Login;
                    DGV [ 2, i ].Value = bankAccountForms [ i ].Name1;
                }
            }
            else
            {
                notification.ShowTextNotification( "Нет данных об аккаунтах", "", Color.Red, Color.Red );
            }
        }

        private void AddDSinDGV ( )
        {
        }

        private void DGV_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }

        ~AccountMainForm ( ) { statusForm = false; }
    }
}
