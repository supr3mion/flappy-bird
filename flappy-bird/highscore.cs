﻿using System;
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
    public partial class highscore : Form
    {
        public highscore()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
