namespace BusPlus
{
    partial class frmPrikazLinija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazLinija));
            this.prikazLinija = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.autobusneLinijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324nivancic22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_nivancic22_DBDataSet = new BusPlus.PI2324_nivancic22_DBDataSet();
            this.autobusneLinijeTableAdapter = new BusPlus.PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.lblTraziStan = new System.Windows.Forms.Label();
            this.txtTraziStan = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTraziVr = new System.Windows.Forms.Label();
            this.txtTraziVr = new System.Windows.Forms.TextBox();
            this.prikazLinija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nivancic22DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nivancic22_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // prikazLinija
            // 
            this.prikazLinija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prikazLinija.BackColor = System.Drawing.Color.Maroon;
            this.prikazLinija.Controls.Add(this.btnOdjava);
            this.prikazLinija.Controls.Add(this.lblNaslov);
            this.prikazLinija.Location = new System.Drawing.Point(1, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(813, 56);
            this.prikazLinija.TabIndex = 2;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOdjava.BackColor = System.Drawing.Color.Transparent;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOdjava.Location = new System.Drawing.Point(691, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(96, 30);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(114, 31);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "BusPlus";
            // 
            // dgvLinije
            // 
            this.dgvLinije.AllowUserToAddRows = false;
            this.dgvLinije.AllowUserToDeleteRows = false;
            this.dgvLinije.AllowUserToResizeColumns = false;
            this.dgvLinije.AllowUserToResizeRows = false;
            this.dgvLinije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLinije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Location = new System.Drawing.Point(62, 147);
            this.dgvLinije.MultiSelect = false;
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.ReadOnly = true;
            this.dgvLinije.Size = new System.Drawing.Size(677, 280);
            this.dgvLinije.TabIndex = 3;
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
            // btnTrazi
            // 
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrazi.Location = new System.Drawing.Point(424, 84);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // lblTraziStan
            // 
            this.lblTraziStan.AutoSize = true;
            this.lblTraziStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTraziStan.Location = new System.Drawing.Point(72, 88);
            this.lblTraziStan.Name = "lblTraziStan";
            this.lblTraziStan.Size = new System.Drawing.Size(138, 16);
            this.lblTraziStan.TabIndex = 5;
            this.lblTraziStan.Text = "Pretraži prema stanici:";
            // 
            // txtTraziStan
            // 
            this.txtTraziStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTraziStan.Location = new System.Drawing.Point(216, 85);
            this.txtTraziStan.Name = "txtTraziStan";
            this.txtTraziStan.Size = new System.Drawing.Size(188, 22);
            this.txtTraziStan.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(616, 85);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Resetiraj filtre";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTraziVr
            // 
            this.lblTraziVr.AutoSize = true;
            this.lblTraziVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTraziVr.Location = new System.Drawing.Point(72, 119);
            this.lblTraziVr.Name = "lblTraziVr";
            this.lblTraziVr.Size = new System.Drawing.Size(204, 16);
            this.lblTraziVr.TabIndex = 8;
            this.lblTraziVr.Text = "Pretraži prema vremenu polaska:";
            // 
            // txtTraziVr
            // 
            this.txtTraziVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTraziVr.Location = new System.Drawing.Point(282, 116);
            this.txtTraziVr.Name = "txtTraziVr";
            this.txtTraziVr.Size = new System.Drawing.Size(122, 22);
            this.txtTraziVr.TabIndex = 9;
            // 
            // frmPrikazLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTraziVr);
            this.Controls.Add(this.lblTraziVr);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTraziStan);
            this.Controls.Add(this.lblTraziStan);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.prikazLinija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrikazLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz Linija";
            this.Load += new System.EventHandler(this.FormaPrikazLinijaZaKorisnike_Load);
            this.prikazLinija.ResumeLayout(false);
            this.prikazLinija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nivancic22DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nivancic22_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel prikazLinija;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.BindingSource pI2324nivancic22DBDataSetBindingSource;
        private PI2324_nivancic22_DBDataSet pI2324_nivancic22_DBDataSet;
        private System.Windows.Forms.BindingSource autobusneLinijeBindingSource;
        private PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter autobusneLinijeTableAdapter;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label lblTraziStan;
        private System.Windows.Forms.TextBox txtTraziStan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTraziVr;
        private System.Windows.Forms.TextBox txtTraziVr;
    }
}