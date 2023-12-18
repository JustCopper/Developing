namespace Developing
{
    partial class Positions
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
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            resetbutton = new Button();
            label_position = new Label();
            searchbutton = new Button();
            savebutton = new Button();
            searchTextBox = new TextBox();
            textBox_position = new TextBox();
            cancelbutton = new Button();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            deletebutton = new Button();
            addbutton = new Button();
            editbutton = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            current_table_label = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
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
            menuStrip1.Size = new Size(577, 24);
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 483);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(resetbutton);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(searchbutton);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(searchTextBox);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 440);
            panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_position);
            groupBox1.Controls.Add(savebutton);
            groupBox1.Controls.Add(textBox_position);
            groupBox1.Controls.Add(cancelbutton);
            groupBox1.Location = new Point(14, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 395);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Должности";
            groupBox1.Visible = false;
            // 
            // resetbutton
            // 
            resetbutton.Location = new Point(326, 6);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(75, 23);
            resetbutton.TabIndex = 30;
            resetbutton.Text = "Сброс";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Location = new Point(16, 25);
            label_position.Name = "label_position";
            label_position.Size = new Size(72, 15);
            label_position.TabIndex = 1;
            label_position.Text = "Должность:";
            label_position.Click += label_position_Click;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(245, 6);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 23);
            searchbutton.TabIndex = 29;
            searchbutton.Text = "Поиск";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(203, 89);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(72, 23);
            savebutton.TabIndex = 3;
            savebutton.Text = "ОК";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(14, 6);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(225, 23);
            searchTextBox.TabIndex = 28;
            // 
            // textBox_position
            // 
            textBox_position.Location = new Point(16, 43);
            textBox_position.Name = "textBox_position";
            textBox_position.Size = new Size(199, 23);
            textBox_position.TabIndex = 2;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(281, 89);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(85, 23);
            cancelbutton.TabIndex = 4;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(387, 395);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(deletebutton);
            panel5.Controls.Add(addbutton);
            panel5.Controls.Add(editbutton);
            panel5.Location = new Point(407, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 392);
            panel5.TabIndex = 5;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(12, 63);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(129, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Удалить";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(12, 5);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(129, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(12, 34);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(129, 23);
            editbutton.TabIndex = 1;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 470);
            panel4.Name = "panel4";
            panel4.Size = new Size(577, 13);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(current_table_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 30);
            panel2.TabIndex = 0;
            // 
            // current_table_label
            // 
            current_table_label.AutoSize = true;
            current_table_label.Location = new Point(12, 8);
            current_table_label.Name = "current_table_label";
            current_table_label.Size = new Size(70, 15);
            current_table_label.TabIndex = 0;
            current_table_label.Text = "Должности";
            // 
            // Positions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 507);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Positions";
            Text = "Должности";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Panel panel2;
        private Label current_table_label;
        private Button deletebutton;
        private Button editbutton;
        private Button addbutton;
        private Button savebutton;
        private TextBox textBox_position;
        private Label label_position;
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