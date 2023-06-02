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
    public partial class FormDistributedWorkersList : Form
    {
        public FormDistributedWorkersList()
        {
            InitializeComponent();
        }

        private void распределённые_ВрачиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void FormDistributedWorkersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.dentistryDataSet.Врачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Список_Процедур". При необходимости она может быть перемещена или удалена.
            this.список_ПроцедурTableAdapter.Fill(this.dentistryDataSet.Список_Процедур);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Распределённые_Врачи". При необходимости она может быть перемещена или удалена.
            this.распределённые_ВрачиTableAdapter.Fill(this.dentistryDataSet.Распределённые_Врачи);

        }

        private static FormDistributedWorkersList f;
        public static FormDistributedWorkersList fdw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormDistributedWorkersList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
