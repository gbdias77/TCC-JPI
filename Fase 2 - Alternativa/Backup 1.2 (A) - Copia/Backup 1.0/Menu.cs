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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Abrirform(object formhija) {
            if (this.panel1.Controls.Count > 0) this.panel1.Controls.RemoveAt(0);
            Form fh = formhija as Form; fh.TopLevel = false; 
            fh.Dock = DockStyle.Fill; this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh; fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Abrirform  (new AdiCliente());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrirform(new VerCliente());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Abrirform(new AdImovel());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Abrirform(new VerImovel());
        }
    }
}
