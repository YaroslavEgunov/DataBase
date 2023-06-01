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
    public partial class FormMedicalCardList : Form
    {
        public FormMedicalCardList()
        {
            InitializeComponent();
        }

        private void медицинская_картаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.медицинская_картаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dentistryDataSet);

        }

        private void FormMedicalСard_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistryDataSet.Медицинская_карта". При необходимости она может быть перемещена или удалена.
            this.медицинская_картаTableAdapter.Fill(this.dentistryDataSet.Медицинская_карта);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фото_клиентаPictureBox.Image = new
               Bitmap(openFileDialogPhoto.FileName);

            }
            else fileImage = "";
        }

    }
}
