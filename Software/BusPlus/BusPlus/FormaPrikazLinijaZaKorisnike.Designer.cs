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
            this.odjavaGumb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.autobusneLinijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324nivancic22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_nivancic22_DBDataSet = new BusPlus.PI2324_nivancic22_DBDataSet();
            this.autobusneLinijeTableAdapter = new BusPlus.PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter();
            this.traziGumb = new System.Windows.Forms.Button();
            this.traziLabel = new System.Windows.Forms.Label();
            this.traziTextBox = new System.Windows.Forms.TextBox();
            this.resetGumb = new System.Windows.Forms.Button();
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
            this.prikazLinija.Controls.Add(this.odjavaGumb);
            this.prikazLinija.Controls.Add(this.label1);
            this.prikazLinija.Location = new System.Drawing.Point(1, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(813, 56);
            this.prikazLinija.TabIndex = 2;
            this.prikazLinija.Paint += new System.Windows.Forms.PaintEventHandler(this.prikazLinija_Paint);
            // 
            // odjavaGumb
            // 
            this.odjavaGumb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.odjavaGumb.BackColor = System.Drawing.Color.Transparent;
            this.odjavaGumb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odjavaGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjavaGumb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.odjavaGumb.Location = new System.Drawing.Point(691, 12);
            this.odjavaGumb.Name = "odjavaGumb";
            this.odjavaGumb.Size = new System.Drawing.Size(96, 30);
            this.odjavaGumb.TabIndex = 4;
            this.odjavaGumb.Text = "Odjava";
            this.odjavaGumb.UseVisualStyleBackColor = false;
            this.odjavaGumb.Click += new System.EventHandler(this.odjavaGumb_Click);
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
            this.dgvLinije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLinije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Location = new System.Drawing.Point(62, 116);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.ReadOnly = true;
            this.dgvLinije.Size = new System.Drawing.Size(677, 280);
            this.dgvLinije.TabIndex = 3;
            this.dgvLinije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinije_CellContentClick);
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
            // traziGumb
            // 
            this.traziGumb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.traziGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.traziGumb.Location = new System.Drawing.Point(389, 84);
            this.traziGumb.Name = "traziGumb";
            this.traziGumb.Size = new System.Drawing.Size(75, 23);
            this.traziGumb.TabIndex = 4;
            this.traziGumb.Text = "Traži";
            this.traziGumb.UseVisualStyleBackColor = true;
            this.traziGumb.Click += new System.EventHandler(this.traziGumb_Click);
            // 
            // traziLabel
            // 
            this.traziLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.traziLabel.AutoSize = true;
            this.traziLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.traziLabel.Location = new System.Drawing.Point(72, 88);
            this.traziLabel.Name = "traziLabel";
            this.traziLabel.Size = new System.Drawing.Size(138, 16);
            this.traziLabel.TabIndex = 5;
            this.traziLabel.Text = "Pretraži prema stanici:";
            // 
            // traziTextBox
            // 
            this.traziTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.traziTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.traziTextBox.Location = new System.Drawing.Point(216, 85);
            this.traziTextBox.Name = "traziTextBox";
            this.traziTextBox.Size = new System.Drawing.Size(167, 22);
            this.traziTextBox.TabIndex = 6;
            // 
            // resetGumb
            // 
            this.resetGumb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resetGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetGumb.Location = new System.Drawing.Point(616, 85);
            this.resetGumb.Name = "resetGumb";
            this.resetGumb.Size = new System.Drawing.Size(123, 23);
            this.resetGumb.TabIndex = 7;
            this.resetGumb.Text = "Resetiraj filtre";
            this.resetGumb.UseVisualStyleBackColor = true;
            this.resetGumb.Click += new System.EventHandler(this.resetGumb_Click);
            // 
            // FormaPrikazLinijaZaKorisnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetGumb);
            this.Controls.Add(this.traziTextBox);
            this.Controls.Add(this.traziLabel);
            this.Controls.Add(this.traziGumb);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.prikazLinija);
            this.Name = "FormaPrikazLinijaZaKorisnike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPrikazLinijaZaKorisnike";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.BindingSource pI2324nivancic22DBDataSetBindingSource;
        private PI2324_nivancic22_DBDataSet pI2324_nivancic22_DBDataSet;
        private System.Windows.Forms.BindingSource autobusneLinijeBindingSource;
        private PI2324_nivancic22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter autobusneLinijeTableAdapter;
        private System.Windows.Forms.Button odjavaGumb;
        private System.Windows.Forms.Button traziGumb;
        private System.Windows.Forms.Label traziLabel;
        private System.Windows.Forms.TextBox traziTextBox;
        private System.Windows.Forms.Button resetGumb;
    }
}