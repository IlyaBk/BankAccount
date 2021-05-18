using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccountForm.Logic;

namespace BankAccountForm.Forms.AccountForms
{
    public partial class AccountAddForm : Form
    {

        public AccountAddForm()
        {
            InitializeComponent();

        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox_roleSystem_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void button_AddAccount_Click ( object sender, EventArgs e )
        {
            LogicAddAccount logicAddAccount = new LogicAddAccount( );
            AccountAddForm addAccountForm = new AccountAddForm( );
            logicAddAccount.AddAccout( addAccountForm );
        }
    }
}
