using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.I_7._0
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void clientesdocorretorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesdocorretorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ci1DataSet1);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ci1DataSet1.clientesdocorretor'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesdocorretorTableAdapter.Fill(this.ci1DataSet1.clientesdocorretor);

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

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 principal = new Form3();
            principal.Enabled = true;
            principal.Show();
            this.Visible = false;
        }
    }
}


bool validaCPF()
        {
            if (cPFTextBox.Text.Length == 14)
            {
                int n1 = Convert.ToInt16(cPFTextBox.Text.Substring(0, 1));
                int n2 = Convert.ToInt16(cPFTextBox.Text.Substring(1, 1));
                int n3 = Convert.ToInt16(cPFTextBox.Text.Substring(2, 1));
                int n4 = Convert.ToInt16(cPFTextBox.Text.Substring(4, 1));
                int n5 = Convert.ToInt16(cPFTextBox.Text.Substring(5, 1));
                int n6 = Convert.ToInt16(cPFTextBox.Text.Substring(6, 1));
                int n7 = Convert.ToInt16(cPFTextBox.Text.Substring(8, 1));
                int n8 = Convert.ToInt16(cPFTextBox.Text.Substring(9, 1));
                int n9 = Convert.ToInt16(cPFTextBox.Text.Substring(10, 1));
                int n10 = Convert.ToInt16(cPFTextBox.Text.Substring(12, 1));
                int n11 = Convert.ToInt16(cPFTextBox.Text.Substring(13, 1));
                if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6 && n6 == n7 && n7 == n8 && n8 == n9)
                {
                    return false;
                }
                else
                {
                    int Soma1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;
                    int digitoVerificador1 = Soma1 % 11;


                    if (digitoVerificador1 < 2) { digitoVerificador1 = 0; }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }
                    int Soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;
                    int digitoVerificador2 = Soma2 % 11;
                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }
                    if (digitoVerificador1 == n10 && digitoVerificador2 == n11)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
         }
        }
