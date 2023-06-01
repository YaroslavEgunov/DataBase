namespace Dentistry
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медицинскиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедурыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.врачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медицинскиеКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::Dentistry.Properties.Resources.Exit_50x501;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Dentistry.Properties.Resources.About_50x50;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процедурыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.медицинскиToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникToolStripMenuItem.Text = "Справочники";
            // 
            // процедурыToolStripMenuItem
            // 
            this.процедурыToolStripMenuItem.Image = global::Dentistry.Properties.Resources.Procedures_50x50;
            this.процедурыToolStripMenuItem.Name = "процедурыToolStripMenuItem";
            this.процедурыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.процедурыToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.процедурыToolStripMenuItem.Text = "Процедуры";
            this.процедурыToolStripMenuItem.Click += new System.EventHandler(this.процедурыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Image = global::Dentistry.Properties.Resources.Doctor_50x50;
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // медицинскиToolStripMenuItem
            // 
            this.медицинскиToolStripMenuItem.Image = global::Dentistry.Properties.Resources.MedCard_50x50;
            this.медицинскиToolStripMenuItem.Name = "медицинскиToolStripMenuItem";
            this.медицинскиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.медицинскиToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.медицинскиToolStripMenuItem.Text = "Медицинские карты";
            this.медицинскиToolStripMenuItem.Click += new System.EventHandler(this.медицинскиToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.справочникиToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(150, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = global::Dentistry.Properties.Resources.Exit_50x501;
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Image = global::Dentistry.Properties.Resources.About_50x50;
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе...";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процедурыToolStripMenuItem1,
            this.врачиToolStripMenuItem,
            this.медицинскиеКартыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // процедурыToolStripMenuItem1
            // 
            this.процедурыToolStripMenuItem1.Image = global::Dentistry.Properties.Resources.Procedures_50x50;
            this.процедурыToolStripMenuItem1.Name = "процедурыToolStripMenuItem1";
            this.процедурыToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.процедурыToolStripMenuItem1.Text = "Процедуры";
            this.процедурыToolStripMenuItem1.Click += new System.EventHandler(this.процедурыToolStripMenuItem_Click);
            // 
            // врачиToolStripMenuItem
            // 
            this.врачиToolStripMenuItem.Image = global::Dentistry.Properties.Resources.Doctor_50x50;
            this.врачиToolStripMenuItem.Name = "врачиToolStripMenuItem";
            this.врачиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.врачиToolStripMenuItem.Text = "Сотрудники";
            this.врачиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // медицинскиеКартыToolStripMenuItem
            // 
            this.медицинскиеКартыToolStripMenuItem.Image = global::Dentistry.Properties.Resources.MedCard_50x50;
            this.медицинскиеКартыToolStripMenuItem.Name = "медицинскиеКартыToolStripMenuItem";
            this.медицинскиеКартыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.медицинскиеКартыToolStripMenuItem.Text = "Медицинские карты";
            this.медицинскиеКартыToolStripMenuItem.Click += new System.EventHandler(this.медицинскиToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator2});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Dentistry.Properties.Resources.Exit_50x501;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Dentistry.Properties.Resources.About_50x50;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Dentistry.Properties.Resources.Procedures_50x50;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.процедурыToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Dentistry.Properties.Resources.Doctor_50x50;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Dentistry.Properties.Resources.MedCard_50x50;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.медицинскиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Dentistry.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::Dentistry.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Стоматология";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem медицинскиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедурыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem врачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медицинскиеКартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

