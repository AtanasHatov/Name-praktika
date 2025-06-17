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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private static CinemaCenterDbContext db = new CinemaCenterDbContext();
        DirectorController controller=new DirectorController(db);
        private void Form3_Load(object sender, EventArgs e)
        {
            infoadd.Visible = false;
        }

        private async void adddirector_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string surname = textBox2.Text;
            int yearwork = int.Parse(textBox3.Text);
            string phonenumber = textBox4.Text;
            string email = textBox5.Text;
            await controller.AddDirector(firstname, surname, yearwork, phonenumber, email);
            infoadd.Visible = true;
        }
    }
}
