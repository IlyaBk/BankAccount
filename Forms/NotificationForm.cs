using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountForm.Forms
{
    public partial class NotificationForm : Form
    {
        public NotificationForm ( string text1, string text2, Color color1, Color color2 )
        {
            InitializeComponent( );
            ShowTextNotification( text1, text2, color1, color2 );
        }
        public NotificationForm ( )
        {
           
        }

        public void ShowTextNotification (string text1, string text2, Color color1, Color color2)
        {
            InitializeComponent( );
            textBox_text1.ForeColor = color1;
            richTextBox_text2.ForeColor = color2;

            textBox_text1.Text = text1;
            richTextBox_text2.Text = text2;
        }

        private void NotificationForm_Load ( object sender, EventArgs e )
        {

        }
    }
}
