using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry
{
    public partial class FormWorkesList : Form
    {
        public FormWorkesList()
        {
            InitializeComponent();
        }

        private void врачиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.врачиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dentistryDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }  
        }

        private void FormWorkesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Распределённые_Врачи". При необходимости она может быть перемещена или удалена.
            this.распределённые_ВрачиTableAdapter.Fill(this.dentistryDataSet.Распределённые_Врачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.dentistryDataSet.Врачи);

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

        private void врачиDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if((врачиDataGridView.Rows[e.RowIndex].
                Cells["PostGridViewTextBoxColumn"].Value == null) ||
                (врачиDataGridView.Rows[e.RowIndex].
                Cells["PostGridViewTextBoxColumn"].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
               (врачиDataGridView.Rows[e.RowIndex].Cells["PostGridViewTextBoxColumn"]
               .Value.ToString() == "Главврач")
                    e.CellStyle.BackColor = Color.Pink;
                else if (врачиDataGridView.Rows[e.RowIndex].Cells["PostGridViewTextBoxColumn"]
               .Value.ToString() == "Врач")
                    e.CellStyle.BackColor = Color.SkyBlue;
            }

        }

        private void распределённыеSaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.распределённые_ВрачиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dentistryDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        string GetSelectedFieldName()
        {
            return
           врачиDataGridView.Columns[врачиDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               врачиBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                врачиBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                врачиBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        врачиBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else врачиBindingSource.Filter = "";

            if (врачиBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                врачиBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
