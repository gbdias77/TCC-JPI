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
    public partial class Adimovel : Form
    {
        public Adimovel()
        {
            InitializeComponent();
        }

        private void apartamentosdocorretorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apartamentosdocorretorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ci1DataSet1);

        }

        private void Adimovel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ci1DataSet1.apartamentosdocorretor'. Você pode movê-la ou removê-la conforme necessário.
            this.apartamentosdocorretorTableAdapter.Fill(this.ci1DataSet1.apartamentosdocorretor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.apartamentosdocorretorBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apartamentosdocorretorBindingSource.EndEdit();
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
