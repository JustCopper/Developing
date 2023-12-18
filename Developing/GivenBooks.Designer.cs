namespace Developing
{
    partial class GivenBooks
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
            panel2 = new Panel();
            current_table_label = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            thirdnamelabel = new Label();
            select_book_for_return = new Button();
            secondnamelabel = new Label();
            comboBox4 = new ComboBox();
            namelabel = new Label();
            label_for_return_book = new Label();
            savebutton = new Button();
            SelectStaffButton = new Button();
            selectFromForm = new Button();
            comboBox3 = new ComboBox();
            cancelbutton = new Button();
            selectReaderButton = new Button();
            comboBox2 = new ComboBox();
            resetbutton = new Button();
            searchbutton = new Button();
            dataGridView1 = new DataGridView();
            searchTextBox = new TextBox();
            panel5 = new Panel();
            openButton = new Button();
            return_button = new Button();
            deletebutton = new Button();
            addbutton = new Button();
            editbutton = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { References });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(718, 24);
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
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 45);
            panel2.TabIndex = 0;
            // 
            // current_table_label
            // 
            current_table_label.AutoSize = true;
            current_table_label.Location = new Point(12, 0);
            current_table_label.Name = "current_table_label";
            current_table_label.Size = new Size(95, 15);
            current_table_label.TabIndex = 0;
            current_table_label.Text = "Журнал выдачи";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(718, 459);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(current_table_label);
            panel6.Controls.Add(resetbutton);
            panel6.Controls.Add(searchbutton);
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(searchTextBox);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(573, 459);
            panel6.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(thirdnamelabel);
            groupBox1.Controls.Add(select_book_for_return);
            groupBox1.Controls.Add(secondnamelabel);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(namelabel);
            groupBox1.Controls.Add(label_for_return_book);
            groupBox1.Controls.Add(savebutton);
            groupBox1.Controls.Add(SelectStaffButton);
            groupBox1.Controls.Add(selectFromForm);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(cancelbutton);
            groupBox1.Controls.Add(selectReaderButton);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 377);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Журнал выдачи";
            groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // thirdnamelabel
            // 
            thirdnamelabel.AutoSize = true;
            thirdnamelabel.Location = new Point(16, 134);
            thirdnamelabel.Name = "thirdnamelabel";
            thirdnamelabel.Size = new Size(66, 15);
            thirdnamelabel.TabIndex = 4;
            thirdnamelabel.Text = "Сотрудник";
            // 
            // select_book_for_return
            // 
            select_book_for_return.Location = new Point(469, 202);
            select_book_for_return.Name = "select_book_for_return";
            select_book_for_return.Size = new Size(29, 24);
            select_book_for_return.TabIndex = 18;
            select_book_for_return.Text = "...";
            select_book_for_return.UseVisualStyleBackColor = true;
            select_book_for_return.Visible = false;
            select_book_for_return.Click += select_book_for_return_Click;
            // 
            // secondnamelabel
            // 
            secondnamelabel.AutoSize = true;
            secondnamelabel.Location = new Point(16, 79);
            secondnamelabel.Name = "secondnamelabel";
            secondnamelabel.Size = new Size(57, 15);
            secondnamelabel.TabIndex = 5;
            secondnamelabel.Text = "Читатель";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(292, 232);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(206, 23);
            comboBox4.TabIndex = 17;
            comboBox4.Visible = false;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(16, 24);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(39, 15);
            namelabel.TabIndex = 6;
            namelabel.Text = "Книга";
            // 
            // label_for_return_book
            // 
            label_for_return_book.AutoSize = true;
            label_for_return_book.Location = new Point(292, 207);
            label_for_return_book.Name = "label_for_return_book";
            label_for_return_book.Size = new Size(112, 15);
            label_for_return_book.TabIndex = 16;
            label_for_return_book.Text = "Книга для возврата";
            label_for_return_book.Visible = false;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(337, 181);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(67, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "ОК";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // SelectStaffButton
            // 
            SelectStaffButton.Location = new Point(211, 152);
            SelectStaffButton.Name = "SelectStaffButton";
            SelectStaffButton.Size = new Size(29, 24);
            SelectStaffButton.TabIndex = 15;
            SelectStaffButton.Text = "...";
            SelectStaffButton.UseVisualStyleBackColor = true;
            SelectStaffButton.Click += SelectStaffButton_Click;
            // 
            // selectFromForm
            // 
            selectFromForm.Location = new Point(211, 42);
            selectFromForm.Name = "selectFromForm";
            selectFromForm.Size = new Size(29, 24);
            selectFromForm.TabIndex = 10;
            selectFromForm.Text = "...";
            selectFromForm.UseVisualStyleBackColor = true;
            selectFromForm.Click += selectFromForm_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(13, 99);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(198, 23);
            comboBox3.TabIndex = 14;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(410, 181);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(92, 23);
            cancelbutton.TabIndex = 11;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // selectReaderButton
            // 
            selectReaderButton.Location = new Point(211, 97);
            selectReaderButton.Name = "selectReaderButton";
            selectReaderButton.Size = new Size(29, 24);
            selectReaderButton.TabIndex = 13;
            selectReaderButton.Text = "...";
            selectReaderButton.UseVisualStyleBackColor = true;
            selectReaderButton.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(13, 154);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(198, 23);
            comboBox2.TabIndex = 12;
            // 
            // resetbutton
            // 
            resetbutton.Location = new Point(443, 17);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(75, 23);
            resetbutton.TabIndex = 30;
            resetbutton.Text = "Сброс";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(362, 17);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 23);
            searchbutton.TabIndex = 29;
            searchbutton.Text = "Поиск";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(547, 374);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 18);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(344, 23);
            searchTextBox.TabIndex = 28;
            // 
            // panel5
            // 
            panel5.Controls.Add(openButton);
            panel5.Controls.Add(return_button);
            panel5.Controls.Add(deletebutton);
            panel5.Controls.Add(addbutton);
            panel5.Controls.Add(editbutton);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(573, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(145, 459);
            panel5.TabIndex = 11;
            // 
            // openButton
            // 
            openButton.Location = new Point(7, 147);
            openButton.Name = "openButton";
            openButton.Size = new Size(129, 23);
            openButton.TabIndex = 4;
            openButton.Text = "Открыть запись";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // return_button
            // 
            return_button.Location = new Point(7, 241);
            return_button.Name = "return_button";
            return_button.Size = new Size(129, 23);
            return_button.TabIndex = 3;
            return_button.Text = "Возврат книги";
            return_button.UseVisualStyleBackColor = true;
            return_button.Visible = false;
            return_button.Click += return_button_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(7, 118);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(129, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Удалить";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(7, 58);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(7, 87);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(129, 23);
            editbutton.TabIndex = 1;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 480);
            panel1.TabIndex = 1;
            // 
            // GivenBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 480);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "GivenBooks";
            Text = "Журнал выдачи";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem References;
        private ToolStripMenuItem PublishingHouseToolStripMenuItem;
        private ToolStripMenuItem PositionsToolStripMenuItem;
        private ToolStripMenuItem StuffToolStripMenuItem;
        private Panel panel2;
        private Label current_table_label;
        private Panel panel3;
        private Panel panel6;
        private Button select_book_for_return;
        internal ComboBox comboBox4;
        private Label label_for_return_book;
        private Button SelectStaffButton;
        internal ComboBox comboBox3;
        private Button selectReaderButton;
        internal ComboBox comboBox2;
        private Button cancelbutton;
        private Button selectFromForm;
        private Button savebutton;
        private Label namelabel;
        private Label secondnamelabel;
        private Label thirdnamelabel;
        internal ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Button return_button;
        private Button deletebutton;
        private Button addbutton;
        private Button editbutton;
        private Panel panel1;
        private Button resetbutton;
        private Button searchbutton;
        private TextBox searchTextBox;
        private Button openButton;
        private GroupBox groupBox1;
    }
}