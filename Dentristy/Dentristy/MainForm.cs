using Dentistry.Properties;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(С) ТУСУР, КСУП, Егунов Ярослав Алексеевич, группа 571-1, 2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void процедурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcList.fd.ShowForm();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkesList.fw.ShowForm();
        }

        private void медицинскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicalCardList.fm.ShowForm();
        }
    }
}
