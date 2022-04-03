using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0104
{
    public partial class enteringform : Form
    {
        public enteringform()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            game Game = new game(nametextBox.Text);
            Game.Show();
            this.Hide();
        }
    }
}
