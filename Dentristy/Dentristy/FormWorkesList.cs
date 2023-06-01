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
            this.Validate();
            this.врачиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dentistryDataSet);

        }

        private void FormWorkesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.dentistryDataSet.Врачи);

        }

        private void врачиDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if((врачиDataGridView.Rows[e.RowIndex].Cells["PostGridViewTextBoxColumn"].Value == null) ||
                (врачиDataGridView.Rows[e.RowIndex].Cells["PostGridViewTextBoxColumn"].Value.ToString() == ""))
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
    }
}
