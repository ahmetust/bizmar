﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bizmar;

namespace Satış
{
    public partial class satisTuru : Form
    {
        public satisTuru()
        {
            InitializeComponent();
        }

        public DataGridViewRowCollection urunler;

        private void btpesinsatis_Click(object sender, EventArgs e)
        {
            pesin frm3= new pesin(urunler);
            frm3.txttoplamtutar3.Text = txttoplamtutar.Text;
            frm3.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mahalleMarketiEntities db = new mahalleMarketiEntities();
            
        }

        private void btcarisatis_Click(object sender, EventArgs e)
        {
            cari frm4 = new cari(urunler);
            frm4.txttoplamm.Text = txttoplamtutar.Text;
            frm4.Show();
            this.Close();
        }
    }
}
