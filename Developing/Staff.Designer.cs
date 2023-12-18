namespace Developing
{
    partial class Staff
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
            cancelbutton = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            selectFromForm = new Button();
            textBox2 = new TextBox();
            thirdnamelabel = new Label();
            savebutton = new Button();
            label_position = new Label();
            namelabel = new Label();
            secondnamelabel = new Label();
            textBox3 = new TextBox();
            resetbutton = new Button();
            searchbutton = new Button();
            searchTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            deletebutton = new Button();
            addbutton = new Button();
            editbutton = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
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
            menuStrip1.Size = new Size(609, 24);
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
            panel2.Controls.Add(current_table_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 31);
            panel2.TabIndex = 0;
            // 
            // current_table_label
            // 
            current_table_label.AutoSize = true;
            current_table_label.Location = new Point(15, 9);
            current_table_label.Name = "current_table_label";
            current_table_label.Size = new Size(73, 15);
            current_table_label.TabIndex = 0;
            current_table_label.Text = "Сотрудники";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 347);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(resetbutton);
            panel6.Controls.Add(searchbutton);
            panel6.Controls.Add(searchTextBox);
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(467, 347);
            panel6.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cancelbutton);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(selectFromForm);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(thirdnamelabel);
            groupBox1.Controls.Add(savebutton);
            groupBox1.Controls.Add(label_position);
            groupBox1.Controls.Add(namelabel);
            groupBox1.Controls.Add(secondnamelabel);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(17, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 309);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сотрудники";
            groupBox1.Visible = false;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(334, 134);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(96, 23);
            cancelbutton.TabIndex = 11;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 7;
            // 
            // selectFromForm
            // 
            selectFromForm.Location = new Point(153, 97);
            selectFromForm.Name = "selectFromForm";
            selectFromForm.Size = new Size(27, 23);
            selectFromForm.TabIndex = 10;
            selectFromForm.Text = "...";
            selectFromForm.UseVisualStyleBackColor = true;
            selectFromForm.Click += selectFromForm_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 8;
            // 
            // thirdnamelabel
            // 
            thirdnamelabel.AutoSize = true;
            thirdnamelabel.Location = new Point(306, 19);
            thirdnamelabel.Name = "thirdnamelabel";
            thirdnamelabel.Size = new Size(58, 15);
            thirdnamelabel.TabIndex = 4;
            thirdnamelabel.Text = "Отчество";
            // 
            // savebutton
            // 
            savebutton.Location = new Point(258, 134);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(70, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "OK";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Location = new Point(8, 79);
            label_position.Name = "label_position";
            label_position.Size = new Size(72, 15);
            label_position.TabIndex = 1;
            label_position.Text = "Должность:";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(8, 19);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(31, 15);
            namelabel.TabIndex = 6;
            namelabel.Text = "Имя";
            // 
            // secondnamelabel
            // 
            secondnamelabel.AutoSize = true;
            secondnamelabel.Location = new Point(159, 19);
            secondnamelabel.Name = "secondnamelabel";
            secondnamelabel.Size = new Size(58, 15);
            secondnamelabel.TabIndex = 5;
            secondnamelabel.Text = "Фамилия";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(306, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 9;
            // 
            // resetbutton
            // 
            resetbutton.Location = new Point(386, 6);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(75, 23);
            resetbutton.TabIndex = 33;
            resetbutton.Text = "Сброс";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(305, 6);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 23);
            searchbutton.TabIndex = 32;
            searchbutton.Text = "Поиск";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(17, 6);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(282, 23);
            searchTextBox.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(444, 309);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(deletebutton);
            panel5.Controls.Add(addbutton);
            panel5.Controls.Add(editbutton);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(467, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 347);
            panel5.TabIndex = 11;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(6, 106);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(129, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Удалить";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(6, 46);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(6, 75);
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
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 405);
            panel1.TabIndex = 1;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 413);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Staff";
            Text = "Сотрудники";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button cancelbutton;
        private Button selectFromForm;
        private Button savebutton;
        private Label namelabel;
        private TextBox textBox3;
        private Label secondnamelabel;
        private Label label_position;
        private Label thirdnamelabel;
        private TextBox textBox2;
        private TextBox textBox1;
        internal ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Button deletebutton;
        private Button addbutton;
        private Button editbutton;
        private Panel panel1;
        private Button resetbutton;
        private Button searchbutton;
        private TextBox searchTextBox;
        private GroupBox groupBox1;
    }
}