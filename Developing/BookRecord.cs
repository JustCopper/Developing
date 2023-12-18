using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Developing
{
    public partial class BookRecord : Form
    {
        private Dictionary<string, string> data;

        public BookRecord(Dictionary<string, string> data)
        {
            this.data = data;

            InitializeComponent();
            FillTextBoxes();
        }

        public void FillTextBoxes()
        {
            try
            {
                if (data != null)
                {

                    textBox1.Text = data["Книга"];
                    textBox2.Text = data["Читатель"];
                    textBox3.Text = data["Сотрудник"];
                    textBox4.Text = DateTime.Parse(data["Дата выдачи"]).ToString("dd.MM.yyyy");
                    textBox5.Text = DateTime.Parse(data["Дата возврата"]).ToString("dd.MM.yyyy");
                    textBox6.Text = data["Фактический возврат"];

                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при загрузке записи!");
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnBookBackbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();

                
                string query = "SELECT book_id FROM NewBooks WHERE ISBN = @isbnbook";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@isbnbook", data["ISBN"]);
                int book_id = (int)command.ExecuteScalar();

                query = "UPDATE GivenBooks SET actual_return_date = @actual_date WHERE book_id = @book_id AND actual_return_date = @status";

                // Create the command with parameters
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@actual_date", DateTime.Now.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@book_id", book_id);
                command.Parameters.AddWithValue("@status", "У читателя");

                command.ExecuteNonQuery();

                GivenBooks gb = this.Owner as GivenBooks;
                gb.showrecords();
                
                this.Close();

            }
        }
    }
}
