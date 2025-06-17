using CinemaCenter.Core;
using CinemaCenter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private static CinemaCenterDbContext db = new CinemaCenterDbContext();
        FilmController filmController = new FilmController(db);

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                studioid.Visible = true;
                directorid.Visible = true;
                title.Visible = true;
                author.Visible = true;
                yearpublished.Visible = true;
                addfilm.Visible = true;
                infoadd.Visible = false;
                yearpub.Visible = false;
                textBox6.Visible = false;
                pogod.Visible = false;
                answear.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                studioid.Visible = false;
                directorid.Visible = false;
                title.Visible = false;
                author.Visible = false;
                yearpublished.Visible = false;
                infoadd.Visible = false;
                addfilm.Visible = false;
                yearpub.Visible = true;
                textBox6.Visible = true;
                pogod.Visible = true;
                answear.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void infoadd_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            studioid.Visible = false;
            directorid.Visible = false;
            title.Visible = false;
            author.Visible = false;
            yearpublished.Visible = false;
            infoadd.Visible = false;
            addfilm.Visible = false;
            yearpub.Visible = false;
            textBox6.Visible = false;
            pogod.Visible = false;
            answear.Visible = false;
        }

        private async void addfilm_Click(object sender, EventArgs e)
        {
            infoadd.Visible = true;
            int studioid = int.Parse(textBox5.Text);
            int directorid = int.Parse(textBox3.Text);
            string title = textBox1.Text;
            string author = textBox4.Text;
            int yearpublished = int.Parse(textBox2.Text);
            await filmController.AddFilm(studioid, directorid, title, author, yearpublished);
        }

        private async void pogod_Click(object sender, EventArgs e)
        {
            int yers = int.Parse(textBox6.Text);
            List<Films> filmiii = await filmController.GetFilmsByYear(yers);
            foreach (Films film in filmiii)
            {
                answear.Text+=$"{film.Title} - {film.Author} - {film.Director} - {film.YearPublished}  \n";
            }
        }
    }
}
