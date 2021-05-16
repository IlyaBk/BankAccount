
namespace BankAccountForm.Forms.AccountForms
{
    partial class AddAccountForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вЫХОДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 411);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ДАННЫЕ АККАУНТА";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item1,
            this.Item2,
            this.Item3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(663, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Item1
            // 
            this.Item1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вЫХОДToolStripMenuItem,
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem});
            this.Item1.ForeColor = System.Drawing.Color.Gray;
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(55, 19);
            this.Item1.Text = "ФАЙЛ";
            // 
            // вЫХОДToolStripMenuItem
            // 
            this.вЫХОДToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вЫХОДToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.вЫХОДToolStripMenuItem.Name = "вЫХОДToolStripMenuItem";
            this.вЫХОДToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.вЫХОДToolStripMenuItem.Text = "ВЫХОД";
            // 
            // пРОВЕРИТЬФАЙЛЫToolStripMenuItem
            // 
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.Name = "пРОВЕРИТЬФАЙЛЫToolStripMenuItem";
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.Text = "ПРОВЕРИТЬ ФАЙЛЫ";
            // 
            // Item2
            // 
            this.Item2.ForeColor = System.Drawing.Color.Gray;
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(73, 19);
            this.Item2.Text = "СПРАВКА";
            // 
            // Item3
            // 
            this.Item3.ForeColor = System.Drawing.Color.Gray;
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(91, 19);
            this.Item3.Text = "НАСТРОЙКА";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(441, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "УПРАВЛЕНИЕ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(663, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "AddAccountForm";
            this.Text = "DI Finances   >>   АККАУНТЫ > ДОБАВИТЬ АККАУНТ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Item1;
        private System.Windows.Forms.ToolStripMenuItem вЫХОДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пРОВЕРИТЬФАЙЛЫToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Item2;
        private System.Windows.Forms.ToolStripMenuItem Item3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}