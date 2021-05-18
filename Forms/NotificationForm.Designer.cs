
namespace BankAccountForm.Forms
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_text2 = new System.Windows.Forms.RichTextBox();
            this.textBox_text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_text2);
            this.groupBox1.Controls.Add(this.textBox_text1);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ИНФОРМАЦИЯ";
            // 
            // richTextBox_text2
            // 
            this.richTextBox_text2.Location = new System.Drawing.Point(3, 48);
            this.richTextBox_text2.Name = "richTextBox_text2";
            this.richTextBox_text2.Size = new System.Drawing.Size(360, 119);
            this.richTextBox_text2.TabIndex = 1;
            this.richTextBox_text2.Text = "";
            // 
            // textBox_text1
            // 
            this.textBox_text1.Location = new System.Drawing.Point(3, 18);
            this.textBox_text1.Name = "textBox_text1";
            this.textBox_text1.Size = new System.Drawing.Size(360, 25);
            this.textBox_text1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(333, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(375, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "NotificationForm";
            this.Text = "DI Finances   >> ОПОВЕЩЕНИЕ";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_text2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_text1;
    }
}