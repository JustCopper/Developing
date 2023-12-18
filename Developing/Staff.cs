using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{
    public partial class Staff : Form
    {

        string mode = "";
        string selectedRowId = null;
        bool isEditMode = false;

        public Staff(string mode)
        {
            InitializeComponent();
            this.mode = mode;
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
                string query = $"SELECT ��������� from Positions";
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                List<string> PositionList = new List<string>();


                while (result.Read())
                {
                    PositionList.Add((string)result["���������"]);
                }
                comboBox1.DataSource = PositionList;
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

                comboBox1.DropDownWidth = 50;
            }

        }

        private void showrecords()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {


                connection.Open();
                var query = $"SELECT Staff.staff_id,Staff.���, Staff.�������, Staff.��������, Positions.��������� FROM Staff INNER JOIN Positions ON Staff.��������� = Positions.id;";


                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["staff_id"].Visible = false;
            }

        }





        private void CreateDataBase()
        {

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "CREATE TABLE Staff (staff_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, ��� nvarchar(MAX), ������� nvarchar(MAX),�������� nvarchar(MAX), ��������� int FOREIGN KEY REFERENCES Positions(id));";
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
        private void HideTextBoxes()
        {

            //textBox1.Visible = !textBox1.Visible;
            //textBox2.Visible = !textBox2.Visible;
            //textBox3.Visible = !textBox3.Visible;
            //comboBox1.Visible = !comboBox1.Visible;
            //label_position.Visible = !label_position.Visible;
            //namelabel.Visible = !namelabel.Visible;
            //secondnamelabel.Visible = !secondnamelabel.Visible;
            //thirdnamelabel.Visible = !thirdnamelabel.Visible;

            searchTextBox.Visible = !searchTextBox.Visible;
            searchbutton.Visible = !searchbutton.Visible;
            resetbutton.Visible = !resetbutton.Visible;

            //addbutton.Visible = !addbutton.Visible;
            //editbutton.Visible = !editbutton.Visible;
            //deletebutton.Visible = !deletebutton.Visible;
            groupBox1.Visible = !groupBox1.Visible;


        }
        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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

                    string query = "SELECT * from Positions WHERE ��������� = @SelectedPosition";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedPosition", comboBox1.Text);

                    // Execute the command and get the result
                    var result = command.ExecuteScalar();
                    if (result.ToString() == null)
                    {

                        MessageBox.Show("������ �� ������� ����� (���������)\n������������� ����� ����������");
                        MessageBox.Show(result.ToString());
                        return;
                    }
                    //comm.CommandText = $"SELECT staff.���, staff.�������, staff.�������� FROM staff INNER JOIN Positions ON staff.staff_id=Positions.id;";
                    string firstName = textBox1.Text;
                    string lastName = textBox2.Text;
                    string middleName = textBox3.Text;
                    string position = result.ToString();

                    // Create the query with typed variables
                    query = "INSERT INTO staff (���, �������, ��������, ���������) VALUES (@FirstName, @LastName, @MiddleName, @Position)";

                    // Create the command with parameters
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@Position", position);
                    command.ExecuteNonQuery();


                }

                ClearTextBoxes();
                HideTextBoxes();
                ChangeVisibleAddingButtons();

                showrecords();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    string selectedPosition = comboBox1.Text;

                    // Create the query with typed variables
                    string query = "SELECT * from Positions WHERE ��������� = @SelectedPosition";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedPosition", selectedPosition);

                    // Execute the command and get the result
                    var result = command.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("������ �� ������� ����� (���������)\n������������� ����� ����������");
                        return;
                    }
                    string firstName = textBox1.Text;
                    string lastName = textBox2.Text;
                    string middleName = textBox3.Text;
                    string position = result.ToString();


                    // Create the query with typed variables
                    query = "UPDATE staff SET ��� = @FirstName, ������� = @LastName, �������� = @MiddleName, ��������� = @Position WHERE staff_id = @SelectedRowId";

                    // Create the command with parameters
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                    // Execute the command
                    command.ExecuteNonQuery();


                    isEditMode = false;
                    ClearTextBoxes();
                    HideTextBoxes();
                    ChangeVisibleAddingButtons();

                    showrecords();

                }





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
                        string query = $"DELETE from staff WHERE staff_id = {Int32.Parse(selectedRowId)}";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        //dataGridView1.CurrentCell.Selected = false;
                    }
                    catch
                    {
                        MessageBox.Show("������!\n������ ������ ��� ������������!");

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
                    MessageBox.Show("������ � ������� �� �������!");
                    return;
                }
                string query = $"SELECT * FROM staff where staff_id ='{Int32.Parse(selectedRowId)}'";
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    textBox1.Text = (string)result["���"];
                    textBox2.Text = (string)result["�������"];
                    textBox3.Text = (string)result["��������"];
                    //comboBox1.Text = (string)result["���������"];
                }


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

        private void selectFromForm_Click(object sender, EventArgs e)
        {
            Form positions_form = new Positions("selection");
            positions_form.Owner = this;
            positions_form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            HideTextBoxes();
            ChangeVisibleAddingButtons();

            ClearTextBoxes();
            if (isEditMode) { isEditMode = !isEditMode; }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    var query = $"SELECT ���,�������,��������,��������� from Staff WHERE staff_id={Convert.ToInt32(selectedRowId)}";
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
                        givenBooks.comboBox2.Text = $"{result["���"]} {result["�������"]} {result["��������"]}";
                    }
                    //Books books = this.Owner as Books;
                    //var s = books.selectedAuthors;
                    //while (result.Read())
                    //{
                    //    books.dataGridView2.Rows.Add(($"{(string)result["���"]} {(string)result["�������"]} {(string)result["��������"]}"));
                    //    s.Add(Convert.ToInt32(selectedRowId));
                    //}


                    this.Close();

                }
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT Staff.staff_id,Staff.���,Staff.�������,Staff.��������, Positions.���������\r\nFROM Staff\r\nJOIN Positions ON Staff.��������� = Positions.id\r\nWHERE CONCAT(���, ' ', �������, ' ', ��������) LIKE '%' + @query + '%'\r\nOR Positions.��������� LIKE '%' + @query + '%'\r\n";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@query", searchTextBox.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["staff_id"].Visible = false;


            }

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            showrecords();
            searchTextBox.Text = "";
        }
    }
}