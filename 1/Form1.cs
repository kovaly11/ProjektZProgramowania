using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace _1
{
    
    public partial class SignIn : MetroForm
    {
        
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Instagram.Bot.Zamkni();
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (Instagram.Bot.Logowanie(Login.Text, Password.Text))
            {
                Form2 s = new Form2();
                s.Show();
                this.Hide();
            }
            else
            {
                Login.Text = "";
                Password.Text = "";
                Form3 s1 = new Form3();
                s1.Show();
            }

        }
    }
}
