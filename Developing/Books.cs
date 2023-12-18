using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace Developing
{


    public partial class Books : Form
    {

        public class Book
        {
            private int id { get; set; }
            public string title { get; set; }
            public string author { get; set; }
            public string isbn { get; set; }
            public DateTime date_publication { get; set; }
            public string publishhouse { get; set; }
            public string genre { get; set; }
        }

        string selectedRowId = null;
        string selectedRowIdAuthor = null;
        bool isEditMode = false;
        public List<int> selectedAuthors = new List<int>();
        string mode = "";

        private void DisableSecondaryOptions()
        {
            menuStrip1.Enabled = false;
        }

        public Books(string mode = "")
        {
            InitializeComponent();
            this.mode = mode;
            if (mode != "") DisableSecondaryOptions();
            //CreateDataBase();
            //insertrecord();
            showrecords();
            loadPositions();
            //checkfk();
        }


        //private void checkfk()
        //{
        //    var conn = Connect("firstBase.sqlite");
        //    SQLiteCommand comm = connection.CreateCommand();
        //    comm.CommandText = "PRAGMA foreign_keys;";
        //    var r = comm.ExecuteScalar();
        //    MessageBox.Show(r.ToString());

        //}

        public void loadPositions()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                //������������
                connection.Open();
                string query = $"SELECT ������������ from PublishHouses";
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                List<string> PublishHousesList = new List<string>();
                command.Dispose();

                while (result.Read())
                {
                    PublishHousesList.Add((string)result["������������"]);
                }
                result.Close();
                comboBox3.DataSource = PublishHousesList;
                comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;

                comboBox3.DropDownWidth = 50;
                //�����
                query = $"SELECT * from Genres";
                command = new SqlCommand(query, connection);
                result = command.ExecuteReader();
                List<string> GenresList = new List<string>();


                while (result.Read())
                {
                    GenresList.Add((string)result["����"]);
                }
                comboBox1.DataSource = GenresList;
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
                result.Close();
                comboBox1.DropDownWidth = 50;
                //������
                query = $"SELECT * from Authors";
                command = new SqlCommand(query, connection);
                result = command.ExecuteReader();
                List<string> AuthorsList = new List<string>();


                while (result.Read())
                {
                    AuthorsList.Add($"{(string)result["���"]} {(string)result["�������"]} {(string)result["��������"]}");
                }
                //comboBox2.DataSource = AuthorsList;
                //comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

                //comboBox2.DropDownWidth = 50;
                result.Close();
            }

        }

        public void showrecords()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                //dataGridView1.ClearSelection();
                //var query = "SELECT b.book_id, b.��������, CONCAT(a.���, ' ', a.�������, ' ', a.��������) AS �����, b.[���� ����������], ph.������������, g.����\r\nFROM Books b\r\nJOIN Authors a ON b.����� = a.author_id\r\nJOIN PublishHouses ph ON b.������������ = ph.publishhouse_id\r\nJOIN Genres g ON b.���� = g.genre_id;\r\n";
                //var query = "SELECT b.book_id, b.��������,b.ISBN, b.[���� ����������], ph.������������, g.����\r\nFROM NewBooks b\r\n\r\nJOIN PublishHouses ph ON b.������������ = ph.publishhouse_id\r\nJOIN Genres g ON b.���� = g.genre_id;\r\n";
                var query = "SELECT \r\n b.book_id, \r\n b.��������,\r\n b.ISBN, \r\n b.[���� ����������], \r\n ph.������������, \r\n g.����,\r\n (SELECT STRING_AGG(CONCAT(a.���, ' ', a.�������, ' ', a.��������), ', ') \r\n  FROM Authors_Books ab \r\n  JOIN Authors a ON ab.id_author = a.author_id \r\n  WHERE ab.id_book = b.book_id) AS ������\r\nFROM \r\n NewBooks b\r\nJOIN \r\n PublishHouses ph ON b.������������ = ph.publishhouse_id\r\nJOIN \r\n Genres g ON b.���� = g.genre_id;\r\n";
                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["book_id"].Visible = false;

            }

            //dataGridView1.ClearSelection();
            //dataGridView1.CurrentCell = null;
            //dataGridView1.Rows[0].Cells[0].Selected = true;
        }

        //private void insertrecord()
        //{
        //    command.CommandText = "INSERT INTO Staff (���������) VALUES (\"��������\")";
        //    command.ExecuteNonQuery();
        //}

        //static public bool Connect(string fileName)
        //{
        //    try
        //    {
        //        connection = new SQLiteConnection("Data Source=" + fileName + "; FailIfMissing=False;Foreign Keys=true");
        //        connection.Open();
        //        return true;
        //    }
        //    catch (SQLiteException ex)
        //    {
        //        Console.WriteLine($"������ ������� � ���� ������. ����������: {ex.Message}");
        //        return false;
        //    }
        //}

        private void CreateDataBase()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                //current_table_label.Text += "������� �������";
                var query = "CREATE TABLE NewBooks (    book_id INT IDENTITY(1,1) PRIMARY KEY,   �������� NVARCHAR(MAX),ISBN NVARCHAR(MAX),   [���� ����������] DATE,   ������������ INT,    ���� INT,    FOREIGN KEY (������������) REFERENCES PublishHouses(publishhouse_id),    FOREIGN KEY (����) REFERENCES Genres(genre_id));";
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
        }
        private void HideTextBoxes()
        {
            groupBox1.Visible = !groupBox1.Visible;

            //textBox1.Visible = !textBox1.Visible;
            //textBoxISBN.Visible = !textBoxISBN.Visible;
            //comboBox1.Visible = !comboBox1.Visible;
            //comboBox3.Visible = !comboBox3.Visible;
            //dateTimePicker1.Visible = !dateTimePicker1.Visible;
            //dataGridView2.Visible = !dataGridView2.Visible;
            //dataGridView1.Visible = !dataGridView1.Visible;
            //label1.Visible = !label1.Visible;
            //label2.Visible = !label2.Visible;
            //label_position.Visible = !label_position.Visible;
            //namelabel.Visible = !namelabel.Visible;
            //thirdnamelabel.Visible = !thirdnamelabel.Visible;
            //secondnamelabel.Visible = !secondnamelabel.Visible;

            //selectAuthorButton.Visible = !selectAuthorButton.Visible;
            //selectGenreButton.Visible = !selectGenreButton.Visible;
            //selectPublishhouseButton.Visible = !selectPublishhouseButton.Visible;
            //buttonRemoveAuthor.Visible = !buttonRemoveAuthor.Visible;

            searchbutton.Visible = !searchbutton.Visible;
            searchTextBox.Visible = !searchTextBox.Visible;
            resetbutton.Visible = !resetbutton.Visible;

            //MessageBox.Show(textBox1.Visible.ToString());
            //cancelbutton.Visible = !cancelbutton.Visible;
            //savebutton.Visible = !savebutton.Visible;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            HideTextBoxes();
            ChangeVisibleAddingButtons();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            //if (validatePosition(textBox_position.Text))
            //{
            //    MessageBox.Show("������� ����������� �����!");
            //    return;
            //}

            if (!isEditMode)
            {
                //using (SQLiteConnection connection = new SQLiteConnection(new SQLiteConnection("Data Source=firstBase.sqlite; FailIfMissing=False")))
                //{


                //}
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {


                    connection.Open();
                    //var author_name = comboBox2.Text.Split(" ");
                    //string query = $"SELECT * FROM Authors WHERE ���=@firstname AND �������=@secondname AND ��������=@thirdname";
                    //SqlCommand command = new SqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@firstname", author_name[0]);
                    //command.Parameters.AddWithValue("@secondname", author_name[1]);
                    //command.Parameters.AddWithValue("@thirdname", author_name[2]);

                    //var author_id = command.ExecuteScalar();
                    //MessageBox.Show(Convert.ToString(author_id));

                    string query = $"SELECT publishhouse_id FROM PublishHouses WHERE ������������ = @publish";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@publish", comboBox3.Text);
                    string p_id = command.ExecuteScalar().ToString();


                    query = $"SELECT genre_id FROM Genres WHERE ���� = @author";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@author", comboBox1.Text);
                    string g_id = command.ExecuteScalar().ToString();

                    //query = "INSERT INTO Books (��������, �����, [���� ����������], ������������, ����) VALUES (@title, @Author, @creation_date, @publishHouse,@genre)";
                    query = "INSERT INTO NewBooks (��������,ISBN, [���� ����������], ������������, ����) VALUES (@title,@ISBN, @creation_date, @publishHouse,@genre)";



                    command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@title", textBox1.Text);
                    command.Parameters.AddWithValue("@ISBN", textBoxISBN.Text);

                    //command.Parameters.AddWithValue("@Author", author_id);
                    command.Parameters.AddWithValue("@creation_date", DateTime.Parse(dateTimePicker1.Text));
                    command.Parameters.AddWithValue("@publishHouse", p_id);
                    command.Parameters.AddWithValue("@genre", g_id);
                    command.ExecuteNonQuery();

                    query = "SELECT * FROM NewBooks WHERE ISBN = @ISBN";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ISBN", textBoxISBN.Text);
                    var p_key_book = command.ExecuteScalar();
                    //MessageBox.Show(p_key_book.ToString());

                    if (dataGridView2.Rows.Count == 0)
                    {
                        MessageBox.Show("�������� �������!");
                        return;
                    }

                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        query = "INSERT INTO Authors_Books(id_book,id_author) VALUES (@id_book,@id_author)";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id_book", p_key_book);
                        command.Parameters.AddWithValue("@id_author", selectedAuthors[i]);
                        command.ExecuteNonQuery();
                    }
                    selectedAuthors.Clear();
                    dataGridView2.Rows.Clear();


                    //string query = "SELECT * from Authors WHERE ��������� = @SelectedPosition";

                    //// Create the command with parameters
                    //SqlCommand command = new SqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@SelectedPosition", comboBox1.Text);

                    //// Execute the command and get the result
                    //var result = command.ExecuteScalar();
                    //if (result.ToString() == null)
                    //{

                    //    MessageBox.Show("������ �� ������� ����� (���������)\n������������� ����� ����������");
                    //    MessageBox.Show(result.ToString());
                    //    return;
                    //}
                    ////comm.CommandText = $"SELECT staff.���, staff.�������, staff.�������� FROM staff INNER JOIN Positions ON staff.staff_id=Positions.id;";
                    //string firstName = textBox1.Text;
                    //string lastName = textBox2.Text;
                    //string middleName = textBox3.Text;
                    //string position = result.ToString();

                    //// Create the query with typed variables

                    //// Create the command with parameters
                    //command = new SqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@FirstName", firstName);
                    //command.Parameters.AddWithValue("@LastName", lastName);
                    //command.Parameters.AddWithValue("@MiddleName", middleName);
                    //command.Parameters.AddWithValue("@Position", position);
                    //command.ExecuteNonQuery();

                }



                HideTextBoxes();
                ChangeVisibleAddingButtons();


                showrecords();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {


                    connection.Open();
                    //var author_name = comboBox2.Text.Split(" ");
                    //string query = $"SELECT * FROM Authors WHERE ���=@firstname AND �������=@secondname AND ��������=@thirdname";
                    //SqlCommand command = new SqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@firstname", author_name[0]);
                    //command.Parameters.AddWithValue("@secondname", author_name[1]);
                    //command.Parameters.AddWithValue("@thirdname", author_name[2]);

                    //var author_id = command.ExecuteScalar();
                    //MessageBox.Show(Convert.ToString(author_id));

                    string query = $"SELECT publishhouse_id FROM PublishHouses WHERE ������������ = @publish";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@publish", comboBox3.Text);
                    string p_id = command.ExecuteScalar().ToString();


                    query = $"SELECT genre_id FROM Genres WHERE ���� = @author";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@author", comboBox1.Text);
                    string g_id = command.ExecuteScalar().ToString();

                    query = "UPDATE NewBooks SET �������� = @title,ISBN = @ISBN,[���� ����������] = @creation_date,������������ = @publishHouse,���� = @genre WHERE book_id = @selectedRowId";



                    command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@title", textBox1.Text);
                    command.Parameters.AddWithValue("@ISBN", textBoxISBN.Text);

                    //command.Parameters.AddWithValue("@Author", author_id);
                    command.Parameters.AddWithValue("@creation_date", DateTime.Parse(dateTimePicker1.Text));
                    command.Parameters.AddWithValue("@publishHouse", p_id);
                    command.Parameters.AddWithValue("@genre", g_id);
                    command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                    command.ExecuteNonQuery();

                    query = "DELETE FROM Authors_Books WHERE id_book = @selectedRowId";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                    var books_authors = command.ExecuteNonQuery();
                    //bool isNumber = int.TryParse(Text, out number);

                    if (dataGridView2.Rows.Count == 0)
                    {
                        MessageBox.Show("�������� �������!");
                        return;
                    }
                    if (textBoxISBN.Text.Length == 0 || !int.TryParse(textBoxISBN.Text, out _))
                    {
                        MessageBox.Show("ISBN ������ ���� ������!");
                    }

                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        query = "INSERT INTO Authors_Books(id_book,id_author) VALUES (@id_book,@id_author)";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id_book", selectedRowId);
                        command.Parameters.AddWithValue("@id_author", selectedAuthors[i]);
                        command.ExecuteNonQuery();
                    }
                    selectedAuthors.Clear();
                    dataGridView2.Rows.Clear();


                }

                isEditMode = false;

                HideTextBoxes();
                ChangeVisibleAddingButtons();
                showrecords();


                //}





            }

            //dataGridView1.CurrentCell.Selected = false;
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

            //command.CommandText = $"INSERT INTO Positions (���������) VALUES (\"{textBox_position.Text}\")";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                if (selectedRowId == null)
                {
                    MessageBox.Show("������ � ������� �� �������!");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("�� ����� ������ ������� ��������� ������?", "��������", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var query = $"DELETE from NewBooks WHERE book_id = {Int32.Parse(selectedRowId)}";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        showrecords();
                        //dataGridView1.CurrentCell.Selected = false;
                    }
                    catch
                    {
                        MessageBox.Show("������!\n������ ������ ��� ������������!");
                    }
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
                    MessageBox.Show("������ � ������� �� �������!");
                    return;
                }

                List<string> AuthorsList = new List<string>();
                List<string> GenresList = new List<string>();
                List<string> PublishHousesList = new List<string>();

                var query = $"SELECT * FROM NewBooks where book_id ='{Int32.Parse(selectedRowId)}'";
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    //MessageBox.Show(Convert.ToString(result["�����"]));
                    textBox1.Text = (string)result["��������"];
                    dateTimePicker1.Text = Convert.ToString(result["���� ����������"]);
                    textBoxISBN.Text = Convert.ToString(result["ISBN"]);


                }
                result.Close();
                //var author_name = comboBox2.Text.Split(" ");
                query = $"SELECT * FROM Authors";
                command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@author", result["�����"]);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AuthorsList.Add($"{(string)reader["���"]} {(string)reader["�������"]} {(string)reader["��������"]}");
                }
                reader.Close();
                //comboBox2.DataSource = AuthorsList;
                //comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;


                //var author_id = command.ExecuteScalar();
                //MessageBox.Show(Convert.ToString(author_id));

                query = $"SELECT * FROM PublishHouses";
                command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@publish", result["������������"]);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PublishHousesList.Add((string)reader["������������"]);
                }
                reader.Close();
                comboBox3.DataSource = PublishHousesList;
                comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;

                query = $"SELECT * FROM Genres";
                command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@author", comboBox1.Text);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GenresList.Add($"{(string)reader["����"]}");
                }
                comboBox1.DataSource = GenresList;
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;


            }


            //connection.Open();

            //using (SQLiteCommand comm = connection.CreateCommand())
            //{

            //}

            HideTextBoxes();
            ChangeVisibleAddingButtons();

            isEditMode = true;

            //textBox_position.Text = result.ToString();

            //connection.Close();

        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form positions_form = new Positions();
            positions_form.Show();
        }

        private void selectPublishHouse_Click(object sender, EventArgs e)
        {
            Form PublishForm = new PublishHouse("selection");
            PublishForm.Owner = this;
            PublishForm.Show();
        }
        private void selectAuthor_Click(object sender, EventArgs e)
        {
            Form Author_form = new Authors("selection");
            Author_form.Owner = this;
            Author_form.Show();
        }
        private void selectGenre_Click(object sender, EventArgs e)
        {
            Form genre_form = new Genres("selection");
            genre_form.Owner = this;
            genre_form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            HideTextBoxes();
            ChangeVisibleAddingButtons();

        }

        private void buttonRemoveAuthor_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(Convert.ToInt32(selectedRowIdAuthor));
            selectedAuthors.RemoveAt(Convert.ToInt32(selectedRowIdAuthor));
            MessageBox.Show(selectedAuthors.ToString());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dataGridView2.Rows[index].Selected = true;

            DataGridViewSelectedRowCollection rows = dataGridView2.SelectedRows;
            int selectedRow = Int32.Parse(rows[0].Index.ToString());
            //MessageBox.Show(selectedRow.ToString());
            selectedRowId = Convert.ToString(dataGridView2.Rows[selectedRow].Cells[0].Value.ToString());
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (mode == "selectionBook")
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
                    var query = $"SELECT * from NewBooks WHERE book_id=@book_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@book_id", selectedRowId);
                    var result = command.ExecuteReader();
                    GivenBooks givenBooks = this.Owner as GivenBooks;
                    var s = givenBooks;

                    Book thisbook = new Book();
                    while (result.Read())
                    {

                        thisbook.isbn = (string)result["ISBN"];
                        thisbook.title = (string)result["��������"];

                    }
                    //s.selectedBook = thisbook;
                    s.comboBox1.SelectedItem = (string)thisbook.title;

                    string tempStaff = givenBooks.comboBox2.Text;
                    string tempReader = givenBooks.comboBox3.Text;
                    string tempBook = givenBooks.comboBox1.Text;

                    givenBooks.loadPositions();

                    givenBooks.comboBox2.Text = tempStaff;
                    givenBooks.comboBox3.Text = tempReader;
                    givenBooks.comboBox1.Text = tempBook;
                    //s.comboBox1 = result["book_id"].ToString();
                    this.Close();

                }
            }
            else if (mode == "selectionISBN")
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                int index = e.RowIndex;
                dataGridView1.Rows[index].Selected = true;

                DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
                int selectedRow = Int32.Parse(rows[0].Index.ToString());

                selectedRowId = Convert.ToString(dataGridView1.Rows[selectedRow].Cells[0].Value.ToString());


                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {

                    connection.Open();
                    var query = $"SELECT * from NewBooks WHERE book_id=@book_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@book_id", selectedRowId);
                    var result = command.ExecuteReader();
                    GivenBooks givenBooks = this.Owner as GivenBooks;
                    var s = givenBooks;

                    Book thisbook = new Book();
                    while (result.Read())
                    {

                        thisbook.isbn = (string)result["ISBN"];
                        thisbook.title = (string)result["��������"];

                    }

                    //s.comboBox4.SelectedItem = (string)thisbook.isbn;

                    string tempStaff = givenBooks.comboBox2.Text;
                    string tempReader = givenBooks.comboBox3.Text;
                    string tempBook = givenBooks.comboBox1.Text;

                    givenBooks.loadPositions();

                    givenBooks.comboBox2.Text = tempStaff;
                    givenBooks.comboBox3.Text = tempReader;
                    givenBooks.comboBox1.Text = tempBook;

                    this.Close();

                }
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                string searchquery = searchTextBox.Text;
                //dataGridView1.ClearSelection();
                //var query = "SELECT b.book_id, b.��������, CONCAT(a.���, ' ', a.�������, ' ', a.��������) AS �����, b.[���� ����������], ph.������������, g.����\r\nFROM Books b\r\nJOIN Authors a ON b.����� = a.author_id\r\nJOIN PublishHouses ph ON b.������������ = ph.publishhouse_id\r\nJOIN Genres g ON b.���� = g.genre_id;\r\n";
                //var query = "SELECT b.book_id, b.��������,b.ISBN, b.[���� ����������], ph.������������, g.����\r\nFROM NewBooks b\r\n\r\nJOIN PublishHouses ph ON b.������������ = ph.publishhouse_id\r\nJOIN Genres g ON b.���� = g.genre_id;\r\n";
                string query = "SELECT NB.book_id AS 'book_id', NB.��������, NB.ISBN, NB.[���� ����������], PH.������������, G.����, STRING_AGG(A.��� + ' ' + A.������� + ' ' + A.��������, ', ') AS '������' FROM NewBooks NB LEFT JOIN Authors_Books AB ON NB.book_id = AB.id_book LEFT JOIN Authors A ON AB.id_author = A.author_id LEFT JOIN publishhouses PH ON NB.������������ = PH.publishhouse_id LEFT JOIN genres G ON NB.���� = G.genre_id LEFT JOIN GivenBooks GB ON NB.book_id = GB.book_id WHERE LOWER(NB.��������) LIKE LOWER('%' + @query + '%') OR LOWER(NB.ISBN) LIKE LOWER('%' + @query + '%') OR LOWER(NB.[���� ����������]) LIKE LOWER('%' + @query + '%') OR LOWER(PH.������������) LIKE LOWER('%' + @query + '%') OR LOWER(G.����) LIKE LOWER('%' + @query + '%') OR LOWER(A.���) LIKE LOWER('%' + @query + '%') OR LOWER(A.�������) LIKE LOWER('%' + @query + '%') OR LOWER(A.��������) LIKE LOWER('%' + @query + '%') GROUP BY NB.��������, NB.ISBN, NB.[���� ����������], PH.������������, G.����, NB.book_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@query", searchquery);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["book_id"].Visible = false;

            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            showrecords();
            searchTextBox.Text = "";
        }
    }
}