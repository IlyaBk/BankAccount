using BankAccountForm.Forms;
using BankAccountForm.Forms.AccountForms;
using BankAccountForm.Logic;
using BankAccountForm.Utilites;
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
        GetQuantityDirectoryFile getQuantityDirectoryFile = new GetQuantityDirectoryFile();

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click ( object sender, EventArgs e)
        { 
            LogicGetAccount logicGetAccount = new LogicGetAccount( );

            if( getQuantityDirectoryFile.GetQuantityDataFile() > 1 )
            { 
                logicGetAccount.MethodGetAllData( );
            }
            else
            {
                logicGetAccount.MethodGetNoData();
            }
        }
    }
}
