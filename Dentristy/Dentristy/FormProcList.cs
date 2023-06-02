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
            try
            {
                this.Validate();
                this.список_ПроцедурBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dentistryDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormProcList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.dentistryDataSet.Врачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Распределённые_Врачи". При необходимости она может быть перемещена или удалена.
            this.распределённые_ВрачиTableAdapter.Fill(this.dentistryDataSet.Распределённые_Врачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Список_Процедур". При необходимости она может быть перемещена или удалена.
            this.список_ПроцедурTableAdapter.Fill(this.dentistryDataSet.Список_Процедур);

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
            список_ПроцедурBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
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

        int idCurrent = -1;
        public int ShowSelectForm(int idProc, out decimal price)
        {
            idCurrent = idProc;
            ShowDialog();
            price =
           (decimal)((DataRowView)список_ПроцедурBindingSource.Current)["стоимость"];
            return
           (int)((DataRowView)список_ПроцедурBindingSource.Current)["код_процедуры"];
        }

        private void FormProcList_Shown(object sender, EventArgs e)
        {
            список_ПроцедурBindingSource.Position =
           список_ПроцедурBindingSource.Find("код_процедуры", idCurrent);
        }
    }
}
