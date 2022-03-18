using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class SearchCases : Form
    {
        public Main f1;
        public string s = "";

        public SearchCases(Main f, string name)
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
                        SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                        $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                        $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                        $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                        $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                        $"AND cas.id_defendant = def.id_defendant AND cas.id_case LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Суд")
                    {
                        SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                        $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                        $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                        $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                        $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                        $"AND cas.id_defendant = def.id_defendant AND cou.name LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Предмет")
                    {
                        SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                        $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                        $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                        $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                        $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                        $"AND cas.id_defendant = def.id_defendant AND cas.subject LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Решение")
                    {
                        SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                        $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                        $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                        $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                        $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                        $"AND cas.id_defendant = def.id_defendant AND cas.decision LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Истец")
                    {
                        SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                        $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                        $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                        $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                        $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                        $"AND cas.id_defendant = def.id_defendant AND pl.name LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Ответчик")
                    {
                        SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                        $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                        $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                        $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                        $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                        $"AND cas.id_defendant = def.id_defendant AND def.name LIKE '%{textBox1.Text}%'", db.getConnection());
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Дата")
                    {
                        SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                        $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                        $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                        $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                        $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                        $"AND cas.id_defendant = def.id_defendant AND cas.date LIKE '%{textBox1.Text}%'", db.getConnection());
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
