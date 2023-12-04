using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{
    public partial class Staff : Form
    {


        string selectedRowId = null;
        bool isEditMode = false;

        public Staff()
        {
            InitializeComponent();
            //CreateDataBase();
            //insertrecord();
            showrecords();
            loadPositions();

        }


        private void loadPositions()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = $"SELECT Должность from Positions";
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                List<string> PositionList = new List<string>();


                while (result.Read())
                {
                    PositionList.Add((string)result["Должность"]);
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
                var query = $"SELECT Staff.staff_id,Staff.Имя, Staff.Фамилия, Staff.Отчество, Positions.Должность FROM Staff INNER JOIN Positions ON Staff.Должность = Positions.id;";


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
                string query = "CREATE TABLE Staff (staff_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, Имя nvarchar(MAX), Фамилия nvarchar(MAX),Отчество nvarchar(MAX), Должность int FOREIGN KEY REFERENCES Positions(id));";
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

            textBox1.Visible = !textBox1.Visible;
            textBox2.Visible = !textBox2.Visible;
            textBox3.Visible = !textBox3.Visible;
            comboBox1.Visible = !comboBox1.Visible;
            label_position.Visible = !label_position.Visible;
            namelabel.Visible = !namelabel.Visible;
            secondnamelabel.Visible = !secondnamelabel.Visible;
            thirdnamelabel.Visible = !thirdnamelabel.Visible;


        }
        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            HideTextBoxes();
            dataGridView1.Visible = false;
            savebutton.Visible = true;
            selectFromForm.Visible = true;
            cancelbutton.Visible = true;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            //if (validatePosition(textBox_position.Text))
            //{
            //    MessageBox.Show("Введены запрещенные знаки!");
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

                    string query = "SELECT * from Positions WHERE Должность = @SelectedPosition";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedPosition", comboBox1.Text);

                    // Execute the command and get the result
                    var result = command.ExecuteScalar();
                    if (result.ToString() == null)
                    {

                        MessageBox.Show("Ошибка во внешнем ключе (ДОЛЖНОСТЬ)\nПерезагрузите форму СОТРУДНИКИ");
                        MessageBox.Show(result.ToString());
                        return;
                    }
                    //comm.CommandText = $"SELECT staff.Имя, staff.Фамилия, staff.Отчество FROM staff INNER JOIN Positions ON staff.staff_id=Positions.id;";
                    string firstName = textBox1.Text;
                    string lastName = textBox2.Text;
                    string middleName = textBox3.Text;
                    string position = result.ToString();

                    // Create the query with typed variables
                    query = "INSERT INTO staff (Имя, Фамилия, Отчество, Должность) VALUES (@FirstName, @LastName, @MiddleName, @Position)";

                    // Create the command with parameters
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@Position", position);
                    command.ExecuteNonQuery();


                }


                label_position.Visible = false; // Скрытие блоков добавления/Редактирования

                dataGridView1.Visible = true;
                savebutton.Visible = false;

                ClearTextBoxes();
                HideTextBoxes();
                dataGridView1.Visible = true;
                savebutton.Visible = false;
                selectFromForm.Visible = false;
                cancelbutton.Visible = false;
                showrecords();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    string selectedPosition = comboBox1.Text;

                    // Create the query with typed variables
                    string query = "SELECT * from Positions WHERE Должность = @SelectedPosition";

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedPosition", selectedPosition);

                    // Execute the command and get the result
                    var result = command.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Ошибка во внешнем ключе (ДОЛЖНОСТЬ)\nПерезагрузите форму СОТРУДНИКИ");
                        return;
                    }
                    string firstName = textBox1.Text;
                    string lastName = textBox2.Text;
                    string middleName = textBox3.Text;
                    string position = result.ToString();


                    // Create the query with typed variables
                    query = "UPDATE staff SET Имя = @FirstName, Фамилия = @LastName, Отчество = @MiddleName, Должность = @Position WHERE staff_id = @SelectedRowId";

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
                    dataGridView1.Visible = true;
                    savebutton.Visible = false;
                    selectFromForm.Visible = false;
                    cancelbutton.Visible = false;
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

                    string query = $"DELETE from staff WHERE staff_id = {Int32.Parse(selectedRowId)}";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    //dataGridView1.CurrentCell.Selected = false;
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
                string query = $"SELECT * FROM staff where staff_id ='{Int32.Parse(selectedRowId)}'";
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    textBox1.Text = (string)result["Имя"];
                    textBox2.Text = (string)result["Фамилия"];
                    textBox3.Text = (string)result["Отчество"];
                    //comboBox1.Text = (string)result["Должность"];
                }


            }


            //connection.Open();

            //using (SQLiteCommand comm = connection.CreateCommand())
            //{

            //}





            HideTextBoxes();
            dataGridView1.Visible = false;
            savebutton.Visible = true;
            selectFromForm.Visible = true;
            cancelbutton.Visible = true;

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
            ClearTextBoxes();
            dataGridView1.Visible = true;
            savebutton.Visible = false;
            selectFromForm.Visible = false;
            cancelbutton.Visible = false;

        }
    }
}