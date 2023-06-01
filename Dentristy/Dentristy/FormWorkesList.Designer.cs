namespace Dentistry
{
    partial class FormWorkesList
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

        private static FormWorkesList f;
        public static FormWorkesList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormWorkesList();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkesList));
            this.dentistryDataSet = new Dentistry.DentistryDataSet();
            this.врачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.врачиTableAdapter = new Dentistry.DentistryDataSetTableAdapters.ВрачиTableAdapter();
            this.tableAdapterManager = new Dentistry.DentistryDataSetTableAdapters.TableAdapterManager();
            this.врачиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.врачиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.врачиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dentistryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingNavigator)).BeginInit();
            this.врачиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dentistryDataSet
            // 
            this.dentistryDataSet.DataSetName = "DentistryDataSet";
            this.dentistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // врачиBindingSource
            // 
            this.врачиBindingSource.DataMember = "Врачи";
            this.врачиBindingSource.DataSource = this.dentistryDataSet;
            // 
            // врачиTableAdapter
            // 
            this.врачиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Dentistry.DentistryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВрачиTableAdapter = this.врачиTableAdapter;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Медицинская_картаTableAdapter = null;
            this.tableAdapterManager.Распределённые_ВрачиTableAdapter = null;
            this.tableAdapterManager.Список_ПроцедурTableAdapter = null;
            // 
            // врачиBindingNavigator
            // 
            this.врачиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.врачиBindingNavigator.BindingSource = this.врачиBindingSource;
            this.врачиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.врачиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.врачиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.врачиBindingNavigatorSaveItem});
            this.врачиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.врачиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.врачиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.врачиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.врачиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.врачиBindingNavigator.Name = "врачиBindingNavigator";
            this.врачиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.врачиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.врачиBindingNavigator.TabIndex = 0;
            this.врачиBindingNavigator.Text = "bindingNavigator1";
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
            // врачиBindingNavigatorSaveItem
            // 
            this.врачиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.врачиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("врачиBindingNavigatorSaveItem.Image")));
            this.врачиBindingNavigatorSaveItem.Name = "врачиBindingNavigatorSaveItem";
            this.врачиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.врачиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.врачиBindingNavigatorSaveItem.Click += new System.EventHandler(this.врачиBindingNavigatorSaveItem_Click);
            // 
            // врачиDataGridView
            // 
            this.врачиDataGridView.AutoGenerateColumns = false;
            this.врачиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.врачиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PostGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.врачиDataGridView.DataSource = this.врачиBindingSource;
            this.врачиDataGridView.Location = new System.Drawing.Point(12, 28);
            this.врачиDataGridView.Name = "врачиDataGridView";
            this.врачиDataGridView.Size = new System.Drawing.Size(776, 410);
            this.врачиDataGridView.TabIndex = 1;
            this.врачиDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.врачиDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_Паспорта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_Паспорта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // PostGridViewTextBoxColumn
            // 
            this.PostGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.PostGridViewTextBoxColumn.HeaderText = "Должность";
            this.PostGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Врач",
            "Главврач"});
            this.PostGridViewTextBoxColumn.Name = "PostGridViewTextBoxColumn";
            this.PostGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PostGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО_Врача";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО_Врача";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormWorkesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.врачиDataGridView);
            this.Controls.Add(this.врачиBindingNavigator);
            this.Name = "FormWorkesList";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.FormWorkesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dentistryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingNavigator)).EndInit();
            this.врачиBindingNavigator.ResumeLayout(false);
            this.врачиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DentistryDataSet dentistryDataSet;
        private System.Windows.Forms.BindingSource врачиBindingSource;
        private DentistryDataSetTableAdapters.ВрачиTableAdapter врачиTableAdapter;
        private DentistryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator врачиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton врачиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView врачиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn PostGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}