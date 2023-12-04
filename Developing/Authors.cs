using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{
    public partial class Authors : Form
    {


        string selectedRowId = null;
        bool isEditMode = false;
        string mode = "";

        public Authors(string mode = "")
        {
            InitializeComponent();

            //CreateDataBase();
            this.mode = mode;
            //insertrecord();
            if (mode != "") DisableSecondaryOptions();
            ShowRecords();

            //dataGridView1.Rows[0].Cells[0].Selected = true;
        }

        private void DisableSecondaryOptions()
        {
            menuStrip1.Enabled = false;
        }

        private void ShowRecords()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM Authors";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["author_id"].Visible = false;

            }
        }

        private void CreateDataBase()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                var query = "CREATE TABLE Authors (author_id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL, Имя nvarchar(MAX),Фамилия nvarchar(MAX),Отчество nvarchar(MAX));";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void StuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form staff_Form = new Staff();
            staff_Form.Show();
        }

        private void PublishingHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ChangeVisibleAddingButtons()
        {
            addbutton.Visible = !addbutton.Visible;
            editbutton.Visible = !editbutton.Visible;
            deletebutton.Visible = !deletebutton.Visible;
        }
        private void ClearTextBoxes()
        {
            textBox_name.Text = "";
            textBox_surname.Text = "";
            textBox_lastname.Text = "";
        }
        private void HideTextBoxes()
        {

            textBox_name.Visible = !textBox_name.Visible;
            textBox_lastname.Visible = !textBox_lastname.Visible;
            textBox_surname.Visible = !textBox_surname.Visible;
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            label_genre.Visible = !label_genre.Visible;
            

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            HideTextBoxes();
            ClearTextBoxes();
            dataGridView1.Visible = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
            ChangeVisibleAddingButtons();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();

                if (!isEditMode)
                {

                    var query = $"INSERT INTO Authors (Имя,Фамилия,Отчество) VALUES (@name,@surname,@lastname)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", textBox_name.Text);
                    command.Parameters.AddWithValue("@surname", textBox_surname.Text);
                    command.Parameters.AddWithValue("@lastname", textBox_lastname.Text);

                    command.ExecuteNonQuery();

                    HideTextBoxes();
                    dataGridView1.Visible = true;
                    savebutton.Visible = false;
                    cancelbutton.Visible = false;
                    textBox_name.Text = ""; //Очистка поля добавления
                    textBox_surname.Text = "";
                    textBox_lastname.Text = "";

                    ChangeVisibleAddingButtons();
                    ClearTextBoxes();
                    ShowRecords();
                }
                else
                {

                    var query = $"UPDATE Authors SET Имя = @name,Фамилия = @surname,Отчество = @lastname WHERE author_id = @selectedRowId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", textBox_name.Text);
                    command.Parameters.AddWithValue("@surname", textBox_surname.Text);
                    command.Parameters.AddWithValue("@lastname", textBox_lastname.Text);
                    command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                    command.ExecuteNonQuery();

                    HideTextBoxes();
                    dataGridView1.Visible = true;
                    savebutton.Visible = false;
                    cancelbutton.Visible = false;
                    textBox_name.Text = "";
                    textBox_surname.Text = "";
                    textBox_lastname.Text = "";

                    isEditMode = false;
                    ChangeVisibleAddingButtons();
                    ClearTextBoxes();
                    ShowRecords();
                }

            }



            //dataGridView1.CurrentCell.Selected = false;
        }
        private bool validateAuthor(string txt)
        {
            Regex rr = new Regex(@"[-.?!)(,:#$%^&*_+=\|/]");
            Regex r = new Regex(@"/[^\\._\\-\\/\\*\\(\\)]/g");
            Match m = rr.Match(txt);
            return m.Success;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;

            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            int selectedRow = Int32.Parse(rows[0].Index.ToString());
            //MessageBox.Show(selectedRow.ToString());
            selectedRowId = Convert.ToString(dataGridView1.Rows[selectedRow].Cells[0].Value.ToString());

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();


                if (selectedRowId == null)
                {
                    MessageBox.Show("Запись в таблице не выбрана!");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var query = $"DELETE from Authors WHERE author_id = @selectedRowId";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show($"Ошибка при удалении автора из таблицы\nАвтор используется в справочнике Книги");
                    }
                    ShowRecords();

                    //dataGridView1.CurrentCell.Selected = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }



        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();
                if (selectedRowId == null)
                {
                    MessageBox.Show("Запись в таблице не выбрана!");
                    return;
                }
                HideTextBoxes();
                dataGridView1.Visible = false;
                savebutton.Visible = true;
                cancelbutton.Visible = true;

                ChangeVisibleAddingButtons();
                ClearTextBoxes();
                isEditMode = true;
                var query = $"SELECT Имя,Фамилия,Отчество from Authors WHERE author_id = {Int32.Parse(selectedRowId)}";
                var command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();

                if (result.Read())
                {
                    textBox_name.Text = result.GetString(0);
                    textBox_surname.Text = result.GetString(1);
                    textBox_lastname.Text = result.GetString(2);
                    // Используйте переменную result
                }
            }
        }



        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (mode == "selection")
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                int index = e.RowIndex;
                dataGridView1.Rows[index].Selected = true;

                DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
                int selectedRow = Int32.Parse(rows[0].Index.ToString());
                //MessageBox.Show(selectedRow.ToString());
                selectedRowId = Convert.ToString(dataGridView1.Rows[selectedRow].Cells[0].Value.ToString());

                //MessageBox.Show(selectedRowId);
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {

                    connection.Open();
                    var query = $"SELECT Имя,Фамилия,Отчество from Authors WHERE author_id={Convert.ToInt32(selectedRowId)}";
                    SqlCommand command = new SqlCommand(query, connection);
                    var result = command.ExecuteReader();
                    Books books = this.Owner as Books;
                    var s = books.selectedAuthors;
                    while (result.Read())
                    {
                        books.dataGridView2.Rows.Add(($"{(string)result["Имя"]} {(string)result["Фамилия"]} {(string)result["Отчество"]}"));
                        s.Add(Convert.ToInt32(selectedRowId));
                    }


                    this.Close();

                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_position_Click(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            savebutton.Visible = false;
            cancelbutton.Visible = false;
            
            ChangeVisibleAddingButtons();
            HideTextBoxes();
            ClearTextBoxes();
        }
    }
}