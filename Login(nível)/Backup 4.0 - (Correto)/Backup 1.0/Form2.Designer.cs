
namespace Backup_1._0
{
    partial class Form2
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label niveisLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ci1DataSet = new Backup_1._0.ci1DataSet();
            this.citbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citbTableAdapter = new Backup_1._0.ci1DataSetTableAdapters.citbTableAdapter();
            this.tableAdapterManager = new Backup_1._0.ci1DataSetTableAdapters.TableAdapterManager();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.niveisComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            niveisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Avançar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ci1DataSet
            // 
            this.ci1DataSet.DataSetName = "ci1DataSet";
            this.ci1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citbBindingSource
            // 
            this.citbBindingSource.DataMember = "citb";
            this.citbBindingSource.DataSource = this.ci1DataSet;
            // 
            // citbTableAdapter
            // 
            this.citbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.apartamentosdocorretorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.citbTableAdapter = this.citbTableAdapter;
            this.tableAdapterManager.clientesdocorretorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Backup_1._0.ci1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(281, 174);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(326, 171);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(121, 20);
            this.loginTextBox.TabIndex = 4;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(281, 200);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(39, 13);
            senhaLabel.TabIndex = 5;
            senhaLabel.Text = "senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(326, 197);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.senhaTextBox.TabIndex = 6;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // niveisLabel
            // 
            niveisLabel.AutoSize = true;
            niveisLabel.Location = new System.Drawing.Point(281, 226);
            niveisLabel.Name = "niveisLabel";
            niveisLabel.Size = new System.Drawing.Size(37, 13);
            niveisLabel.TabIndex = 7;
            niveisLabel.Text = "niveis:";
            // 
            // niveisComboBox
            // 
            this.niveisComboBox.FormattingEnabled = true;
            this.niveisComboBox.Items.AddRange(new object[] {
            "contador",
            "corretor"});
            this.niveisComboBox.Location = new System.Drawing.Point(326, 223);
            this.niveisComboBox.Name = "niveisComboBox";
            this.niveisComboBox.Size = new System.Drawing.Size(121, 21);
            this.niveisComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "*";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ver senha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(niveisLabel);
            this.Controls.Add(this.niveisComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ci1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ci1DataSet ci1DataSet;
        private System.Windows.Forms.BindingSource citbBindingSource;
        private ci1DataSetTableAdapters.citbTableAdapter citbTableAdapter;
        private ci1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox niveisComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}