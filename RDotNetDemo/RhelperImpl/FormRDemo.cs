using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RhelperImpl
{
    public partial class FormRDemo : Form
    {
        public RHelper.RHelper rEngine { get; set; }
        public FormRDemo()
        {
            InitializeComponent();
            rEngine = new RHelper.RHelper();
            this.ucRConsole1.rEngine = rEngine;
        }
         

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.rEngine.Dispose();
        }
    }
}
