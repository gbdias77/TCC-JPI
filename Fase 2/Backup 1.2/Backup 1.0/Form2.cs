﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FazerCadastro abrate = new FazerCadastro();
            abrate.ShowDialog();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarCadastro abrate = new CriarCadastro();
            abrate.ShowDialog();
            this.Visible = false;
        }
    }
}
