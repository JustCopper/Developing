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
    public partial class PHReport : Form
    {
        public PHReport()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT p.Издательство, COUNT(*) as [Книг выдано]\r\n FROM GivenBooks gb\r\n JOIN NewBooks nb ON gb.book_id = nb.book_id\r\n JOIN publishhouses p ON nb.Издательство = p.publishhouse_id \r\n WHERE gb.given_date BETWEEN CONVERT(date, @start_date, 104) AND CONVERT(date, @end_date, 104) \r \n GROUP BY p.Издательство\r \n ORDER BY [Книг выдано] DESC;\r\n";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@start_date", DateTime.Parse(dateTimePicker1.Text));
                command.Parameters.AddWithValue("@end_date", DateTime.Parse(dateTimePicker2.Text));
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

            using (StreamWriter sw = new StreamWriter("Актуальные издательства.csv", false, Encoding.UTF8))
            {
                sw.Write(sb.ToString());
            }

        }

        private void ApplyParameters_Click(object sender, EventArgs e)
        {
            LoadForm();
            
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }
    }
}
