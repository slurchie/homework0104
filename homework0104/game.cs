using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace homework0104
{
    public partial class game : Form
    {
        string nameplayer;
        int piccounter = 10;

        public game(string Nameplayer)
        {
            InitializeComponent();
            nameplayer = Nameplayer;
        }
        private void Showform()
        {
            picture pic = new picture();
            pic.Show();
            piccounter-=1;
            if(piccounter<=0)
            {
                timer1.Enabled = false;
                DialogResult message = MessageBox.Show("Ура!Победа!");
                saveInfo();
                if (message == DialogResult.Yes) { Application.Exit();}
            }
           
        }

        private void game1_Click(object sender, EventArgs e)
        {
            Showform();
            game1.Enabled = false;
        }

        private void game4_Click(object sender, EventArgs e)
        {
            Showform();
            game4.Enabled = false;
        }

        private void game7_Click(object sender, EventArgs e)
        {
            Showform();
            game7.Enabled = false;
        }

        private void game8_Click(object sender, EventArgs e)
        {
            Showform();
            game8.Enabled = false;
        }

        private void game10_Click(object sender, EventArgs e)
        {
            Showform();
            game10.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formochka frm = new formochka(this);
            frm.Show();
            timer1.Enabled = false;
            this.Hide();
        }

        private void game17_Click(object sender, EventArgs e)
        {
            Showform();
            game17.Enabled = false;
        }

        private void game20_Click(object sender, EventArgs e)
        {
            Showform();
            game20.Enabled = false;
        }

        private void game21_Click(object sender, EventArgs e)
        {
            Showform();
            game21.Enabled = false;
        }

        private void game23_Click(object sender, EventArgs e)
        {
            Showform();
            game23.Enabled = false;
        }

        private void game24_Click(object sender, EventArgs e)
        {
            Showform();
            game24.Enabled = false;
        }

        public void saveInfo()
        {
            //StreamWriter strmwrtr = new StreamWriter("Info.txt");
            int counts = 10 - piccounter;
            string playerInfo = nameplayer + " " + counts+" картинок \n";
            File.AppendAllText("Info.txt",playerInfo);
        }
    }
}
