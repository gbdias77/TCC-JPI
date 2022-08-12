
namespace Backup_1._0
{
    partial class Form4
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
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label tel1Label;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ci1DataSet1 = new Backup_1._0.ci1DataSet1();
            this.clientesdocontadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesdocontadorTableAdapter = new Backup_1._0.ci1DataSet1TableAdapters.clientesdocontadorTableAdapter();
            this.tableAdapterManager = new Backup_1._0.ci1DataSet1TableAdapters.TableAdapterManager();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tel1TextBox = new System.Windows.Forms.TextBox();
            cPFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            tel1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdocontadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(276, 152);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 4;
            cPFLabel.Text = "CPF:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(276, 178);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 6;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(276, 204);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // tel1Label
            // 
            tel1Label.AutoSize = true;
            tel1Label.Location = new System.Drawing.Point(276, 230);
            tel1Label.Name = "tel1Label";
            tel1Label.Size = new System.Drawing.Size(31, 13);
            tel1Label.TabIndex = 10;
            tel1Label.Text = "Tel1:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Novo cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salvar\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(703, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ci1DataSet1
            // 
            this.ci1DataSet1.DataSetName = "ci1DataSet1";
            this.ci1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesdocontadorBindingSource
            // 
            this.clientesdocontadorBindingSource.DataMember = "clientesdocontador";
            this.clientesdocontadorBindingSource.DataSource = this.ci1DataSet1;
            // 
            // clientesdocontadorTableAdapter
            // 
            this.clientesdocontadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.apartamentosdocorretorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesdocontadorTableAdapter = this.clientesdocontadorTableAdapter;
            this.tableAdapterManager.clientesdocorretorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Backup_1._0.ci1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.Location = new System.Drawing.Point(320, 149);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPFTextBox.TabIndex = 5;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(320, 175);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(320, 201);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // tel1TextBox
            // 
            this.tel1TextBox.Location = new System.Drawing.Point(320, 227);
            this.tel1TextBox.Name = "tel1TextBox";
            this.tel1TextBox.Size = new System.Drawing.Size(100, 20);
            this.tel1TextBox.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(tel1Label);
            this.Controls.Add(this.tel1TextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdocontadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ci1DataSet1 ci1DataSet1;
        private System.Windows.Forms.BindingSource clientesdocontadorBindingSource;
        private ci1DataSet1TableAdapters.clientesdocontadorTableAdapter clientesdocontadorTableAdapter;
        private ci1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox tel1TextBox;
    }
}