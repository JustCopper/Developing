using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{
    public partial class Positions : Form
    {


        string selectedRowId = null;
        bool isEditMode = false;
        string mode = "";

        public Positions(string mode = "")
        {
            InitializeComponent();

            //CreateDataBase();
            this.mode = mode;
            //insertrecord();
            if (mode != "") DisableSecondaryOptions();
            showrecords();


        }

        private void DisableSecondaryOptions()
        {
            menuStrip1.Enabled = false;
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

                string query = "SELECT * FROM Positions";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

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

        private void CreateDataBase()
        {

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                connection.Open();
                string query = "CREATE TABLE Positions(id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL, ��������� nvarchar(MAX));";
                //string query = "CREATE TABLE PublishHouses (publishhouse_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, ������������ TEXT, ����� TEXT);";
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

        private void addbutton_Click(object sender, EventArgs e)
        {
            label_position.Visible = true;
            textBox_position.Visible = true;
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

                    string position = textBox_position.Text;

                    // Create the query with typed variables
                    string query = "INSERT INTO Positions (���������) VALUES (@Position)";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Position", position);

                    // Execute the command
                    command.ExecuteNonQuery();

                    label_position.Visible = false; // ������� ������ ����������/��������������
                    textBox_position.Visible = false;
                    dataGridView1.Visible = true;
                    savebutton.Visible = false;
                    cancelbutton.Visible = false;
                    textBox_position.Text = ""; //������� ���� ����������
                    ChangeVisibleAddingButtons();
                    showrecords();
                }
                else
                {

                    string query = "UPDATE Positions SET ��������� = @Position WHERE id = @SelectedRowId";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Position", textBox_position.Text);
                    command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);
                    command.ExecuteNonQuery();

                    label_position.Visible = false;
                    textBox_position.Visible = false;
                    dataGridView1.Visible = true;
                    savebutton.Visible = false;
                    cancelbutton.Visible = false;
                    textBox_position.Text = "";

                    isEditMode = false;
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
                        string query = "DELETE from Positions WHERE id = @SelectedRowId";

                        // Create the command with parameters
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                        // Execute the command
                        command.ExecuteNonQuery();

                        showrecords();

                    }
                    catch (Exception exc)
                    {
                        //comm.CommandText = "PRAGMA foreign_key_check;";
                        //var reader = comm.ExecuteNonQuery();
                        //MessageBox.Show(reader.ToString());
                        //MessageBox.Show($"Table:{reader.GetString(0)}, RowId:{reader.GetInt64(1)},Parent Table:{reader.GetString(2)},Foreign_Key:{reader.GetInt32(3)}");

                        MessageBox.Show($"������ ��� �������� ��������� �� �������\n��������� ������������ � ����������� ����������");

                    }


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
                label_position.Visible = true;
                textBox_position.Visible = true;
                dataGridView1.Visible = false;
                savebutton.Visible = true;
                cancelbutton.Visible = true;


                isEditMode = true;
                string query = "SELECT ��������� from Positions WHERE id = @SelectedRowId";

                // Create the command with parameters
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                // Execute the command and get the result
                var result = command.ExecuteScalar();

                // Set the result to the text box
                textBox_position.Text = result.ToString();

                ChangeVisibleAddingButtons();


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

                    string query = "SELECT ��������� from Positions WHERE id = @SelectedRowId";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                    // Execute the command and get the result
                    string result = command.ExecuteScalar().ToString();
                    Staff staff = this.Owner as Staff;
                    var s = staff.comboBox1;
                    s.SelectedItem = result.ToString();
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
            label_position.Visible = false; // ������� ������ ����������/��������������
            textBox_position.Visible = false;
            dataGridView1.Visible = true;
            savebutton.Visible = false;
            cancelbutton.Visible = false;
            textBox_position.Text = ""; //������� ���� ����������
            ChangeVisibleAddingButtons();
        }
    }
}