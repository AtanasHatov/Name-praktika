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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private static CinemaCenterDbContext db = new CinemaCenterDbContext();
        StudioController controller = new StudioController(db);
        private void Form6_Load(object sender, EventArgs e)
        {
            name.Visible = false;
            address.Visible = false;
            phone.Visible = false;
            email.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            infoadd.Visible = false;
            addbuton.Visible = false;
            textBox5.Visible = false;
            buttonpoime.Visible = false;
            buttonmeil.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                name.Visible = true;
                address.Visible = true;
                phone.Visible = true;
                email.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                addbuton.Visible = true;
                textBox5.Visible = false;
                buttonpoime.Visible = false;
                buttonmeil.Visible = false;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                name.Visible = true;
                textBox5.Visible = true;
                address.Visible = false;
                phone.Visible = false;
                email.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                infoadd.Visible = false;
                addbuton.Visible = false;
                buttonpoime.Visible = true;
                buttonmeil.Visible = false;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                name.Visible = false;
                address.Visible = false;
                phone.Visible = false;
                email.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = true;
                infoadd.Visible = false;
                addbuton.Visible = false;
                textBox5.Visible = true;
                buttonpoime.Visible = false;
                buttonmeil.Visible = true;
            }
        }

        private async void addbuton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = textBox2.Text;
            string phone = textBox3.Text;
            string email = textBox4.Text;
            await controller.AddStudio(name, address, phone, email);
            infoadd.Visible = true;
        }

        private async void buttonpoime_Click(object sender, EventArgs e)
        {
            string firstname2 = textBox1.Text;
            var stuf = await controller.GetStudiosByName(firstname2);
            foreach (Studios studio in stuf)
            {
                textBox5.Text += ($"{studio.Name} -  {studio.PhoneNumber} - {studio.Email} \n");
            }
        }

        private async void buttonmeil_Click(object sender, EventArgs e)
        {
            string firstname2 = textBox4.Text;
            var stuf = await controller.GetStudiosByEmail(firstname2);
            foreach (Studios studio in stuf)
            {
                textBox5.Text += ($"{studio.Name} -  {studio.PhoneNumber} - {studio.Email} \n");
            }
        }
    }
}
