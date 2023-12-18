using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{

    public partial class GivenBooks : Form
    {

        //public string book_id = null;
        //public string author_id = null;
        //public string reader_id = null;
        string selectedRowId = null;
        bool isEditMode = false;
        bool isReturnMode = false;


        public GivenBooks()
        {
            InitializeComponent();
            //CreateDataBase();
            //insertrecord();
            showrecords();
            loadPositions();

        }


        public void loadPositions()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = $"SELECT * from NewBooks";
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                List<string> BooksList = new List<string>();
                List<string> ReadersList = new List<string>();
                List<string> StaffList = new List<string>();
                List<string> ISBNBooksList = new List<string>();

                while (result.Read())
                {
                    BooksList.Add((string)result["Название"]);
                    ISBNBooksList.Add((string)result["ISBN"]);
                }
                result.Close();
                comboBox1.DataSource = BooksList;
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

                comboBox4.DataSource = ISBNBooksList;
                comboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;

                query = $"SELECT * FROM Staff";
                command = new SqlCommand(query, connection);
                result = command.ExecuteReader();
                while (result.Read())
                {
                    StaffList.Add($"{(string)result["Имя"]} {result["Фамилия"]} {result["Отчество"]}");
                }
                result.Close();
                comboBox2.DataSource = StaffList;
                comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

                query = $"SELECT * FROM Readers";
                command = new SqlCommand(query, connection);
                result = command.ExecuteReader();
                while (result.Read())
                {
                    ReadersList.Add($"{(string)result["Имя"]} {result["Фамилия"]} {result["Отчество"]}");
                }
                result.Close();
                comboBox3.DataSource = ReadersList;
                comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;

            }

        }

        public void showrecords()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {


                connection.Open();
                var query = $"SELECT \r\nGivenBooks.p_id AS p_id, NewBooks.Название AS Книга,NewBooks.ISBN, \r\n CONCAT(Readers.Имя, ' ', Readers.Фамилия, ' ', Readers.Отчество) AS Читатель,\r\n CONCAT(Staff.Имя, ' ', Staff.Фамилия, ' ', Staff.Отчество) AS Сотрудник,given_date as [Дата выдачи],return_date AS [Дата возврата], GivenBooks.actual_return_date as [Фактический возврат] \r\nFROM \r\n GivenBooks\r\nINNER JOIN \r\n NewBooks ON GivenBooks.book_id = NewBooks.book_id\r\nINNER JOIN \r\n Readers ON GivenBooks.reader_id = Readers.reader_id\r\nINNER JOIN \r\n Staff ON GivenBooks.staff_id = Staff.staff_id;\r\n";


                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["p_id"].Visible = false;
            }

        }





        private void CreateDataBase()
        {

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "CREATE TABLE GivenBooks (p_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,book_id int,staff_id int,reader_id int, given_date DATE,return_date DATE, FOREIGN KEY(book_id) REFERENCES NewBooks(book_id),FOREIGN KEY(staff_id) REFERENCES Staff(staff_id),FOREIGN KEY(reader_id) REFERENCES Readers(reader_id));";
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
            openButton.Enabled = !openButton.Enabled;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            ChangeVisibleAddingButtons();
            ChangeVisibility();

            //select_book_for_return.Visible = !select_book_for_return.Visible;

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            //if (validatePosition(textBox_position.Text))
            //{
            //    MessageBox.Show("Введены запрещенные знаки!");
            //    return;
            //}

            if (!isEditMode && !isReturnMode) // Добавление новой записи
            {




                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {


                    connection.Open();

                    string query = "SELECT * from NewBooks WHERE Название = @titlebook";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@titlebook", comboBox1.Text);

                    // Execute the command and get the result
                    var book_id = command.ExecuteScalar();

                    if (book_id.ToString() == null)
                    {

                        MessageBox.Show("Ошибка во внешнем ключе (ДОЛЖНОСТЬ)\nПерезагрузите форму СОТРУДНИКИ");
                        MessageBox.Show(book_id.ToString());
                        return;
                    }
                    var staff_name = comboBox2.Text.Split(" ");
                    query = $"SELECT * FROM Staff WHERE Имя = @name AND Фамилия = @secondname AND Отчество = @thirdname";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", staff_name[0]);
                    command.Parameters.AddWithValue("@secondname", staff_name[1]);
                    command.Parameters.AddWithValue("@thirdname", staff_name[2]);
                    var staff_id = command.ExecuteScalar();

                    var reader_name = comboBox3.Text.Split(" ");
                    query = $"SELECT * FROM Readers WHERE Имя = @name AND Фамилия = @secondname AND Отчество = @thirdname";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", reader_name[0]);
                    command.Parameters.AddWithValue("@secondname", reader_name[1]);
                    command.Parameters.AddWithValue("@thirdname", reader_name[2]);
                    var reader_id = command.ExecuteScalar();

                    DateTime currentDate = DateTime.Now;
                    DateTime twoWeeksLater = currentDate.AddDays(2 * 7);


                    // Create the query with typed variables
                    query = "INSERT INTO GivenBooks (book_id, staff_id, reader_id, given_date,return_date) VALUES (@book, @staff, @reader, @givendate,@returndate)";

                    // Create the command with parameters
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@book", book_id);
                    command.Parameters.AddWithValue("@staff", staff_id);
                    command.Parameters.AddWithValue("@reader", reader_id);
                    command.Parameters.AddWithValue("@givendate", currentDate);
                    command.Parameters.AddWithValue("@returndate", twoWeeksLater);

                    command.ExecuteNonQuery();


                }



                ChangeVisibility();

                showrecords();
                ChangeVisibleAddingButtons();

            }
            else if (isReturnMode) // Неактуально
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    var isbnbook = comboBox4.Text;
                    string query = "SELECT book_id FROM NewBooks WHERE ISBN = @isbnbook";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@isbnbook", isbnbook);
                    int book_id = (int)command.ExecuteScalar();

                    query = "UPDATE GivenBooks SET actual_return_date = @actual_date WHERE book_id = @book_id AND actual_return_date = @status";

                    // Create the command with parameters
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@actual_date", DateTime.Now.ToString("dd.MM.yyyy"));
                    command.Parameters.AddWithValue("@book_id", book_id);
                    command.Parameters.AddWithValue("@status", "У читателя");

                    command.ExecuteNonQuery();

                    ChangeFunctionsReturn();
                    showrecords();

                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {
                    connection.Open();


                    string query = "SELECT book_id from NewBooks WHERE Название = @titlebook";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@titlebook", comboBox1.Text);

                    // Execute the command and get the result
                    var book_id = command.ExecuteScalar();

                    var staff_name = comboBox2.Text.Split(" ");
                    query = $"SELECT staff_id FROM Staff WHERE Имя = @name AND Фамилия = @secondname AND Отчество = @thirdname";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", staff_name[0]);
                    command.Parameters.AddWithValue("@secondname", staff_name[1]);
                    command.Parameters.AddWithValue("@thirdname", staff_name[2]);
                    var staff_id = command.ExecuteScalar();

                    var reader_name = comboBox3.Text.Split(" ");
                    query = $"SELECT reader_id FROM Readers WHERE Имя = @name AND Фамилия = @secondname AND Отчество = @thirdname";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", reader_name[0]);
                    command.Parameters.AddWithValue("@secondname", reader_name[1]);
                    command.Parameters.AddWithValue("@thirdname", reader_name[2]);
                    var reader_id = command.ExecuteScalar();


                    // Create the query with typed variables
                    //query = "UPDATE GivenBooks SET book_id = 2, staff_id = 3, reader_id = 2, given_date = @givendate,return_date = @returndate WHERE p_id = @SelectedRowId";
                    var query2 = "UPDATE GivenBooks SET book_id = @book,staff_id = @staff, reader_id = @reader WHERE p_id = @SelectedRowId";
                    //var query3 = $"UPDATE GivenBooks SET staff_id = '{staff_id}', reader_id = '{reader_id}'";

                    // Create the command with parameters
                    command = new SqlCommand(query2, connection);
                    command.Parameters.AddWithValue("@book", book_id);
                    command.Parameters.AddWithValue("@staff", staff_id);
                    command.Parameters.AddWithValue("@reader", reader_id);
                    //command.Parameters.AddWithValue("@givendate",DateTime.Parse("23.10.2002"));
                    //command.Parameters.AddWithValue("@returndate", DateTime.Parse("23.10.2022"));
                    command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);
                    MessageBox.Show($"{book_id} {staff_id} {reader_id} {selectedRowId}");
                    // Execute the command
                    command.ExecuteNonQuery();


                    isEditMode = false;

                    ChangeVisibility();

                    showrecords();
                    ChangeVisibleAddingButtons();

                }





            }

            //dataGridView1.CurrentCell.Selected = false;
        }
        private void ChangeVisibility()
        {
            groupBox1.Visible = !groupBox1.Visible;
            searchbutton.Visible = !searchbutton.Visible;
            searchTextBox.Visible = !searchTextBox.Visible;
            resetbutton.Visible = !resetbutton.Visible;
        }
        private bool validatePosition(string txt)
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

            //command.CommandText = $"INSERT INTO Positions (Должность) VALUES (\"{textBox_position.Text}\")";

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
                        string query = $"DELETE from GivenBooks WHERE p_id = @selectedRowId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                        command.ExecuteNonQuery();

                        //dataGridView1.CurrentCell.Selected = false;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!\nДанная запись уже используется!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    showrecords();
                    return;
                }
                showrecords();
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
                //string query = $"SELECT * FROM GivenBooks where p_id =@selectedRowId";
                //SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                //var result = command.ExecuteReader();
                //while (result.Read())
                //{
                //    //textBox1.Text = (string)result["Имя"];
                //    //textBox2.Text = (string)result["Фамилия"];
                //    //textBox3.Text = (string)result["Отчество"];
                //    //comboBox1.Text = (string)result["Должность"];
                //}


            }





            ChangeVisibility();


            isEditMode = true;
            ChangeVisibleAddingButtons();


            //textBox_position.Text = result.ToString();

            //connection.Close();

        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form positions_form = new Positions();
            positions_form.Show();
        }

        private void selectFromForm_Click(object sender, EventArgs e)
        {
            Form books_form = new Books("selectionBook");
            books_form.Owner = this;
            books_form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            if (isReturnMode) //Неактуально
            {
                ChangeFunctionsReturn();
            }
            else
            {
                ChangeVisibility();

                ChangeVisibleAddingButtons();

            }



        }
        private void ChangeFunctionsReturn()
        {
            isReturnMode = !isReturnMode;
            return_button.Visible = !return_button.Visible;
            comboBox4.Visible = !comboBox4.Visible;
            label_for_return_book.Visible = !label_for_return_book.Visible;

            dataGridView1.Visible = !dataGridView1.Visible;

            cancelbutton.Visible = !cancelbutton.Visible;
            savebutton.Visible = !savebutton.Visible;

            addbutton.Visible = !addbutton.Visible;
            editbutton.Visible = !editbutton.Visible;
            deletebutton.Visible = !deletebutton.Visible;

            searchbutton.Visible = !searchbutton.Visible;
            searchTextBox.Visible = !searchTextBox.Visible;
            resetbutton.Visible = !resetbutton.Visible;

        }
        private void return_button_Click(object sender, EventArgs e)
        {
            ChangeFunctionsReturn();
        }

        private void select_book_for_return_Click(object sender, EventArgs e)
        {
            Form books_form = new Books("selectionISBN");
            books_form.Owner = this;
            books_form.Show();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            showrecords();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();

                string query = "SELECT GB.p_id AS 'p_id', NB.Название as Книга, NB.ISBN, R.Имя + ' ' + R.Фамилия + ' ' + R.Отчество AS 'Читатель', S.Имя + ' ' + S.Фамилия + ' ' + S.Отчество AS 'Сотрудник', GB.given_date AS 'Дата выдачи', GB.return_date AS 'Дата возврата', GB.actual_return_date AS 'Фактический возврат' FROM NewBooks NB LEFT JOIN GivenBooks GB ON NB.book_id = GB.book_id LEFT JOIN Readers R ON GB.reader_id = R.reader_id LEFT JOIN Staff S ON GB.staff_id = S.staff_id WHERE (NB.Название LIKE '%' + @query + '%' OR R.Имя + ' ' + R.Фамилия + ' ' + R.Отчество LIKE '%' + @query + '%' OR S.Имя + ' ' + S.Фамилия + ' ' + S.Отчество LIKE '%' + @query + '%' OR NB.ISBN LIKE '%' + @query + '%') AND GB.given_date IS NOT NULL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@query", searchTextBox.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["p_id"].Visible = false;

            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                Dictionary<string, string> resultDict = new Dictionary<string, string>();

                connection.Open();
                if (selectedRowId == null)
                {
                    MessageBox.Show("Запись в таблице не выбрана!");
                    return;
                }
                string query = "SELECT GB.p_id AS 'p_id', NB.Название as 'Книга',NB.ISBN, R.Имя + ' ' + R.Фамилия + ' ' + R.Отчество AS 'Читатель', S.Имя + ' ' + S.Фамилия + ' ' + S.Отчество AS 'Сотрудник', GB.given_date AS 'Дата выдачи', GB.return_date AS 'Дата возврата', GB.actual_return_date AS 'Фактический возврат' FROM NewBooks NB LEFT JOIN GivenBooks GB ON NB.book_id = GB.book_id LEFT JOIN Readers R ON GB.reader_id = R.reader_id LEFT JOIN Staff S ON GB.staff_id = S.staff_id WHERE GB.p_id = @selectedRowId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //resultDict.Add("Книга", reader["Книга"].ToString());

                    resultDict["p_id"] = reader["p_id"].ToString();
                    resultDict["Книга"] = reader["Книга"].ToString();
                    resultDict["ISBN"] = reader["ISBN"].ToString();
                    resultDict["Читатель"] = reader["Читатель"].ToString();
                    resultDict["Сотрудник"] = reader["Сотрудник"].ToString();
                    resultDict["Дата выдачи"] = reader["Дата выдачи"].ToString();
                    resultDict["Дата возврата"] = reader["Дата возврата"].ToString();
                    resultDict["Фактический возврат"] = reader["Фактический возврат"].ToString();
                }
                BookRecord bookRecord = new BookRecord(resultDict);
                bookRecord.Owner = this;
                bookRecord.Show();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Readers r = new Readers("selection");
            r.Owner = this;
            r.Show();

            //Form books_form = new Books("selectionBook");
            //books_form.Owner = this;
            //books_form.Show();
        }

        private void SelectStaffButton_Click(object sender, EventArgs e)
        {
            Staff s = new Staff("selection");
            s.Owner = this;
            s.Show();
        }
    }
}