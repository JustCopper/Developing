namespace Developing
{
    partial class Genres
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
            groupBox1 = new GroupBox();
            label_genre = new Label();
            savebutton = new Button();
            cancelbutton = new Button();
            textBox_genre = new TextBox();
            searchTextBox = new TextBox();
            resetbutton = new Button();
            dataGridView1 = new DataGridView();
            searchbutton = new Button();
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
            menuStrip1.Size = new Size(549, 24);
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
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 464);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(deletebutton);
            panel5.Controls.Add(addbutton);
            panel5.Controls.Add(editbutton);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(388, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 433);
            panel5.TabIndex = 5;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(20, 104);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(129, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Удалить";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(20, 46);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(20, 75);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(129, 23);
            editbutton.TabIndex = 1;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(searchTextBox);
            panel3.Controls.Add(resetbutton);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(searchbutton);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 433);
            panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_genre);
            groupBox1.Controls.Add(savebutton);
            groupBox1.Controls.Add(cancelbutton);
            groupBox1.Controls.Add(textBox_genre);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 386);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Жанры";
            groupBox1.Visible = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label_genre
            // 
            label_genre.AutoSize = true;
            label_genre.Location = new Point(95, 19);
            label_genre.Name = "label_genre";
            label_genre.Size = new Size(41, 15);
            label_genre.TabIndex = 1;
            label_genre.Text = "Жанр:";
            label_genre.Click += label_position_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(196, 86);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(65, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "ОК";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(267, 86);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(97, 23);
            cancelbutton.TabIndex = 4;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // textBox_genre
            // 
            textBox_genre.Location = new Point(95, 37);
            textBox_genre.Name = "textBox_genre";
            textBox_genre.Size = new Size(199, 23);
            textBox_genre.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 6);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(170, 23);
            searchTextBox.TabIndex = 25;
            // 
            // resetbutton
            // 
            resetbutton.Location = new Point(269, 5);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(75, 23);
            resetbutton.TabIndex = 27;
            resetbutton.Text = "Сброс";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(370, 386);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(188, 5);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 23);
            searchbutton.TabIndex = 26;
            searchbutton.Text = "Поиск";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(current_table_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 31);
            panel2.TabIndex = 0;
            // 
            // current_table_label
            // 
            current_table_label.AutoSize = true;
            current_table_label.Location = new Point(12, 13);
            current_table_label.Name = "current_table_label";
            current_table_label.Size = new Size(47, 15);
            current_table_label.TabIndex = 0;
            current_table_label.Text = "Жанры";
            // 
            // Genres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 488);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Genres";
            Text = "Жанры";
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
        private Panel panel2;
        private Label current_table_label;
        private Button deletebutton;
        private Button editbutton;
        private Button addbutton;
        private Button savebutton;
        private TextBox textBox_genre;
        private Label label_genre;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Panel panel3;
        private Button cancelbutton;
        private Button resetbutton;
        private Button searchbutton;
        private TextBox searchTextBox;
        private GroupBox groupBox1;
    }
}