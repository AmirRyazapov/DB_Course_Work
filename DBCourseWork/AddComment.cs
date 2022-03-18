using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class AddComment : Form
    {
        public AddComment()
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
                command = new MySqlCommand($"INSERT INTO comments (id_case, comment) VALUES ('{comboBox1.SelectedValue}', '{textBox1.Text}')", db.getConnection());
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

        private void AddComment_Load(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                string query1 = "SELECT id_case FROM cases";
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(query1, db.getConnection());
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1, "cases");
                comboBox1.DisplayMember = "id_case";
                comboBox1.ValueMember = "id_case";
                comboBox1.DataSource = ds1.Tables["cases"];
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
