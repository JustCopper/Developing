namespace Developing
{
    partial class BookRecord
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            closeButton = new Button();
            ReturnBookBackbutton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Выданная книга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Выдал сотрудник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 109);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Взял читатель";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(218, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(218, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(218, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(218, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 149);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "Дата выдачи книги";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(218, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(207, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 187);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 8;
            label5.Text = "Дата возврата книги";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(218, 220);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(207, 23);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 223);
            label6.Name = "label6";
            label6.Size = new Size(163, 15);
            label6.TabIndex = 10;
            label6.Text = "Дата фактического возврата";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 271);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Запись выдачи";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(390, 320);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 13;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ReturnBookBackbutton
            // 
            ReturnBookBackbutton.Location = new Point(268, 319);
            ReturnBookBackbutton.Name = "ReturnBookBackbutton";
            ReturnBookBackbutton.Size = new Size(116, 23);
            ReturnBookBackbutton.TabIndex = 14;
            ReturnBookBackbutton.Text = "Возврат книги";
            ReturnBookBackbutton.UseVisualStyleBackColor = true;
            ReturnBookBackbutton.Click += ReturnBookBackbutton_Click;
            // 
            // BookRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 354);
            Controls.Add(ReturnBookBackbutton);
            Controls.Add(closeButton);
            Controls.Add(groupBox1);
            Name = "BookRecord";
            Text = "BookRecord";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private GroupBox groupBox1;
        private Button closeButton;
        private Button ReturnBookBackbutton;
    }
}