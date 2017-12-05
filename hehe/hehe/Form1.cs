using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hehe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_mo_hinh_3_tangDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.dB_mo_hinh_3_tangDataSet.Lop);

        }
    }
}
