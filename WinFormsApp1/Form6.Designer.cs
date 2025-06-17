namespace WinFormsApp1
{
    partial class Form6
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
            comboBox1 = new ComboBox();
            name = new Label();
            address = new Label();
            phone = new Label();
            email = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            infoadd = new Label();
            addbuton = new Button();
            textBox5 = new TextBox();
            buttonpoime = new Button();
            buttonmeil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(312, -2);
            label1.Name = "label1";
            label1.Size = new Size(155, 50);
            label1.TabIndex = 0;
            label1.Text = "Studios";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Add Studio", "Po ime", "po email" });
            comboBox1.Location = new Point(586, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 45);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Choose option";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            name.Location = new Point(12, 53);
            name.Name = "name";
            name.Size = new Size(95, 41);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            address.Location = new Point(12, 94);
            address.Name = "address";
            address.Size = new Size(116, 41);
            address.TabIndex = 3;
            address.Text = "Address";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            phone.Location = new Point(12, 135);
            phone.Name = "phone";
            phone.Size = new Size(202, 41);
            phone.TabIndex = 4;
            phone.Text = "Phone number";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            email.Location = new Point(12, 176);
            email.Name = "email";
            email.Size = new Size(88, 41);
            email.TabIndex = 5;
            email.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // infoadd
            // 
            infoadd.AutoSize = true;
            infoadd.Location = new Point(12, 230);
            infoadd.Name = "infoadd";
            infoadd.Size = new Size(156, 20);
            infoadd.TabIndex = 10;
            infoadd.Text = "Успешно добавено!!!";
            // 
            // addbuton
            // 
            addbuton.BackColor = SystemColors.ScrollBar;
            addbuton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addbuton.Location = new Point(210, 226);
            addbuton.Name = "addbuton";
            addbuton.Size = new Size(107, 49);
            addbuton.TabIndex = 11;
            addbuton.Text = "Add";
            addbuton.UseVisualStyleBackColor = false;
            addbuton.Click += addbuton_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(397, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(363, 27);
            textBox5.TabIndex = 12;
            // 
            // buttonpoime
            // 
            buttonpoime.BackColor = SystemColors.ScrollBar;
            buttonpoime.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonpoime.Location = new Point(544, 154);
            buttonpoime.Name = "buttonpoime";
            buttonpoime.Size = new Size(216, 63);
            buttonpoime.TabIndex = 13;
            buttonpoime.Text = "PO IMEE";
            buttonpoime.UseVisualStyleBackColor = false;
            buttonpoime.Click += buttonpoime_Click;
            // 
            // buttonmeil
            // 
            buttonmeil.BackColor = SystemColors.ScrollBar;
            buttonmeil.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonmeil.Location = new Point(544, 243);
            buttonmeil.Name = "buttonmeil";
            buttonmeil.Size = new Size(216, 76);
            buttonmeil.TabIndex = 14;
            buttonmeil.Text = "Po meil";
            buttonmeil.UseVisualStyleBackColor = false;
            buttonmeil.Click += buttonmeil_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonmeil);
            Controls.Add(buttonpoime);
            Controls.Add(textBox5);
            Controls.Add(addbuton);
            Controls.Add(infoadd);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(email);
            Controls.Add(phone);
            Controls.Add(address);
            Controls.Add(name);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label name;
        private Label address;
        private Label phone;
        private Label email;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label infoadd;
        private Button addbuton;
        private TextBox textBox5;
        private Button buttonpoime;
        private Button buttonmeil;
    }
}