namespace WinFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            directorid = new Label();
            title = new Label();
            author = new Label();
            yearpublished = new Label();
            studioid = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            addfilm = new Button();
            infoadd = new Label();
            yearpub = new Label();
            textBox6 = new TextBox();
            pogod = new Button();
            answear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(321, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 46);
            label1.TabIndex = 0;
            label1.Text = "Films";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(641, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // directorid
            // 
            directorid.AutoSize = true;
            directorid.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            directorid.Location = new Point(27, 189);
            directorid.Name = "directorid";
            directorid.Size = new Size(141, 41);
            directorid.TabIndex = 2;
            directorid.Text = "DirectorId";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            title.Location = new Point(27, 239);
            title.Name = "title";
            title.Size = new Size(71, 41);
            title.TabIndex = 3;
            title.Text = "Title";
            // 
            // author
            // 
            author.AutoSize = true;
            author.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            author.Location = new Point(27, 280);
            author.Name = "author";
            author.Size = new Size(103, 41);
            author.TabIndex = 4;
            author.Text = "Author";
            // 
            // yearpublished
            // 
            yearpublished.AutoSize = true;
            yearpublished.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            yearpublished.Location = new Point(27, 321);
            yearpublished.Name = "yearpublished";
            yearpublished.Size = new Size(203, 41);
            yearpublished.TabIndex = 5;
            yearpublished.Text = "Year Published";
            // 
            // studioid
            // 
            studioid.AutoSize = true;
            studioid.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            studioid.Location = new Point(27, 144);
            studioid.Name = "studioid";
            studioid.Size = new Size(125, 41);
            studioid.TabIndex = 6;
            studioid.Text = "StudioID";
            studioid.Click += label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AddFilm", "GetFilmsByYear" });
            comboBox1.Location = new Point(27, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Choose options";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 335);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(275, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(275, 294);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(275, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(243, 27);
            textBox5.TabIndex = 12;
            // 
            // addfilm
            // 
            addfilm.BackColor = SystemColors.ScrollBar;
            addfilm.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addfilm.Location = new Point(589, 377);
            addfilm.Name = "addfilm";
            addfilm.Size = new Size(135, 50);
            addfilm.TabIndex = 13;
            addfilm.Text = "Add Film";
            addfilm.UseVisualStyleBackColor = false;
            addfilm.Click += addfilm_Click;
            // 
            // infoadd
            // 
            infoadd.AutoSize = true;
            infoadd.Location = new Point(372, 407);
            infoadd.Name = "infoadd";
            infoadd.Size = new Size(146, 20);
            infoadd.TabIndex = 14;
            infoadd.Text = "Успешно дабавен!!!";
            infoadd.Click += infoadd_Click;
            // 
            // yearpub
            // 
            yearpub.AutoSize = true;
            yearpub.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            yearpub.Location = new Point(559, 169);
            yearpub.Name = "yearpub";
            yearpub.Size = new Size(203, 41);
            yearpub.TabIndex = 15;
            yearpub.Text = "Year Published";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(559, 230);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(209, 27);
            textBox6.TabIndex = 16;
            // 
            // pogod
            // 
            pogod.BackColor = SystemColors.ScrollBar;
            pogod.Location = new Point(577, 285);
            pogod.Name = "pogod";
            pogod.Size = new Size(174, 45);
            pogod.TabIndex = 17;
            pogod.Text = "Oppp!";
            pogod.UseVisualStyleBackColor = false;
            pogod.Click += pogod_Click;
            // 
            // answear
            // 
            answear.Location = new Point(27, 100);
            answear.Name = "answear";
            answear.Size = new Size(522, 27);
            answear.TabIndex = 18;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(answear);
            Controls.Add(pogod);
            Controls.Add(textBox6);
            Controls.Add(yearpub);
            Controls.Add(infoadd);
            Controls.Add(addfilm);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(studioid);
            Controls.Add(yearpublished);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(directorid);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label directorid;
        private Label title;
        private Label author;
        private Label yearpublished;
        private Label studioid;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button addfilm;
        private Label infoadd;
        private Label yearpub;
        private TextBox textBox6;
        private Button pogod;
        private TextBox answear;
    }
}