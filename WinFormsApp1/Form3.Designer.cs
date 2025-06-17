namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            adddirector = new Button();
            firstname = new Label();
            surname = new Label();
            phonenumber = new Label();
            email = new Label();
            yearwork = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            infoadd = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(299, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 50);
            label1.TabIndex = 0;
            label1.Text = "Directors";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 312);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // adddirector
            // 
            adddirector.BackColor = SystemColors.ScrollBar;
            adddirector.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            adddirector.Location = new Point(547, 379);
            adddirector.Name = "adddirector";
            adddirector.Size = new Size(232, 59);
            adddirector.TabIndex = 2;
            adddirector.Text = "Add Director";
            adddirector.UseVisualStyleBackColor = false;
            adddirector.Click += adddirector_Click;
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.BackColor = SystemColors.Info;
            firstname.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            firstname.Location = new Point(179, 85);
            firstname.Name = "firstname";
            firstname.Size = new Size(162, 41);
            firstname.TabIndex = 3;
            firstname.Text = "First Name";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            surname.Location = new Point(179, 155);
            surname.Name = "surname";
            surname.Size = new Size(135, 41);
            surname.TabIndex = 4;
            surname.Text = "Surname";
            // 
            // phonenumber
            // 
            phonenumber.AutoSize = true;
            phonenumber.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            phonenumber.Location = new Point(179, 270);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(216, 41);
            phonenumber.TabIndex = 5;
            phonenumber.Text = "Phone Number";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            email.Location = new Point(179, 323);
            email.Name = "email";
            email.Size = new Size(91, 41);
            email.TabIndex = 6;
            email.Text = "Email";
            // 
            // yearwork
            // 
            yearwork.AutoSize = true;
            yearwork.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            yearwork.Location = new Point(179, 216);
            yearwork.Name = "yearwork";
            yearwork.Size = new Size(149, 41);
            yearwork.TabIndex = 7;
            yearwork.Text = "Year work";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(413, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(413, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(413, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(357, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(413, 337);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(357, 27);
            textBox5.TabIndex = 12;
            // 
            // infoadd
            // 
            infoadd.AutoSize = true;
            infoadd.Location = new Point(378, 405);
            infoadd.Name = "infoadd";
            infoadd.Size = new Size(139, 20);
            infoadd.TabIndex = 13;
            infoadd.Text = "Успешно добавен!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(infoadd);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(yearwork);
            Controls.Add(email);
            Controls.Add(phonenumber);
            Controls.Add(surname);
            Controls.Add(firstname);
            Controls.Add(adddirector);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button adddirector;
        private Label firstname;
        private Label surname;
        private Label phonenumber;
        private Label email;
        private Label yearwork;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label infoadd;
    }
}