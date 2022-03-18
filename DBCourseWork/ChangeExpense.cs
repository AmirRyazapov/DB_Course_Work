using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class ChangeExpense : Form
    {
        public string id = "";
        public ChangeExpense(string num)
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
                MySqlCommand command = new MySqlCommand($"UPDATE expenses SET state_duty = '{numericUpDown1.Value}', represent_services = '{numericUpDown2.Value}', other = '{numericUpDown3.Value}' WHERE id_case = {id}", db.getConnection());
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
