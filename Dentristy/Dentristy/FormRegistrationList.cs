using Dentistry.DentistryDataSetTableAdapters;
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
    public partial class FormRegistrationList : Form
    {
        public FormRegistrationList()
        {
            InitializeComponent();
        }

        private void записиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.записиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dentistryDataSet);

        }

        private void FormRegistrationList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Записи". При необходимости она может быть перемещена или удалена.
            this.записиTableAdapter.Fill(this.dentistryDataSet.Записи);

        }

        private static FormRegistrationList f;
        public static FormRegistrationList fr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRegistrationList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return
           записиDataGridView.Columns[записиDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void список_ПроцедурDataGridView_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (String.Compare(GetSelectedFieldName(), "Название_Процедуры", false) ==0)
            {
                decimal price = 0;
                int idProcCurrent = -1;
                int.TryParse((((DataRowView)записиBindingSource.Current)["название_процедуры"]).ToString(), out idProcCurrent);
                int idProc = FormProcList.fd.ShowSelectForm(idProcCurrent, out price);
                MessageBox.Show("Код процедуры=" + idProc.ToString());
                записиBindingSource.EndEdit();
                записиTableAdapter.Update(this.dentistryDataSet);
            }
        }
    }
}
