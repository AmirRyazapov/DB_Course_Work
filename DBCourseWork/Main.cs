using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class Main : Form
    {
        public string name = "";
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Maximized;
        }

        private void outputTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name = "plaintiffs";
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                showTable(db, name);
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
        }

        private void showTable(DB_Connection db, string s)
        {
            dGV.Columns.Clear();
            MySqlDataAdapter SDA;
            if (s == "courts")
            {
                SDA = new MySqlDataAdapter($"SELECT name AS 'Название суда', type AS 'Тип' FROM {s}", db.getConnection());
            }
            else if (s == "defendants" || s == "plaintiffs")
            {
                SDA = new MySqlDataAdapter($"SELECT name AS 'Имя', INN AS 'ИНН', district AS 'Район', type AS 'Тип' FROM {s}", db.getConnection());
            }
            else if (s == "cases")
            {
                SDA = new MySqlDataAdapter($"SELECT cas.id_case AS 'Номер дела', cou.name " +
                    $"AS 'Суд', cas.subject AS 'Предмет иска', cas.decision AS 'Решение суда', " +
                    $"pl.name AS 'Истец', def.name AS 'Ответчик', date AS 'Дата решения' " +
                    $"FROM {s} AS cas, courts AS cou, defendants AS def, plaintiffs AS pl " +
                    $"WHERE cas.id_courts = cou.id_court AND cas.id_plaintiff = pl.id_plaintiff " +
                    $"AND cas.id_defendant = def.id_defendant", db.getConnection());
            }
            else if (s == "comments")
            {
                SDA = new MySqlDataAdapter($"SELECT id_comment AS 'id', id_case AS 'Номер дела', comment AS 'Комментарий' FROM {s}", db.getConnection());
            }
            else
            {
                SDA = new MySqlDataAdapter($"SELECT id_case AS 'Номер дела', state_duty AS 'Госпошлина, руб', represent_services AS 'Услуги представителя, руб', other AS 'Прочее, руб' FROM {s}", db.getConnection());
            }
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dGV.DataSource = DATA;

            var column = new DataGridViewColumn();
            column.HeaderText = "Удалить";
            column.Name = "delete";
            column.CellTemplate = new DataGridViewButtonCell();
            dGV.Columns.Add(column);

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Изменить";
            column2.Name = "change";
            column2.CellTemplate = new DataGridViewButtonCell();
            dGV.Columns.Add(column2);
        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DB_Connection db = new DB_Connection();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 4 && (name == "defendants" || name == "plaintiffs"))
            {
                var a = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value;
                try
                {
                    db.openConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand($"DELETE FROM {name} WHERE INN = {a}", db.getConnection());
                    command.ExecuteNonQuery();
                    showTable(db, name);
                    db.closeConnection();
                    MessageBox.Show("Запись успешно удалена!");
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
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 2 && name == "courts")
            {
                var a = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;
                try
                {
                    db.openConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand($"DELETE FROM {name} WHERE name = '{a}'", db.getConnection());
                    command.ExecuteNonQuery();
                    showTable(db, name);
                    db.closeConnection();
                    MessageBox.Show("Запись успешно удалена!");
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
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 7 && name == "cases")
            {
                var a = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;
                try
                {
                    db.openConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand($"DELETE FROM {name} WHERE id_case = '{a}'", db.getConnection());
                    command.ExecuteNonQuery();
                    showTable(db, name);
                    db.closeConnection();
                    MessageBox.Show("Запись успешно удалена!");
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
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 3 && name == "comments")
            {
                var a = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;
                try
                {
                    db.openConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand($"DELETE FROM {name} WHERE id_comment = '{a}'", db.getConnection());
                    command.ExecuteNonQuery();
                    showTable(db, name);
                    db.closeConnection();
                    MessageBox.Show("Запись успешно удалена!");
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
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 4 && name == "expenses")
            {
                var a = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;
                try
                {
                    db.openConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand($"DELETE FROM {name} WHERE id_case = '{a}'", db.getConnection());
                    command.ExecuteNonQuery();
                    showTable(db, name);
                    db.closeConnection();
                    MessageBox.Show("Запись успешно удалена!");
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
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 5 && (name == "plaintiffs" || name == "defendants"))
            {
                ChangePerson cp = new ChangePerson(this, name);
                cp.textBox1.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                cp.textBox2.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
                cp.textBox3.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value.ToString();
                cp.comboBox1.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
                cp.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 3 && name == "courts")
            {
                ChangeCourt cc = new ChangeCourt(this, name);
                cc.textBox1.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                cc.comboBox1.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
                cc.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 8 && name == "cases")
            {
                AddCases ac = new AddCases(name, "change");
                ac.textBox1.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                ac.comboBox1.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
                ac.textBox2.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value.ToString();
                ac.comboBox2.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
                ac.comboBox3.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value.ToString();
                ac.comboBox4.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[5].Value.ToString();
                ac.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 4 && name == "comments")
            {
                ChangeComment cc = new ChangeComment(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString());
                cc.textBox1.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value.ToString();
                cc.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null && e.ColumnIndex == 5 && name == "expenses")
            {
                ChangeExpense ce = new ChangeExpense(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString());
                ce.numericUpDown1.Value = Convert.ToDecimal(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value);
                ce.numericUpDown2.Value = Convert.ToDecimal(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);
                ce.numericUpDown3.Value = Convert.ToDecimal(((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value);
                ce.Show();
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson ap = new AddPerson("plaintiffs");
            ap.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPerson sp = new SearchPerson(this, "plaintiffs");
            sp.Show();
        }

        private void outputTableDefendantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name = "defendants";
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                showTable(db, name);
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
        }

        private void addNoteDefendantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson ap = new AddPerson("defendants");
            ap.Show();
        }

        private void searchDefendantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPerson sp = new SearchPerson(this, "defendants");
            sp.Show();
        }

        private void outputCourtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name = "courts";
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                showTable(db, name);
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
        }

        private void addCourtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourt ac = new AddCourt("courts");
            ac.Show();
        }

        private void outputCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name = "cases";
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                showTable(db, name);
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
        }

        private void addCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCases ac = new AddCases("cases", "add");
            ac.Show();
        }

        private void searchCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCases sc = new SearchCases(this, "cases");
            sc.Show();
        }

        private void searchCourtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCourts sc = new SearchCourts(this, "courts");
            sc.Show();
        }

        private void outputCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name = "comments";
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                showTable(db, name);
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
        }

        private void addCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddComment ac = new AddComment();
            ac.Show();
        }

        private void searchCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchComments sc = new SearchComments(this, "comments");
            sc.Show();
        }

        private void outputExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name = "expenses";
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                showTable(db, name);
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
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpense ae = new AddExpense();
            ae.Show();
        }

        private void searchExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchExpenses se = new SearchExpenses(this, "expenses");
            se.Show();
        }

        private void listOfCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfCases loc = new ListOfCases(this);
            loc.Show();
        }

        private void expenseLitigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseLitigation el = new ExpenseLitigation(this);
            el.Show();
        }

        private void numOfCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_Connection db = new DB_Connection();
            try
            {
                db.openConnection();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT * FROM numOfCases", db.getConnection());
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                dGV.Columns.Clear();
                dGV.DataSource = DATA;
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
        }
    }
}

