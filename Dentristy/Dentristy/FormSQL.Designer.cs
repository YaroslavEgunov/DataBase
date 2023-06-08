namespace Dentistry
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonDistrWorkers = new System.Windows.Forms.RadioButton();
            this.radioButtonProc = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Proc = new System.Windows.Forms.RadioButton();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.buttonSelectDishes = new System.Windows.Forms.Button();
            this.dataGridViewDish = new System.Windows.Forms.DataGridView();
            this.panelProc = new System.Windows.Forms.Panel();
            this.comboBoxNal_proc = new System.Windows.Forms.ComboBox();
            this.comboBoxColor_proc = new System.Windows.Forms.ComboBox();
            this.checkBoxAnas_proc = new System.Windows.Forms.CheckBox();
            this.labelNal_proc = new System.Windows.Forms.Label();
            this.labelAnas_proc = new System.Windows.Forms.Label();
            this.labelColor_proc = new System.Windows.Forms.Label();
            this.textBoxPrice_proc = new System.Windows.Forms.TextBox();
            this.labelPrice_proc = new System.Windows.Forms.Label();
            this.textBoxName_proc = new System.Windows.Forms.TextBox();
            this.labelName_proc = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxId_proc = new System.Windows.Forms.TextBox();
            this.labelId_dish = new System.Windows.Forms.Label();
            this.radioButtonDelete_proc = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_proc = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_proc = new System.Windows.Forms.RadioButton();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
            this.panelProc.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 424);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 366);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonDistrWorkers);
            this.groupBoxSelect.Controls.Add(this.radioButtonProc);
            this.groupBoxSelect.Controls.Add(this.radioButtonWorkers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 52);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = " Запросы по данным";
            // 
            // radioButtonDistrWorkers
            // 
            this.radioButtonDistrWorkers.AutoSize = true;
            this.radioButtonDistrWorkers.Location = new System.Drawing.Point(100, 19);
            this.radioButtonDistrWorkers.Name = "radioButtonDistrWorkers";
            this.radioButtonDistrWorkers.Size = new System.Drawing.Size(144, 17);
            this.radioButtonDistrWorkers.TabIndex = 2;
            this.radioButtonDistrWorkers.TabStop = true;
            this.radioButtonDistrWorkers.Text = "Распределённые врачи";
            this.radioButtonDistrWorkers.UseVisualStyleBackColor = true;
            this.radioButtonDistrWorkers.CheckedChanged += new System.EventHandler(this.radioButtonDistrWorkers_CheckedChanged);
            // 
            // radioButtonProc
            // 
            this.radioButtonProc.AutoSize = true;
            this.radioButtonProc.Location = new System.Drawing.Point(250, 19);
            this.radioButtonProc.Name = "radioButtonProc";
            this.radioButtonProc.Size = new System.Drawing.Size(82, 17);
            this.radioButtonProc.TabIndex = 1;
            this.radioButtonProc.TabStop = true;
            this.radioButtonProc.Text = "Процедуры";
            this.radioButtonProc.UseVisualStyleBackColor = true;
            this.radioButtonProc.CheckedChanged += new System.EventHandler(this.radioButtonProc_CheckedChanged);
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.Location = new System.Drawing.Point(10, 19);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(84, 17);
            this.radioButtonWorkers.TabIndex = 0;
            this.radioButtonWorkers.TabStop = true;
            this.radioButtonWorkers.Text = "Сотрудники";
            this.radioButtonWorkers.UseVisualStyleBackColor = true;
            this.radioButtonWorkers.CheckedChanged += new System.EventHandler(this.radioButtonWorkers_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 147);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 274);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxWorker);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.labelWorker);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 144);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Прибыль сотрудников";
            // 
            // buttonF_select
            // 
            this.buttonF_select.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonF_select.Location = new System.Drawing.Point(3, 118);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(780, 23);
            this.buttonF_select.TabIndex = 5;
            this.buttonF_select.Text = "Прибыль сотрудников";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Proc);
            this.groupBoxDet.Location = new System.Drawing.Point(432, 17);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(348, 82);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли сотрудников.";
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(7, 52);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDet_NO.TabIndex = 1;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Нет детализации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Proc
            // 
            this.radioButtonDet_Proc.AutoSize = true;
            this.radioButtonDet_Proc.Location = new System.Drawing.Point(7, 19);
            this.radioButtonDet_Proc.Name = "radioButtonDet_Proc";
            this.radioButtonDet_Proc.Size = new System.Drawing.Size(211, 17);
            this.radioButtonDet_Proc.TabIndex = 0;
            this.radioButtonDet_Proc.TabStop = true;
            this.radioButtonDet_Proc.Text = "Прибыль сотрудника по процедурам";
            this.radioButtonDet_Proc.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 85);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(252, 17);
            this.checkBoxOrder.TabIndex = 4;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию прибыли";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(107, 17);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(250, 20);
            this.textBoxWorker.TabIndex = 1;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(165, 50);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(192, 20);
            this.textBoxMore.TabIndex = 3;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(6, 20);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(98, 13);
            this.labelWorker.TabIndex = 0;
            this.labelWorker.Text = "ФИО сотрудника:";
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 52);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(153, 17);
            this.checkBoxMore.TabIndex = 2;
            this.checkBoxMore.Text = "Выбрать прибыль более:";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 159);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 262);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 156);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(9, 122);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(185, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(94, 87);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(6, 90);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(83, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер записи:";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(6, 60);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 28);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonSelectDishes);
            this.tabPageDML.Controls.Add(this.dataGridViewDish);
            this.tabPageDML.Controls.Add(this.panelProc);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 424);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // buttonSelectDishes
            // 
            this.buttonSelectDishes.Location = new System.Drawing.Point(307, 199);
            this.buttonSelectDishes.Name = "buttonSelectDishes";
            this.buttonSelectDishes.Size = new System.Drawing.Size(173, 23);
            this.buttonSelectDishes.TabIndex = 3;
            this.buttonSelectDishes.Text = "Показать список процедур";
            this.buttonSelectDishes.UseVisualStyleBackColor = true;
            this.buttonSelectDishes.Click += new System.EventHandler(this.buttonSelectDishes_Click);
            // 
            // dataGridViewDish
            // 
            this.dataGridViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDish.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDish.Location = new System.Drawing.Point(3, 228);
            this.dataGridViewDish.Name = "dataGridViewDish";
            this.dataGridViewDish.Size = new System.Drawing.Size(786, 193);
            this.dataGridViewDish.TabIndex = 2;
            // 
            // panelProc
            // 
            this.panelProc.Controls.Add(this.comboBoxNal_proc);
            this.panelProc.Controls.Add(this.comboBoxColor_proc);
            this.panelProc.Controls.Add(this.checkBoxAnas_proc);
            this.panelProc.Controls.Add(this.labelNal_proc);
            this.panelProc.Controls.Add(this.labelColor_proc);
            this.panelProc.Controls.Add(this.textBoxPrice_proc);
            this.panelProc.Controls.Add(this.labelAnas_proc);
            this.panelProc.Controls.Add(this.labelPrice_proc);
            this.panelProc.Controls.Add(this.textBoxName_proc);
            this.panelProc.Controls.Add(this.labelName_proc);
            this.panelProc.Location = new System.Drawing.Point(3, 92);
            this.panelProc.Name = "panelProc";
            this.panelProc.Size = new System.Drawing.Size(783, 101);
            this.panelProc.TabIndex = 1;
            // 
            // comboBoxNal_proc
            // 
            this.comboBoxNal_proc.FormattingEnabled = true;
            this.comboBoxNal_proc.Items.AddRange(new object[] {
            "Мягкое ",
            "Жёсткое"});
            this.comboBoxNal_proc.Location = new System.Drawing.Point(563, 37);
            this.comboBoxNal_proc.Name = "comboBoxNal_proc";
            this.comboBoxNal_proc.Size = new System.Drawing.Size(139, 21);
            this.comboBoxNal_proc.TabIndex = 16;
            // 
            // comboBoxColor_proc
            // 
            this.comboBoxColor_proc.FormattingEnabled = true;
            this.comboBoxColor_proc.Items.AddRange(new object[] {
            "Жёлтый",
            "Светло-жёлтый",
            "Белый"});
            this.comboBoxColor_proc.Location = new System.Drawing.Point(528, 11);
            this.comboBoxColor_proc.Name = "comboBoxColor_proc";
            this.comboBoxColor_proc.Size = new System.Drawing.Size(174, 21);
            this.comboBoxColor_proc.TabIndex = 15;
            // 
            // checkBoxAnas_proc
            // 
            this.checkBoxAnas_proc.AutoSize = true;
            this.checkBoxAnas_proc.Location = new System.Drawing.Point(181, 60);
            this.checkBoxAnas_proc.Name = "checkBoxAnas_proc";
            this.checkBoxAnas_proc.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAnas_proc.TabIndex = 14;
            this.checkBoxAnas_proc.Text = "Необходима";
            this.checkBoxAnas_proc.UseVisualStyleBackColor = true;
            // 
            // labelNal_proc
            // 
            this.labelNal_proc.AutoSize = true;
            this.labelNal_proc.Location = new System.Drawing.Point(365, 40);
            this.labelNal_proc.Name = "labelNal_proc";
            this.labelNal_proc.Size = new System.Drawing.Size(192, 13);
            this.labelNal_proc.TabIndex = 12;
            this.labelNal_proc.Text = "Снятие налёта во время процедуры:";
            // 
            // labelAnas_proc
            // 
            this.labelAnas_proc.AutoSize = true;
            this.labelAnas_proc.Location = new System.Drawing.Point(3, 60);
            this.labelAnas_proc.Name = "labelAnas_proc";
            this.labelAnas_proc.Size = new System.Drawing.Size(172, 13);
            this.labelAnas_proc.TabIndex = 10;
            this.labelAnas_proc.Text = "Анастезия во время процедуры:";
            // 
            // labelColor_proc
            // 
            this.labelColor_proc.AutoSize = true;
            this.labelColor_proc.Location = new System.Drawing.Point(365, 14);
            this.labelColor_proc.Name = "labelColor_proc";
            this.labelColor_proc.Size = new System.Drawing.Size(157, 13);
            this.labelColor_proc.TabIndex = 8;
            this.labelColor_proc.Text = "Цвет пломбы для процедуры:";
            // 
            // textBoxPrice_proc
            // 
            this.textBoxPrice_proc.Location = new System.Drawing.Point(132, 37);
            this.textBoxPrice_proc.Name = "textBoxPrice_proc";
            this.textBoxPrice_proc.Size = new System.Drawing.Size(208, 20);
            this.textBoxPrice_proc.TabIndex = 7;
            // 
            // labelPrice_proc
            // 
            this.labelPrice_proc.AutoSize = true;
            this.labelPrice_proc.Location = new System.Drawing.Point(3, 40);
            this.labelPrice_proc.Name = "labelPrice_proc";
            this.labelPrice_proc.Size = new System.Drawing.Size(123, 13);
            this.labelPrice_proc.TabIndex = 6;
            this.labelPrice_proc.Text = "Стоимость процедуры:";
            // 
            // textBoxName_proc
            // 
            this.textBoxName_proc.Location = new System.Drawing.Point(127, 11);
            this.textBoxName_proc.Name = "textBoxName_proc";
            this.textBoxName_proc.Size = new System.Drawing.Size(213, 20);
            this.textBoxName_proc.TabIndex = 5;
            // 
            // labelName_proc
            // 
            this.labelName_proc.AutoSize = true;
            this.labelName_proc.Location = new System.Drawing.Point(3, 14);
            this.labelName_proc.Name = "labelName_proc";
            this.labelName_proc.Size = new System.Drawing.Size(118, 13);
            this.labelName_proc.TabIndex = 0;
            this.labelName_proc.Text = "Название процедуры:";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_proc);
            this.groupBoxDML.Controls.Add(this.labelId_dish);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_proc);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_proc);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_proc);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 83);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(354, 43);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxId_proc
            // 
            this.textBoxId_proc.Location = new System.Drawing.Point(130, 45);
            this.textBoxId_proc.Name = "textBoxId_proc";
            this.textBoxId_proc.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_proc.TabIndex = 4;
            // 
            // labelId_dish
            // 
            this.labelId_dish.AutoSize = true;
            this.labelId_dish.Location = new System.Drawing.Point(6, 48);
            this.labelId_dish.Name = "labelId_dish";
            this.labelId_dish.Size = new System.Drawing.Size(118, 13);
            this.labelId_dish.TabIndex = 3;
            this.labelId_dish.Text = "Название процедуры:";
            // 
            // radioButtonDelete_proc
            // 
            this.radioButtonDelete_proc.AutoSize = true;
            this.radioButtonDelete_proc.Location = new System.Drawing.Point(495, 19);
            this.radioButtonDelete_proc.Name = "radioButtonDelete_proc";
            this.radioButtonDelete_proc.Size = new System.Drawing.Size(279, 17);
            this.radioButtonDelete_proc.TabIndex = 2;
            this.radioButtonDelete_proc.TabStop = true;
            this.radioButtonDelete_proc.Text = "Удалить данные по процедуре с заданным кодом";
            this.radioButtonDelete_proc.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate_proc
            // 
            this.radioButtonUpdate_proc.AutoSize = true;
            this.radioButtonUpdate_proc.Location = new System.Drawing.Point(202, 19);
            this.radioButtonUpdate_proc.Name = "radioButtonUpdate_proc";
            this.radioButtonUpdate_proc.Size = new System.Drawing.Size(287, 17);
            this.radioButtonUpdate_proc.TabIndex = 1;
            this.radioButtonUpdate_proc.TabStop = true;
            this.radioButtonUpdate_proc.Text = "Изменить данные по процедуре с заданным кодом";
            this.radioButtonUpdate_proc.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_proc
            // 
            this.radioButtonInsert_proc.AutoSize = true;
            this.radioButtonInsert_proc.Location = new System.Drawing.Point(9, 19);
            this.radioButtonInsert_proc.Name = "radioButtonInsert_proc";
            this.radioButtonInsert_proc.Size = new System.Drawing.Size(187, 17);
            this.radioButtonInsert_proc.TabIndex = 0;
            this.radioButtonInsert_proc.TabStop = true;
            this.radioButtonInsert_proc.Text = "Добавить данные по процедуре";
            this.radioButtonInsert_proc.UseVisualStyleBackColor = true;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
            this.panelProc.ResumeLayout(false);
            this.panelProc.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonProc;
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.RadioButton radioButtonDistrWorkers;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_Proc;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonInsert_proc;
        private System.Windows.Forms.RadioButton radioButtonUpdate_proc;
        private System.Windows.Forms.Panel panelProc;
        private System.Windows.Forms.TextBox textBoxId_proc;
        private System.Windows.Forms.Label labelId_dish;
        private System.Windows.Forms.RadioButton radioButtonDelete_proc;
        private System.Windows.Forms.TextBox textBoxPrice_proc;
        private System.Windows.Forms.Label labelPrice_proc;
        private System.Windows.Forms.TextBox textBoxName_proc;
        private System.Windows.Forms.Label labelName_proc;
        private System.Windows.Forms.Label labelColor_proc;
        private System.Windows.Forms.Label labelAnas_proc;
        private System.Windows.Forms.CheckBox checkBoxAnas_proc;
        private System.Windows.Forms.Label labelNal_proc;
        private System.Windows.Forms.ComboBox comboBoxNal_proc;
        private System.Windows.Forms.ComboBox comboBoxColor_proc;
        private System.Windows.Forms.Button buttonSelectDishes;
        private System.Windows.Forms.DataGridView dataGridViewDish;
        private System.Windows.Forms.Button buttonExecuteDML;
    }
}