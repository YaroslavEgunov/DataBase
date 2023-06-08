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
using System.Data.Common;

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

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DentistryConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Врачи");
        }

        private void radioButtonDistrWorkers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT ФИО_Врача, Название_Процедуры, " +
                "Стаж_Работы FROM Распределённые_Врачи, Врачи " +
                "Where Распределённые_Врачи.Номер_Паспорта = Врачи.Номер_Паспорта");
        }

        private void radioButtonProc_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Название_Процедуры, " +
                "CAST(Стоимость AS decimal(16,2)) AS [Текущая цена], " +
                "'Произойдет' AS Пояснение, " +
                "CAST(Стоимость*1.5 AS decimal(16,2)) AS [Повышение цены на 50%] FROM Список_Процедур");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWorker.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника." +
                    "\nДопустим ввод первых символов.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }

            string sqlSelect = "";

            if (radioButtonDet_Proc.Checked)
                sqlSelect = @"SELECT w.Номер_Паспорта, ФИО_Врача, d.Название_Процедуры, CAST((Стоимость) AS decimal(16,2)) AS Прибыль " +
                    "FROM Распределённые_Врачи w, Список_Процедур d, Врачи v " +
                    "WHERE v.Номер_Паспорта = w.Номер_Паспорта AND w.Название_Процедуры = d.Название_Процедуры AND ФИО_Врача LIKE @last_name " +
                    "GROUP BY w.Номер_Паспорта, ФИО_Врача, d.Название_Процедуры, d.Стоимость";

            else
                sqlSelect = @"SELECT w.Номер_Паспорта, ФИО_Врача, CAST((Стоимость) AS decimal(16,2)) AS Прибыль " +
                    "FROM Распределённые_Врачи w, Список_Процедур d, Врачи v " +
                    "WHERE v.Номер_Паспорта = w.Номер_Паспорта AND w.Название_Процедуры = d.Название_Процедуры AND ФИО_Врача LIKE @last_name " +
                    "GROUP BY w.Номер_Паспорта, ФИО_Врача, d.Название_Процедуры, d.Стоимость";

            if (checkBoxMore.Checked)
                sqlSelect += " HAVING Sum(Стоимость) >@amount";

            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY Sum(Стоимость) desc";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DentistryConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxWorker.Text + "%");

            if (checkBoxMore.Checked)

                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                   Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;

            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой записи", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT Записи.ID_Записи, " +
                    "(SELECT Название_Процедуры FROM Список_Процедур WHERE Название_Процедуры = Записи.Название_Процедуры) AS Процедура, " +
                    "(SELECT ФИО_Врача FROM Врачи WHERE Номер_Паспорта = Записи.Номер_Паспорта) AS Выполнил_сотрудник " +
                    "FROM Записи WHERE ID_Записи = @number";

            else if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = @"SELECT * FROM Записи WHERE ID_Записи = @number";
            }

            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DentistryConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;

            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value =
               int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSelectDishes_Click(object sender, EventArgs e)
        {
            dataGridViewDish.DataSource = FillDataGridView("SELECT * FROM Список_Процедур");
        }

        void InsertDish()
        {
            if (String.IsNullOrEmpty(textBoxId_proc.Text))
            {
                MessageBox.Show("Обязательно введите название процедуры", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = "INSERT INTO Список_Процедур " +
                "(Название_Процедуры, Стоимость, Цвет_Пломбы, Снятие_Налёта, Анастезия) " +
                "VALUES (@Name, @Price, @Color, @Nal, @Anas)";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DentistryConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@Name", textBoxName_proc.Text);
            command.Parameters.AddWithValue("@Price", textBoxPrice_proc.Text);

            if (!String.IsNullOrEmpty(comboBoxColor_proc.Text))
                command.Parameters.AddWithValue("@Color", comboBoxColor_proc.Text);
            else
                command.Parameters.AddWithValue("@Color", DBNull.Value);

            if (!String.IsNullOrEmpty(comboBoxNal_proc.Text))
                command.Parameters.AddWithValue("@Nal", comboBoxNal_proc.Text);
            else
                command.Parameters.AddWithValue("@Nal", DBNull.Value);

            command.Parameters.AddWithValue("@Anas", checkBoxAnas_proc.Checked);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Close();
            buttonSelectDishes_Click(this, EventArgs.Empty);
        }

        void UpdateDish()
        {
            double price = 0;

            if ((!String.IsNullOrEmpty(textBoxPrice_proc.Text)) &&
            (!double.TryParse(textBoxPrice_proc.Text, out price)))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE Список_Процедур SET {0} Анастезия=@Anas WHERE Название_Процедуры = @Name";


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DentistryConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";

            if (!String.IsNullOrEmpty(textBoxName_proc.Text))
                sqlValues += "Название_Процедуры=@Name,";

            if (!String.IsNullOrEmpty(textBoxPrice_proc.Text))
                sqlValues += "Стоимость=@Price,";

            if (!String.IsNullOrEmpty(comboBoxColor_proc.Text))
                sqlValues += "Цвет_Пломбы=@Color,";
            
            if (!String.IsNullOrEmpty(comboBoxNal_proc.Text))
                sqlValues += "Снятие_Налёта=@Nal,";

            command.CommandText = String.Format(sqlUpdate, sqlValues);

            if (!String.IsNullOrEmpty(textBoxName_proc.Text))
                command.Parameters.AddWithValue("@Name", textBoxName_proc.Text);

            if (!String.IsNullOrEmpty(textBoxPrice_proc.Text))
                command.Parameters.AddWithValue("@Price", price);

            if (!String.IsNullOrEmpty(comboBoxColor_proc.Text))
                command.Parameters.AddWithValue("@Color", price);

            if (!String.IsNullOrEmpty(comboBoxNal_proc.Text))
                command.Parameters.AddWithValue("@Nal", comboBoxNal_proc.Text);

            command.Parameters.AddWithValue("@Anas", checkBoxAnas_proc.Checked);

            try
            {
                command.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            buttonSelectDishes_Click(this, EventArgs.Empty);
        }

        void DeleteDish()
        {
            if (String.IsNullOrEmpty(textBoxName_proc.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда данные которого необходимо удалить", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }

            string name;

            name = textBoxName_proc.Text; 

            string sqlDelete = @"DELETE FROM Список_Процедур WHERE Название_Процедуры=@Name_proc";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.DentistryConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Name_proc", name);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectDishes_Click(this, EventArgs.Empty);
        }

        private void radioButtonDelete_dish_CheckedChanged(object sender, EventArgs e)
        {
            panelProc.Visible = !radioButtonDelete_proc.Checked;
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_proc.Checked)
                InsertDish();
            else
                if (radioButtonUpdate_proc.Checked)
                    UpdateDish();
            else
                if (radioButtonDelete_proc.Checked)
                    DeleteDish();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}




