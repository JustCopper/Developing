using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Developing
{
    public partial class FavorGenres : Form
    {
        public FavorGenres()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT g.Жанр, COUNT(*) as [Книг взяли]\r\nFROM GivenBooks gb\r\nJOIN NewBooks b ON gb.book_id = b.book_id\r\nJOIN Genres g ON b.Жанр = g.genre_id\r\nWHERE gb.given_date BETWEEN CONVERT(date, '01.12.2023', 104) AND CONVERT(date, '25.12.2023', 104)\r\nGROUP BY g.Жанр\r\nORDER BY [Книг взяли] DESC;\r\n";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@start_date", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@end_date", dateTimePicker2.Text);
                //var result = command.ExecuteReader();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Привяжите результаты к DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        public void ExportCSV()
        {


            // Создайте новый объект StringBuilder
            var sb = new StringBuilder();

            sb.AppendLine($"\"Дата генерации отчета \",\"{DateTime.Now.ToString("dd-MM-yyyy")}\"");
            sb.AppendLine($"\"Начальная дата\",\"{dateTimePicker1.Text}\"");
            sb.AppendLine($"\"Конечная дата\",\"{dateTimePicker2.Text}\"");

            // Добавьте заголовки столбцов
            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));


            // Добавьте строки данных
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            using (StreamWriter sw = new StreamWriter("Популярные Жанры.csv", false, Encoding.UTF8))
            {
                sw.Write(sb.ToString());
            }

        }

        private void ApplyParameters_Click(object sender, EventArgs e)
        {
            LoadForm();
            
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }
    }
}
