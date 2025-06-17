namespace WinFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            firstnamw = new Label();
            surname = new Label();
            yearwork = new Label();
            phone = new Label();
            email = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            infoadd = new Label();
            addproducer = new Button();
            name = new Label();
            textBox6 = new TextBox();
            metod2 = new Button();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 50);
            label1.TabIndex = 0;
            label1.Text = "Producers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Add Producent", "GetProducersByName" });
            comboBox1.Location = new Point(566, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Choose optional";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // firstnamw
            // 
            firstnamw.AutoSize = true;
            firstnamw.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            firstnamw.Location = new Point(124, 114);
            firstnamw.Name = "firstnamw";
            firstnamw.Size = new Size(155, 41);
            firstnamw.TabIndex = 3;
            firstnamw.Text = "First Name";
            firstnamw.Click += label2_Click;
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            surname.Location = new Point(124, 165);
            surname.Name = "surname";
            surname.Size = new Size(130, 41);
            surname.TabIndex = 4;
            surname.Text = "Surname";
            // 
            // yearwork
            // 
            yearwork.AutoSize = true;
            yearwork.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            yearwork.Location = new Point(124, 216);
            yearwork.Name = "yearwork";
            yearwork.Size = new Size(149, 41);
            yearwork.TabIndex = 5;
            yearwork.Text = "Year Work";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            phone.Location = new Point(124, 263);
            phone.Name = "phone";
            phone.Size = new Size(202, 41);
            phone.TabIndex = 6;
            phone.Text = "Phone number";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            email.Location = new Point(124, 313);
            email.Name = "email";
            email.Size = new Size(88, 41);
            email.TabIndex = 7;
            email.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(360, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(360, 327);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 27);
            textBox5.TabIndex = 12;
            // 
            // infoadd
            // 
            infoadd.AutoSize = true;
            infoadd.Location = new Point(212, 379);
            infoadd.Name = "infoadd";
            infoadd.Size = new Size(147, 20);
            infoadd.TabIndex = 13;
            infoadd.Text = "Успешно добавен!!!";
            infoadd.Click += infoadd_Click;
            // 
            // addproducer
            // 
            addproducer.BackColor = SystemColors.ScrollBar;
            addproducer.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            addproducer.Location = new Point(481, 379);
            addproducer.Name = "addproducer";
            addproducer.Size = new Size(262, 54);
            addproducer.TabIndex = 14;
            addproducer.Text = "Add Producer";
            addproducer.UseVisualStyleBackColor = false;
            addproducer.Click += button1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            name.Location = new Point(12, 400);
            name.Name = "name";
            name.Size = new Size(155, 41);
            name.TabIndex = 15;
            name.Text = "First Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(201, 414);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(237, 27);
            textBox6.TabIndex = 16;
            // 
            // metod2
            // 
            metod2.BackColor = SystemColors.ScrollBar;
            metod2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            metod2.Location = new Point(31, 327);
            metod2.Name = "metod2";
            metod2.Size = new Size(154, 70);
            metod2.TabIndex = 17;
            metod2.Text = "Buu!!!";
            metod2.UseVisualStyleBackColor = false;
            metod2.Click += metod2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(375, 99);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(374, 27);
            textBox7.TabIndex = 18;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(metod2);
            Controls.Add(textBox6);
            Controls.Add(name);
            Controls.Add(addproducer);
            Controls.Add(infoadd);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(email);
            Controls.Add(phone);
            Controls.Add(yearwork);
            Controls.Add(surname);
            Controls.Add(firstnamw);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label firstnamw;
        private Label surname;
        private Label yearwork;
        private Label phone;
        private Label email;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label infoadd;
        private Button addproducer;
        private Label name;
        private TextBox textBox6;
        private Button metod2;
        private TextBox textBox7;
    }
}