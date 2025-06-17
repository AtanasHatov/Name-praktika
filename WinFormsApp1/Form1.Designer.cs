namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            menu = new Button();
            actors = new Button();
            directors = new Button();
            films = new Button();
            producers = new Button();
            studios = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(95, -1);
            label1.Name = "label1";
            label1.Size = new Size(615, 106);
            label1.TabIndex = 0;
            label1.Text = "Cinema Center";
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            menu.Font = new Font("Segoe UI Light", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            menu.Location = new Point(345, 136);
            menu.Name = "menu";
            menu.Size = new Size(113, 41);
            menu.TabIndex = 1;
            menu.Text = "Menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += button1_Click;
            // 
            // actors
            // 
            actors.BackColor = SystemColors.ScrollBar;
            actors.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            actors.Location = new Point(513, 199);
            actors.Name = "actors";
            actors.Size = new Size(125, 45);
            actors.TabIndex = 2;
            actors.Text = "Actors";
            actors.UseVisualStyleBackColor = false;
            actors.Click += actors_Click;
            // 
            // directors
            // 
            directors.BackColor = SystemColors.ScrollBar;
            directors.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            directors.Location = new Point(183, 199);
            directors.Name = "directors";
            directors.Size = new Size(138, 45);
            directors.TabIndex = 3;
            directors.Text = "Directors";
            directors.UseVisualStyleBackColor = false;
            directors.Click += directors_Click;
            // 
            // films
            // 
            films.BackColor = SystemColors.ScrollBar;
            films.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            films.Location = new Point(513, 338);
            films.Name = "films";
            films.Size = new Size(97, 48);
            films.TabIndex = 4;
            films.Text = "Films";
            films.UseVisualStyleBackColor = false;
            films.Click += films_Click;
            // 
            // producers
            // 
            producers.BackColor = SystemColors.ScrollBar;
            producers.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            producers.Location = new Point(156, 338);
            producers.Name = "producers";
            producers.Size = new Size(165, 47);
            producers.TabIndex = 5;
            producers.Text = "Producers";
            producers.UseVisualStyleBackColor = false;
            producers.Click += producers_Click;
            // 
            // studios
            // 
            studios.BackColor = SystemColors.ScrollBar;
            studios.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            studios.Location = new Point(345, 271);
            studios.Name = "studios";
            studios.Size = new Size(122, 46);
            studios.TabIndex = 6;
            studios.Text = "Studios";
            studios.UseVisualStyleBackColor = false;
            studios.Click += studios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(639, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(659, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(138, 116);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(studios);
            Controls.Add(producers);
            Controls.Add(films);
            Controls.Add(directors);
            Controls.Add(actors);
            Controls.Add(menu);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button menu;
        private Button actors;
        private Button directors;
        private Button films;
        private Button producers;
        private Button studios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
