using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class loading : Form
    {
        public loading(string info)
        {
            //actievatie van paneel
            InitializeComponent();

            //informatie over wat er geladen word
            lblLoading.Text = "loading " + info + "\r\n" + "please wait";
        }
    }
}
