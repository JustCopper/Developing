namespace Developing
{
    partial class Authors
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
            panel5 = new Panel();
            deletebutton = new Button();
            addbutton = new Button();
            editbutton = new Button();
            panel3 = new Panel();
            resetbutton = new Button();
            groupBox1 = new GroupBox();
            label_genre = new Label();
            textBox_surname = new TextBox();
            savebutton = new Button();
            textBox_lastname = new TextBox();
            textBox_name = new TextBox();
            label2 = new Label();
            cancelbutton = new Button();
            label1 = new Label();
            searchTextBox = new TextBox();
            searchbutton = new Button();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel2 = new Panel();
            current_table_label = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { References });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(727, 24);
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
            PositionsToolStripMenuItem.Enabled = false;
            PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem";
            PositionsToolStripMenuItem.Size = new Size(147, 22);
            PositionsToolStripMenuItem.Text = "Должности";
            // 
            // StuffToolStripMenuItem
            // 
            StuffToolStripMenuItem.Name = "StuffToolStripMenuItem";
            StuffToolStripMenuItem.Size = new Size(147, 22);
            StuffToolStripMenuItem.Text = "Сотрудники";
            StuffToolStripMenuItem.Click += StuffToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 452);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(deletebutton);
            panel5.Controls.Add(addbutton);
            panel5.Controls.Add(editbutton);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(581, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(146, 403);
            panel5.TabIndex = 5;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(6, 136);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(129, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Удалить";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(6, 78);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(6, 107);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(129, 23);
            editbutton.TabIndex = 1;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(resetbutton);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(searchTextBox);
            panel3.Controls.Add(searchbutton);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(581, 403);
            panel3.TabIndex = 4;
            // 
            // resetbutton
            // 
            resetbutton.Location = new Point(427, 20);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(75, 23);
            resetbutton.TabIndex = 10;
            resetbutton.Text = "Сброс";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_genre);
            groupBox1.Controls.Add(textBox_surname);
            groupBox1.Controls.Add(savebutton);
            groupBox1.Controls.Add(textBox_lastname);
            groupBox1.Controls.Add(textBox_name);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cancelbutton);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 324);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Авторы";
            groupBox1.Visible = false;
            // 
            // label_genre
            // 
            label_genre.AutoSize = true;
            label_genre.Location = new Point(17, 37);
            label_genre.Name = "label_genre";
            label_genre.Size = new Size(31, 15);
            label_genre.TabIndex = 1;
            label_genre.Text = "Имя";
            label_genre.Visible = false;
            label_genre.Click += label_position_Click;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(179, 55);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(156, 23);
            textBox_surname.TabIndex = 6;
            textBox_surname.Visible = false;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(356, 98);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(69, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "ОК";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Visible = false;
            savebutton.Click += savebutton_Click;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(349, 55);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.Size = new Size(176, 23);
            textBox_lastname.TabIndex = 6;
            textBox_lastname.Visible = false;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(17, 55);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(150, 23);
            textBox_name.TabIndex = 2;
            textBox_name.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 37);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            label2.Visible = false;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(431, 98);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(94, 23);
            cancelbutton.TabIndex = 4;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Visible = false;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "Отчество";
            label1.Visible = false;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 21);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(328, 23);
            searchTextBox.TabIndex = 8;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(346, 21);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 23);
            searchbutton.TabIndex = 9;
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
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 324);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 434);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 18);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(current_table_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 31);
            panel2.TabIndex = 0;
            // 
            // current_table_label
            // 
            current_table_label.AutoSize = true;
            current_table_label.Location = new Point(12, 13);
            current_table_label.Name = "current_table_label";
            current_table_label.Size = new Size(49, 15);
            current_table_label.TabIndex = 0;
            current_table_label.Text = "Авторы";
            // 
            // Authors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 476);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Authors";
            Text = "Авторы";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel2;
        private Label current_table_label;
        private Button deletebutton;
        private Button editbutton;
        private Button addbutton;
        private Button savebutton;
        private TextBox textBox_name;
        private Label label_genre;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Panel panel3;
        private Button cancelbutton;
        private TextBox textBox_surname;
        private TextBox textBox_lastname;
        private Label label2;
        private Label label1;
        private TextBox searchTextBox;
        private Button resetbutton;
        private Button searchbutton;
        private GroupBox groupBox1;
    }
}