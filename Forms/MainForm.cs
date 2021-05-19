using BankAccountForm.Forms;
using BankAccountForm.Forms.AccountForms;
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

namespace BankAccountForm
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click ( object sender, EventArgs e)
        {
            LogicGetAccount logicGetAccount = new LogicGetAccount( );
            NotificationForm notificationForm = new NotificationForm( );
            AccountMainForm accountMainForm = new AccountMainForm( );
            logicGetAccount.MethodGetAllData( logicGetAccount);
            accountMainForm.Show( );

            //else notificationForm.ShowTextNotification( "Форма уже открыта!", "", Color.Aqua, Color.Aqua ); 
            //this.Hide( );
        }
    }
}
