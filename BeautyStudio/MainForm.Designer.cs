﻿namespace BeautyStudio
{
    partial class MainForm
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
            if (disposing && (components != null))
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсехКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСловариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьУКогоСегодняДеньРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПосещенийПоДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.функцииToolStripMenuItem,
            this.свойстваToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1310, 29);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьВсехКлиентовToolStripMenuItem,
            this.добавитьНовогоКлиентаToolStripMenuItem});
            this.клиентыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.DropDownOpening += new System.EventHandler(this.клиентыToolStripMenuItem_DropDownOpening);
            // 
            // показатьВсехКлиентовToolStripMenuItem
            // 
            this.показатьВсехКлиентовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.показатьВсехКлиентовToolStripMenuItem.Name = "показатьВсехКлиентовToolStripMenuItem";
            this.показатьВсехКлиентовToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.показатьВсехКлиентовToolStripMenuItem.Text = "Показать всех клиентов";
            this.показатьВсехКлиентовToolStripMenuItem.Click += new System.EventHandler(this.показатьВсехКлиентовToolStripMenuItem_Click);
            // 
            // добавитьНовогоКлиентаToolStripMenuItem
            // 
            this.добавитьНовогоКлиентаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитьНовогоКлиентаToolStripMenuItem.Name = "добавитьНовогоКлиентаToolStripMenuItem";
            this.добавитьНовогоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.добавитьНовогоКлиентаToolStripMenuItem.Text = "Добавить нового клиента";
            this.добавитьНовогоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовогоКлиентаToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьСловариToolStripMenuItem});
            this.свойстваToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // обновитьСловариToolStripMenuItem
            // 
            this.обновитьСловариToolStripMenuItem.Name = "обновитьСловариToolStripMenuItem";
            this.обновитьСловариToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.обновитьСловариToolStripMenuItem.Text = "Обновить словари";
            this.обновитьСловариToolStripMenuItem.Click += new System.EventHandler(this.обновитьСловариToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьУКогоСегодняДеньРожденияToolStripMenuItem,
            this.поискПосещенийПоДатеToolStripMenuItem});
            this.функцииToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // показатьУКогоСегодняДеньРожденияToolStripMenuItem
            // 
            this.показатьУКогоСегодняДеньРожденияToolStripMenuItem.Name = "показатьУКогоСегодняДеньРожденияToolStripMenuItem";
            this.показатьУКогоСегодняДеньРожденияToolStripMenuItem.Size = new System.Drawing.Size(369, 26);
            this.показатьУКогоСегодняДеньРожденияToolStripMenuItem.Text = "Показать у кого сегодня день рождения";
            // 
            // поискПосещенийПоДатеToolStripMenuItem
            // 
            this.поискПосещенийПоДатеToolStripMenuItem.Name = "поискПосещенийПоДатеToolStripMenuItem";
            this.поискПосещенийПоДатеToolStripMenuItem.Size = new System.Drawing.Size(369, 26);
            this.поискПосещенийПоДатеToolStripMenuItem.Text = "Поиск посещений по дате";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 632);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Татьянин День";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem показатьВсехКлиентовToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem добавитьНовогоКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьСловариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьУКогоСегодняДеньРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПосещенийПоДатеToolStripMenuItem;
    }
}