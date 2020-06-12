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

namespace _1
{
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void ChangeLabel(String s)
        {
            InfoLabel.Text = s;
        }
        public void ChangeTextBox(String s)
        {
            InfoTextBox.Text += s;
        }
        public void ClearTextBox()
        {
            InfoTextBox.Text = "";
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
