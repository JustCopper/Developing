namespace Developing
{
    partial class Books
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            References = new ToolStripMenuItem();
            PublishingHouseToolStripMenuItem = new ToolStripMenuItem();
            PositionsToolStripMenuItem = new ToolStripMenuItem();
            StuffToolStripMenuItem = new ToolStripMenuItem();
            editbutton = new Button();
            addbutton = new Button();
            deletebutton = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            resetbutton = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            thirdnamelabel = new Label();
            label2 = new Label();
            label_position = new Label();
            textBoxISBN = new TextBox();
            secondnamelabel = new Label();
            buttonRemoveAuthor = new Button();
            namelabel = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            savebutton = new Button();
            selectGenreButton = new Button();
            selectPublishhouseButton = new Button();
            cancelbutton = new Button();
            comboBox3 = new ComboBox();
            selectAuthorButton = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            searchbutton = new Button();
            label3 = new Label();
            searchTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { References });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(848, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // References
            // 
            References.DropDownItems.AddRange(new ToolStripItem[] { PublishingHouseToolStripMenuItem, PositionsToolStripMenuItem, StuffToolStripMenuItem });
            References.Name = "References";
            References.Size = new Size(94, 20);
            References.Text = "Справочники";
            References.Click += toolStripMenuItem1_Click;
            // 
            // PublishingHouseToolStripMenuItem
            // 
            PublishingHouseToolStripMenuItem.Enabled = false;
            PublishingHouseToolStripMenuItem.Name = "PublishingHouseToolStripMenuItem";
            PublishingHouseToolStripMenuItem.Size = new Size(147, 22);
            PublishingHouseToolStripMenuItem.Text = "Издательства";
            PublishingHouseToolStripMenuItem.Click += PublishingHouseToolStripMenuItem_Click;
            // 
            // PositionsToolStripMenuItem
            // 
            PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem";
            PositionsToolStripMenuItem.Size = new Size(147, 22);
            PositionsToolStripMenuItem.Text = "Должности";
            PositionsToolStripMenuItem.Click += PositionsToolStripMenuItem_Click;
            // 
            // StuffToolStripMenuItem
            // 
            StuffToolStripMenuItem.Enabled = false;
            StuffToolStripMenuItem.Name = "StuffToolStripMenuItem";
            StuffToolStripMenuItem.Size = new Size(147, 22);
            StuffToolStripMenuItem.Text = "Сотрудники";
            StuffToolStripMenuItem.Click += StuffToolStripMenuItem_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(707, 115);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(129, 23);
            editbutton.TabIndex = 1;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(707, 86);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(707, 144);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(129, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Удалить";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 512);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(resetbutton);
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(searchbutton);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(deletebutton);
            panel6.Controls.Add(searchTextBox);
            panel6.Controls.Add(addbutton);
            panel6.Controls.Add(editbutton);
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(848, 512);
            panel6.TabIndex = 12;
            // 
            // resetbutton
            // 
            resetbutton.Location = new Point(434, 38);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(75, 23);
            resetbutton.TabIndex = 24;
            resetbutton.Text = "Сброс";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(thirdnamelabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label_position);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(secondnamelabel);
            groupBox1.Controls.Add(buttonRemoveAuthor);
            groupBox1.Controls.Add(namelabel);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(savebutton);
            groupBox1.Controls.Add(selectGenreButton);
            groupBox1.Controls.Add(selectPublishhouseButton);
            groupBox1.Controls.Add(cancelbutton);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(selectAuthorButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(19, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 407);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Книги";
            groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 7;
            // 
            // thirdnamelabel
            // 
            thirdnamelabel.AutoSize = true;
            thirdnamelabel.Location = new Point(23, 78);
            thirdnamelabel.Name = "thirdnamelabel";
            thirdnamelabel.Size = new Size(81, 15);
            thirdnamelabel.TabIndex = 4;
            thirdnamelabel.Text = "Издательство";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 174);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 20;
            label2.Text = "ISBN";
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Location = new Point(23, 124);
            label_position.Name = "label_position";
            label_position.Size = new Size(38, 15);
            label_position.TabIndex = 1;
            label_position.Text = "Жанр";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(23, 192);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(148, 23);
            textBoxISBN.TabIndex = 21;
            // 
            // secondnamelabel
            // 
            secondnamelabel.AutoSize = true;
            secondnamelabel.Location = new Point(346, 31);
            secondnamelabel.Name = "secondnamelabel";
            secondnamelabel.Size = new Size(40, 15);
            secondnamelabel.TabIndex = 5;
            secondnamelabel.Text = "Автор";
            // 
            // buttonRemoveAuthor
            // 
            buttonRemoveAuthor.Location = new Point(579, 79);
            buttonRemoveAuthor.Name = "buttonRemoveAuthor";
            buttonRemoveAuthor.Size = new Size(37, 24);
            buttonRemoveAuthor.TabIndex = 19;
            buttonRemoveAuthor.Text = "-";
            buttonRemoveAuthor.UseVisualStyleBackColor = true;
            buttonRemoveAuthor.Click += buttonRemoveAuthor_Click;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(23, 31);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(94, 15);
            namelabel.TabIndex = 6;
            namelabel.Text = "Название книги";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView2.Location = new Point(346, 49);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(227, 140);
            dataGridView2.TabIndex = 18;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Выбранные";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(423, 249);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(65, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "ОК";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // selectGenreButton
            // 
            selectGenreButton.Location = new Point(206, 142);
            selectGenreButton.Name = "selectGenreButton";
            selectGenreButton.Size = new Size(27, 24);
            selectGenreButton.TabIndex = 10;
            selectGenreButton.Text = "...";
            selectGenreButton.UseVisualStyleBackColor = true;
            selectGenreButton.Click += selectGenre_Click;
            // 
            // selectPublishhouseButton
            // 
            selectPublishhouseButton.Location = new Point(206, 94);
            selectPublishhouseButton.Name = "selectPublishhouseButton";
            selectPublishhouseButton.Size = new Size(27, 24);
            selectPublishhouseButton.TabIndex = 17;
            selectPublishhouseButton.Text = "...";
            selectPublishhouseButton.UseVisualStyleBackColor = true;
            selectPublishhouseButton.Click += selectPublishHouse_Click;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(494, 249);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(79, 23);
            cancelbutton.TabIndex = 11;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(23, 96);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(183, 23);
            comboBox3.TabIndex = 13;
            // 
            // selectAuthorButton
            // 
            selectAuthorButton.Location = new Point(579, 49);
            selectAuthorButton.Name = "selectAuthorButton";
            selectAuthorButton.Size = new Size(37, 24);
            selectAuthorButton.TabIndex = 16;
            selectAuthorButton.Text = "+";
            selectAuthorButton.UseVisualStyleBackColor = true;
            selectAuthorButton.Click += selectAuthor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 231);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 14;
            label1.Text = "Дата публикации";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(23, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(353, 38);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 23);
            searchbutton.TabIndex = 23;
            searchbutton.Text = "Поиск";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 10);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 25;
            label3.Text = "Книги";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(19, 38);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(328, 23);
            searchTextBox.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(666, 407);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 536);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Books";
            Text = "Книги";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem References;
        private ToolStripMenuItem PublishingHouseToolStripMenuItem;
        private ToolStripMenuItem PositionsToolStripMenuItem;
        private ToolStripMenuItem StuffToolStripMenuItem;
        private Button deletebutton;
        private Button addbutton;
        private Button editbutton;
        private Panel panel1;
        private Panel panel6;
        private Button selectPublishhouseButton;
        private Button selectAuthorButton;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        internal ComboBox comboBox3;
        private Button cancelbutton;
        private Button selectGenreButton;
        private Button savebutton;
        private Label namelabel;
        private Label secondnamelabel;
        private Label label_position;
        private Label thirdnamelabel;
        private TextBox textBox1;
        internal ComboBox comboBox1;
        private DataGridView dataGridView1;
        public DataGridView dataGridView2;
        private Button buttonRemoveAuthor;
        private Label label2;
        private TextBox textBoxISBN;
        private DataGridViewTextBoxColumn Column1;
        private Button resetbutton;
        private Button searchbutton;
        private TextBox searchTextBox;
        private Label label3;
        private GroupBox groupBox1;
    }
}