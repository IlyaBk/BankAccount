
namespace AccountForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вЫХОДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item1,
            this.Item2,
            this.Item3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(703, 27);
            this.menuStrip1.TabIndex = 4;
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
            this.вЫХОДToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.вЫХОДToolStripMenuItem.Text = "ВЫХОД";
            // 
            // пРОВЕРИТЬФАЙЛЫToolStripMenuItem
            // 
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.Name = "пРОВЕРИТЬФАЙЛЫToolStripMenuItem";
            this.пРОВЕРИТЬФАЙЛЫToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 295);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "FILE SYSTEM:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 267);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "КАТЕГОРИИ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пользователи";
            // 
            // pictureBox1
            //
            // this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(703, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "DI Finances >> ГЛАВНАЯ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Item1;
        private System.Windows.Forms.ToolStripMenuItem вЫХОДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пРОВЕРИТЬФАЙЛЫToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Item2;
        private System.Windows.Forms.ToolStripMenuItem Item3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

