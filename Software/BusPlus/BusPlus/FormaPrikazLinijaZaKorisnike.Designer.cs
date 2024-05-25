namespace BusPlus
{
    partial class FormaPrikazLinijaZaKorisnike
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
            this.prikazLinija = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.pocetnaStanicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavrsnaStanicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDlinijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojAutobusaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetnoVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavrsnoVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autobusneLinijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324nivancic22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_nivancic22_DBDataSet = new BusPlus.PI2324_nivancic22_DBDataSet();
            this.autobusneLinijeTableAdapter = new BusPlus.PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter();
            this.prikazLinija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nivancic22DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nivancic22_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // prikazLinija
            // 
            this.prikazLinija.BackColor = System.Drawing.Color.Maroon;
            this.prikazLinija.Controls.Add(this.label1);
            this.prikazLinija.Location = new System.Drawing.Point(1, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(813, 56);
            this.prikazLinija.TabIndex = 2;
            this.prikazLinija.Paint += new System.Windows.Forms.PaintEventHandler(this.prikazLinija_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BusPlus";
            // 
            // dgvLinije
            // 
            this.dgvLinije.AllowUserToAddRows = false;
            this.dgvLinije.AllowUserToDeleteRows = false;
            this.dgvLinije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLinije.AutoGenerateColumns = false;
            this.dgvLinije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pocetnaStanicaDataGridViewTextBoxColumn,
            this.zavrsnaStanicaDataGridViewTextBoxColumn,
            this.iDlinijeDataGridViewTextBoxColumn,
            this.brojAutobusaDataGridViewTextBoxColumn,
            this.pocetnoVrijemeDataGridViewTextBoxColumn,
            this.zavrsnoVrijemeDataGridViewTextBoxColumn});
            this.dgvLinije.DataSource = this.autobusneLinijeBindingSource;
            this.dgvLinije.Location = new System.Drawing.Point(60, 95);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.Size = new System.Drawing.Size(677, 280);
            this.dgvLinije.TabIndex = 3;
            this.dgvLinije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinije_CellContentClick);
            // 
            // pocetnaStanicaDataGridViewTextBoxColumn
            // 
            this.pocetnaStanicaDataGridViewTextBoxColumn.DataPropertyName = "PocetnaStanica";
            this.pocetnaStanicaDataGridViewTextBoxColumn.HeaderText = "PocetnaStanica";
            this.pocetnaStanicaDataGridViewTextBoxColumn.Name = "pocetnaStanicaDataGridViewTextBoxColumn";
            // 
            // zavrsnaStanicaDataGridViewTextBoxColumn
            // 
            this.zavrsnaStanicaDataGridViewTextBoxColumn.DataPropertyName = "ZavrsnaStanica";
            this.zavrsnaStanicaDataGridViewTextBoxColumn.HeaderText = "ZavrsnaStanica";
            this.zavrsnaStanicaDataGridViewTextBoxColumn.Name = "zavrsnaStanicaDataGridViewTextBoxColumn";
            // 
            // iDlinijeDataGridViewTextBoxColumn
            // 
            this.iDlinijeDataGridViewTextBoxColumn.DataPropertyName = "ID_linije";
            this.iDlinijeDataGridViewTextBoxColumn.HeaderText = "ID_linije";
            this.iDlinijeDataGridViewTextBoxColumn.Name = "iDlinijeDataGridViewTextBoxColumn";
            // 
            // brojAutobusaDataGridViewTextBoxColumn
            // 
            this.brojAutobusaDataGridViewTextBoxColumn.DataPropertyName = "BrojAutobusa";
            this.brojAutobusaDataGridViewTextBoxColumn.HeaderText = "BrojAutobusa";
            this.brojAutobusaDataGridViewTextBoxColumn.Name = "brojAutobusaDataGridViewTextBoxColumn";
            // 
            // pocetnoVrijemeDataGridViewTextBoxColumn
            // 
            this.pocetnoVrijemeDataGridViewTextBoxColumn.DataPropertyName = "PocetnoVrijeme";
            this.pocetnoVrijemeDataGridViewTextBoxColumn.HeaderText = "PocetnoVrijeme";
            this.pocetnoVrijemeDataGridViewTextBoxColumn.Name = "pocetnoVrijemeDataGridViewTextBoxColumn";
            // 
            // zavrsnoVrijemeDataGridViewTextBoxColumn
            // 
            this.zavrsnoVrijemeDataGridViewTextBoxColumn.DataPropertyName = "ZavrsnoVrijeme";
            this.zavrsnoVrijemeDataGridViewTextBoxColumn.HeaderText = "ZavrsnoVrijeme";
            this.zavrsnoVrijemeDataGridViewTextBoxColumn.Name = "zavrsnoVrijemeDataGridViewTextBoxColumn";
            // 
            // autobusneLinijeBindingSource
            // 
            this.autobusneLinijeBindingSource.DataMember = "AutobusneLinije";
            this.autobusneLinijeBindingSource.DataSource = this.pI2324nivancic22DBDataSetBindingSource;
            // 
            // pI2324nivancic22DBDataSetBindingSource
            // 
            this.pI2324nivancic22DBDataSetBindingSource.DataSource = this.pI2324_nivancic22_DBDataSet;
            this.pI2324nivancic22DBDataSetBindingSource.Position = 0;
            // 
            // pI2324_nivancic22_DBDataSet
            // 
            this.pI2324_nivancic22_DBDataSet.DataSetName = "PI2324_nivancic22_DBDataSet";
            this.pI2324_nivancic22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autobusneLinijeTableAdapter
            // 
            this.autobusneLinijeTableAdapter.ClearBeforeFill = true;
            // 
            // FormaPrikazLinijaZaKorisnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.prikazLinija);
            this.Name = "FormaPrikazLinijaZaKorisnike";
            this.Text = "FormaPrikazLinijaZaKorisnike";
            this.Load += new System.EventHandler(this.FormaPrikazLinijaZaKorisnike_Load);
            this.prikazLinija.ResumeLayout(false);
            this.prikazLinija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nivancic22DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nivancic22_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel prikazLinija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.BindingSource pI2324nivancic22DBDataSetBindingSource;
        private PI2324_nivancic22_DBDataSet pI2324_nivancic22_DBDataSet;
        private System.Windows.Forms.BindingSource autobusneLinijeBindingSource;
        private PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter autobusneLinijeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetnaStanicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavrsnaStanicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlinijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojAutobusaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetnoVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavrsnoVrijemeDataGridViewTextBoxColumn;
    }
}