using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 outro = new Form4();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 outro = new Form5();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LanFiscal outro = new LanFiscal();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BalFiscal outro = new BalFiscal();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 outro = new Form6();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 outro = new Form7();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Adimovel outro = new Adimovel();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Verimovel outro = new Verimovel();
            outro.ShowDialog();
            this.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 outro = new Form2();
            outro.ShowDialog();
            this.Visible = false;
        }
    }
}
