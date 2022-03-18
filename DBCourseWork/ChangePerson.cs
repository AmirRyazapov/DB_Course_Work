using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class ChangePerson : Form
    {
        public string INN = "";
        public string s = "";
        public Main f1;

        public ChangePerson(Main f, string name)
        {
            InitializeComponent();
            s = name;
            f1 = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            INN = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand($"UPDATE {s} SET name = '{textBox1.Text}', INN = '{textBox2.Text}', district = '{textBox3.Text}', type = '{comboBox1.SelectedItem}' WHERE INN = {INN}", db.getConnection());
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
