using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class SearchPerson : Form
    {
        public Main f1;
        public string s = "";

        public SearchPerson(Main f, string name)
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Имя";
            s = name;
            f1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            if (comboBox1.SelectedItem.ToString() != "" && textBox1.Text != "")
            {
                try
                {
                    db.openConnection();
                    MySqlDataAdapter SDA = new MySqlDataAdapter();
                    if (comboBox1.SelectedItem.ToString() == "Имя")
                    {
                        SDA = new MySqlDataAdapter($"SELECT name AS 'Имя', INN AS 'ИНН', district AS 'Район', type AS 'Тип' FROM {s} WHERE name LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "ИНН")
                    {
                        SDA = new MySqlDataAdapter($"SELECT name AS 'Имя', INN AS 'ИНН', district AS 'Район', type AS 'Тип' FROM {s} WHERE INN LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Район")
                    {
                        SDA = new MySqlDataAdapter($"SELECT name AS 'Имя', INN AS 'ИНН', district AS 'Район', type AS 'Тип' FROM {s} WHERE district LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Тип")
                    {
                        SDA = new MySqlDataAdapter($"SELECT name AS 'Имя', INN AS 'ИНН', district AS 'Район', type AS 'Тип' FROM {s} WHERE type LIKE '%{textBox1.Text}%'", db.getConnection());
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
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
