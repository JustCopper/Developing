using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Developing
{
    public partial class PublishHouse : Form
    {


        string selectedRowId = null;
        bool isEditMode = false;
        string mode = "";

        public PublishHouse(string mode = "")
        {
            InitializeComponent();

            //loadddb();
            this.mode = mode;
            //insertrecord();
            if (mode != "") DisableSecondaryOptions();
            showrecordss();

            //dataGridView1.Rows[0].Cells[0].Selected = true;
        }

        private void DisableSecondaryOptions()
        {
            menuStrip1.Enabled = false;
        }


        private void showrecordss()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM PublishHouses";
                SqlCommand command = new SqlCommand(query, connection);
                //SqlDataReader reader = command.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["publishhouse_id"].Visible = false;
            }
            //SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True");
            //connection.Open();

        }
        //private void showrecords()
        //{
        //    using (SQLiteConnection connection = new SQLiteConnection(new SQLiteConnection("Data Source=firstBase.sqlite; FailIfMissing=False;foreign keys=true")))
        //    {

        //        using (SQLiteCommand comm = connection.CreateCommand())
        //        {

        //            connection.Open();
        //            dataGridView1.ClearSelection();
        //            comm.CommandText = "SELECT * FROM PublishHouses";

        //            DataTable data = new DataTable();
        //            SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
        //            adapter.Fill(data);
        //            dataGridView1.DataSource = data;
        //            dataGridView1.Columns["publishhouse_id"].Visible = false;
        //            connection.Close();
        //            return;
        //        }
        //    }

        //    //dataGridView1.ClearSelection();
        //    //dataGridView1.CurrentCell = null;
        //    //dataGridView1.Rows[0].Cells[0].Selected = true;
        //}

        private void loadddb()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "CREATE TABLE PublishHouses (publishhouse_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, Издательство nvarchar(MAX), Адрес nvarchar(MAX));";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
        //private void loaddb()
        //{

        //    using (SQLiteConnection connection = new SQLiteConnection(new SQLiteConnection("Data Source=firstBase.sqlite; FailIfMissing=False;foreign keys=true")))
        //    {
        //        using (SQLiteCommand comm = connection.CreateCommand())
        //        {
        //            connection.Open();
        //            //comm.CommandText = "DROP TABLE PublishHouses";
        //            //comm.ExecuteNonQuery();
        //            comm.CommandText = "CREATE TABLE IF NOT EXISTS [PublishHouses]([publishhouse_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, [Издательство] TEXT, [Адрес] TEXT);";
        //            comm.ExecuteNonQuery();
        //            connection.Close();
        //            return;
        //        }
        //    }



        //}

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
            label_name.Visible = true;
            label1.Visible = true;
            PublishHouse_address.Visible = true;

            PublishHouse_Name.Visible = true;
            dataGridView1.Visible = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
            ChangeVisibleAddingButtons();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            //using (SQLiteConnection connection = new SQLiteConnection(new SQLiteConnection("Data Source=firstBase.sqlite; FailIfMissing=False;foreign keys=true")))
            //{


            //    using (SQLiteCommand comm = connection.CreateCommand())
            //    {
            //        connection.Open();

            //        if (!isEditMode)
            //        {
            //            var transaction = connection.BeginTransaction();
            //            comm.CommandText = $"INSERT INTO PublishHouses ('Издательство','Адрес') VALUES (\"{PublishHouse_Name.Text}\",'{PublishHouse_address.Text}')";
            //            comm.ExecuteNonQuery();

            //            label_name.Visible = false; // Скрытие блоков добавления/Редактирования
            //            label1.Visible = false;
            //            PublishHouse_address.Visible = false;
            //            PublishHouse_Name.Visible = false;
            //            dataGridView1.Visible = true;
            //            savebutton.Visible = false;
            //            cancelbutton.Visible = false;
            //            PublishHouse_Name.Text = ""; //Очистка поля добавления

            //            transaction.Commit();
            //            showrecords();
            //        }
            //        else
            //        {
            //            var transaction = connection.BeginTransaction();

            //            //comm.CommandText = $"INSERT INTO PublishHouses ('Издательство','Адрес') VALUES ('123','456')";
            //            comm.CommandText = $"UPDATE PublishHouses SET Издательство='333',Адрес='555' WHERE publishhouse_id=1";
            //            //comm.CommandText = $"UPDATE PublishHouses SET Издательство = '{PublishHouse_Name.Text}',Адрес = '{PublishHouse_address.Text}' WHERE publishhouse_id = {selectedRowId}";

            //            comm.ExecuteNonQuery();



            //            label_name.Visible = false; // Скрытие блоков добавления/Редактирования
            //            label1.Visible = false;
            //            PublishHouse_address.Visible = false;
            //            PublishHouse_Name.Visible = false;
            //            dataGridView1.Visible = true;
            //            savebutton.Visible = false;
            //            cancelbutton.Visible = false;
            //            PublishHouse_Name.Text = "";
            //            PublishHouse_address.Text = "";

            //            isEditMode = false;
            //            //transaction.Rollback();
            //            transaction.Commit();
            //            showrecords();
            //        }

            //    }
            //}

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {

                if (!isEditMode)
                {
                    connection.Open();
                    string publishHouseName = PublishHouse_Name.Text;
                    string publishHouseAddress = PublishHouse_address.Text;

                    string query = "INSERT INTO PublishHouses (Издательство, Адрес) VALUES (@PublishHouseName, @PublishHouseAddress)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PublishHouseName", publishHouseName);
                    command.Parameters.AddWithValue("@PublishHouseAddress", publishHouseAddress);

                    command.ExecuteNonQuery();

                    label_name.Visible = false; // Скрытие блоков добавления/Редактирования
                    label1.Visible = false;
                    PublishHouse_address.Visible = false;
                    PublishHouse_Name.Visible = false;
                    dataGridView1.Visible = true;
                    savebutton.Visible = false;
                    cancelbutton.Visible = false;
                    PublishHouse_Name.Text = ""; //Очистка поля добавления
                    PublishHouse_address.Text = "";
                    ChangeVisibleAddingButtons();

                    showrecordss();
                }
                else
                {


                    connection.Open();
                    string publishHouseName = PublishHouse_Name.Text;
                    string publishHouseAddress = PublishHouse_address.Text;


                    string query = "UPDATE PublishHouses SET Издательство = @PublishHouseName, Адрес = @PublishHouseAddress WHERE publishhouse_id = @SelectedRowId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PublishHouseName", publishHouseName);
                    command.Parameters.AddWithValue("@PublishHouseAddress", publishHouseAddress);
                    command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                    command.ExecuteNonQuery();
                    isEditMode = false;

                    label_name.Visible = false; // Скрытие блоков добавления/Редактирования
                    label1.Visible = false;
                    PublishHouse_address.Visible = false;
                    PublishHouse_Name.Visible = false;
                    dataGridView1.Visible = true;
                    savebutton.Visible = false;
                    cancelbutton.Visible = false;
                    PublishHouse_Name.Text = "";
                    PublishHouse_address.Text = "";
                    ChangeVisibleAddingButtons();

                    showrecordss();
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

                //command.CommandText = $"INSERT INTO Positions (Должность) VALUES (\"{textBox_position.Text}\")";
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



                        string query = "DELETE from PublishHouses WHERE publishhouse_id = @SelectedRowId";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                        command.ExecuteNonQuery();


                        //comm.CommandText = $"DELETE from PublishHouses WHERE publishhouse_id = {Int32.Parse(selectedRowId)}";
                        //comm.ExecuteNonQuery();

                        //transaction.Commit();
                    }
                    catch (Exception exc)
                    {
                        //comm.CommandText = "PRAGMA foreign_key_check;";
                        //var reader = comm.ExecuteNonQuery();
                        //MessageBox.Show(reader.ToString());
                        //MessageBox.Show($"Table:{reader.GetString(0)}, RowId:{reader.GetInt64(1)},Parent Table:{reader.GetString(2)},Foreign_Key:{reader.GetInt32(3)}");
                        MessageBox.Show(exc.Message);
                        //MessageBox.Show($"Ошибка при удалении издательства из таблицы\nИздательство используется в справочнике Книги");
                        //transaction.Rollback();
                    }
                    showrecordss();

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


                if (selectedRowId == null)
                {
                    MessageBox.Show("Запись в таблице не выбрана!");
                    return;
                }
                label_name.Visible = true;
                label1.Visible = true;
                PublishHouse_address.Visible = true;
                PublishHouse_Name.Visible = true;
                dataGridView1.Visible = false;
                savebutton.Visible = true;
                cancelbutton.Visible = true;
                ChangeVisibleAddingButtons();


                isEditMode = true;

                connection.Open();
                string query = "SELECT Издательство, Адрес FROM PublishHouses WHERE publishhouse_id = @SelectedRowId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                var result = command.ExecuteReader();

                //comm.CommandText = $"SELECT Издательство,Адрес from PublishHouses WHERE publishhouse_id = {Int32.Parse(selectedRowId)}";

                //var result = comm.ExecuteReader();



                if (result.Read())
                {
                    PublishHouse_Name.Text = result.GetString(0);
                    PublishHouse_address.Text = result.GetString(1);

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
                    string query = "SELECT Издательство FROM PublishHouses WHERE publishhouse_id = @SelectedRowId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedRowId", selectedRowId);

                    var result = command.ExecuteScalar()?.ToString();
                    Books books = this.Owner as Books;
                    var s = books.comboBox3;
                    s.SelectedItem = result.ToString();
                    this.Close();

                    //connection.Open();
                    //comm.CommandText = $"SELECT Жанр from Genres WHERE genre_id={Convert.ToInt32(selectedRowId)}";
                    //string result = comm.ExecuteScalar().ToString();
                    //Staff staff = this.Owner as Staff;
                    //var s = staff.comboBox1;
                    //s.SelectedItem = result.ToString();
                    //this.Close();

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
            label_name.Visible = false; // Скрытие блоков добавления/Редактирования
            label1.Visible = false;
            PublishHouse_address.Visible = false;
            PublishHouse_Name.Visible = false;
            dataGridView1.Visible = true;
            savebutton.Visible = false;
            cancelbutton.Visible = false;
            PublishHouse_Name.Text = ""; //Очистка поля добавления
            PublishHouse_address.Text = "";
            ChangeVisibleAddingButtons();

        }
    }
}