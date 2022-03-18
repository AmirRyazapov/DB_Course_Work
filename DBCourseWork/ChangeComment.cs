using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class ChangeComment : Form
    {
        public string id = "";
        public ChangeComment(string num)
        {
            InitializeComponent();
            id = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand($"UPDATE comments SET comment = '{textBox1.Text}' WHERE id_comment = {id}", db.getConnection());
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
