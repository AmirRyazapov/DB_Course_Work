using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class AddCases : Form
    {
        public string s = "";
        public string action = "";
        public string id = "";

        public AddCases(string str, string a)
        {
            InitializeComponent();
            s = str;
            action = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                if (action == "add")
                {
                    command = new MySqlCommand($"INSERT INTO {s} (id_case, id_courts, subject, decision, id_plaintiff, " +
                    $"id_defendant, date) VALUES ('{textBox1.Text}', (SELECT id_court FROM courts WHERE name = '{comboBox1.SelectedValue}'), " +
                    $"'{textBox2.Text}', '{comboBox2.SelectedItem}', (SELECT id_plaintiff FROM plaintiffs WHERE name = '{comboBox3.SelectedValue}'), " +
                    $"(SELECT id_defendant FROM defendants WHERE name = '{comboBox4.SelectedValue}'), " +
                    $"'{dateTimePicker1.Text}')", db.getConnection());
                    command.ExecuteNonQuery();
                    command = new MySqlCommand($"INSERT INTO comments (id_case, comment) VALUES ('{textBox1.Text}', " +
                        $"'{textBox3.Text}')", db.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!");
                }
                else
                {
                    command = new MySqlCommand($"UPDATE {s} SET id_case = '{textBox1.Text}', id_courts = " +
                        $"(SELECT id_court FROM courts WHERE name = '{comboBox1.SelectedValue}'), subject = '{textBox2.Text}', " +
                        $"decision = '{comboBox2.SelectedItem}', id_plaintiff = (SELECT id_plaintiff FROM plaintiffs WHERE name = '{comboBox3.SelectedValue}'), " +
                    $"id_defendant = (SELECT id_defendant FROM defendants WHERE name = '{comboBox4.SelectedValue}'), date = '{dateTimePicker1.Text}' " +
                    $"WHERE id_case = {id}", db.getConnection());
                    command.ExecuteNonQuery();
                    command = new MySqlCommand($"UPDATE comments SET comment = '{textBox3.Text}' WHERE id_case = {id}", db.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно изменена!");
                }
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

        private void AddCases_Load(object sender, EventArgs e)
        {
            if (action == "change")
            {
                button1.Text = "Изменить запись";
                id = textBox1.Text;
            }
            else
            {
                button1.Text = "Добавить запись";
            }
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                string query1 = "SELECT id_court, name FROM courts";
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(query1, db.getConnection());
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1, "courts");
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "name";
                comboBox1.DataSource = ds1.Tables["courts"];

                string query2 = "SELECT id_plaintiff, name FROM plaintiffs";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, db.getConnection());
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2, "plaintiffs");
                comboBox3.DisplayMember = "name";
                comboBox3.ValueMember = "name";
                comboBox3.DataSource = ds2.Tables["plaintiffs"];

                string query3 = "SELECT id_defendant, name FROM defendants";
                MySqlDataAdapter adapter3 = new MySqlDataAdapter(query3, db.getConnection());
                DataSet ds3 = new DataSet();
                adapter3.Fill(ds3, "defendants");
                comboBox4.DisplayMember = "name";
                comboBox4.ValueMember = "name";
                comboBox4.DataSource = ds3.Tables["defendants"];
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
