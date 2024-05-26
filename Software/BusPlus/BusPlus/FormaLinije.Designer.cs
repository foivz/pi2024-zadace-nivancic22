namespace BusPlus
{
    partial class FormaLinije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaLinije));
            this.prikazLinija = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.autobusneLinijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_nivancic22_DBDataSet = new BusPlus.PI2324_nivancic22_DBDataSet();
            this.izmijeniGumb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dodajGumb = new System.Windows.Forms.Button();
            this.autobusneLinijeTableAdapter = new BusPlus.PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter();
            this.dataGridViewLinije = new System.Windows.Forms.DataGridView();
            this.pI2324nivancic22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prikazLinija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nivancic22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nivancic22DBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prikazLinija
            // 
            this.prikazLinija.BackColor = System.Drawing.Color.Maroon;
            this.prikazLinija.Controls.Add(this.label1);
            this.prikazLinija.Location = new System.Drawing.Point(0, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(813, 56);
            this.prikazLinija.TabIndex = 1;
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
            // autobusneLinijeBindingSource
            // 
            this.autobusneLinijeBindingSource.DataMember = "AutobusneLinije";
            this.autobusneLinijeBindingSource.DataSource = this.pI2324_nivancic22_DBDataSet;
            // 
            // pI2324_nivancic22_DBDataSet
            // 
            this.pI2324_nivancic22_DBDataSet.DataSetName = "PI2324_nivancic22_DBDataSet";
            this.pI2324_nivancic22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izmijeniGumb
            // 
            this.izmijeniGumb.Location = new System.Drawing.Point(612, 376);
            this.izmijeniGumb.Name = "izmijeniGumb";
            this.izmijeniGumb.Size = new System.Drawing.Size(120, 31);
            this.izmijeniGumb.TabIndex = 3;
            this.izmijeniGumb.Text = "Izmijeni";
            this.izmijeniGumb.UseVisualStyleBackColor = true;
            this.izmijeniGumb.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Izbriši";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dodajGumb
            // 
            this.dodajGumb.Location = new System.Drawing.Point(360, 376);
            this.dodajGumb.Name = "dodajGumb";
            this.dodajGumb.Size = new System.Drawing.Size(120, 31);
            this.dodajGumb.TabIndex = 5;
            this.dodajGumb.Text = "Dodaj";
            this.dodajGumb.UseVisualStyleBackColor = true;
            this.dodajGumb.Click += new System.EventHandler(this.button3_Click);
            // 
            // autobusneLinijeTableAdapter
            // 
            this.autobusneLinijeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewLinije
            // 
            this.dataGridViewLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinije.Location = new System.Drawing.Point(60, 88);
            this.dataGridViewLinije.Name = "dataGridViewLinije";
            this.dataGridViewLinije.Size = new System.Drawing.Size(672, 282);
            this.dataGridViewLinije.TabIndex = 6;
            // 
            // pI2324nivancic22DBDataSetBindingSource
            // 
            this.pI2324nivancic22DBDataSetBindingSource.DataSource = this.pI2324_nivancic22_DBDataSet;
            this.pI2324nivancic22DBDataSetBindingSource.Position = 0;
            // 
            // FormaLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLinije);
            this.Controls.Add(this.dodajGumb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.izmijeniGumb);
            this.Controls.Add(this.prikazLinija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaLinije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz Linija";
            this.prikazLinija.ResumeLayout(false);
            this.prikazLinija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nivancic22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nivancic22DBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel prikazLinija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izmijeniGumb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dodajGumb;
        private PI2324_nivancic22_DBDataSet pI2324_nivancic22_DBDataSet;
        private System.Windows.Forms.BindingSource autobusneLinijeBindingSource;
        private PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter autobusneLinijeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewLinije;
        private System.Windows.Forms.BindingSource pI2324nivancic22DBDataSetBindingSource;
    }
}