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
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            select_book_for_return = new Button();
            comboBox4 = new ComboBox();
            label_for_return_book = new Label();
            button2 = new Button();
            comboBox3 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            cancelbutton = new Button();
            selectFromForm = new Button();
            savebutton = new Button();
            namelabel = new Label();
            secondnamelabel = new Label();
            thirdnamelabel = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            return_button = new Button();
            deletebutton = new Button();
            addbutton = new Button();
            editbutton = new Button();
            panel2 = new Panel();
            current_table_label = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { References });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(669, 24);
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
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 362);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 401);
            panel4.Name = "panel4";
            panel4.Size = new Size(734, 57);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 276);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(select_book_for_return);
            panel6.Controls.Add(comboBox4);
            panel6.Controls.Add(label_for_return_book);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(comboBox3);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(comboBox2);
            panel6.Controls.Add(cancelbutton);
            panel6.Controls.Add(selectFromForm);
            panel6.Controls.Add(savebutton);
            panel6.Controls.Add(namelabel);
            panel6.Controls.Add(secondnamelabel);
            panel6.Controls.Add(thirdnamelabel);
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(509, 276);
            panel6.TabIndex = 12;
            // 
            // select_book_for_return
            // 
            select_book_for_return.Location = new Point(345, 31);
            select_book_for_return.Name = "select_book_for_return";
            select_book_for_return.Size = new Size(29, 24);
            select_book_for_return.TabIndex = 18;
            select_book_for_return.Text = "...";
            select_book_for_return.UseVisualStyleBackColor = true;
            select_book_for_return.Visible = false;
            select_book_for_return.Click += select_book_for_return_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(192, 32);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(152, 23);
            comboBox4.TabIndex = 17;
            comboBox4.Visible = false;
            // 
            // label_for_return_book
            // 
            label_for_return_book.AutoSize = true;
            label_for_return_book.Location = new Point(192, 14);
            label_for_return_book.Name = "label_for_return_book";
            label_for_return_book.Size = new Size(112, 15);
            label_for_return_book.TabIndex = 16;
            label_for_return_book.Text = "Книга для возврата";
            label_for_return_book.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(157, 147);
            button2.Name = "button2";
            button2.Size = new Size(29, 24);
            button2.TabIndex = 15;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(36, 87);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 14;
            comboBox3.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(157, 85);
            button1.Name = "button1";
            button1.Size = new Size(29, 24);
            button1.TabIndex = 13;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(36, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Visible = false;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(399, 223);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(92, 23);
            cancelbutton.TabIndex = 11;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Visible = false;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // selectFromForm
            // 
            selectFromForm.Location = new Point(157, 32);
            selectFromForm.Name = "selectFromForm";
            selectFromForm.Size = new Size(29, 24);
            selectFromForm.TabIndex = 10;
            selectFromForm.Text = "...";
            selectFromForm.UseVisualStyleBackColor = true;
            selectFromForm.Visible = false;
            selectFromForm.Click += selectFromForm_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(326, 223);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(67, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "ОК";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Visible = false;
            savebutton.Click += savebutton_Click;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(39, 12);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(39, 15);
            namelabel.TabIndex = 6;
            namelabel.Text = "Книга";
            namelabel.Visible = false;
            // 
            // secondnamelabel
            // 
            secondnamelabel.AutoSize = true;
            secondnamelabel.Location = new Point(39, 67);
            secondnamelabel.Name = "secondnamelabel";
            secondnamelabel.Size = new Size(57, 15);
            secondnamelabel.TabIndex = 5;
            secondnamelabel.Text = "Читатель";
            secondnamelabel.Visible = false;
            // 
            // thirdnamelabel
            // 
            thirdnamelabel.AutoSize = true;
            thirdnamelabel.Location = new Point(39, 129);
            thirdnamelabel.Name = "thirdnamelabel";
            thirdnamelabel.Size = new Size(66, 15);
            thirdnamelabel.TabIndex = 4;
            thirdnamelabel.Text = "Сотрудник";
            thirdnamelabel.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
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
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(494, 276);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(return_button);
            panel5.Controls.Add(deletebutton);
            panel5.Controls.Add(addbutton);
            panel5.Controls.Add(editbutton);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(509, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 276);
            panel5.TabIndex = 11;
            // 
            // return_button
            // 
            return_button.Location = new Point(18, 101);
            return_button.Name = "return_button";
            return_button.Size = new Size(129, 23);
            return_button.TabIndex = 3;
            return_button.Text = "Возврат книги";
            return_button.UseVisualStyleBackColor = true;
            return_button.Click += return_button_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(18, 72);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(129, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Удалить";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(18, 12);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(18, 41);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(129, 23);
            editbutton.TabIndex = 1;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(current_table_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 51);
            panel2.TabIndex = 0;
            // 
            // current_table_label
            // 
            current_table_label.AutoSize = true;
            current_table_label.Location = new Point(15, 20);
            current_table_label.Name = "current_table_label";
            current_table_label.Size = new Size(95, 15);
            current_table_label.TabIndex = 0;
            current_table_label.Text = "Журнал выдачи";
            // 
            // GivenBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 386);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GivenBooks";
            Text = "Журнал выдачи";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem References;
        private ToolStripMenuItem PublishingHouseToolStripMenuItem;
        private ToolStripMenuItem PositionsToolStripMenuItem;
        private ToolStripMenuItem StuffToolStripMenuItem;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label current_table_label;
        private DataGridView dataGridView1;
        private Button deletebutton;
        private Button editbutton;
        private Button addbutton;
        private Button savebutton;
        private Label namelabel;
        private Label secondnamelabel;
        private Label thirdnamelabel;
        private Button selectFromForm;
        internal ComboBox comboBox1;
        private Panel panel6;
        private Panel panel5;
        private Button cancelbutton;
        private Button button2;
        internal ComboBox comboBox3;
        private Button button1;
        internal ComboBox comboBox2;
        private Button return_button;
        private Button select_book_for_return;
        internal ComboBox comboBox4;
        private Label label_for_return_book;
    }
}