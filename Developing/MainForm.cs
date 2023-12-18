namespace Developing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form positions_form = new Positions();
            positions_form.Show();
        }

        private void StuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form staff_Form = new Staff("");
            staff_Form.Show();
        }

        private void GenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form genres_form = new Genres();
            genres_form.Show();
        }

        private void AuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form author_form = new Authors();
            author_form.Show();
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form books_form = new Books();
            books_form.Show();
        }

        private void PublishingHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form publishhouse_form = new PublishHouse();
            publishhouse_form.Show();
        }

        private void ReadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form readers_form = new Readers();
            readers_form.Show();
        }

        private void JournalAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form givebooks_form = new GivenBooks();
            givebooks_form.Show();
        }

        private void выданныеКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form moreBooksGiven = new GivenBooksForYear();
            moreBooksGiven.Show();
        }

        private void популярныеЖанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FBooks = new FavorGenres();
            FBooks.Show();
        }

        private void актуальныеИздательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PHReport = new NotReturned();
            PHReport.Show();
        }
    }
}
