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
        AccountAddForm addAccountForm = new AccountAddForm( );
        public AccountMainForm()
        {
            InitializeComponent();
        }

        private void button_AddAccount_Click ( object sender, EventArgs e )
        {
            addAccountForm.Show( );
        }
    }
}
