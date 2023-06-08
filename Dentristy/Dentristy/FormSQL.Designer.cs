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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.radioButtonProc = new System.Windows.Forms.RadioButton();
            this.radioButtonDistrWorkers = new System.Windows.Forms.RadioButton();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 366);
            this.dataGridViewSelect.TabIndex = 1;
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
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonProc;
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.RadioButton radioButtonDistrWorkers;
    }
}