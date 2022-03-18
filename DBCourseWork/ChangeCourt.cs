using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class ChangeCourt : Form
    {
        public string name = "";
        public string s = "";
        public Main f1;

        public ChangeCourt(Main f, string name1)
        {
            InitializeComponent();
            s = name1;
            f1 = f;
        }

        private void ChangeCourt_Load(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand($"UPDATE {s} SET name = '{textBox1.Text}', type = '{comboBox1.SelectedItem}' WHERE name = '{name}'", db.getConnection());
                command.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Запись успешно изменена!");
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
    }
}
