namespace BusPlus
{
    partial class FormaPregledLinija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPregledLinija));
            this.prikazLinija = new System.Windows.Forms.Panel();
            this.odjavaGumb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.dodajGumb = new System.Windows.Forms.Button();
            this.brisiGumb = new System.Windows.Forms.Button();
            this.gumbIzmijeni = new System.Windows.Forms.Button();
            this.prikazLinija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // prikazLinija
            // 
            this.prikazLinija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prikazLinija.BackColor = System.Drawing.Color.Maroon;
            this.prikazLinija.Controls.Add(this.odjavaGumb);
            this.prikazLinija.Controls.Add(this.label1);
            this.prikazLinija.Location = new System.Drawing.Point(0, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(1201, 56);
            this.prikazLinija.TabIndex = 2;
            // 
            // odjavaGumb
            // 
            this.odjavaGumb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.odjavaGumb.BackColor = System.Drawing.Color.Transparent;
            this.odjavaGumb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odjavaGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjavaGumb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.odjavaGumb.Location = new System.Drawing.Point(642, 12);
            this.odjavaGumb.Name = "odjavaGumb";
            this.odjavaGumb.Size = new System.Drawing.Size(96, 30);
            this.odjavaGumb.TabIndex = 2;
            this.odjavaGumb.Text = "Odjava";
            this.odjavaGumb.UseVisualStyleBackColor = false;
            this.odjavaGumb.Click += new System.EventHandler(this.odjavaGumb_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvLinije.AllowUserToResizeColumns = false;
            this.dgvLinije.AllowUserToResizeRows = false;
            this.dgvLinije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLinije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Location = new System.Drawing.Point(37, 85);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.ReadOnly = true;
            this.dgvLinije.Size = new System.Drawing.Size(672, 319);
            this.dgvLinije.TabIndex = 3;
            this.dgvLinije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinije_CellContentClick);
            // 
            // dodajGumb
            // 
            this.dodajGumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajGumb.Location = new System.Drawing.Point(589, 426);
            this.dodajGumb.Name = "dodajGumb";
            this.dodajGumb.Size = new System.Drawing.Size(120, 31);
            this.dodajGumb.TabIndex = 8;
            this.dodajGumb.Text = "Dodaj";
            this.dodajGumb.UseVisualStyleBackColor = true;
            this.dodajGumb.Click += new System.EventHandler(this.Button3_Click);
            // 
            // brisiGumb
            // 
            this.brisiGumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brisiGumb.Location = new System.Drawing.Point(463, 426);
            this.brisiGumb.Name = "brisiGumb";
            this.brisiGumb.Size = new System.Drawing.Size(120, 31);
            this.brisiGumb.TabIndex = 7;
            this.brisiGumb.Text = "Izbriši";
            this.brisiGumb.UseVisualStyleBackColor = true;
            this.brisiGumb.Click += new System.EventHandler(this.brisiGumb_Click);
            // 
            // gumbIzmijeni
            // 
            this.gumbIzmijeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gumbIzmijeni.Location = new System.Drawing.Point(337, 426);
            this.gumbIzmijeni.Name = "gumbIzmijeni";
            this.gumbIzmijeni.Size = new System.Drawing.Size(120, 31);
            this.gumbIzmijeni.TabIndex = 6;
            this.gumbIzmijeni.Text = "Izmijeni";
            this.gumbIzmijeni.UseVisualStyleBackColor = true;
            this.gumbIzmijeni.Click += new System.EventHandler(this.gumbIzmijeni_Click);
            // 
            // FormaPregledLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 498);
            this.Controls.Add(this.dodajGumb);
            this.Controls.Add(this.brisiGumb);
            this.Controls.Add(this.gumbIzmijeni);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.prikazLinija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPregledLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPregledLinija";
            this.Load += new System.EventHandler(this.FormaPregledLinija_Load);
            this.prikazLinija.ResumeLayout(false);
            this.prikazLinija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel prikazLinija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.Button dodajGumb;
        private System.Windows.Forms.Button brisiGumb;
        private System.Windows.Forms.Button gumbIzmijeni;
        private System.Windows.Forms.Button odjavaGumb;
    }
}