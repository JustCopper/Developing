namespace Developing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            References = new ToolStripMenuItem();
            PublishingHouseToolStripMenuItem = new ToolStripMenuItem();
            PositionsToolStripMenuItem = new ToolStripMenuItem();
            StuffToolStripMenuItem = new ToolStripMenuItem();
            GenresToolStripMenuItem = new ToolStripMenuItem();
            AuthorsToolStripMenuItem = new ToolStripMenuItem();
            BooksToolStripMenuItem = new ToolStripMenuItem();
            ReadersToolStripMenuItem = new ToolStripMenuItem();
            JournalAuditToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            выданныеКнигиToolStripMenuItem = new ToolStripMenuItem();
            популярныеЖанрыToolStripMenuItem = new ToolStripMenuItem();
            актуальныеИздательстваToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { References, отчетыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // References
            // 
            References.DropDownItems.AddRange(new ToolStripItem[] { PublishingHouseToolStripMenuItem, PositionsToolStripMenuItem, StuffToolStripMenuItem, GenresToolStripMenuItem, AuthorsToolStripMenuItem, BooksToolStripMenuItem, ReadersToolStripMenuItem, JournalAuditToolStripMenuItem });
            References.Name = "References";
            References.Size = new Size(94, 20);
            References.Text = "Справочники";
            // 
            // PublishingHouseToolStripMenuItem
            // 
            PublishingHouseToolStripMenuItem.Name = "PublishingHouseToolStripMenuItem";
            PublishingHouseToolStripMenuItem.Size = new Size(193, 22);
            PublishingHouseToolStripMenuItem.Text = "Издательства";
            PublishingHouseToolStripMenuItem.Click += PublishingHouseToolStripMenuItem_Click;
            // 
            // PositionsToolStripMenuItem
            // 
            PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem";
            PositionsToolStripMenuItem.Size = new Size(193, 22);
            PositionsToolStripMenuItem.Text = "Должности";
            PositionsToolStripMenuItem.Click += PositionsToolStripMenuItem_Click;
            // 
            // StuffToolStripMenuItem
            // 
            StuffToolStripMenuItem.Name = "StuffToolStripMenuItem";
            StuffToolStripMenuItem.Size = new Size(193, 22);
            StuffToolStripMenuItem.Text = "Сотрудники";
            StuffToolStripMenuItem.Click += StuffToolStripMenuItem_Click;
            // 
            // GenresToolStripMenuItem
            // 
            GenresToolStripMenuItem.Name = "GenresToolStripMenuItem";
            GenresToolStripMenuItem.Size = new Size(193, 22);
            GenresToolStripMenuItem.Text = "Жанры";
            GenresToolStripMenuItem.Click += GenresToolStripMenuItem_Click;
            // 
            // AuthorsToolStripMenuItem
            // 
            AuthorsToolStripMenuItem.Name = "AuthorsToolStripMenuItem";
            AuthorsToolStripMenuItem.Size = new Size(193, 22);
            AuthorsToolStripMenuItem.Text = "Авторы";
            AuthorsToolStripMenuItem.Click += AuthorsToolStripMenuItem_Click;
            // 
            // BooksToolStripMenuItem
            // 
            BooksToolStripMenuItem.Name = "BooksToolStripMenuItem";
            BooksToolStripMenuItem.Size = new Size(193, 22);
            BooksToolStripMenuItem.Text = "Книги";
            BooksToolStripMenuItem.Click += BooksToolStripMenuItem_Click;
            // 
            // ReadersToolStripMenuItem
            // 
            ReadersToolStripMenuItem.Name = "ReadersToolStripMenuItem";
            ReadersToolStripMenuItem.Size = new Size(193, 22);
            ReadersToolStripMenuItem.Text = "Читательские билеты";
            ReadersToolStripMenuItem.Click += ReadersToolStripMenuItem_Click;
            // 
            // JournalAuditToolStripMenuItem
            // 
            JournalAuditToolStripMenuItem.Name = "JournalAuditToolStripMenuItem";
            JournalAuditToolStripMenuItem.Size = new Size(193, 22);
            JournalAuditToolStripMenuItem.Text = "Журнал выдачи";
            JournalAuditToolStripMenuItem.Click += JournalAuditToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выданныеКнигиToolStripMenuItem, популярныеЖанрыToolStripMenuItem, актуальныеИздательстваToolStripMenuItem });
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // выданныеКнигиToolStripMenuItem
            // 
            выданныеКнигиToolStripMenuItem.Name = "выданныеКнигиToolStripMenuItem";
            выданныеКнигиToolStripMenuItem.Size = new Size(226, 22);
            выданныеКнигиToolStripMenuItem.Text = "Количество выданных книг";
            выданныеКнигиToolStripMenuItem.Click += выданныеКнигиToolStripMenuItem_Click;
            // 
            // популярныеЖанрыToolStripMenuItem
            // 
            популярныеЖанрыToolStripMenuItem.Name = "популярныеЖанрыToolStripMenuItem";
            популярныеЖанрыToolStripMenuItem.Size = new Size(261, 22);
            популярныеЖанрыToolStripMenuItem.Text = "Популярные жанры";
            популярныеЖанрыToolStripMenuItem.Click += популярныеЖанрыToolStripMenuItem_Click;
            // 
            // актуальныеИздательстваToolStripMenuItem
            // 
            актуальныеИздательстваToolStripMenuItem.Name = "актуальныеИздательстваToolStripMenuItem";
            актуальныеИздательстваToolStripMenuItem.Size = new Size(226, 22);
            актуальныеИздательстваToolStripMenuItem.Text = "Просрочен срок возврата";
            актуальныеИздательстваToolStripMenuItem.Click += актуальныеИздательстваToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "Библиотека";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem References;
        private ToolStripMenuItem PublishingHouseToolStripMenuItem;
        private ToolStripMenuItem PositionsToolStripMenuItem;
        private ToolStripMenuItem StuffToolStripMenuItem;
        private ToolStripMenuItem GenresToolStripMenuItem;
        private ToolStripMenuItem AuthorsToolStripMenuItem;
        private ToolStripMenuItem BooksToolStripMenuItem;
        private ToolStripMenuItem ReadersToolStripMenuItem;
        private ToolStripMenuItem JournalAuditToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem выданныеКнигиToolStripMenuItem;
        private ToolStripMenuItem популярныеЖанрыToolStripMenuItem;
        private ToolStripMenuItem актуальныеИздательстваToolStripMenuItem;
    }
}