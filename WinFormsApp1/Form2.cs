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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private static CinemaCenterDbContext db = new CinemaCenterDbContext();
        ActorController actorController = new ActorController(db);

        private void firstname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                firstname.Visible = true;
                surname.Visible = true;
                yearwork.Visible = true;
                phone.Visible = true;
                email.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                addactor.Visible = true;
                name.Visible = false;
                textBox6.Visible = false;
                poime.Visible = false;
                textBox7.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                firstname.Visible = false;
                surname.Visible = false;
                yearwork.Visible = false;
                phone.Visible = false;
                email.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                addactor.Visible = false;
                name.Visible = true;
                textBox6.Visible = true;
                poime.Visible = true;
                textBox7.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            firstname.Visible = false;
            surname.Visible = false;
            yearwork.Visible = false;
            phone.Visible = false;
            email.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            addinfo.Visible = false;
            name.Visible = false;
            textBox6.Visible = false;
            addactor.Visible = false;
            poime.Visible = false;
            textBox7.Visible = false;
        }

        private async void addactor_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string surname = textBox2.Text;
            int yearwork = int.Parse(textBox3.Text);
            string phonenumber = textBox4.Text;
            string email = textBox5.Text;
            await actorController.AddActor(firstname, surname, yearwork, phonenumber, email);
            addinfo.Visible = true;
        }

        private async void poime_Click(object sender, EventArgs e)
        {
            string firstname2 = textBox6.Text;
            var actorsss1 = await actorController.GetActorsByName(firstname2);
            foreach (Actors actor in actorsss1)
            {
                textBox7.Text += ($"{actor.FirstName} - {actor.SurName} - {actor.PhoneNumber} - {actor.Email} \n");
            }
        }
    }
}
