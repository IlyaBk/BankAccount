
namespace AccountForm.Forms.NotificationForms
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
        protected override void Dispose(bool disposing)
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_text2 = new System.Windows.Forms.RichTextBox();
            this.textBox_text1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.richTextBox_text2);
            this.groupBox1.Controls.Add(this.textBox_text1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ИНФОРМАЦИЯ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(5, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выгрузить в файл";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(229, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_text2
            // 
            this.richTextBox_text2.Location = new System.Drawing.Point(5, 42);
            this.richTextBox_text2.Name = "richTextBox_text2";
            this.richTextBox_text2.Size = new System.Drawing.Size(360, 90);
            this.richTextBox_text2.TabIndex = 1;
            this.richTextBox_text2.Text = "";
            // 
            // textBox_text1
            // 
            this.textBox_text1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_text1.Location = new System.Drawing.Point(5, 17);
            this.textBox_text1.Name = "textBox_text1";
            this.textBox_text1.ReadOnly = true;
            this.textBox_text1.Size = new System.Drawing.Size(360, 25);
            this.textBox_text1.TabIndex = 0;
            this.textBox_text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(375, 167);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
        private System.Windows.Forms.Button button2;
    }
}