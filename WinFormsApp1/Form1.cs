namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actors.Show();
            directors.Show();
            films.Show();
            producers.Show();
            studios.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actors.Visible = false;
            directors.Visible = false;
            films.Visible = false;
            producers.Visible = false;
            studios.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void actors_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void directors_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void films_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void producers_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void studios_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();    
        }
    }
}
