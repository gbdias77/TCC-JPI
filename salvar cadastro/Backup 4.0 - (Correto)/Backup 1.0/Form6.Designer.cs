
namespace Backup_1._0
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label orçamentoLabel;
            System.Windows.Forms.Label cPFLabel;
            this.ci1DataSet1 = new Backup_1._0.ci1DataSet1();
            this.clientesdocorretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesdocorretorTableAdapter = new Backup_1._0.ci1DataSet1TableAdapters.clientesdocorretorTableAdapter();
            this.tableAdapterManager = new Backup_1._0.ci1DataSet1TableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.orçamentoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            orçamentoLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdocorretorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ci1DataSet1
            // 
            this.ci1DataSet1.DataSetName = "ci1DataSet1";
            this.ci1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesdocorretorBindingSource
            // 
            this.clientesdocorretorBindingSource.DataMember = "clientesdocorretor";
            this.clientesdocorretorBindingSource.DataSource = this.ci1DataSet1;
            // 
            // clientesdocorretorTableAdapter
            // 
            this.clientesdocorretorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.apartamentosdocorretorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesdocontadorTableAdapter = null;
            this.tableAdapterManager.clientesdocorretorTableAdapter = this.clientesdocorretorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Backup_1._0.ci1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(274, 118);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesdocorretorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(342, 115);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(274, 144);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesdocorretorBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(342, 141);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 4;
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(274, 196);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 7;
            cEPLabel.Text = "CEP:";
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesdocorretorBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(342, 193);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEPTextBox.TabIndex = 8;
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Location = new System.Drawing.Point(274, 222);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(30, 13);
            ruaLabel.TabIndex = 9;
            ruaLabel.Text = "Rua:";
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesdocorretorBindingSource, "Rua", true));
            this.ruaTextBox.Location = new System.Drawing.Point(342, 219);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ruaTextBox.TabIndex = 10;
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new System.Drawing.Point(274, 248);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(37, 13);
            idadeLabel.TabIndex = 11;
            idadeLabel.Text = "Idade:";
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesdocorretorBindingSource, "Idade", true));
            this.idadeTextBox.Location = new System.Drawing.Point(342, 245);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.idadeTextBox.TabIndex = 12;
            // 
            // orçamentoLabel
            // 
            orçamentoLabel.AutoSize = true;
            orçamentoLabel.Location = new System.Drawing.Point(274, 274);
            orçamentoLabel.Name = "orçamentoLabel";
            orçamentoLabel.Size = new System.Drawing.Size(62, 13);
            orçamentoLabel.TabIndex = 13;
            orçamentoLabel.Text = "Orçamento:";
            // 
            // orçamentoTextBox
            // 
            this.orçamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesdocorretorBindingSource, "Orçamento", true));
            this.orçamentoTextBox.Location = new System.Drawing.Point(342, 271);
            this.orçamentoTextBox.Name = "orçamentoTextBox";
            this.orçamentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.orçamentoTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Novo cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 56);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(276, 170);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 17;
            cPFLabel.Text = "CPF:";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesdocorretorBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(342, 167);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPFTextBox.TabIndex = 18;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(this.idadeTextBox);
            this.Controls.Add(orçamentoLabel);
            this.Controls.Add(this.orçamentoTextBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdocorretorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ci1DataSet1 ci1DataSet1;
        private System.Windows.Forms.BindingSource clientesdocorretorBindingSource;
        private ci1DataSet1TableAdapters.clientesdocorretorTableAdapter clientesdocorretorTableAdapter;
        private ci1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox orçamentoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cPFTextBox;
    }
}