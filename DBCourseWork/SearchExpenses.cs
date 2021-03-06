using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class SearchExpenses : Form
    {
        public Main f1;
        public string s = "";

        public SearchExpenses(Main f, string name)
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Номер дела";
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
                    if (comboBox1.SelectedItem.ToString() == "Номер дела")
                    {
                        SDA = new MySqlDataAdapter($"SELECT id_case AS 'Номер дела', state_duty AS 'Госпошлина, руб', represent_services AS 'Услуги представителя, руб', other AS 'Прочее, руб' FROM {s} WHERE id_case LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Госпошлина")
                    {
                        SDA = new MySqlDataAdapter($"SELECT id_case AS 'Номер дела', state_duty AS 'Госпошлина, руб', represent_services AS 'Услуги представителя, руб', other AS 'Прочее, руб' FROM {s} WHERE state_duty LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Услуги представителя")
                    {
                        SDA = new MySqlDataAdapter($"SELECT id_case AS 'Номер дела', state_duty AS 'Госпошлина, руб', represent_services AS 'Услуги представителя, руб', other AS 'Прочее, руб' FROM {s} WHERE represent_services LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Прочее")
                    {
                        SDA = new MySqlDataAdapter($"SELECT id_case AS 'Номер дела', state_duty AS 'Госпошлина, руб', represent_services AS 'Услуги представителя, руб', other AS 'Прочее, руб' FROM {s} WHERE other LIKE '%{textBox1.Text}%'", db.getConnection());
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
