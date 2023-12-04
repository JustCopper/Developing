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
            label2 = new Label();
            textBoxISBN = new TextBox();
            buttonRemoveAuthor = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            selectPublishhouseButton = new Button();
            selectAuthorButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox3 = new ComboBox();
            cancelbutton = new Button();
            selectGenreButton = new Button();
            savebutton = new Button();
            namelabel = new Label();
            secondnamelabel = new Label();
            label_position = new Label();
            thirdnamelabel = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { References });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(819, 24);
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
            editbutton.Location = new Point(678, 58);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(129, 23);
            editbutton.TabIndex = 1;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(678, 29);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(678, 87);
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
            panel1.Size = new Size(819, 494);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(textBoxISBN);
            panel6.Controls.Add(buttonRemoveAuthor);
            panel6.Controls.Add(dataGridView2);
            panel6.Controls.Add(deletebutton);
            panel6.Controls.Add(selectPublishhouseButton);
            panel6.Controls.Add(addbutton);
            panel6.Controls.Add(selectAuthorButton);
            panel6.Controls.Add(editbutton);
            panel6.Controls.Add(dateTimePicker1);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(comboBox3);
            panel6.Controls.Add(cancelbutton);
            panel6.Controls.Add(selectGenreButton);
            panel6.Controls.Add(savebutton);
            panel6.Controls.Add(namelabel);
            panel6.Controls.Add(secondnamelabel);
            panel6.Controls.Add(label_position);
            panel6.Controls.Add(thirdnamelabel);
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(819, 494);
            panel6.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 188);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 20;
            label2.Text = "ISBN";
            label2.Visible = false;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(55, 206);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(121, 23);
            textBoxISBN.TabIndex = 21;
            textBoxISBN.Visible = false;
            // 
            // buttonRemoveAuthor
            // 
            buttonRemoveAuthor.Location = new Point(611, 93);
            buttonRemoveAuthor.Name = "buttonRemoveAuthor";
            buttonRemoveAuthor.Size = new Size(37, 24);
            buttonRemoveAuthor.TabIndex = 19;
            buttonRemoveAuthor.Text = "-";
            buttonRemoveAuthor.UseVisualStyleBackColor = true;
            buttonRemoveAuthor.Visible = false;
            buttonRemoveAuthor.Click += buttonRemoveAuthor_Click;
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
            dataGridView2.Location = new Point(378, 63);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(227, 140);
            dataGridView2.TabIndex = 18;
            dataGridView2.Visible = false;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Выбранные";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // selectPublishhouseButton
            // 
            selectPublishhouseButton.Location = new Point(204, 108);
            selectPublishhouseButton.Name = "selectPublishhouseButton";
            selectPublishhouseButton.Size = new Size(27, 24);
            selectPublishhouseButton.TabIndex = 17;
            selectPublishhouseButton.Text = "...";
            selectPublishhouseButton.UseVisualStyleBackColor = true;
            selectPublishhouseButton.Visible = false;
            selectPublishhouseButton.Click += selectPublishHouse_Click;
            // 
            // selectAuthorButton
            // 
            selectAuthorButton.Location = new Point(611, 63);
            selectAuthorButton.Name = "selectAuthorButton";
            selectAuthorButton.Size = new Size(37, 24);
            selectAuthorButton.TabIndex = 16;
            selectAuthorButton.Text = "+";
            selectAuthorButton.UseVisualStyleBackColor = true;
            selectAuthorButton.Visible = false;
            selectAuthorButton.Click += selectAuthor_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(250, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 44);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 14;
            label1.Text = "Дата публикации";
            label1.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(55, 110);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(148, 23);
            comboBox3.TabIndex = 13;
            comboBox3.Visible = false;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(569, 358);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(79, 23);
            cancelbutton.TabIndex = 11;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Visible = false;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // selectGenreButton
            // 
            selectGenreButton.Location = new Point(204, 154);
            selectGenreButton.Name = "selectGenreButton";
            selectGenreButton.Size = new Size(27, 24);
            selectGenreButton.TabIndex = 10;
            selectGenreButton.Text = "...";
            selectGenreButton.UseVisualStyleBackColor = true;
            selectGenreButton.Visible = false;
            selectGenreButton.Click += selectGenre_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(498, 358);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(65, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "ОК";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Visible = false;
            savebutton.Click += savebutton_Click;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(55, 45);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(94, 15);
            namelabel.TabIndex = 6;
            namelabel.Text = "Название книги";
            namelabel.Visible = false;
            // 
            // secondnamelabel
            // 
            secondnamelabel.AutoSize = true;
            secondnamelabel.Location = new Point(378, 45);
            secondnamelabel.Name = "secondnamelabel";
            secondnamelabel.Size = new Size(40, 15);
            secondnamelabel.TabIndex = 5;
            secondnamelabel.Text = "Автор";
            secondnamelabel.Visible = false;
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Location = new Point(55, 138);
            label_position.Name = "label_position";
            label_position.Size = new Size(38, 15);
            label_position.TabIndex = 1;
            label_position.Text = "Жанр";
            label_position.Visible = false;
            // 
            // thirdnamelabel
            // 
            thirdnamelabel.AutoSize = true;
            thirdnamelabel.Location = new Point(55, 92);
            thirdnamelabel.Name = "thirdnamelabel";
            thirdnamelabel.Size = new Size(81, 15);
            thirdnamelabel.TabIndex = 4;
            thirdnamelabel.Text = "Издательство";
            thirdnamelabel.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(55, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(642, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 518);
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
    }
}