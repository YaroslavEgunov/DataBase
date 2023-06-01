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
    public partial class FormProcList : Form
    {
        public FormProcList()
        {
            InitializeComponent();
        }

        private void список_ПроцедурBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.список_ПроцедурBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dentistryDataSet);

        }

        private void FormProcList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Список_Процедур". При необходимости она может быть перемещена или удалена.
            this.список_ПроцедурTableAdapter.Fill(this.dentistryDataSet.Список_Процедур);

        }
    }
}
