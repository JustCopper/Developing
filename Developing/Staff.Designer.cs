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
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            cancelbutton = new Button();
            selectFromForm = new Button();
            savebutton = new Button();
            namelabel = new Label();
            textBox3 = new TextBox();
            secondnamelabel = new Label();
            label_position = new Label();
            thirdnamelabel = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
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
            menuStrip1.Size = new Size(668, 24);
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
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 458);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 402);
            panel4.Name = "panel4";
            panel4.Size = new Size(734, 56);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 276);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(cancelbutton);
            panel6.Controls.Add(selectFromForm);
            panel6.Controls.Add(savebutton);
            panel6.Controls.Add(namelabel);
            panel6.Controls.Add(textBox3);
            panel6.Controls.Add(secondnamelabel);
            panel6.Controls.Add(label_position);
            panel6.Controls.Add(thirdnamelabel);
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(504, 276);
            panel6.TabIndex = 12;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(391, 237);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(96, 23);
            cancelbutton.TabIndex = 11;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Visible = false;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // selectFromForm
            // 
            selectFromForm.Location = new Point(156, 101);
            selectFromForm.Name = "selectFromForm";
            selectFromForm.Size = new Size(27, 23);
            selectFromForm.TabIndex = 10;
            selectFromForm.Text = "...";
            selectFromForm.UseVisualStyleBackColor = true;
            selectFromForm.Visible = false;
            selectFromForm.Click += selectFromForm_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(315, 237);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(70, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "OK";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Visible = false;
            savebutton.Click += savebutton_Click;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(38, 23);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(31, 15);
            namelabel.TabIndex = 6;
            namelabel.Text = "Имя";
            namelabel.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(336, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 9;
            textBox3.Visible = false;
            // 
            // secondnamelabel
            // 
            secondnamelabel.AutoSize = true;
            secondnamelabel.Location = new Point(191, 23);
            secondnamelabel.Name = "secondnamelabel";
            secondnamelabel.Size = new Size(58, 15);
            secondnamelabel.TabIndex = 5;
            secondnamelabel.Text = "Фамилия";
            secondnamelabel.Visible = false;
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Location = new Point(38, 83);
            label_position.Name = "label_position";
            label_position.Size = new Size(72, 15);
            label_position.TabIndex = 1;
            label_position.Text = "Должность:";
            label_position.Visible = false;
            // 
            // thirdnamelabel
            // 
            thirdnamelabel.AutoSize = true;
            thirdnamelabel.Location = new Point(336, 23);
            thirdnamelabel.Name = "thirdnamelabel";
            thirdnamelabel.Size = new Size(58, 15);
            thirdnamelabel.TabIndex = 4;
            thirdnamelabel.Text = "Отчество";
            thirdnamelabel.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 8;
            textBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 23);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 101);
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
            dataGridView1.Location = new Point(15, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(491, 273);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(deletebutton);
            panel5.Controls.Add(addbutton);
            panel5.Controls.Add(editbutton);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(504, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 276);
            panel5.TabIndex = 11;
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
            panel2.Size = new Size(734, 51);
            panel2.TabIndex = 0;
            // 
            // current_table_label
            // 
            current_table_label.AutoSize = true;
            current_table_label.Location = new Point(15, 20);
            current_table_label.Name = "current_table_label";
            current_table_label.Size = new Size(73, 15);
            current_table_label.TabIndex = 0;
            current_table_label.Text = "Сотрудники";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 377);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Staff";
            Text = "Сотрудники";
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
        private Label label_position;
        private Button savebutton;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label namelabel;
        private Label secondnamelabel;
        private Label thirdnamelabel;
        private Button selectFromForm;
        internal ComboBox comboBox1;
        private Panel panel6;
        private Panel panel5;
        private Button cancelbutton;
    }
}