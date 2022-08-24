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
    public partial class FazerCadastro : Form
    {
        public FazerCadastro()
        {
            InitializeComponent();
        }

        private void citbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ci1DataSet);

        }

        private void FazerCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ci1DataSet.citb'. Você pode movê-la ou removê-la conforme necessário.
            this.citbTableAdapter.Fill(this.ci1DataSet.citb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTableReader read = new DataTableReader(ci1DataSet.citb);
            bool logado = false;
            if
                (String.Compare(loginTextBox.Text, "") != 0 && (String.Compare(senhaTextBox.Text, "") != 0) && (String.Compare(niveisComboBox.Text, "") != 0))
            {
                while (read.Read())
                {
                    if

                        (String.Compare
                        (loginTextBox.Text, read.GetString(0)) == 0 &&
                        (String.Compare(senhaTextBox.Text, read.GetString(1))) == 0 &&
                        (String.Compare(niveisComboBox.Text, read.GetString(2))) == 0)
                        logado = true;
                    {
                        //00 
                    }

                }
            }
            else
            {
                MessageBox.Show("preencher todos os campos");
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
            if (logado)
            {
                if (niveisComboBox.Text == "contador")
                {
                    Menu principal = new Menu();
                    principal.Show();
                    this.Visible = false;
                    principal.button7.Enabled = false;
                    principal.button8.Enabled = false;
                    principal.label2.Visible = false;
                }
                if (niveisComboBox.Text == "corretor")
                {
                    Menu principal = new Menu();
                    principal.Show();
                    this.Visible = false;
                    principal.button4.Enabled = false;
                    principal.button5.Enabled = false;
                    principal.button6.Enabled = false;
                    principal.button10.Enabled = false;
                    principal.label2.Visible = true;
                }
            }

            else

            {


                MessageBox.Show("login ou senha incorretos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 voltar = new Form2();
            this.Visible = false;
            voltar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
