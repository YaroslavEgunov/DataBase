using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dentistry
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL f;
        public static FormSQL freq
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником
            //данных

             SqlConnection connection = new SqlConnection(Properties.Settings.Default.DentistryConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата
            //запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Врачи"); 
        }

        private void radioButtonDistrWorkers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Распределённые_Врачи");
        }

        private void radioButtonProc_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Название_Процедуры, Стоимость FROM Список_Процедур");
        }
    }
}
