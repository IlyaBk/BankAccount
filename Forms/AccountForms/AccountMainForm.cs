using AccountForm.BaseClasses;
using AccountForm.Forms.NotificationForms;

using AccountForm.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountForm.Forms.AccountForms
{
    public partial class AccountMainForm : Form
    {
        internal AccountMainForm( AccountForm<int> [ ] logicGetAccount, int lengthmass )
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

        internal void DSAddAllData(AccountForm<int> [] logicGetAccount, int lengthmass)
        {
            if( logicGetAccount != null)
            {
                AccountForm<int> [ ] accountForms = new AccountForm<int> [ lengthmass ];
                accountForms = ( AccountForm<int> [ ] ) logicGetAccount;
                try
                {
                    for ( int i = 0; i < lengthmass; i++ )
                    {
                        DGV.Rows.Add( );
                        DGV [ 0, i ].Value = accountForms [ i ].IdPerson;
                        DGV [ 1, i ].Value = accountForms [ i ].Login;
                        DGV [ 2, i ].Value = accountForms [ i ].Name1;
                    }
                }
                catch ( System.Exception ex )
                {
                    notification.ShowTextNotification( "Ошибка при работе с данными!", ex.ToString( ), Color.Red, Color.Red );

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

        private void groupBox5_Enter ( object sender, EventArgs e )
        {

        }
    }
}
