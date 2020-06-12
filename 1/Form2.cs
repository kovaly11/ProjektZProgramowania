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
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Instagram.Bot.Zamkni();
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            String Tag = TagForm.Text;
            if (Tag == "")
            {
                Form3 s1 = new Form3();
                s1.ClearTextBox();
                s1.ChangeTextBox("Missing Tag");
                s1.Show();
            }
            else
            {
                Instagram.Bot.PrejscDoLinku("https://www.instagram.com/explore/tags/" + Tag);
                Int32.TryParse(NumrerOfPeople.Text, out int num);
                Instagram.Bot.UstawIlosc(num);
                Instagram.Bot.ZbiorPostow();
                String[] people;
                if (LikeButton.Checked)
                {
                    people = Instagram.Bot.UstawieniaLikow();
                    Form3 s1 = new Form3();
                    s1.ChangeLabel("Likes");
                    s1.ClearTextBox();
                    foreach(String i in people)
                        s1.ChangeTextBox(i + "\n");
                    s1.Show();
                }
                if (SubscribeButton.Checked)
                {
                    people = Instagram.Bot.Subskrybuj();
                    Form3 s1 = new Form3();
                    s1.ChangeLabel("Subscribe");
                    s1.ClearTextBox();
                    foreach (String i in people)
                        s1.ChangeTextBox(i + "\n");
                    s1.Show();
                }
                if (ComentButton.Checked)
                {
                    people = Instagram.Bot.PiszKomentarzy();
                    Form3 s1 = new Form3();
                    s1.ChangeLabel("Comments");
                    s1.ClearTextBox();
                    foreach (String i in people)
                        s1.ChangeTextBox(i + "\n");
                    s1.Show();
                }
            }

        }

    }
    }
