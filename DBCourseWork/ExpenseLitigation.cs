using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class ExpenseLitigation : Form
    {
        public Main f1;

        public ExpenseLitigation(Main f)
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
                if (comboBox1.SelectedItem.ToString() == "Больше")
                {
                    SDA = new MySqlDataAdapter($"SELECT cases.id_case AS 'Номер дела', cases.subject AS 'Предмет иска', " +
                        $"cases.decision AS 'Решение суда', cases.date AS 'Дата', expenses.state_duty AS 'Госпошлина(руб)', " +
                        $"expenses.represent_services AS 'Оплата услуг представителя(руб)', expenses.other AS 'Прочее(руб)', " +
                        $"(expenses.state_duty + expenses.represent_services + expenses.other) AS 'Сумма расходов(руб)' " +
                        $"FROM `cases`, `expenses` WHERE cases.id_case = expenses.id_case AND " +
                        $"(expenses.state_duty + expenses.represent_services + expenses.other) > {numericUpDown1.Value} " +
                        $"GROUP BY cases.id_case", db.getConnection());
                }
                else if (comboBox1.SelectedItem.ToString() == "Меньше")
                {
                    SDA = new MySqlDataAdapter($"SELECT cases.id_case AS 'Номер дела', cases.subject AS 'Предмет иска', " +
                        $"cases.decision AS 'Решение суда', cases.date AS 'Дата', expenses.state_duty AS 'Госпошлина(руб)', " +
                        $"expenses.represent_services AS 'Оплата услуг представителя(руб)', expenses.other AS 'Прочее(руб)', " +
                        $"(expenses.state_duty + expenses.represent_services + expenses.other) AS 'Сумма расходов(руб)' " +
                        $"FROM `cases`, `expenses` WHERE cases.id_case = expenses.id_case AND " +
                        $"(expenses.state_duty + expenses.represent_services + expenses.other) < {numericUpDown1.Value} " +
                        $"GROUP BY cases.id_case", db.getConnection());
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

        private void ExpenseLitigation_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Больше";
        }
    }
}
