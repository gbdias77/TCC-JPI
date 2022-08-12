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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void clientesdocorretorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesdocorretorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ci1DataSet1);

        }


        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ci1DataSet1.clientesdocorretor'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientesdocorretorBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesdocorretorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ci1DataSet1);
            MessageBox.Show("Salvo");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 outro = new Form3();
            outro.ShowDialog();
            this.Visible = false;
        }
    }
    }
