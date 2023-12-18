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
    public partial class NotReturned : Form
    {
        public NotReturned()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT \r\n GB.p_id,CONCAT(S.Имя, ' ', S.Фамилия, ' ', S.Отчество) AS Читатель, \r\n NB.Название as 'Книга', \r\n CONVERT(VARCHAR, GB.given_date, 104) as [Дата выдачи], \r\n CONVERT(VARCHAR, GB.return_date, 104) as [Дата возврата], \r\n DATEDIFF(day, GB.return_date, GETDATE()) AS [Просрочено дней]\r\nFROM \r\n GivenBooks GB\r\nJOIN \r\n NewBooks NB ON GB.book_id = NB.book_id\r\nJOIN \r\n Staff S ON GB.staff_id = S.staff_id\r\nWHERE \r\n ISDATE(GB.actual_return_date) = 0 AND \r\n GB.return_date < GETDATE() AND \r\n GB.return_date BETWEEN @fdate AND @sdate\r\nORDER BY [Просрочено дней] DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@fdate", SqlDbType.Date).Value = dateTimePicker1.Text;
                command.Parameters.Add("@sdate", SqlDbType.Date).Value = dateTimePicker2.Text;
                //var result = command.ExecuteReader();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Привяжите результаты к DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                dataGridView1.Columns["p_id"].Visible = false;

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
        private void ExportWord(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Application.Documents.Add(Type.Missing);

                var titles = word.Application.ActiveDocument.Paragraphs.Add();
                var titlesRanges = titles.Range;
                //Microsoft.Office.Interop.Word.Range range = word.Application.ActiveDocument.Range(titlesRanges, titlesRanges);
                titlesRanges.Text = "Название отчета: Читатели которые не вернули книги вовремя";
                titlesRanges.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                titlesRanges.InsertParagraphAfter();

                var titles3 = word.Application.ActiveDocument.Paragraphs.Add();
                var dateTitle3 = titles3.Range;
                dateTitle3.Text = $"Выбранный диапазон дат: {dateTimePicker1.Text} - {dateTimePicker2.Text}";
                dateTitle3.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                dateTitle3.InsertParagraphAfter();

                //range = word.Application.ActiveDocument.Range(0, 0);
                var titles2 = word.Application.ActiveDocument.Paragraphs.Add();
                var dateTitle = titles2.Range;
                dateTitle.Text = "Дата формирования отчета: " + DateTime.Now.ToString("dd.MM.yyyy");
                dateTitle.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                dateTitle.InsertParagraphAfter();

                var myTable = word.Application.ActiveDocument.Paragraphs.Add();
                var myTableRange = myTable.Range;

                //var test = word.Application.ActiveDocument.Range(1, 1);
                Microsoft.Office.Interop.Word.Table table = word.Application.ActiveDocument.Tables.Add(myTableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count, Type.Missing, Type.Missing);
                table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    table.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
                    table.Cell(1, i + 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                        table.Cell(i + 2, j + 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                    }
                }

                var afterTable = word.Application.ActiveDocument.Paragraphs.Add();

                var AfterTableRange = afterTable.Range;
                //range = word.Application.ActiveDocument.Range(table.Range.End, table.Range.End);
                AfterTableRange.Text = "Директор Иванов И. И.                                                                                                     ";

                // Добавление текста "Подпись: ________" в следующую строку
                AfterTableRange.Text += "Подпись: __________";
                AfterTableRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                AfterTableRange.ParagraphFormat.SpaceBefore = 20; // Замените 10 на желаемую величину отступа


                AfterTableRange.InsertParagraphAfter();

                word.Visible = true;


            }
            else
            {
                MessageBox.Show("Нечего экспортировать!");
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\source\\repos\\Developing\\Developing\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT \r\n CONCAT(S.Имя, ' ', S.Фамилия, ' ', S.Отчество) AS Читатель, \r\n NB.Название as 'Книга', \r\n CONVERT(VARCHAR, GB.given_date, 104) as [Дата выдачи], \r\n CONVERT(VARCHAR, GB.return_date, 104) as [Дата возврата], \r\n DATEDIFF(day, GB.return_date, GETDATE()) AS [Просрочено дней]\r\nFROM \r\n GivenBooks GB\r\nJOIN \r\n NewBooks NB ON GB.book_id = NB.book_id\r\nJOIN \r\n Staff S ON GB.staff_id = S.staff_id\r\nWHERE \r\n ISDATE(GB.actual_return_date) = 0 AND \r\n GB.return_date < GETDATE()\r\nORDER BY [Просрочено дней] DESC";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add("@fdate", SqlDbType.Date).Value = dateTimePicker1.Text;
                command.Parameters.Add("@sdate", SqlDbType.Date).Value = dateTimePicker2.Text;
                //var result = command.ExecuteReader();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    ExportWord(dataTable);

                }
            }
        }
    }
}
