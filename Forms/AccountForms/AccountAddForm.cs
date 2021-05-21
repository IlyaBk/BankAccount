using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountForm.Logic;
using AccountForm.Utilites;

namespace AccountForm.Forms.AccountForms
{
    public partial class AccountAddForm : Form
    {

        public AccountAddForm()
        {
            InitializeComponent();
            StatusAccountAddForm = true;
        }

        public bool StatusAccountAddForm { get; set; }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox_roleSystem_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void button_AddAccount_Click ( object sender, EventArgs e )
        {
            LogicAddAccount logicAddAccount = new LogicAddAccount(this);
        }

        ~AccountAddForm()
        {
            StatusAccountAddForm = false;
            GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile();

            LogicGetAccount logicGetAccount = new LogicGetAccount();

            if( getQuantityDirectoryFile.GetQuantityDataFile() > 1 )
            {
                logicGetAccount.MethodGetAllData();
            }
            else
            {
                logicGetAccount.MethodGetNoData();
            }
        }
    }
}
