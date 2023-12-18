using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{
    public partial class Genres : Form
    {


        string selectedRowId = null;
        bool isEditMode = false;
        string mode = "";

        public Genres(string mode = "")
        {
            InitializeComponent();

            //loaddb();
            this.mode = mode;
            //insertrecord();
            if (mode != "") DisableSecondaryOptions();
            showrecords();

            //dataGridView1.Rows[0].Cells[0].Selected = true;
        }

        private void DisableSecondaryOptions()
        {
            menuStrip1.Enabled = false;
        }
        private void HideTextBoxes()
        {
            groupBox1.Visible = !groupBox1.Visible;
            //textBox_genre.Visible = !textBox_genre.Visible;
            //label_genre.Visible = !label_genre.Visible;
            //dataGridView1.Visible = !dataGridView1.Visible;
            //cancelbutton.Visible = !cancelbutton.Visible;
            //savebutton.Visible = !savebutton.Visible;

            //searchTextBox.Visible = !searchTextBox.Visible;
            //searchbutton.Visible = !searchbutton.Visible;
            //resetbutton.Visible = !resetbutton.Visible;

        }

        //private void checkfk()
        //{
        //    var conn = Connect("firstBase.sqlite");
        //    SQLiteCommand comm = connection.CreateCommand();
        //    comm.CommandText = "PRAGMA main.foreign_key_check(staff);";
        //    var r = comm.ExecuteScalar();
        //    MessageBox.Show(r.ToString());

        //}

        private void showrecords()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();

                string query = "SELECT * FROM Genres";
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Columns["genre_id"].Visible = false;

            }

            //dataGridView1.ClearSelection();
            //dataGridView1.CurrentCell = null;
            //dataGridView1.Rows[0].Cells[0].Selected = true;
        }

        //private void insertrecord() // ��� ���������� �������� ������
        //{
        //    command.CommandText = "INSERT INTO Positions (���������) VALUES (\"��������\")";
        //    command.ExecuteNonQuery();
        //}

        //static public bool Connect(string fileName)
        //{
        //    try
        //    {
        //        connection = new SQLiteConnection("Data Source=" + fileName + "; FailIfMissing=False");
        //        connection.Open();
        //        return true;
        //    }
        //    catch (SQLiteException ex)
        //    {
        //        Console.WriteLine($"������ ������� � ���� ������. ����������: {ex.Message}");
        //        return false;
        //    }
        //}

        private void loaddb()
        {
            //if (!File.Exists(@"C:\TestDB.db"))
            //{
            //    SQLiteConnection.CreateFile(@"C:\TestDB.db"); 
            //}

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();
                string query = "CREATE TABLE Genres(genre_id  INT IDENTITY(1,1) PRIMARY KEY NOT NULL, ���� nvarchar(MAX));";
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

                    string genre = textBox_genre.Text;

                    // Create the query with typed variables
                    string query = "INSERT INTO Genres (����) VALUES (@Genre)";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Genre", genre);

                    // Execute the command
                    command.ExecuteNonQuery();

                    HideTextBoxes();

                    textBox_genre.Text = ""; //������� ���� ����������
                    ChangeVisibleAddingButtons();

                    showrecords();
                }
                else
                {

                    string genre = textBox_genre.Text;


                    // Create the query with typed variables
                    string query = "UPDATE Genres SET ���� = @Genre WHERE genre_id = @SelectedRowId";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Genre", genre);
                    command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                    // Execute the command
                    command.ExecuteNonQuery();

                    HideTextBoxes();

                    textBox_genre.Text = "";

                    isEditMode = false;
                    ChangeVisibleAddingButtons();
                    showrecords();
                }

            }



            //dataGridView1.CurrentCell.Selected = false;
        }
        private bool validateGenre(string txt)
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

                //command.CommandText = $"INSERT INTO Positions (���������) VALUES (\"{textBox_position.Text}\")";
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
                        var query = $"DELETE from Genres WHERE genre_id = {Int32.Parse(selectedRowId)}";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();


                    }
                    catch (Exception exc)
                    {
                        //comm.CommandText = "PRAGMA foreign_key_check;";
                        //var reader = comm.ExecuteNonQuery();
                        //MessageBox.Show(reader.ToString());
                        //MessageBox.Show($"Table:{reader.GetString(0)}, RowId:{reader.GetInt64(1)},Parent Table:{reader.GetString(2)},Foreign_Key:{reader.GetInt32(3)}");
                        MessageBox.Show(exc.Message);
                        MessageBox.Show($"������ ��� �������� ����� �� �������\n���� ������������ � ����������� �����");

                    }
                    showrecords();

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
                    MessageBox.Show("������ � ������� �� �������!");
                    return;
                }
                HideTextBoxes();

                ChangeVisibleAddingButtons();

                isEditMode = true;
                var query = $"SELECT ���� from Genres WHERE genre_id = {Int32.Parse(selectedRowId)}";
                SqlCommand command = new SqlCommand(query, connection);

                var result = command.ExecuteScalar();
                textBox_genre.Text = result.ToString();


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
                    var query = $"SELECT ���� from Genres WHERE genre_id={Convert.ToInt32(selectedRowId)}";
                    SqlCommand command = new SqlCommand(query, connection);
                    string result = command.ExecuteScalar().ToString();
                    Books books = this.Owner as Books;
                    var s = books.comboBox1;
                    s.SelectedItem = result.ToString();

                    string tempgenre = result.ToString();
                    string publishhouse = books.comboBox3.Text;

                    books.loadPositions();
                    //var s = books.comboBox3;
                    //s.SelectedItem = result.ToString();
                    books.comboBox3.Text = publishhouse;
                    books.comboBox1.Text = tempgenre;

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
            HideTextBoxes();

            textBox_genre.Text = ""; //������� ���� ����������
            ChangeVisibleAddingButtons();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();

                string query = "SELECT * FROM Genres WHERE LOWER(����) LIKE LOWER('%' + @query + '%')";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@query", searchTextBox.Text);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Columns["genre_id"].Visible = false;

            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            showrecords();
            searchTextBox.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}