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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private static CinemaCenterDbContext db = new CinemaCenterDbContext();
        ProducersController producersController = new ProducersController(db);
        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            firstnamw.Visible = false;
            surname.Visible = false;
            yearwork.Visible = false;
            phone.Visible = false;
            email.Visible = false;
            infoadd.Visible = false;
            addproducer.Visible = false;
            name.Visible = false;
            textBox6.Visible = false;
            metod2.Visible = false;
            textBox7.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                firstnamw.Visible = true;
                surname.Visible = true;
                yearwork.Visible = true;
                phone.Visible = true;
                email.Visible = true;
                addproducer.Visible = true;
                infoadd.Visible = false;
                name.Visible = false;
                textBox6.Visible = false;
                metod2.Visible = false;
                textBox7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                firstnamw.Visible = false;
                surname.Visible = false;
                yearwork.Visible = false;
                phone.Visible = false;
                email.Visible = false;
                infoadd.Visible = false;
                addproducer.Visible = false;
                name.Visible = true;
                textBox6.Visible = true;
                metod2.Visible = true;
                textBox7.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void infoadd_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            infoadd.Visible = true;
            string firstname = textBox1.Text;
            string surname = textBox2.Text;
            int yearwork = int.Parse(textBox3.Text);
            string phonenumber = textBox4.Text;
            string email = textBox5.Text;
            await producersController.AddProducer(firstname, surname, yearwork, phonenumber, email);
        }

        private async void metod2_Click(object sender, EventArgs e)
        {
            string namepr = textBox6.Text;
            List<Producers> producerssss = await producersController.GetProducersByName(namepr);
            foreach (Producers producers in producerssss)
            {
               textBox7.Text+= $"{producers.FirstName} - {producers.SurName} - {producers.ProducersFilms} \n";
            }
        }
    }
}
