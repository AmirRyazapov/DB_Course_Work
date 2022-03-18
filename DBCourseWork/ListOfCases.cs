using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class ListOfCases : Form
    {
        public Main f1;

        public ListOfCases(Main f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                MySqlDataAdapter SDA = new MySqlDataAdapter();
                if (comboBox1.SelectedItem.ToString() == "Предмет иска" && comboBox2.SelectedItem.ToString() == "По возрастанию")
                {
                    SDA = new MySqlDataAdapter($"SELECT coalesce(cases.subject, 'Итоги') AS 'Предмет иска', " +
                        $"SUM(expenses.state_duty + expenses.represent_services + expenses.other) AS 'Сумма судебных затрат (руб)', " +
                        $"COUNT(*) AS 'Количество дел' FROM `cases`, `expenses` WHERE date BETWEEN '{dateTimePicker1.Text}' " +
                        $"AND '{dateTimePicker2.Text}' AND cases.id_case = expenses.id_case " +
                        $"GROUP BY cases.subject WITH ROLLUP ORDER BY SUM(expenses.state_duty + expenses.represent_services + expenses.other)", db.getConnection());
                }
                else if (comboBox1.SelectedItem.ToString() == "Предмет иска" && comboBox2.SelectedItem.ToString() == "По убыванию")
                {
                    SDA = new MySqlDataAdapter($"SELECT coalesce(cases.subject, 'Итоги') AS 'Предмет иска', " +
                        $"SUM(expenses.state_duty + expenses.represent_services + expenses.other) AS 'Сумма судебных затрат (руб)', " +
                        $"COUNT(*) AS 'Количество дел' FROM `cases`, `expenses` WHERE date BETWEEN '{dateTimePicker1.Text}' " +
                        $"AND '{dateTimePicker2.Text}' AND cases.id_case = expenses.id_case " +
                        $"GROUP BY cases.subject WITH ROLLUP ORDER BY SUM(expenses.state_duty + expenses.represent_services + expenses.other) DESC", db.getConnection());
                }
                else if (comboBox1.SelectedItem.ToString() == "Решение суда" && comboBox2.SelectedItem.ToString() == "По возрастанию")
                {
                    SDA = new MySqlDataAdapter($"SELECT coalesce(cases.decision, 'Итоги') AS 'Решение суда', " +
                        $"SUM(expenses.state_duty + expenses.represent_services + expenses.other) AS 'Сумма судебных затрат (руб)', " +
                        $"COUNT(*) AS 'Количество дел' FROM `cases`, `expenses` WHERE date BETWEEN '{dateTimePicker1.Text}' " +
                        $"AND '{dateTimePicker2.Text}' AND cases.id_case = expenses.id_case " +
                        $"GROUP BY cases.decision WITH ROLLUP ORDER BY SUM(expenses.state_duty + expenses.represent_services + expenses.other)", db.getConnection());
                }
                else if (comboBox1.SelectedItem.ToString() == "Решение суда" && comboBox2.SelectedItem.ToString() == "По убыванию")
                {
                    SDA = new MySqlDataAdapter($"SELECT coalesce(cases.decision, 'Итоги') AS 'Решение суда', " +
                        $"SUM(expenses.state_duty + expenses.represent_services + expenses.other) AS 'Сумма судебных затрат (руб)', " +
                        $"COUNT(*) AS 'Количество дел' FROM `cases`, `expenses` WHERE date BETWEEN '{dateTimePicker1.Text}' " +
                        $"AND '{dateTimePicker2.Text}' AND cases.id_case = expenses.id_case " +
                        $"GROUP BY cases.decision WITH ROLLUP ORDER BY SUM(expenses.state_duty + expenses.represent_services + expenses.other) DESC", db.getConnection());
                }
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                f1.dGV.Columns.Clear();
                f1.dGV.DataSource = DATA;
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
            Close();
        }

        private void ListOfCases_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Предмет иска";
            comboBox2.SelectedItem = "По возрастанию";
        }
    }
}
