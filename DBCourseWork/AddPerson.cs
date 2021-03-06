using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class AddPerson : Form
    {
        public string s = "";
        public AddPerson(string str)
        {
            InitializeComponent();
            s = str;
        }

        private void AddPlaintiffs_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Физическое лицо";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();

            try
            {
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand($"INSERT INTO {s} (name, INN, district, type) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{comboBox1.SelectedItem}')", db.getConnection());
                command.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Запись успешно добавлена!");
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
