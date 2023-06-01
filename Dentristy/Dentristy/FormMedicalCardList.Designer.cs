namespace Dentistry
{
    partial class FormMedicalCardList
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

        private static FormMedicalCardList f;
        public static FormMedicalCardList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMedicalCardList();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicalCardList));
            System.Windows.Forms.Label номер_КартыLabel;
            System.Windows.Forms.Label данные_о_леченииLabel;
            System.Windows.Forms.Label данные_о_клиентеLabel;
            System.Windows.Forms.Label фото_клиентаLabel;
            this.dentistryDataSet = new Dentistry.DentistryDataSet();
            this.медицинская_картаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.медицинская_картаTableAdapter = new Dentistry.DentistryDataSetTableAdapters.Медицинская_картаTableAdapter();
            this.tableAdapterManager = new Dentistry.DentistryDataSetTableAdapters.TableAdapterManager();
            this.медицинская_картаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.медицинская_картаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_КартыTextBox = new System.Windows.Forms.TextBox();
            this.данные_о_леченииTextBox = new System.Windows.Forms.TextBox();
            this.данные_о_клиентеTextBox = new System.Windows.Forms.TextBox();
            this.фото_клиентаPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            номер_КартыLabel = new System.Windows.Forms.Label();
            данные_о_леченииLabel = new System.Windows.Forms.Label();
            данные_о_клиентеLabel = new System.Windows.Forms.Label();
            фото_клиентаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dentistryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медицинская_картаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медицинская_картаBindingNavigator)).BeginInit();
            this.медицинская_картаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фото_клиентаPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dentistryDataSet
            // 
            this.dentistryDataSet.DataSetName = "DentistryDataSet";
            this.dentistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // медицинская_картаBindingSource
            // 
            this.медицинская_картаBindingSource.DataMember = "Медицинская_карта";
            this.медицинская_картаBindingSource.DataSource = this.dentistryDataSet;
            // 
            // медицинская_картаTableAdapter
            // 
            this.медицинская_картаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Dentistry.DentistryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Медицинская_картаTableAdapter = this.медицинская_картаTableAdapter;
            this.tableAdapterManager.Распределённые_ВрачиTableAdapter = null;
            this.tableAdapterManager.Список_ПроцедурTableAdapter = null;
            // 
            // медицинская_картаBindingNavigator
            // 
            this.медицинская_картаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.медицинская_картаBindingNavigator.BindingSource = this.медицинская_картаBindingSource;
            this.медицинская_картаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.медицинская_картаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.медицинская_картаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.медицинская_картаBindingNavigatorSaveItem});
            this.медицинская_картаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.медицинская_картаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.медицинская_картаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.медицинская_картаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.медицинская_картаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.медицинская_картаBindingNavigator.Name = "медицинская_картаBindingNavigator";
            this.медицинская_картаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.медицинская_картаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.медицинская_картаBindingNavigator.TabIndex = 0;
            this.медицинская_картаBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // медицинская_картаBindingNavigatorSaveItem
            // 
            this.медицинская_картаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.медицинская_картаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("медицинская_картаBindingNavigatorSaveItem.Image")));
            this.медицинская_картаBindingNavigatorSaveItem.Name = "медицинская_картаBindingNavigatorSaveItem";
            this.медицинская_картаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.медицинская_картаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.медицинская_картаBindingNavigatorSaveItem.Click += new System.EventHandler(this.медицинская_картаBindingNavigatorSaveItem_Click);
            // 
            // номер_КартыLabel
            // 
            номер_КартыLabel.AutoSize = true;
            номер_КартыLabel.Location = new System.Drawing.Point(12, 41);
            номер_КартыLabel.Name = "номер_КартыLabel";
            номер_КартыLabel.Size = new System.Drawing.Size(79, 13);
            номер_КартыLabel.TabIndex = 1;
            номер_КартыLabel.Text = "Номер Карты:";
            // 
            // номер_КартыTextBox
            // 
            this.номер_КартыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.медицинская_картаBindingSource, "Номер_Карты", true));
            this.номер_КартыTextBox.Location = new System.Drawing.Point(97, 38);
            this.номер_КартыTextBox.Name = "номер_КартыTextBox";
            this.номер_КартыTextBox.Size = new System.Drawing.Size(139, 20);
            this.номер_КартыTextBox.TabIndex = 2;
            // 
            // данные_о_леченииLabel
            // 
            данные_о_леченииLabel.AutoSize = true;
            данные_о_леченииLabel.Location = new System.Drawing.Point(276, 68);
            данные_о_леченииLabel.Name = "данные_о_леченииLabel";
            данные_о_леченииLabel.Size = new System.Drawing.Size(104, 13);
            данные_о_леченииLabel.TabIndex = 3;
            данные_о_леченииLabel.Text = "Данные о лечении:";
            // 
            // данные_о_леченииTextBox
            // 
            this.данные_о_леченииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.медицинская_картаBindingSource, "Данные_о_лечении", true));
            this.данные_о_леченииTextBox.Location = new System.Drawing.Point(279, 96);
            this.данные_о_леченииTextBox.Multiline = true;
            this.данные_о_леченииTextBox.Name = "данные_о_леченииTextBox";
            this.данные_о_леченииTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.данные_о_леченииTextBox.Size = new System.Drawing.Size(221, 194);
            this.данные_о_леченииTextBox.TabIndex = 4;
            // 
            // данные_о_клиентеLabel
            // 
            данные_о_клиентеLabel.AutoSize = true;
            данные_о_клиентеLabel.Location = new System.Drawing.Point(12, 68);
            данные_о_клиентеLabel.Name = "данные_о_клиентеLabel";
            данные_о_клиентеLabel.Size = new System.Drawing.Size(104, 13);
            данные_о_клиентеLabel.TabIndex = 5;
            данные_о_клиентеLabel.Text = "Данные о клиенте:";
            // 
            // данные_о_клиентеTextBox
            // 
            this.данные_о_клиентеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.медицинская_картаBindingSource, "Данные_о_клиенте", true));
            this.данные_о_клиентеTextBox.Location = new System.Drawing.Point(15, 96);
            this.данные_о_клиентеTextBox.Multiline = true;
            this.данные_о_клиентеTextBox.Name = "данные_о_клиентеTextBox";
            this.данные_о_клиентеTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.данные_о_клиентеTextBox.Size = new System.Drawing.Size(221, 194);
            this.данные_о_клиентеTextBox.TabIndex = 6;
            // 
            // фото_клиентаLabel
            // 
            фото_клиентаLabel.AutoSize = true;
            фото_клиентаLabel.Location = new System.Drawing.Point(536, 68);
            фото_клиентаLabel.Name = "фото_клиентаLabel";
            фото_клиентаLabel.Size = new System.Drawing.Size(82, 13);
            фото_клиентаLabel.TabIndex = 7;
            фото_клиентаLabel.Text = "Фото клиента:";
            // 
            // фото_клиентаPictureBox
            // 
            this.фото_клиентаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.медицинская_картаBindingSource, "Фото_клиента", true));
            this.фото_клиентаPictureBox.Location = new System.Drawing.Point(539, 96);
            this.фото_клиентаPictureBox.Name = "фото_клиентаPictureBox";
            this.фото_клиентаPictureBox.Size = new System.Drawing.Size(221, 194);
            this.фото_клиентаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фото_клиентаPictureBox.TabIndex = 8;
            this.фото_клиентаPictureBox.TabStop = false;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(685, 296);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPhoto.TabIndex = 9;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // FormMedicalСard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(номер_КартыLabel);
            this.Controls.Add(this.номер_КартыTextBox);
            this.Controls.Add(данные_о_леченииLabel);
            this.Controls.Add(this.данные_о_леченииTextBox);
            this.Controls.Add(данные_о_клиентеLabel);
            this.Controls.Add(this.данные_о_клиентеTextBox);
            this.Controls.Add(фото_клиентаLabel);
            this.Controls.Add(this.фото_клиентаPictureBox);
            this.Controls.Add(this.медицинская_картаBindingNavigator);
            this.Name = "FormMedicalСard";
            this.Text = "Список медицинских карт";
            this.Load += new System.EventHandler(this.FormMedicalСard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dentistryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медицинская_картаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медицинская_картаBindingNavigator)).EndInit();
            this.медицинская_картаBindingNavigator.ResumeLayout(false);
            this.медицинская_картаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фото_клиентаPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DentistryDataSet dentistryDataSet;
        private System.Windows.Forms.BindingSource медицинская_картаBindingSource;
        private DentistryDataSetTableAdapters.Медицинская_картаTableAdapter медицинская_картаTableAdapter;
        private DentistryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator медицинская_картаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton медицинская_картаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_КартыTextBox;
        private System.Windows.Forms.TextBox данные_о_леченииTextBox;
        private System.Windows.Forms.TextBox данные_о_клиентеTextBox;
        private System.Windows.Forms.PictureBox фото_клиентаPictureBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}