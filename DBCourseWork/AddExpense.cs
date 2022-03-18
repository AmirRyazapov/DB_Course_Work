using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                command = new MySqlCommand($"INSERT INTO expenses (id_case, state_duty, represent_services, other) VALUES ('{comboBox1.SelectedValue}', '{numericUpDown1.Value}', '{numericUpDown2.Value}', '{numericUpDown3.Value}')", db.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!");
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

        private void AddExpense_Load(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                string query = "SELECT id_case FROM cases WHERE id_case NOT IN(SELECT id_case FROM expenses)";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "cases");
                comboBox1.DisplayMember = "id_case";
                comboBox1.ValueMember = "id_case";
                comboBox1.DataSource = ds.Tables["cases"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
