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
    public partial class formochka : Form
    {
        game info;

        public formochka(game Info)
        {
            info = Info;
            InitializeComponent();
        }

        private void formochka_FormClosed(object sender, FormClosedEventArgs e)
        {
            info.saveInfo();
            Application.Exit();
        }
    }
}
