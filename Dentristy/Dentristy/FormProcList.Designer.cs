namespace Dentistry
{
    partial class FormProcList
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

        private static FormProcList f;
        public static FormProcList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormProcList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label название_ПроцедурыLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label анастезияLabel;
            System.Windows.Forms.Label цвет_ПломбыLabel;
            System.Windows.Forms.Label снятие_НалётаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcList));
            this.dentistryDataSet = new Dentistry.DentistryDataSet();
            this.список_ПроцедурBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_ПроцедурTableAdapter = new Dentistry.DentistryDataSetTableAdapters.Список_ПроцедурTableAdapter();
            this.tableAdapterManager = new Dentistry.DentistryDataSetTableAdapters.TableAdapterManager();
            this.список_ПроцедурBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.список_ПроцедурBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_ПроцедурыTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.анастезияCheckBox = new System.Windows.Forms.CheckBox();
            this.цвет_ПломбыComboBox = new System.Windows.Forms.ComboBox();
            this.снятие_НалётаComboBox = new System.Windows.Forms.ComboBox();
            название_ПроцедурыLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            анастезияLabel = new System.Windows.Forms.Label();
            цвет_ПломбыLabel = new System.Windows.Forms.Label();
            снятие_НалётаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dentistryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_ПроцедурBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_ПроцедурBindingNavigator)).BeginInit();
            this.список_ПроцедурBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // название_ПроцедурыLabel
            // 
            название_ПроцедурыLabel.AutoSize = true;
            название_ПроцедурыLabel.Location = new System.Drawing.Point(12, 36);
            название_ПроцедурыLabel.Name = "название_ПроцедурыLabel";
            название_ПроцедурыLabel.Size = new System.Drawing.Size(120, 13);
            название_ПроцедурыLabel.TabIndex = 1;
            название_ПроцедурыLabel.Text = "Название Процедуры:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 62);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 3;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // анастезияLabel
            // 
            анастезияLabel.AutoSize = true;
            анастезияLabel.Location = new System.Drawing.Point(12, 90);
            анастезияLabel.Name = "анастезияLabel";
            анастезияLabel.Size = new System.Drawing.Size(64, 13);
            анастезияLabel.TabIndex = 5;
            анастезияLabel.Text = "Анастезия:";
            // 
            // цвет_ПломбыLabel
            // 
            цвет_ПломбыLabel.AutoSize = true;
            цвет_ПломбыLabel.Location = new System.Drawing.Point(12, 118);
            цвет_ПломбыLabel.Name = "цвет_ПломбыLabel";
            цвет_ПломбыLabel.Size = new System.Drawing.Size(80, 13);
            цвет_ПломбыLabel.TabIndex = 7;
            цвет_ПломбыLabel.Text = "Цвет Пломбы:";
            // 
            // снятие_НалётаLabel
            // 
            снятие_НалётаLabel.AutoSize = true;
            снятие_НалётаLabel.Location = new System.Drawing.Point(12, 145);
            снятие_НалётаLabel.Name = "снятие_НалётаLabel";
            снятие_НалётаLabel.Size = new System.Drawing.Size(86, 13);
            снятие_НалётаLabel.TabIndex = 9;
            снятие_НалётаLabel.Text = "Снятие Налёта:";
            // 
            // dentistryDataSet
            // 
            this.dentistryDataSet.DataSetName = "DentistryDataSet";
            this.dentistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_ПроцедурBindingSource
            // 
            this.список_ПроцедурBindingSource.DataMember = "Список_Процедур";
            this.список_ПроцедурBindingSource.DataSource = this.dentistryDataSet;
            // 
            // список_ПроцедурTableAdapter
            // 
            this.список_ПроцедурTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Dentistry.DentistryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Медицинская_картаTableAdapter = null;
            this.tableAdapterManager.Распределённые_ВрачиTableAdapter = null;
            this.tableAdapterManager.Список_ПроцедурTableAdapter = this.список_ПроцедурTableAdapter;
            // 
            // список_ПроцедурBindingNavigator
            // 
            this.список_ПроцедурBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.список_ПроцедурBindingNavigator.BindingSource = this.список_ПроцедурBindingSource;
            this.список_ПроцедурBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.список_ПроцедурBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.список_ПроцедурBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.список_ПроцедурBindingNavigatorSaveItem});
            this.список_ПроцедурBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.список_ПроцедурBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.список_ПроцедурBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.список_ПроцедурBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.список_ПроцедурBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.список_ПроцедурBindingNavigator.Name = "список_ПроцедурBindingNavigator";
            this.список_ПроцедурBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.список_ПроцедурBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.список_ПроцедурBindingNavigator.TabIndex = 0;
            this.список_ПроцедурBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // список_ПроцедурBindingNavigatorSaveItem
            // 
            this.список_ПроцедурBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.список_ПроцедурBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("список_ПроцедурBindingNavigatorSaveItem.Image")));
            this.список_ПроцедурBindingNavigatorSaveItem.Name = "список_ПроцедурBindingNavigatorSaveItem";
            this.список_ПроцедурBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.список_ПроцедурBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.список_ПроцедурBindingNavigatorSaveItem.Click += new System.EventHandler(this.список_ПроцедурBindingNavigatorSaveItem_Click);
            // 
            // название_ПроцедурыTextBox
            // 
            this.название_ПроцедурыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_ПроцедурBindingSource, "Название_Процедуры", true));
            this.название_ПроцедурыTextBox.Location = new System.Drawing.Point(138, 33);
            this.название_ПроцедурыTextBox.Name = "название_ПроцедурыTextBox";
            this.название_ПроцедурыTextBox.Size = new System.Drawing.Size(121, 20);
            this.название_ПроцедурыTextBox.TabIndex = 2;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_ПроцедурBindingSource, "Стоимость", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.стоимостьTextBox.Location = new System.Drawing.Point(138, 59);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(121, 20);
            this.стоимостьTextBox.TabIndex = 4;
            // 
            // анастезияCheckBox
            // 
            this.анастезияCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.список_ПроцедурBindingSource, "Анастезия", true));
            this.анастезияCheckBox.Location = new System.Drawing.Point(138, 85);
            this.анастезияCheckBox.Name = "анастезияCheckBox";
            this.анастезияCheckBox.Size = new System.Drawing.Size(121, 24);
            this.анастезияCheckBox.TabIndex = 6;
            this.анастезияCheckBox.Text = "Необходима";
            this.анастезияCheckBox.UseVisualStyleBackColor = true;
            // 
            // цвет_ПломбыComboBox
            // 
            this.цвет_ПломбыComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_ПроцедурBindingSource, "Цвет_Пломбы", true));
            this.цвет_ПломбыComboBox.FormattingEnabled = true;
            this.цвет_ПломбыComboBox.Items.AddRange(new object[] {
            "Жёлтый",
            "Светло-жёлтый"});
            this.цвет_ПломбыComboBox.Location = new System.Drawing.Point(138, 115);
            this.цвет_ПломбыComboBox.Name = "цвет_ПломбыComboBox";
            this.цвет_ПломбыComboBox.Size = new System.Drawing.Size(121, 21);
            this.цвет_ПломбыComboBox.TabIndex = 8;
            // 
            // снятие_НалётаComboBox
            // 
            this.снятие_НалётаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_ПроцедурBindingSource, "Снятие_Налёта", true));
            this.снятие_НалётаComboBox.FormattingEnabled = true;
            this.снятие_НалётаComboBox.Items.AddRange(new object[] {
            "Мягкое ",
            "Жёсткое"});
            this.снятие_НалётаComboBox.Location = new System.Drawing.Point(138, 142);
            this.снятие_НалётаComboBox.Name = "снятие_НалётаComboBox";
            this.снятие_НалётаComboBox.Size = new System.Drawing.Size(121, 21);
            this.снятие_НалётаComboBox.TabIndex = 10;
            // 
            // FormProcList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(название_ПроцедурыLabel);
            this.Controls.Add(this.название_ПроцедурыTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(анастезияLabel);
            this.Controls.Add(this.анастезияCheckBox);
            this.Controls.Add(цвет_ПломбыLabel);
            this.Controls.Add(this.цвет_ПломбыComboBox);
            this.Controls.Add(снятие_НалётаLabel);
            this.Controls.Add(this.снятие_НалётаComboBox);
            this.Controls.Add(this.список_ПроцедурBindingNavigator);
            this.Name = "FormProcList";
            this.Text = "Список процедур";
            this.Load += new System.EventHandler(this.FormProcList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dentistryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_ПроцедурBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_ПроцедурBindingNavigator)).EndInit();
            this.список_ПроцедурBindingNavigator.ResumeLayout(false);
            this.список_ПроцедурBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DentistryDataSet dentistryDataSet;
        private System.Windows.Forms.BindingSource список_ПроцедурBindingSource;
        private DentistryDataSetTableAdapters.Список_ПроцедурTableAdapter список_ПроцедурTableAdapter;
        private DentistryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator список_ПроцедурBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton список_ПроцедурBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_ПроцедурыTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.CheckBox анастезияCheckBox;
        private System.Windows.Forms.ComboBox цвет_ПломбыComboBox;
        private System.Windows.Forms.ComboBox снятие_НалётаComboBox;
    }
}