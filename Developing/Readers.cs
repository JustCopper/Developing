using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{
    public partial class Readers : Form
    {


        string selectedRowId = null;
        bool isEditMode = false;
        string mode = "";

        public Readers(string mode = "")
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
                string query = "SELECT * FROM Readers";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["reader_id"].Visible = false;

            }
        }

        private void CreateDataBase()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                var query = "CREATE TABLE Readers (reader_id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL, Имя nvarchar(MAX),Фамилия nvarchar(MAX),Отчество nvarchar(MAX),[Номер паспорта] int);";
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
            Form staff_Form = new Staff("");
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
            addbutton.Enabled = !addbutton.Enabled;
            editbutton.Enabled = !editbutton.Enabled;
            deletebutton.Enabled = !deletebutton.Enabled;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            HideTextBoxes();


            ChangeVisibleAddingButtons();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();

                if (!isEditMode)
                {

                    var query = $"INSERT INTO Readers (Имя,Фамилия,Отчество,[Номер паспорта]) VALUES (@name,@surname,@lastname,@passport)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", textBox_name.Text);
                    command.Parameters.AddWithValue("@surname", textBox_surname.Text);
                    command.Parameters.AddWithValue("@lastname", textBox_lastname.Text);
                    command.Parameters.AddWithValue("@passport", textBox1.Text);


                    command.ExecuteNonQuery();



                    textBox_name.Text = ""; //Очистка поля добавления
                    textBox_surname.Text = "";
                    textBox_lastname.Text = "";

                    textBox1.Text = "";
                    textBox_lastname.Text = "";
                    textBox_surname.Text = "";
                    textBox_name.Text = "";
                    HideTextBoxes();
                    ChangeVisibleAddingButtons();
                    ShowRecords();
                }
                else
                {

                    var query = $"UPDATE Readers SET Имя = @name,Фамилия = @surname,Отчество = @lastname,[Номер паспорта] = @passport WHERE reader_id = @selectedRowId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", textBox_name.Text);
                    command.Parameters.AddWithValue("@surname", textBox_surname.Text);
                    command.Parameters.AddWithValue("@lastname", textBox_lastname.Text);
                    command.Parameters.AddWithValue("@passport", textBox1.Text);

                    command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                    command.ExecuteNonQuery();



                    textBox_name.Text = "";
                    textBox_surname.Text = "";
                    textBox_lastname.Text = "";
                    textBox1.Text = "";

                    textBox1.Text = "";
                    textBox_lastname.Text = "";
                    textBox_surname.Text = "";
                    textBox_name.Text = "";



                    isEditMode = false;
                    ChangeVisibleAddingButtons();
                    HideTextBoxes();
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
                        var query = $"DELETE from Readers WHERE reader_id = @selectedRowId";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Ошибка!\nДанная запись уже используется!");
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



                ChangeVisibleAddingButtons();
                HideTextBoxes();
                isEditMode = true;
                var query = $"SELECT * from Readers WHERE reader_id = {Int32.Parse(selectedRowId)}";
                var command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();

                if (result.Read())
                {
                    textBox_name.Text = (string)result["Имя"];
                    textBox_surname.Text = (string)result["Фамилия"];
                    textBox_lastname.Text = (string)result["Отчество"];
                    textBox1.Text = Convert.ToString(result["Номер паспорта"]);
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
                    var query = $"SELECT Имя,Фамилия,Отчество,[Номер паспорта] from Readers WHERE reader_id={Convert.ToInt32(selectedRowId)}";
                    SqlCommand command = new SqlCommand(query, connection);
                    var result = command.ExecuteReader();
                    GivenBooks givenBooks = this.Owner as GivenBooks;

                    string tempStaff = givenBooks.comboBox2.Text;
                    string tempReader = givenBooks.comboBox3.Text;
                    string tempBook = givenBooks.comboBox1.Text;

                    givenBooks.loadPositions();

                    givenBooks.comboBox2.Text = tempStaff;
                    givenBooks.comboBox3.Text = tempReader;
                    givenBooks.comboBox1.Text = tempBook;

                    while (result.Read())
                    {
                        givenBooks.comboBox3.Text = $"{result["Имя"]} {result["Фамилия"]} {result["Отчество"]}";
                    }
                    //Books books = this.Owner as Books;
                    //var s = books.selectedAuthors;
                    //while (result.Read())
                    //{
                    //    books.dataGridView2.Rows.Add(($"{(string)result["Имя"]} {(string)result["Фамилия"]} {(string)result["Отчество"]}"));
                    //    s.Add(Convert.ToInt32(selectedRowId));
                    //}


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

        private void HideTextBoxes()
        {

            groupBox1.Visible = !groupBox1.Visible;

            searchTextBox.Visible = !searchTextBox.Visible;
            searchbutton.Visible = !searchbutton.Visible;
            resetbutton.Visible = !resetbutton.Visible;

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            if (isEditMode) { isEditMode = !isEditMode; }



            textBox_surname.Text = "";
            textBox_lastname.Text = "";
            textBox1.Text = "";
            textBox_name.Text = "";
            HideTextBoxes();
            ChangeVisibleAddingButtons();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();

                string query = "SELECT * \r\nFROM Readers\r\nWHERE CONCAT(Имя, ' ', фамилия, ' ', Отчество) LIKE '%' + @query + '%'\r\nOR [номер паспорта] LIKE '%' + @query + '%'\r\n";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@query", searchTextBox.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["reader_id"].Visible = false;

            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            ShowRecords();
        }
    }
}