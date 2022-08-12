
namespace Backup_1._0
{
    partial class Adimovel
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
            System.Windows.Forms.Label fotosLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label informaçõesadicionaisLabel;
            System.Windows.Forms.Label preçocompraLabel;
            System.Windows.Forms.Label preçoaluguelLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ci1DataSet1 = new Backup_1._0.ci1DataSet1();
            this.apartamentosdocorretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartamentosdocorretorTableAdapter = new Backup_1._0.ci1DataSet1TableAdapters.apartamentosdocorretorTableAdapter();
            this.tableAdapterManager = new Backup_1._0.ci1DataSet1TableAdapters.TableAdapterManager();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.informaçõesadicionaisTextBox = new System.Windows.Forms.TextBox();
            this.preçocompraTextBox = new System.Windows.Forms.TextBox();
            this.preçoaluguelTextBox = new System.Windows.Forms.TextBox();
            this.fotosPictureBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            fotosLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            informaçõesadicionaisLabel = new System.Windows.Forms.Label();
            preçocompraLabel = new System.Windows.Forms.Label();
            preçoaluguelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentosdocorretorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotosPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "Novo cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 56);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ci1DataSet1
            // 
            this.ci1DataSet1.DataSetName = "ci1DataSet1";
            this.ci1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartamentosdocorretorBindingSource
            // 
            this.apartamentosdocorretorBindingSource.DataMember = "apartamentosdocorretor";
            this.apartamentosdocorretorBindingSource.DataSource = this.ci1DataSet1;
            // 
            // apartamentosdocorretorTableAdapter
            // 
            this.apartamentosdocorretorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.apartamentosdocorretorTableAdapter = this.apartamentosdocorretorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesdocontadorTableAdapter = null;
            this.tableAdapterManager.clientesdocorretorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Backup_1._0.ci1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fotosLabel
            // 
            fotosLabel.AutoSize = true;
            fotosLabel.Location = new System.Drawing.Point(277, 160);
            fotosLabel.Name = "fotosLabel";
            fotosLabel.Size = new System.Drawing.Size(33, 13);
            fotosLabel.TabIndex = 18;
            fotosLabel.Text = "fotos:";
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Location = new System.Drawing.Point(277, 219);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(25, 13);
            ruaLabel.TabIndex = 20;
            ruaLabel.Text = "rua:";
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartamentosdocorretorBindingSource, "rua", true));
            this.ruaTextBox.Location = new System.Drawing.Point(397, 216);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(147, 20);
            this.ruaTextBox.TabIndex = 21;
            // 
            // informaçõesadicionaisLabel
            // 
            informaçõesadicionaisLabel.AutoSize = true;
            informaçõesadicionaisLabel.Location = new System.Drawing.Point(277, 245);
            informaçõesadicionaisLabel.Name = "informaçõesadicionaisLabel";
            informaçõesadicionaisLabel.Size = new System.Drawing.Size(114, 13);
            informaçõesadicionaisLabel.TabIndex = 22;
            informaçõesadicionaisLabel.Text = "informaçõesadicionais:";
            // 
            // informaçõesadicionaisTextBox
            // 
            this.informaçõesadicionaisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartamentosdocorretorBindingSource, "informaçõesadicionais", true));
            this.informaçõesadicionaisTextBox.Location = new System.Drawing.Point(397, 242);
            this.informaçõesadicionaisTextBox.Name = "informaçõesadicionaisTextBox";
            this.informaçõesadicionaisTextBox.Size = new System.Drawing.Size(147, 20);
            this.informaçõesadicionaisTextBox.TabIndex = 23;
            // 
            // preçocompraLabel
            // 
            preçocompraLabel.AutoSize = true;
            preçocompraLabel.Location = new System.Drawing.Point(277, 271);
            preçocompraLabel.Name = "preçocompraLabel";
            preçocompraLabel.Size = new System.Drawing.Size(72, 13);
            preçocompraLabel.TabIndex = 24;
            preçocompraLabel.Text = "preçocompra:";
            // 
            // preçocompraTextBox
            // 
            this.preçocompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartamentosdocorretorBindingSource, "preçocompra", true));
            this.preçocompraTextBox.Location = new System.Drawing.Point(397, 268);
            this.preçocompraTextBox.Name = "preçocompraTextBox";
            this.preçocompraTextBox.Size = new System.Drawing.Size(147, 20);
            this.preçocompraTextBox.TabIndex = 25;
            // 
            // preçoaluguelLabel
            // 
            preçoaluguelLabel.AutoSize = true;
            preçoaluguelLabel.Location = new System.Drawing.Point(277, 297);
            preçoaluguelLabel.Name = "preçoaluguelLabel";
            preçoaluguelLabel.Size = new System.Drawing.Size(71, 13);
            preçoaluguelLabel.TabIndex = 26;
            preçoaluguelLabel.Text = "preçoaluguel:";
            // 
            // preçoaluguelTextBox
            // 
            this.preçoaluguelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartamentosdocorretorBindingSource, "preçoaluguel", true));
            this.preçoaluguelTextBox.Location = new System.Drawing.Point(397, 294);
            this.preçoaluguelTextBox.Name = "preçoaluguelTextBox";
            this.preçoaluguelTextBox.Size = new System.Drawing.Size(147, 20);
            this.preçoaluguelTextBox.TabIndex = 27;
            // 
            // fotosPictureBox
            // 
            this.fotosPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.apartamentosdocorretorBindingSource, "fotos", true));
            this.fotosPictureBox.Location = new System.Drawing.Point(397, 69);
            this.fotosPictureBox.Name = "fotosPictureBox";
            this.fotosPictureBox.Size = new System.Drawing.Size(168, 141);
            this.fotosPictureBox.TabIndex = 19;
            this.fotosPictureBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 33);
            this.button3.TabIndex = 28;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Adimovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(fotosLabel);
            this.Controls.Add(this.fotosPictureBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(informaçõesadicionaisLabel);
            this.Controls.Add(this.informaçõesadicionaisTextBox);
            this.Controls.Add(preçocompraLabel);
            this.Controls.Add(this.preçocompraTextBox);
            this.Controls.Add(preçoaluguelLabel);
            this.Controls.Add(this.preçoaluguelTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Adimovel";
            this.Text = "Adimovel";
            this.Load += new System.EventHandler(this.Adimovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentosdocorretorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotosPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ci1DataSet1 ci1DataSet1;
        private System.Windows.Forms.BindingSource apartamentosdocorretorBindingSource;
        private ci1DataSet1TableAdapters.apartamentosdocorretorTableAdapter apartamentosdocorretorTableAdapter;
        private ci1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox fotosPictureBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.TextBox informaçõesadicionaisTextBox;
        private System.Windows.Forms.TextBox preçocompraTextBox;
        private System.Windows.Forms.TextBox preçoaluguelTextBox;
        private System.Windows.Forms.Button button3;
    }
}