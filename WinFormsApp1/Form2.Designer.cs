namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            firstname = new Label();
            surname = new Label();
            yearwork = new Label();
            phone = new Label();
            email = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            addactor = new Button();
            addinfo = new Label();
            name = new Label();
            textBox6 = new TextBox();
            poime = new Button();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(312, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 50);
            label1.TabIndex = 0;
            label1.Text = "Actors";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(609, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Add actor", "GetActorsByName" });
            comboBox1.Location = new Point(37, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Choose option";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.BackColor = SystemColors.Info;
            firstname.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            firstname.Location = new Point(37, 147);
            firstname.Name = "firstname";
            firstname.Size = new Size(157, 38);
            firstname.TabIndex = 3;
            firstname.Text = "First Name";
            firstname.Click += firstname_Click;
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.BackColor = SystemColors.Info;
            surname.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            surname.Location = new Point(37, 195);
            surname.Name = "surname";
            surname.Size = new Size(129, 38);
            surname.TabIndex = 4;
            surname.Text = "Surname";
            // 
            // yearwork
            // 
            yearwork.AutoSize = true;
            yearwork.BackColor = SystemColors.Info;
            yearwork.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            yearwork.Location = new Point(37, 245);
            yearwork.Name = "yearwork";
            yearwork.Size = new Size(145, 38);
            yearwork.TabIndex = 5;
            yearwork.Text = "Year work";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = SystemColors.Info;
            phone.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            phone.Location = new Point(37, 295);
            phone.Name = "phone";
            phone.Size = new Size(202, 38);
            phone.TabIndex = 6;
            phone.Text = "Phone number";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = SystemColors.Info;
            email.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            email.Location = new Point(37, 347);
            email.Name = "email";
            email.Size = new Size(88, 38);
            email.TabIndex = 7;
            email.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(304, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(246, 306);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(304, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(246, 358);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(304, 27);
            textBox5.TabIndex = 12;
            // 
            // addactor
            // 
            addactor.BackColor = SystemColors.ScrollBar;
            addactor.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addactor.Location = new Point(634, 358);
            addactor.Name = "addactor";
            addactor.Size = new Size(142, 65);
            addactor.TabIndex = 13;
            addactor.Text = "Add";
            addactor.UseVisualStyleBackColor = false;
            addactor.Click += addactor_Click;
            // 
            // addinfo
            // 
            addinfo.AutoSize = true;
            addinfo.Location = new Point(465, 403);
            addinfo.Name = "addinfo";
            addinfo.Size = new Size(131, 20);
            addinfo.TabIndex = 14;
            addinfo.Text = "Добави успешно!";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            name.Location = new Point(72, 147);
            name.Name = "name";
            name.Size = new Size(94, 38);
            name.TabIndex = 15;
            name.Text = "Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(246, 158);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(304, 27);
            textBox6.TabIndex = 16;
            // 
            // poime
            // 
            poime.BackColor = SystemColors.ScrollBar;
            poime.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            poime.Location = new Point(634, 358);
            poime.Name = "poime";
            poime.Size = new Size(141, 63);
            poime.TabIndex = 17;
            poime.Text = "Gas!";
            poime.UseVisualStyleBackColor = false;
            poime.Click += poime_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(37, 206);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(513, 27);
            textBox7.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(poime);
            Controls.Add(textBox6);
            Controls.Add(name);
            Controls.Add(addinfo);
            Controls.Add(addactor);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(email);
            Controls.Add(phone);
            Controls.Add(yearwork);
            Controls.Add(surname);
            Controls.Add(firstname);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label firstname;
        private Label surname;
        private Label yearwork;
        private Label phone;
        private Label email;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button addactor;
        private Label addinfo;
        private Label name;
        private TextBox textBox6;
        private Button poime;
        private TextBox textBox7;
    }
}